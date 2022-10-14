using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace M_VideoRecovery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRefVid_Click(object sender, EventArgs e)
        {
            DialogResult result = SelectVideoFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtRef.Text = SelectVideoFile.FileName.ToString();

            }
        }

        private void BtnBroken_Click(object sender, EventArgs e)
        {
            DialogResult result2 = SelectVideoFile.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                TxtBroken.Text = SelectVideoFile.FileName.ToString();

            }
        }

        private void BtnDst_Click(object sender, EventArgs e)
        {
            DialogResult result = BrowseDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtDest.Text = BrowseDialog.SelectedPath.ToString();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (TxtRef.Text == "")
            {
                MessageBox.Show("Please Select Reference File");
            }
            else if (TxtBroken.Text == "")
            {
                MessageBox.Show("Please Select Broken File");
            }
            else if (TxtDest.Text == "")
            {
                MessageBox.Show("Please Select Destination Path");
            }
            else
            {
                Process cmdcommand = new Process();
                cmdcommand.EnableRaisingEvents = true;
                cmdcommand.StartInfo.FileName = "cmd.exe";
                cmdcommand.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
                cmdcommand.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                cmdcommand.StartInfo.RedirectStandardOutput = true;
                cmdcommand.StartInfo.RedirectStandardInput = true;
                cmdcommand.StartInfo.CreateNoWindow = true;
                cmdcommand.StartInfo.UseShellExecute = false;
                cmdcommand.Exited += new EventHandler(myCoding_Exited);
                cmdcommand.OutputDataReceived += Cmd_OutputDataReceived;
                cmdcommand.StartInfo.Arguments = "/C cli.exe -dst " + TxtDest.Text + " " + TxtRef.Text + " " + TxtBroken.Text + "  ";
                cmdcommand.Start();
                cmdcommand.BeginOutputReadLine();
            }        

        }
        private void Cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            SetText(e.Data);
        }
        delegate void StringArgReturningVoidDelegate(string text);
        private void SetText(string text)
        {
            if (text != null)
            {
                if (listBox1.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    listBox1.Items.Add(text);
                }
            }
        }
        private void myCoding_Exited(object sender, EventArgs e)
        {
            MessageBox.Show("Finished Check Log Screen");
        }
    }
}
