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
    public partial class FolderDetail : Form
    {
        string path = string.Empty;
        public FolderDetail()
        {
            InitializeComponent();
        }
        public FolderDetail(string _path)
        {
            InitializeComponent();
            path = _path;
            this.Load += new EventHandler(LoadFolderAndFile);
            listBoxFolderList.DoubleClick += new EventHandler(ShowFileInfo);
        }

        private void ShowFileInfo(object sender, EventArgs e)
        {
            if (listBoxFolderList.Items.Count>0)
            {
                string _selectedFolder = listBoxFolderList.SelectedItem.ToString();
                LoadFiles(_selectedFolder);
            }
        }

        private void LoadFiles(string selectedFolder)
        {
            string[] _files = Directory.GetFiles(selectedFolder);

            listViewFile.Items.Clear();
            int index = 0;
            foreach (string _file in _files)
            {
                FileInfo _fi = new FileInfo(_file);

                listViewFile.Items.Add((index + 1).ToString());
                listViewFile.Items[index].SubItems.Add(_fi.Name);
                listViewFile.Items[index].SubItems.Add(_fi.FullName);
                listViewFile.Items[index].SubItems.Add((_fi.Length / 1024 / 1024).ToString());
                listViewFile.Items[index].SubItems.Add(_fi.Extension);
                index++;
            }
        }

        private void LoadFolderAndFile(object sender, EventArgs e)
        {
            string[] _directories = Directory.GetDirectories(path);
            listBoxFolderList.Items.AddRange(_directories);

            LoadFiles(path);
        }
    }
}
