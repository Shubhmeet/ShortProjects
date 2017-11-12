/*
* @ author :sxk162731
*/
namespace Asg5_sxk162731
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
            this.fName = new System.Windows.Forms.Label();
            this.searchTitle = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.stringSearch = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.outputList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.save_Results = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.filesearch = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progress_text = new System.Windows.Forms.Label();
            this.progressbar_title = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(55, 81);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(80, 20);
            this.fName.TabIndex = 0;
            this.fName.Text = "File Name";
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Location = new System.Drawing.Point(55, 125);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(88, 20);
            this.searchTitle.TabIndex = 1;
            this.searchTitle.Text = "Search For";
            // 
            // filename
            // 
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.Location = new System.Drawing.Point(150, 78);
            this.filename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(558, 26);
            this.filename.TabIndex = 1;
            this.filename.TextChanged += new System.EventHandler(this.stringSearch_TextChanged);
            // 
            // stringSearch
            // 
            this.stringSearch.AccessibleDescription = "";
            this.stringSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringSearch.Location = new System.Drawing.Point(150, 121);
            this.stringSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stringSearch.Name = "stringSearch";
            this.stringSearch.Size = new System.Drawing.Size(558, 26);
            this.stringSearch.TabIndex = 3;
            this.stringSearch.TextChanged += new System.EventHandler(this.stringSearch_TextChanged);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.Location = new System.Drawing.Point(714, 74);
            this.browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(84, 36);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // outputList
            // 
            this.outputList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.outputList.FullRowSelect = true;
            this.outputList.GridLines = true;
            this.outputList.Location = new System.Drawing.Point(59, 190);
            this.outputList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(741, 278);
            this.outputList.TabIndex = 6;
            this.outputList.TabStop = false;
            this.outputList.UseCompatibleStateImageBehavior = false;
            this.outputList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Counter";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Line no";
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Text";
            this.columnHeader3.Width = 516;
            // 
            // save_Results
            // 
            this.save_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_Results.Location = new System.Drawing.Point(611, 487);
            this.save_Results.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_Results.Name = "save_Results";
            this.save_Results.Size = new System.Drawing.Size(188, 35);
            this.save_Results.TabIndex = 8;
            this.save_Results.TabStop = false;
            this.save_Results.Text = "Save Search Results";
            this.save_Results.UseVisualStyleBackColor = true;
            this.save_Results.Click += new System.EventHandler(this.save_Results_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear.Location = new System.Drawing.Point(58, 487);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 35);
            this.clear.TabIndex = 10;
            this.clear.TabStop = false;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // filesearch
            // 
            this.filesearch.WorkerReportsProgress = true;
            this.filesearch.WorkerSupportsCancellation = true;
            this.filesearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.filesearch_DoWork);
            this.filesearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.filesearch_ProgressChanged);
            this.filesearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.filesearch_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(111, 162);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(687, 20);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 12;
            // 
            // progress_text
            // 
            this.progress_text.AutoSize = true;
            this.progress_text.Location = new System.Drawing.Point(55, 161);
            this.progress_text.Name = "progress_text";
            this.progress_text.Size = new System.Drawing.Size(32, 20);
            this.progress_text.TabIndex = 13;
            this.progress_text.Text = "1%";
            // 
            // progressbar_title
            // 
            this.progressbar_title.Location = new System.Drawing.Point(166, 768);
            this.progressbar_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressbar_title.Name = "progressbar_title";
            this.progressbar_title.Size = new System.Drawing.Size(0, 26);
            this.progressbar_title.TabIndex = 14;
            this.progressbar_title.TabStop = false;
            this.progressbar_title.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(715, 121);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 39);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Location = new System.Drawing.Point(715, 121);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 36);
            this.submit.TabIndex = 4;
            this.submit.Text = "Search";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.help.Location = new System.Drawing.Point(714, 27);
            this.help.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(84, 29);
            this.help.TabIndex = 16;
            this.help.TabStop = false;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 557);
            this.Controls.Add(this.help);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressbar_title);
            this.Controls.Add(this.progress_text);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save_Results);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.stringSearch);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.searchTitle);
            this.Controls.Add(this.fName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Text Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox stringSearch;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ListView outputList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button save_Results;
        private System.Windows.Forms.Button clear;
        private System.ComponentModel.BackgroundWorker filesearch;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progress_text;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox progressbar_title;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button help;
    }
}

