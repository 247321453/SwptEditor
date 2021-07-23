using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SaveEditor
{
    public partial class OpenSaveForm : Form
    {
        public string FileName;

        public string InitialDirectory = "./";

        public OpenSaveForm()
        {
            InitializeComponent();
        }

        private void OpenSaveForm_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetDirectories(InitialDirectory);
            if (files != null)
            {
                cb_list.BeginUpdate();
                cb_list.Items.Clear();
                var list = new List<SaveThumbnail>();
                foreach (var file in files)
                {
                    string name = Path.GetFileName(file);
                    long id = SaveThumbnail.GetSaveID(name);
                    if (id != 0)
                    {
                        string txt = Path.Combine(file, "Global.txt");
                        if (File.Exists(txt))
                        {
                            var info = new SaveThumbnail(txt);
                            if (info.IsVaild())
                            {
                                info.ID = id;
                                list.Add(info);
                            }
                        }
                    }
                }
                cb_list.Items.AddRange(list.ToArray());
                cb_list.EndUpdate();
                if (list.Count > 0) {
                    cb_list.SelectedIndex = 0;
                }
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_list.SelectedIndex;
            if (index >= 0) {
                SaveThumbnail info = cb_list.Items[index] as SaveThumbnail;
                FileName = info.Path;
                textBox1.Text = "" + info.ID;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = "explorer.exe";
            p.StartInfo.Arguments = " /select, \"" + Path.GetFullPath(InitialDirectory) + "\"";
            try
            {
                p.Start();
            }
            catch {
                MessageBox.Show("打开文件夹失败");
            }
        }
    }
}
