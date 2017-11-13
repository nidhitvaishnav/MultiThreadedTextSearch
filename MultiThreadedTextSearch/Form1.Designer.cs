namespace MultiThreadedTextSearch
{
    partial class myForm
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
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.textLbl = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.searchCancelBtn = new System.Windows.Forms.Button();
            this.displayLv = new System.Windows.Forms.ListView();
            this.clmHdrIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrLineNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activityStatusLbl = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.textFoundLbl = new System.Windows.Forms.Label();
            this.lineCounted = new System.Windows.Forms.Label();
            this.lineCountedLbl = new System.Windows.Forms.Label();
            this.textFound = new System.Windows.Forms.Label();
            this.uniqueLineTextLbl = new System.Windows.Forms.Label();
            this.uniqueLineText = new System.Windows.Forms.Label();
            this.activityStatusLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLbl.Location = new System.Drawing.Point(12, 16);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(75, 17);
            this.fileNameLbl.TabIndex = 0;
            this.fileNameLbl.Text = "File Name:";
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl.Location = new System.Drawing.Point(10, 51);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(78, 17);
            this.textLbl.TabIndex = 1;
            this.textLbl.Text = "Search for:";
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(94, 13);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(479, 23);
            this.filePath.TabIndex = 0;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(94, 48);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(478, 23);
            this.searchText.TabIndex = 2;
            // 
            // browseBtn
            // 
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.Location = new System.Drawing.Point(589, 13);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // searchCancelBtn
            // 
            this.searchCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCancelBtn.Location = new System.Drawing.Point(589, 48);
            this.searchCancelBtn.Name = "searchCancelBtn";
            this.searchCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.searchCancelBtn.TabIndex = 3;
            this.searchCancelBtn.Text = "Search";
            this.searchCancelBtn.UseVisualStyleBackColor = true;
            this.searchCancelBtn.Click += new System.EventHandler(this.searchCancelBtn_Click);
            // 
            // displayLv
            // 
            this.displayLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHdrIndex,
            this.clmHdrLineNo,
            this.clmHdrText});
            this.displayLv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLv.FullRowSelect = true;
            this.displayLv.HideSelection = false;
            this.displayLv.Location = new System.Drawing.Point(15, 93);
            this.displayLv.Name = "displayLv";
            this.displayLv.Size = new System.Drawing.Size(649, 262);
            this.displayLv.TabIndex = 6;
            this.displayLv.UseCompatibleStateImageBehavior = false;
            this.displayLv.View = System.Windows.Forms.View.Details;
            // 
            // clmHdrIndex
            // 
            this.clmHdrIndex.Text = "Index";
            this.clmHdrIndex.Width = 50;
            // 
            // clmHdrLineNo
            // 
            this.clmHdrLineNo.Text = "Line No.";
            this.clmHdrLineNo.Width = 75;
            // 
            // clmHdrText
            // 
            this.clmHdrText.Text = "Text";
            this.clmHdrText.Width = 500;
            // 
            // activityStatusLbl
            // 
            this.activityStatusLbl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl,
            this.toolStripStatusLbl});
            this.activityStatusLbl.Location = new System.Drawing.Point(0, 451);
            this.activityStatusLbl.Name = "activityStatusLbl";
            this.activityStatusLbl.Size = new System.Drawing.Size(693, 22);
            this.activityStatusLbl.TabIndex = 7;
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // textFoundLbl
            // 
            this.textFoundLbl.AutoSize = true;
            this.textFoundLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoundLbl.Location = new System.Drawing.Point(238, 397);
            this.textFoundLbl.Name = "textFoundLbl";
            this.textFoundLbl.Size = new System.Drawing.Size(79, 17);
            this.textFoundLbl.TabIndex = 8;
            this.textFoundLbl.Text = "Text found:";
            this.textFoundLbl.Visible = false;
            // 
            // lineCounted
            // 
            this.lineCounted.AutoSize = true;
            this.lineCounted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCounted.Location = new System.Drawing.Point(340, 368);
            this.lineCounted.Name = "lineCounted";
            this.lineCounted.Size = new System.Drawing.Size(13, 17);
            this.lineCounted.TabIndex = 9;
            this.lineCounted.Text = "-";
            this.lineCounted.Visible = false;
            // 
            // lineCountedLbl
            // 
            this.lineCountedLbl.AutoSize = true;
            this.lineCountedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineCountedLbl.Location = new System.Drawing.Point(223, 368);
            this.lineCountedLbl.Name = "lineCountedLbl";
            this.lineCountedLbl.Size = new System.Drawing.Size(94, 17);
            this.lineCountedLbl.TabIndex = 10;
            this.lineCountedLbl.Text = "Line counted:";
            this.lineCountedLbl.Visible = false;
            // 
            // textFound
            // 
            this.textFound.AutoSize = true;
            this.textFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFound.Location = new System.Drawing.Point(340, 397);
            this.textFound.Name = "textFound";
            this.textFound.Size = new System.Drawing.Size(13, 17);
            this.textFound.TabIndex = 11;
            this.textFound.Text = "-";
            this.textFound.Visible = false;
            // 
            // uniqueLineTextLbl
            // 
            this.uniqueLineTextLbl.AutoSize = true;
            this.uniqueLineTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueLineTextLbl.Location = new System.Drawing.Point(133, 424);
            this.uniqueLineTextLbl.Name = "uniqueLineTextLbl";
            this.uniqueLineTextLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uniqueLineTextLbl.Size = new System.Drawing.Size(184, 17);
            this.uniqueLineTextLbl.TabIndex = 12;
            this.uniqueLineTextLbl.Text = "No. of unique lines with text:";
            this.uniqueLineTextLbl.Visible = false;
            // 
            // uniqueLineText
            // 
            this.uniqueLineText.AutoSize = true;
            this.uniqueLineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueLineText.Location = new System.Drawing.Point(340, 424);
            this.uniqueLineText.Name = "uniqueLineText";
            this.uniqueLineText.Size = new System.Drawing.Size(13, 17);
            this.uniqueLineText.TabIndex = 13;
            this.uniqueLineText.Text = "-";
            this.uniqueLineText.Visible = false;
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 473);
            this.Controls.Add(this.uniqueLineText);
            this.Controls.Add(this.uniqueLineTextLbl);
            this.Controls.Add(this.textFound);
            this.Controls.Add(this.lineCountedLbl);
            this.Controls.Add(this.lineCounted);
            this.Controls.Add(this.textFoundLbl);
            this.Controls.Add(this.activityStatusLbl);
            this.Controls.Add(this.displayLv);
            this.Controls.Add(this.searchCancelBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.fileNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "myForm";
            this.Text = "Text Search";
            this.activityStatusLbl.ResumeLayout(false);
            this.activityStatusLbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button searchCancelBtn;
        private System.Windows.Forms.ListView displayLv;
        private System.Windows.Forms.ColumnHeader clmHdrLineNo;
        private System.Windows.Forms.ColumnHeader clmHdrText;
        private System.Windows.Forms.StatusStrip activityStatusLbl;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label textFoundLbl;
        private System.Windows.Forms.Label lineCounted;
        private System.Windows.Forms.Label lineCountedLbl;
        private System.Windows.Forms.Label textFound;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.ColumnHeader clmHdrIndex;
        private System.Windows.Forms.Label uniqueLineTextLbl;
        private System.Windows.Forms.Label uniqueLineText;
    }
}

