using LR5_CSH.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace LR5_CSH
{
    public partial class Form1 : Form
    {
        private int _initResourses;
        private DilogFormGetInfo _newForm;
        private Thread _startDepartments, _openSellings, _restore;
        public Form1()
        {
            InitializeComponent();
            lbForStatus.Text = "";
            lbRestoreStat.Text = "";
            lbSelingStat.Text = "";
            btOpenSellings.Enabled = false;
            nUDNumOfDailyProd.Enabled = false;
            lbAboutOpenSelling.Visible = false;
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            if (nUDNumOfDepartm.Value == 0)
            {
                MessageBox.Show(this, "Set number of deprtment in this factory.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nUDNumOfWorkers.Value == 0)
            {
                MessageBox.Show(this, "Set number of workers in each department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lbForStatus.Text = "Factry started";
                var factory = new Factory((int)nUDNumOfDepartm.Value, (int)nUDNumOfWorkers.Value);
                _startDepartments = new Thread(StartAllDepartmentsThread);
                // _startDepartments.IsBackground = true;
                _startDepartments.Start();
                _openSellings = new Thread(SellingThread);
                _openSellings.IsBackground = true;
                _restore = new Thread(RestoreResoursesAndPayments);
                _restore.IsBackground = true;
                TurnOffOnNumericUpDowns(false);
                nUDNumOfDailyProd.Maximum = Factory.TotalAmountOfResourses;
                _initResourses = Factory.TotalAmountOfResourses;
                prBResourses.Maximum = Factory.TotalAmountOfResourses;
                btOpenSellings.Enabled = true;
                prBResourses.Value = Factory.TotalAmountOfResourses;
                btStart.Enabled = false;
            }
        }
        public void StartAllDepartmentsThread()
        {
            for (int i = 0; i < Factory.NumberOfDepartments; i++)
            {
                var dep = new Department(Factory.NumberOfWorkersInOneDepartment, this);
                lock (Factory.Locker)
                {
                    Factory.DepartmentsList.Add(dep);
                }
                UpdateResoursesLable(Factory.TotalAmountOfResourses);
                UpdateDailyProductAmount(Department.DailyProductAmount);
            }
            StartworkInAllDepartments();
        }
        public void StartworkInAllDepartments()
        {
            while (Factory.TotalAmountOfResourses > 0)
            {
                foreach (var dep in Factory.DepartmentsList)
                {
                    dep.AmountOfResourses = Factory.TotalAmountOfResourses / Factory.NumberOfDepartments;
                    dep.Produce();
                    UpdateResoursesLable(Factory.TotalAmountOfResourses);
                    UpdateDailyProductAmount(Department.DailyProductAmount);
                    if (!_openSellings.IsAlive)
                    {
                        UpdateProductAmount(Department.DailyProductAmount);
                    }
                }
                Thread.Sleep(10);
            }
            if (_openSellings.IsAlive)
            {
                _restore?.Start();
            }
        }
        private void SellingThread(object arg)
        {
            UpdateSelingStatusLabel("Selling started");
            var period = (int)arg;

            for (var i = 0; i < Factory.DepartmentsList.Count; i++)
            {
                var dep = Factory.DepartmentsList[i];
                SellAllChairs(period, dep);
                SellAllTables(period, dep);
            }
            if (!_restore.IsAlive && Factory.TotalAmountOfResourses <= 0)
            {
                if (_restore.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    _restore = new Thread(RestoreResoursesAndPayments);
                    _restore.IsBackground = true;
                    _restore.Start();
                }
                else
                {
                    _restore.Start();
                }
            }
            if (_startDepartments.IsAlive || Factory.GetCurrentNumbOfFurniture() > 0)
            {
                SellingThread(arg);
            }
            UpdateSelingStatusLabel("Selling ended");

        }
        private void SellAllChairs(int period, Department dep)
        {
            var numberOfChairs = dep.DailyProductAmountList.Where(x => x.Name == "chairs").Select(y => y.Amount).Sum();
            for (; numberOfChairs > 0; numberOfChairs--)
            {
                lock (Factory.BankLocker)
                {
                    Factory.BankAccount += 40;
                }
                UpdateBankAccountLable(Factory.BankAccount);
                UpdateProductAmount(Factory.GetCurrentNumbOfFurniture() - numberOfChairs);
                Thread.Sleep(period);
            }
            lock (dep.Locker)
            {
                dep.DailyProductAmountList.RemoveAll(x => x.Name == "chairs");
            }
            UpdateProductAmount(Factory.GetCurrentNumbOfFurniture());
        }
        private void SellAllTables(int period, Department dep)
        {
            var numberOfTables = dep.DailyProductAmountList.Where(x => x.Name == "tables").Select(y => y.Amount).Sum();
            for (; numberOfTables > 0; numberOfTables--)
            {
                lock (Factory.BankLocker)
                {
                    Factory.BankAccount += 50;
                }
                UpdateBankAccountLable(Factory.BankAccount);
                UpdateProductAmount(Factory.GetCurrentNumbOfFurniture() - numberOfTables);
                Thread.Sleep(period);
            }
            lock (dep.Locker)
            {
                dep.DailyProductAmountList.RemoveAll(x => x.Name == "tables");
            }
            UpdateProductAmount(Factory.GetCurrentNumbOfFurniture());
        }
        public void RestoreResoursesAndPayments()
        {
            UpdateRestoreStatusLabel("Restorstoring begun");
            for (var i = Factory.DepartmentsList.Count - 1; i > 0 && Factory.BankAccount > 0; --i)
            {
                lock (Factory.BankLocker)
                {
                    Factory.BankAccount -= Factory.NumberOfWorkersInOneDepartment * Factory.DepartmentsList[i].Payment;
                }
                UpdateBankAccountLable(Factory.BankAccount);
                Factory.SpenOnPayment += Factory.NumberOfWorkersInOneDepartment * Factory.DepartmentsList[i].Payment;

                UpdateSpendingLable(Factory.SpenOnPayment);
                Thread.Sleep(10);
            }
            while (Factory.BankAccount > 0)
            {
                lock (Factory.BankLocker)
                {
                    Factory.BankAccount -= Factory.CommonResousesPrice;
                }
                UpdateBankAccountLable(Factory.BankAccount);
                lock (Factory.Locker)
                {
                    Factory.TotalAmountOfResourses++;
                }
                UpdateProgressBar(Factory.TotalAmountOfResourses);
                if (Factory.TotalAmountOfResourses >= 3) Factory.FillDepartmentsWithResourses();
                UpdateResoursesLable(Factory.TotalAmountOfResourses);
            }
            UpdateRestoreStatusLabel("Restorstoring ended");
            if (MessageBox.Show("Resourses were restored.\nDo you want to save factory state and restat all departments ?", "Message",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EventArgs e = new EventArgs();
                object sender = new Factory();
                btStop_Click(sender, e);
            }
            else
            {
                SerializeableXML.SerializeFactoryLog(FileDialogOpenSave.FileSaveToLog());
            }
        }
        private void btOpenSellings_Click(object sender, EventArgs e)
        {
            mTBSellingTime.Enabled = true;
            lbAboutOpenSelling.Visible = true;

            if (string.IsNullOrEmpty(mTBSellingTime.Text) || mTBSellingTime.Text == "  :")
            {
                MessageBox.Show("Set a selling period", "Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var sellingPeriod = mTBSellingTime.Text.Trim();
                var timeForSleep = mTBSellingTime.Text.Split(':');
                var sec = Convert.ToInt32(timeForSleep[0]) * 1000;
                var msec = Convert.ToInt32(timeForSleep[1]);
                _openSellings = new Thread(SellingThread);

                _openSellings.IsBackground = true;
                _openSellings.Start(msec + sec);
            }
        }
        private void btStop_Click(object sender, EventArgs e)
        {
            if (Factory.DepartmentsList.Count > 0)
            {
                if (sender is Factory)
                {
                    if (SerializeableXML.SerializeFactoryLog(FileDialogOpenSave.FileSaveToLog()))
                    {
                        _startDepartments = new Thread(StartworkInAllDepartments);
                        _startDepartments.IsBackground = true;
                        _startDepartments.Start();
                    }
                }
                else
                {
                    SerializeableXML.SerializeFactoryLog(FileDialogOpenSave.FileSaveToLog());
                    if (MessageBox.Show("Do you want to save factory state and restart all departments ?", "Message",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _startDepartments?.Abort();
                        _openSellings?.Abort();
                        _restore?.Abort();
                        Factory.DepartmentsList.Clear();
                        ResetUIElements();
                        btStart_Click(sender, e);
                    }
                }
            }
            else MessageBox.Show("There is nothing to stop yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btOpenLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad++.exe", FileDialogOpenSave.FileDialogOpenFromInSeparateThread());
        }
        private void btInfo_Click(object sender, EventArgs e)
        {
            _newForm = new DilogFormGetInfo();
            _newForm.Show();
        }
        private void ResetUIElements()
        {
            Thread.Sleep(15);
            nUDNumOfDepartm.Value = 0;
            nUDNumOfWorkers.Value = 0;
            nUDNumOfDailyProd.Value = 0;
            TurnOffOnNumericUpDowns(true);
            mTBSellingTime.Clear();
            lbForStatus.Text = "";
            lbRestoreStat.Text = "";
            lbSelingStat.Text = "";
            UpdateProductAmount(0);
            UpdateResoursesLable(0);
            UpdateBankAccountLable(0);
            lbSpentOnPayment.Text = "0";
            lbAboutOpenSelling.Visible = false;
            btOpenSellings.Enabled = false;
            btStart.Enabled = true;
            prBResourses.Value = 0;
        }
        private void TurnOffOnNumericUpDowns(bool sideON)
        {
            if (sideON)
            {
                nUDNumOfDepartm.Enabled = true;
                nUDNumOfWorkers.Enabled = true;
            }
            else
            {
                nUDNumOfDepartm.Enabled = false;
                nUDNumOfWorkers.Enabled = false;
            }
        }
        public void UpdateProgressBar(int value)
        {
            if (prBResourses.InvokeRequired)
            {
                prBResourses.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                prBResourses.Value = value;
            }
        }
        private void UpdateResoursesLable(int value)
        {
            if (lbForResourses.InvokeRequired)
            {
                lbForResourses.Invoke(new Action<int>(UpdateResoursesLable), value);
            }
            else
            {
                lbForResourses.Text = $@"{value.ToString()}/{_initResourses}";
                _newForm?.UpdateDataGridView();
            }
        }
        private void UpdateSelingStatusLabel(string value)
        {
            if (lbSelingStat.InvokeRequired)
            {
                lbSelingStat.Invoke(new Action<string>(UpdateSelingStatusLabel), value);
            }
            else
            {
                lbSelingStat.Text = value;
            }
        }
        private void UpdateRestoreStatusLabel(string value)
        {
            if (lbRestoreStat.InvokeRequired)
            {
                lbRestoreStat.Invoke(new Action<string>(UpdateRestoreStatusLabel), value);
            }
            else
            {
                lbRestoreStat.Text = value;
            }
        }
        private void UpdateBankAccountLable(int value)
        {
            if (lbForBankAccount.InvokeRequired)
            {
                lbForBankAccount.Invoke(new Action<int>(UpdateBankAccountLable), value);
            }
            else
            {
                lbForBankAccount.Text = value.ToString();
            }
        }
        private void UpdateSpendingLable(int value)
        {
            if (lbSpentOnPayment.InvokeRequired)
            {
                lbSpentOnPayment.Invoke(new Action<int>(UpdateSpendingLable), value);
            }
            else
            {
                lbSpentOnPayment.Text = value.ToString();
            }
        }
        private void UpdateDailyProductAmount(decimal value)
        {
            if (nUDNumOfDailyProd.InvokeRequired)
            {
                nUDNumOfDailyProd.Invoke(new Action<decimal>(UpdateDailyProductAmount), value);
            }
            else
            {
                nUDNumOfDailyProd.Value = value;
            }
        }
        private void UpdateProductAmount(int value)
        {
            if (lbCurrentProdNum.InvokeRequired)
            {
                lbCurrentProdNum.Invoke(new Action<int>(UpdateProductAmount), value);
            }
            else
            {
                lbCurrentProdNum.Text = value.ToString();
            }
        }
    }
}

