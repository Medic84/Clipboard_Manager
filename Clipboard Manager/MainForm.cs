using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.Win32;

namespace ClipMng
{
    public partial class MainForm : Form
    {
        public String Last = "";
        
        public MainForm()
        {
            InitializeComponent();
            TT.Start();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey key;

            if (!TWinAutoRun.Checked)
            {
                key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                key.DeleteValue("Clipboard Manager");
                key.Close();
            }
            else
            {
                key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                key.SetValue("Clipboard Manager", Application.ExecutablePath);
                key.Close();
            }   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowser("http://mediclab.org");
        }

        private void показатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm ShFm = new ShowForm();
            ShFm.TextBox1.Text = TMainList.SelectedItems[0].Text;
            ShFm.Show();
        }

        private void скопироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TMainList.SelectedItems[0].Text);
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TMainList.Items.RemoveAt(TMainList.SelectedItems[0].Index);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            OpenBrowser("http://www.facebook.com/profile.php?id=100001124670058");
        }

        private void googleplus_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://plus.google.com/u/0/116041127872162226481/posts");
        }

        private void vkontakte_Click(object sender, EventArgs e)
        {
            OpenBrowser("http://vkontakte.ru/id14833332");
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://twitter.com/#!/Med1c84");
        }

        public void OpenBrowser(String adress)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = adress;
            p.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String New = "", Time = "";
            String path = Application.StartupPath + "\\log.txt";
            StreamWriter hOpen;

            if (checkBox1.Checked)
            {
                if (!File.Exists(path)) File.CreateText(path);
            }
            try
            {
                New = Clipboard.GetText();
                Time = System.DateTime.Now.ToString();
            }
            catch (ObjectDisposedException d) { d.ToString(); }

            if (Last != New)
            {
                ListViewItem listItem = new ListViewItem(New);
                listItem.SubItems.Add(Time);
                TMainList.Items.Add(listItem);
                hOpen = File.AppendText(path);
                if (checkBox1.Checked) hOpen.WriteLine(Time + "\t" + New + "\n");
                hOpen.Close();
                hOpen.Dispose();
                Last = New;
             }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Application.StartupPath + "\\log.txt";
            
            File.Delete(path);

            if (checkBox1.Checked)
            {
                if (!File.Exists(path)) File.CreateText(path);
            }
        }
    }
}
