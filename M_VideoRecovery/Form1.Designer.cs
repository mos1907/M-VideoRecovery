namespace M_VideoRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnRefVid = new System.Windows.Forms.Button();
            this.BtnBroken = new System.Windows.Forms.Button();
            this.TxtRef = new System.Windows.Forms.TextBox();
            this.TxtBroken = new System.Windows.Forms.TextBox();
            this.BtnDst = new System.Windows.Forms.Button();
            this.TxtDest = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SelectVideoFile = new System.Windows.Forms.OpenFileDialog();
            this.BrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // BtnRefVid
            // 
            this.BtnRefVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefVid.Location = new System.Drawing.Point(12, 12);
            this.BtnRefVid.Name = "BtnRefVid";
            this.BtnRefVid.Size = new System.Drawing.Size(122, 23);
            this.BtnRefVid.TabIndex = 0;
            this.BtnRefVid.Text = " Reference Video File";
            this.BtnRefVid.UseVisualStyleBackColor = true;
            this.BtnRefVid.Click += new System.EventHandler(this.BtnRefVid_Click);
            // 
            // BtnBroken
            // 
            this.BtnBroken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBroken.Location = new System.Drawing.Point(12, 41);
            this.BtnBroken.Name = "BtnBroken";
            this.BtnBroken.Size = new System.Drawing.Size(122, 23);
            this.BtnBroken.TabIndex = 1;
            this.BtnBroken.Text = "Broken Video File";
            this.BtnBroken.UseVisualStyleBackColor = true;
            this.BtnBroken.Click += new System.EventHandler(this.BtnBroken_Click);
            // 
            // TxtRef
            // 
            this.TxtRef.Enabled = false;
            this.TxtRef.Location = new System.Drawing.Point(140, 12);
            this.TxtRef.Multiline = true;
            this.TxtRef.Name = "TxtRef";
            this.TxtRef.ReadOnly = true;
            this.TxtRef.Size = new System.Drawing.Size(554, 23);
            this.TxtRef.TabIndex = 2;
            // 
            // TxtBroken
            // 
            this.TxtBroken.Enabled = false;
            this.TxtBroken.Location = new System.Drawing.Point(140, 41);
            this.TxtBroken.Multiline = true;
            this.TxtBroken.Name = "TxtBroken";
            this.TxtBroken.ReadOnly = true;
            this.TxtBroken.Size = new System.Drawing.Size(554, 23);
            this.TxtBroken.TabIndex = 3;
            // 
            // BtnDst
            // 
            this.BtnDst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDst.Location = new System.Drawing.Point(12, 70);
            this.BtnDst.Name = "BtnDst";
            this.BtnDst.Size = new System.Drawing.Size(122, 23);
            this.BtnDst.TabIndex = 4;
            this.BtnDst.Text = "Destination Path";
            this.BtnDst.UseVisualStyleBackColor = true;
            this.BtnDst.Click += new System.EventHandler(this.BtnDst_Click);
            // 
            // TxtDest
            // 
            this.TxtDest.Enabled = false;
            this.TxtDest.Location = new System.Drawing.Point(140, 70);
            this.TxtDest.Multiline = true;
            this.TxtDest.Name = "TxtDest";
            this.TxtDest.ReadOnly = true;
            this.TxtDest.Size = new System.Drawing.Size(554, 23);
            this.TxtDest.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(682, 225);
            this.listBox1.TabIndex = 6;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(588, 330);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(106, 32);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "Start Repair";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // SelectVideoFile
            // 
            this.SelectVideoFile.FileName = "FileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(701, 370);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtDest);
            this.Controls.Add(this.BtnDst);
            this.Controls.Add(this.TxtBroken);
            this.Controls.Add(this.TxtRef);
            this.Controls.Add(this.BtnBroken);
            this.Controls.Add(this.BtnRefVid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M Video Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRefVid;
        private System.Windows.Forms.Button BtnBroken;
        private System.Windows.Forms.TextBox TxtRef;
        private System.Windows.Forms.TextBox TxtBroken;
        private System.Windows.Forms.Button BtnDst;
        private System.Windows.Forms.TextBox TxtDest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.OpenFileDialog SelectVideoFile;
        private System.Windows.Forms.FolderBrowserDialog BrowseDialog;
    }
}

