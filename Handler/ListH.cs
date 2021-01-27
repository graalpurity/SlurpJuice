//this is used for handling the Script List 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Slurp_Juice;

namespace Slurp_Juice.Handler
{
    public static class ListH
    {
        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        public static void SetEditorText()
        {
            Slurp form = new Slurp();
            form.webBrowser1.DocumentText = File.ReadAllText($"C:/Visual Studio Projects/Slurp Juice/Lua{form.scriptsList.SelectedItem}");
        }
    }
}
