using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LR5_CSH
{
    static class FileDialogOpenSave
    {
        public static string FileDialogOpenFromInSeparateThread()
        {
            string filePath = string.Empty;
            Thread temp = new Thread(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = $@"{Application.StartupPath}\Logs";
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var t = openFileDialog.SafeFileName;
                    filePath = openFileDialog.FileName;
                }
                else filePath = "";
            });
            temp.SetApartmentState(ApartmentState.STA);
            temp.Start();
            temp.Join();
            return filePath;
        }
        public static string FileSaveToLog()
        {
            string datePatt = @"dd/mm/yyyy_HH_mm_ss";
            string filePath = string.Empty;
            try
            {
                if (!Directory.Exists($@"{Application.StartupPath}\Logs)"))
                {
                    Directory.CreateDirectory($@"{Application.StartupPath}\Logs");
                }
                filePath = $@"{Application.StartupPath}\Logs\log_{DateTime.Now.ToString(datePatt)}.xml";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save XML file error");
            }
            return filePath;
        }
    }
}
