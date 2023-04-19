using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using LR5_CSH.Models;

namespace LR5_CSH
{
    class SerializeableXML
    {       
        public static bool SerializeFactoryLog(string path)
        {
            if (string.IsNullOrEmpty(path)) return false;
            try
            {
                var serializer = new XmlSerializer(Factory.DepartmentsList.GetType());
                using (var file = new StreamWriter(path))
                {
                    serializer.Serialize(file, Factory.DepartmentsList);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Form1 owner = new Form1();
                MessageBox.Show(owner, ex.Message, "Serialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }      
    }
}
