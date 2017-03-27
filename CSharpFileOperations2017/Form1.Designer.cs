namespace CSharpFileOperations2017
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoadAllLines = new System.Windows.Forms.Button();
            this.btnSR = new System.Windows.Forms.Button();
            this.btnSRasync = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveUserPW = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckUserPW = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 42);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 7);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(117, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Here is some text";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(9, 119);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(78, 45);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(9, 75);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(78, 38);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(279, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 180);
            this.listBox1.TabIndex = 4;
            // 
            // btnLoadAllLines
            // 
            this.btnLoadAllLines.Location = new System.Drawing.Point(93, 27);
            this.btnLoadAllLines.Name = "btnLoadAllLines";
            this.btnLoadAllLines.Size = new System.Drawing.Size(75, 42);
            this.btnLoadAllLines.TabIndex = 5;
            this.btnLoadAllLines.Text = "Load All Lines";
            this.btnLoadAllLines.UseVisualStyleBackColor = true;
            this.btnLoadAllLines.Click += new System.EventHandler(this.btnLoadAllLines_Click);
            // 
            // btnSR
            // 
            this.btnSR.Location = new System.Drawing.Point(93, 75);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(75, 48);
            this.btnSR.TabIndex = 6;
            this.btnSR.Text = "Stream Reader";
            this.btnSR.UseVisualStyleBackColor = true;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnSRasync
            // 
            this.btnSRasync.Location = new System.Drawing.Point(183, 23);
            this.btnSRasync.Name = "btnSRasync";
            this.btnSRasync.Size = new System.Drawing.Size(75, 51);
            this.btnSRasync.TabIndex = 7;
            this.btnSRasync.Text = "SR Async";
            this.btnSRasync.UseVisualStyleBackColor = true;
            this.btnSRasync.Click += new System.EventHandler(this.btnSRasync_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(435, 7);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(233, 178);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "lblOutput";
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Location = new System.Drawing.Point(183, 78);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(79, 42);
            this.btnReadAsync.TabIndex = 9;
            this.btnReadAsync.Text = "Read Async";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(4, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // btnSaveUserPW
            // 
            this.btnSaveUserPW.Location = new System.Drawing.Point(244, 11);
            this.btnSaveUserPW.Name = "btnSaveUserPW";
            this.btnSaveUserPW.Size = new System.Drawing.Size(131, 24);
            this.btnSaveUserPW.TabIndex = 14;
            this.btnSaveUserPW.Text = "Save User PW";
            this.btnSaveUserPW.UseVisualStyleBackColor = true;
            this.btnSaveUserPW.Click += new System.EventHandler(this.btnSaveUserPW_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnCheckUserPW);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnSaveUserPW);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 78);
            this.panel1.TabIndex = 15;
            // 
            // btnCheckUserPW
            // 
            this.btnCheckUserPW.Location = new System.Drawing.Point(244, 41);
            this.btnCheckUserPW.Name = "btnCheckUserPW";
            this.btnCheckUserPW.Size = new System.Drawing.Size(131, 23);
            this.btnCheckUserPW.TabIndex = 15;
            this.btnCheckUserPW.Text = "Check User PW";
            this.btnCheckUserPW.UseVisualStyleBackColor = true;
            this.btnCheckUserPW.Click += new System.EventHandler(this.btnCheckUserPW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReadAsync);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSRasync);
            this.Controls.Add(this.btnSR);
            this.Controls.Add(this.btnLoadAllLines);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoadAllLines;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.Button btnSRasync;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveUserPW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckUserPW;
    }
}

