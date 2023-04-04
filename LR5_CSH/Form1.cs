using System;
using LR5_CSH.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LR5_CSH
{
    public partial class Form1 : Form
    {
        struct DataParameter
        {
            public int Process;
            public int Delay;
        }
        private DataParameter _inputparameter;
        private BindingSource _source;
        private Thread _startDepartments, _openSellings;
        private delegate Action SafeCallDelegate(int value/*string text*/);
        public Form1()
        {
            InitializeComponent();
            lbForStatus.Text = "";
            lbAboutOpenSelling.Visible = false;
            _source = new BindingSource();
            _source.DataSource = Factory.DepartmentsList;
            nUDNumOfDailyProd.Enabled = false;
            //            prBResourses.DataBindings.Add("Value", source, "AmountOfResourses");
            //nUDNumOfDailyProd.DataBindings.Add("Value", source, "AmountOfResourses");
            lbForResourses.DataBindings.Add("Text", _source, "AmountOfResourses");
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
                //Factory.StartAllDepartmentsThread();
                var factory = new Factory((int)nUDNumOfDepartm.Value, (int)nUDNumOfWorkers.Value);
                _startDepartments = new Thread(StartAllDepartmentsThread);
                //StartDepartments.IsBackground = true;

                _startDepartments.Start(/*factory*/);
                //StartDepartments.Join();
                /**********NEW**************/
                _inputparameter.Delay = 10;
                _inputparameter.Process = 1200;
                // backgroundWorker.RunWorkerAsync(_inputparameter);
                // lbForResourses.Text = (--Factory.TotalAmountOfResourses).ToString();

            }

        }
        public void StartAllDepartmentsThread()
        {
            //var localFactory = factory as Factory;

            for (/*var resourse = 0*/; Factory.TotalAmountOfResourses > 0; /*Factory.TotalAmountOfResourses--*/)
            {
                var dep = new Department(Factory.NumberOfWorkersInOneDepartment,
                    Factory.NumberOfDepartments * Factory.NumberOfWorkersInOneDepartment);
                dep.Produce();
                Factory.DepartmentsList.Add(dep);
                UpdateResoursesLable(Factory.TotalAmountOfResourses);
                Thread.Sleep(10);
            }
        }
        private void UpdateResoursesLable(int value/*string text*/)
        {
            if (lbForResourses.InvokeRequired)
            {
                lbForResourses.Invoke(new Action<int>(UpdateResoursesLable), value);
                //var d = new SafeCallDelegate(WriteTextSafe);
                //lbForResourses.Invoke(d, new object[] { text });
            }
            else
            {
                //source.ResetBindings(true);
                lbForResourses.Text = value.ToString();
            }
        }
        #region /*********************************/

        //private void btStart_Click(object sender, EventArgs e)
        //{
        //    Thread thread2 = new Thread(new ThreadStart(SetText));
        //    thread2.Start();
        //    Thread.Sleep(1000);
        //}


        private void SetText()
        {
            //WriteTextSafe("This text was set safely.");
        }
        #endregion /**************************************************************/

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prBResourses.Value = e.ProgressPercentage;
            // lbForResourses.Text = $"Processing resourses...{e.ProgressPercentage}%";
            prBResourses.Update();
        }
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParameter)e.Argument).Process;
            int delay = ((DataParameter)e.Argument).Delay;
            int index = 1;
            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        //Thread.Sleep(delay); //used to simulate length of operation
                        //Add your code here

                        Factory.NumberOfDepartments = (int)nUDNumOfDepartm.Value;
                        Factory.NumberOfWorkersInOneDepartment = (int)nUDNumOfWorkers.Value;
                        _startDepartments = new Thread(Factory.StartAllDepartmentsThread);
                        _startDepartments.Start(/*new Factory((int)nUDNumOfDepartm.Value, (int)nUDNumOfWorkers.Value)*/);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process has been completed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btOpenSellings_Click(object sender, EventArgs e)
        {
            mTBSellingTime.Enabled = true;
            lbAboutOpenSelling.Visible = true;            
            
            if (string.IsNullOrEmpty(mTBSellingTime.Text) || mTBSellingTime.Text  == "  :")
            {
                MessageBox.Show("Set a selling period", "Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var sellingPeriod = mTBSellingTime.Text.Trim();
                var timeForSleep = mTBSellingTime.Text.Split(':');
                int min = Convert.ToInt32(timeForSleep[0]) * 60000;
                int sec = Convert.ToInt32(timeForSleep[1]) * 1000;

                _openSellings = new Thread(SellingThread);
                _openSellings.Start(min + sec);
            }
        }
        private void SellingThread(object arg)
        {
            var period = (int)arg;
            if (_startDepartments.IsAlive)
            {

            }
            foreach (var dep in Factory.DepartmentsList)
            {
                SellAllChairs(period, dep);                
                SellAllTables(period, dep);
            }

        }
        private void SellAllChairs(int period, Department dep)
        {
            var numberOfChairs = dep.DailyProductAmount.Where(x => x.Name == "chairs").Count();
            for (; numberOfChairs > 0; numberOfChairs--)
            {
                Factory.BankAccount += 40;
                UpdateBankAccountLable(Factory.BankAccount);
                Thread.Sleep(period);
            }
            dep.DailyProductAmount.RemoveAll(x => x.Name == "chairs");
        }
        private void SellAllTables(int period, Department dep)
        {
            var numberOfTables = dep.DailyProductAmount.Where(x => x.Name == "tables").Count();
            for (; numberOfTables > 0; numberOfTables--)
            {
                Factory.BankAccount += 50;
                UpdateBankAccountLable(Factory.BankAccount);
                Thread.Sleep(period);
            }
            dep.DailyProductAmount.RemoveAll(x => x.Name == "tables");
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
        private void UpdateDailyProductAmount(decimal value) //TODO implenemt ~~ this
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();

            if (_startDepartments != null && _startDepartments.IsAlive)
                _startDepartments.Abort();//!!!
            if (_openSellings != null && _openSellings.IsAlive)
                _openSellings.Abort();//!!!
        }

    }
}

