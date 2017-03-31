namespace SSH_Form_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bExecuteCommand = new System.Windows.Forms.Button();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bTestButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.bDownloadFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbRemotePath = new System.Windows.Forms.TextBox();
            this.bGetFiles = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(85, 20);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(100, 20);
            this.tbHostAddress.TabIndex = 0;
            this.tbHostAddress.Text = "192.168.0.106";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host Address";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(85, 46);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "pi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(85, 72);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "raspberry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(85, 98);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(100, 23);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Location = new System.Drawing.Point(85, 127);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(100, 23);
            this.bDisconnect.TabIndex = 3;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bDisconnect);
            this.groupBox1.Controls.Add(this.tbHostAddress);
            this.groupBox1.Controls.Add(this.bConnect);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Properties";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(213, 18);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(447, 317);
            this.tbOutput.TabIndex = 5;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(213, 343);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(333, 20);
            this.tbInput.TabIndex = 6;
            // 
            // bExecuteCommand
            // 
            this.bExecuteCommand.Location = new System.Drawing.Point(552, 341);
            this.bExecuteCommand.Name = "bExecuteCommand";
            this.bExecuteCommand.Size = new System.Drawing.Size(108, 23);
            this.bExecuteCommand.TabIndex = 7;
            this.bExecuteCommand.Text = "Execute Command";
            this.bExecuteCommand.UseVisualStyleBackColor = true;
            this.bExecuteCommand.Click += new System.EventHandler(this.bExecuteCommand_Click);
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(756, 58);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(268, 263);
            this.tbDebug.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Debug Area";
            // 
            // bTestButton
            // 
            this.bTestButton.Location = new System.Drawing.Point(756, 29);
            this.bTestButton.Name = "bTestButton";
            this.bTestButton.Size = new System.Drawing.Size(173, 23);
            this.bTestButton.TabIndex = 9;
            this.bTestButton.Text = "Test Button";
            this.bTestButton.UseVisualStyleBackColor = true;
            this.bTestButton.Click += new System.EventHandler(this.bTestButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFileName);
            this.groupBox2.Controls.Add(this.bUploadFile);
            this.groupBox2.Controls.Add(this.bDownloadFile);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbLocalPath);
            this.groupBox2.Controls.Add(this.tbRemotePath);
            this.groupBox2.Controls.Add(this.bGetFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 186);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SFTP File Properties";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(81, 72);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(108, 20);
            this.tbFileName.TabIndex = 13;
            this.tbFileName.Text = "Not used yet";
            // 
            // bUploadFile
            // 
            this.bUploadFile.Location = new System.Drawing.Point(85, 156);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(104, 23);
            this.bUploadFile.TabIndex = 11;
            this.bUploadFile.Text = "Upload File";
            this.bUploadFile.UseVisualStyleBackColor = true;
            this.bUploadFile.Click += new System.EventHandler(this.bUploadFile_Click);
            // 
            // bDownloadFile
            // 
            this.bDownloadFile.Location = new System.Drawing.Point(85, 127);
            this.bDownloadFile.Name = "bDownloadFile";
            this.bDownloadFile.Size = new System.Drawing.Size(104, 23);
            this.bDownloadFile.TabIndex = 12;
            this.bDownloadFile.Text = "Download File";
            this.bDownloadFile.UseVisualStyleBackColor = true;
            this.bDownloadFile.Click += new System.EventHandler(this.bDownloadFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Local Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remote Path";
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Location = new System.Drawing.Point(81, 45);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(108, 20);
            this.tbLocalPath.TabIndex = 11;
            this.tbLocalPath.Text = "Not used yet";
            // 
            // tbRemotePath
            // 
            this.tbRemotePath.Location = new System.Drawing.Point(81, 19);
            this.tbRemotePath.Name = "tbRemotePath";
            this.tbRemotePath.Size = new System.Drawing.Size(108, 20);
            this.tbRemotePath.TabIndex = 11;
            this.tbRemotePath.Text = "/home/pi/tmp/";
            // 
            // bGetFiles
            // 
            this.bGetFiles.Location = new System.Drawing.Point(85, 98);
            this.bGetFiles.Name = "bGetFiles";
            this.bGetFiles.Size = new System.Drawing.Size(104, 23);
            this.bGetFiles.TabIndex = 11;
            this.bGetFiles.Text = "Get File List";
            this.bGetFiles.UseVisualStyleBackColor = true;
            this.bGetFiles.Click += new System.EventHandler(this.bGetFiles_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Debug Area --> --> -->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bTestButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.bExecuteCommand);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LabSSH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bExecuteCommand;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bTestButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bGetFiles;
        private System.Windows.Forms.Button bUploadFile;
        private System.Windows.Forms.Button bDownloadFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbRemotePath;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

