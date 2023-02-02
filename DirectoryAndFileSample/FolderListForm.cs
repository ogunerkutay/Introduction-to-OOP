using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryAndFileSample
{
    public partial class FolderListForm : Form
    {
        public FolderListForm()
        {
            InitializeComponent();

            buttonChooseFolder.Click += new EventHandler(SelectFolder);
            buttonListFolder.Click += new System.EventHandler(ListFolders);
            listViewFolderList.DoubleClick += new EventHandler(GetFolderDetail);
        }

        private void GetFolderDetail(object? sender, EventArgs e)
        {
            if (listViewFolderList.Items.Count>0)
            {
                if (listViewFolderList.SelectedItems.Count>0)
                {
                   string _fullPath = listViewFolderList.SelectedItems[0].SubItems[1].Text; 
                    FolderDetail _frmFolderDetail = new FolderDetail(_fullPath);
                    _frmFolderDetail.Show();
                }

            }
        }

        private void SelectFolder(object? sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBoxFolderPath.Text = folderBrowserDialog1.SelectedPath;

            }

        }

        private void ListFolders(object sender, EventArgs e)
        {
            string _path = textBoxFolderPath.Text.Trim();
            string[] _directories = Directory.GetDirectories(_path);
            int _index = 0;
            foreach (string directory in _directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                listViewFolderList.Items.Add((_index+1).ToString());
                listViewFolderList.Items[_index].SubItems.Add(directoryInfo.FullName);
                listViewFolderList.Items[_index].SubItems.Add(directoryInfo.Name);
                _index++;
            }
        }
    }
}
