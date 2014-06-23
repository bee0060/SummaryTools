namespace SummaryTools
{
    partial class Index
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
            this.fbdSrc = new System.Windows.Forms.FolderBrowserDialog();
            this.labSrcDirectory = new System.Windows.Forms.Label();
            this.btnSelectSrc = new System.Windows.Forms.Button();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.btnOpenTables = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.labPreviewData = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.labUsedTime = new System.Windows.Forms.Label();
            this.txtUsedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labSrcDirectory
            // 
            this.labSrcDirectory.AutoSize = true;
            this.labSrcDirectory.Location = new System.Drawing.Point(7, 51);
            this.labSrcDirectory.Name = "labSrcDirectory";
            this.labSrcDirectory.Size = new System.Drawing.Size(77, 12);
            this.labSrcDirectory.TabIndex = 0;
            this.labSrcDirectory.Text = "源表格文件夹";
            // 
            // btnSelectSrc
            // 
            this.btnSelectSrc.Location = new System.Drawing.Point(435, 46);
            this.btnSelectSrc.Name = "btnSelectSrc";
            this.btnSelectSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSrc.TabIndex = 1;
            this.btnSelectSrc.Text = "选择源文件夹";
            this.btnSelectSrc.UseVisualStyleBackColor = true;
            this.btnSelectSrc.Click += new System.EventHandler(this.btnSelectSrc_Click);
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(96, 48);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.ReadOnly = true;
            this.txtSrcPath.Size = new System.Drawing.Size(306, 21);
            this.txtSrcPath.TabIndex = 2;
            // 
            // btnOpenTables
            // 
            this.btnOpenTables.Location = new System.Drawing.Point(96, 94);
            this.btnOpenTables.Name = "btnOpenTables";
            this.btnOpenTables.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTables.TabIndex = 3;
            this.btnOpenTables.Text = "打开表格文件";
            this.btnOpenTables.UseVisualStyleBackColor = true;
            this.btnOpenTables.Click += new System.EventHandler(this.btnOpenTables_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(435, 94);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "汇总";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // labPreviewData
            // 
            this.labPreviewData.AutoSize = true;
            this.labPreviewData.Location = new System.Drawing.Point(13, 137);
            this.labPreviewData.Name = "labPreviewData";
            this.labPreviewData.Size = new System.Drawing.Size(53, 12);
            this.labPreviewData.TabIndex = 6;
            this.labPreviewData.Text = "预览数据";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(96, 137);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(414, 254);
            this.txtOutput.TabIndex = 7;
            // 
            // labUsedTime
            // 
            this.labUsedTime.AutoSize = true;
            this.labUsedTime.Location = new System.Drawing.Point(15, 402);
            this.labUsedTime.Name = "labUsedTime";
            this.labUsedTime.Size = new System.Drawing.Size(29, 12);
            this.labUsedTime.TabIndex = 8;
            this.labUsedTime.Text = "耗时";
            // 
            // txtUsedTime
            // 
            this.txtUsedTime.Location = new System.Drawing.Point(96, 399);
            this.txtUsedTime.Name = "txtUsedTime";
            this.txtUsedTime.Size = new System.Drawing.Size(100, 21);
            this.txtUsedTime.TabIndex = 9;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 526);
            this.Controls.Add(this.txtUsedTime);
            this.Controls.Add(this.labUsedTime);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.labPreviewData);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnOpenTables);
            this.Controls.Add(this.txtSrcPath);
            this.Controls.Add(this.btnSelectSrc);
            this.Controls.Add(this.labSrcDirectory);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSrc;
        private System.Windows.Forms.Label labSrcDirectory;
        private System.Windows.Forms.Button btnSelectSrc;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.Button btnOpenTables;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label labPreviewData;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label labUsedTime;
        private System.Windows.Forms.TextBox txtUsedTime;
    }
}