using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet; // Library used for SSH
                    // 22 November 2014. .NET 4.0 Binary
                    // https://sshnet.codeplex.com/releases/view/120565
using Renci.SshNet.Sftp;
using System.Threading;
using System.IO;

namespace LabSSH
{
    public class LabSSH
    {
        // Constructor
        public LabSSH()
        { }

        //Destructor
        ~LabSSH()
        { }

        // Public class properties
        # region class properties
        private string _remote;
        public string remote
        {
            get { return _remote; }
            set { _remote = value; }
        }

        private string _user;
        public string user
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private SshClient _sshClient;
        public SshClient sshClient
        {
            get { return _sshClient; }
            set { _sshClient = value; }
        }

        private StreamReader _reader;
        public StreamReader reader
        {
            get { return _reader; }
            set { _reader = value; }
        }

        private StreamWriter _writer;
        public StreamWriter writer
        {
            get { return _writer; }
            set { _writer = value; }
        }

        private ShellStream _stream;
        public ShellStream stream
        {
            get { return _stream; }
            set { _stream = value; }
        }

        private SftpClient _sftpClient;
        public SftpClient sftpClient
        {
            get { return _sftpClient; }
            set { _sftpClient = value; }
        }

        private string _fileList;
        public string fileList
        {
            get { return _fileList; }
            set { _fileList = value; }
        }
        #endregion

        // SSH stream methods
        #region class stream methods
        public void connect()
        {
            sshClient = new SshClient(remote, user, password);
            sshClient.Connect(); //connect to the client

            stream = sshClient.CreateShellStream("dumb", 80, 24, 800, 600, 1024);
           
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            writer.AutoFlush = true;
        }

        public void executeCommand(string command)
        {
            writer.WriteLine(command);
            writer.AutoFlush = true;
        }

        public void disconnect()
        {
            sshClient.Disconnect();
        }
        #endregion

        // SFTP File methods
        #region sftp file methods
        public void getFileList(string remotePath)
        {
            fileList = "\r\n";
            sftpClient = new SftpClient(remote, user, password);
            sftpClient.Connect();
            var files = sftpClient.ListDirectory(remotePath);
            foreach(var file in files)
            {
                fileList = fileList + file.FullName + "\r\n";
            }
            sftpClient.Disconnect();
        }

        // Download and Upload File is not working yet. 
        // Need to resolve the paths
        public void uploadFile(string remotePath, string localPath, string fileName)
        {
            sftpClient = new SftpClient(remote, user, password);
            sftpClient.Connect();
            sftpClient.ChangeDirectory(remotePath);
            var uploadFile = File.OpenRead(fileName);
            sftpClient.UploadFile(uploadFile, fileName, true);
            //sftpClient.UploadFile(uploadFile, localPath + "/" + fileName, true);
            sftpClient.Disconnect();
        }

        public void downloadFile(string remotePath, string localPath, string fileName)
        {
            sftpClient = new SftpClient(remote, user, password);
            sftpClient.Connect();
            sftpClient.ChangeDirectory(remotePath);
            Stream downloadStream = File.OpenWrite(fileName);
            sftpClient.DownloadFile(localPath + "/" + fileName, downloadStream);
            sftpClient.Disconnect();
        }

        #endregion
    }
}
