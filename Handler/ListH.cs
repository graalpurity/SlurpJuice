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
        public static void Clear()
        {
            Slurp form = new Slurp();
            form.scriptsList.Items.Clear();
        }

        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
