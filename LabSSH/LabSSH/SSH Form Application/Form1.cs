using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using LabSSH;

namespace SSH_Form_Application
{
    public partial class Form1 : Form
    {
        LabSSH.LabSSH ssh;
        LabSSH.LabSSH sftp;

        public Form1()
        {
            InitializeComponent();
        }

        #region Form events
        private void Form1_Load(object sender, EventArgs e)
        { }

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // class constructor
                //ssh = new LabSSH.LabSSH(tbHostAddress.Text, tbUserName.Text, tbPassword.Text);
                ssh = new LabSSH.LabSSH();

                ssh.remote = tbHostAddress.Text;
                ssh.user = tbUserName.Text;
                ssh.password = tbPassword.Text;

                Cursor.Current = Cursors.WaitCursor;
                tbDebug.AppendText("Connection Started\r\n");
                ssh.connect();
                readReader();
                Cursor.Current = Cursors.Default;
                tbDebug.AppendText("Connection Complete\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ssh.disconnect();
                Cursor.Current = Cursors.Default;
                tbDebug.AppendText("\r\nDisconnection Complete\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bExecuteCommand_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ssh.writer.WriteLine(tbInput.Text);
                ssh.writer.AutoFlush = true;
                readReader();
                Cursor.Current = Cursors.Default;
                tbInput.Text = "";
                tbInput.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void bGetFiles_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                sftp = new LabSSH.LabSSH();
                sftp.remote = tbHostAddress.Text;
                sftp.user = tbUserName.Text;
                sftp.password = tbPassword.Text;
                sftp.getFileList(tbRemotePath.Text);
                tbOutput.AppendText(sftp.fileList + "--------------------------\r\n");
                Cursor.Current = Cursors.Default;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Download and Upload File is not working yet. 
        // Need to resolve the paths
        private void bDownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                sftp = new LabSSH.LabSSH();
                sftp.remote = tbHostAddress.Text;
                sftp.user = tbUserName.Text;
                sftp.password = tbPassword.Text;
                sftp.uploadFile(tbRemotePath.Text, tbLocalPath.Text, tbFileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void bUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                sftp = new LabSSH.LabSSH();
                sftp.remote = tbHostAddress.Text;
                sftp.user = tbUserName.Text;
                sftp.password = tbPassword.Text;
                sftp.uploadFile(tbRemotePath.Text, tbLocalPath.Text, tbFileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        # endregion

        #region private methods
        private void readReader()
        {
            try
            {
                int i;
                for (i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    if (ssh.stream.DataAvailable)
                    {
                        tbOutput.AppendText(ssh.reader.ReadToEnd());
                        tbOutput.ScrollToCaret();
                        Thread.Sleep(50);
                    }
                    tbDebug.AppendText(i.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        # endregion

        private void bTestButton_Click(object sender, EventArgs e)
        {
            
        }

        




    }
}
