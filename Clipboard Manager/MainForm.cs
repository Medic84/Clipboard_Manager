using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Threading;
using System.Data.SQLite;

namespace ClipMng
{
    
    public partial class MainForm : Form
    {
        private Thread tChecker = null;
        private String Last = null;
        private SQLiteConnection conn = new SQLiteConnection("Data Source=History.db;");

        public MainForm()
        {
            conn.Open();
           
            InitializeComponent();

            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS History (Text, Time)", conn);
                cmd.ExecuteNonQuery();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM History;", conn);
                SQLiteDataReader reader = command.ExecuteReader();
                foreach (DbDataRecord record in reader)
                {
                    ListViewItem Item = new ListViewItem(record["Text"].ToString());
                    Item.SubItems.Add(record["Time"].ToString());
                    TMainList.Items.Add(Item);
                    Last = record["Text"].ToString();
                }
            }

            tChecker = new Thread(TClipboardChecker);
            tChecker.SetApartmentState(ApartmentState.STA);
            tChecker.Start();
        }

        //private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //{
        //    RegistryKey key;

        //    if (!TWinAutoRun.Checked)
        //    {
        //        key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
        //        key.DeleteValue("Clipboard Manager");
        //        key.Close();
        //    }
        //    else
        //    {
        //        key = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
        //        key.SetValue("Clipboard Manager", Application.ExecutablePath);
        //        key.Close();
        //    }   
        //}

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

        public void OpenBrowser(String adress)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = adress;
            p.Start();
        }

        private void TClipboardChecker()
        {
            String New = null, Time = null;

            while (true)
            {
               New = Clipboard.GetText();
               Time = DateTime.Now.ToString();

                TMainList.Invoke((MethodInvoker)delegate
                {
                    if (New != null && Time != null && Last != New)
                    {
                        ListViewItem newItem = new ListViewItem(New);
                        newItem.SubItems.Add(Time);
                        if (слежениеЗаБуферомToolStripMenuItem.Checked)
                        {
                            SQLiteCommand cmd = new SQLiteCommand(String.Format("INSERT INTO History values (\"{0}\", \"{1}\")",New.Replace("\"","\"\""),Time), conn);
                            cmd.ExecuteNonQuery();
                            TMainList.Items.Add(newItem);
                        }
                    }
                });
                Last = New;
                Thread.Sleep(250);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tChecker.Abort();
            conn.Dispose();
        }

        private void слежениеЗаБуферомToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
