namespace BookShelf
{
    partial class frmMain
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPublished = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDisplayFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayClear = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAdd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.lblPublished);
            this.grpAdd.Controls.Add(this.lblPublisher);
            this.grpAdd.Controls.Add(this.lblAuthor);
            this.grpAdd.Controls.Add(this.lblTitle);
            this.grpAdd.Controls.Add(this.txtPublished);
            this.grpAdd.Controls.Add(this.txtPublisher);
            this.grpAdd.Controls.Add(this.txtAuthor);
            this.grpAdd.Controls.Add(this.txtTitle);
            this.grpAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpAdd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grpAdd.Location = new System.Drawing.Point(13, 245);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(355, 144);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "New Books";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(265, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPublished
            // 
            this.lblPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublished.Location = new System.Drawing.Point(6, 109);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(74, 20);
            this.lblPublished.TabIndex = 7;
            this.lblPublished.Text = "Published:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(6, 77);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(64, 20);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(6, 51);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtPublished
            // 
            this.txtPublished.Location = new System.Drawing.Point(80, 108);
            this.txtPublished.Name = "txtPublished";
            this.txtPublished.Size = new System.Drawing.Size(179, 20);
            this.txtPublished.TabIndex = 3;
            this.txtPublished.Text = "Published";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(80, 77);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(179, 20);
            this.txtPublisher.TabIndex = 2;
            this.txtPublisher.Text = "Publisher";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 50);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(266, 20);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(80, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(266, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Title";
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(13, 26);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(355, 173);
            this.lbxOutput.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(12, 205);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(104, 205);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowAll.Location = new System.Drawing.Point(191, 205);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(81, 34);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(278, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayFile,
            this.mnuTopDisplay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDisplayFile
            // 
            this.mnuDisplayFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayExit});
            this.mnuDisplayFile.Name = "mnuDisplayFile";
            this.mnuDisplayFile.Size = new System.Drawing.Size(37, 20);
            this.mnuDisplayFile.Text = "File";
            // 
            // mnuDisplayExit
            // 
            this.mnuDisplayExit.Name = "mnuDisplayExit";
            this.mnuDisplayExit.Size = new System.Drawing.Size(180, 22);
            this.mnuDisplayExit.Text = "Exit";
            this.mnuDisplayExit.Click += new System.EventHandler(this.mnuDisplayExit_Click);
            // 
            // mnuTopDisplay
            // 
            this.mnuTopDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayNext,
            this.mnuDisplayBack,
            this.mnuDisplayAll,
            this.mnuDisplayClear});
            this.mnuTopDisplay.Name = "mnuTopDisplay";
            this.mnuTopDisplay.Size = new System.Drawing.Size(57, 20);
            this.mnuTopDisplay.Text = "Display";
            this.mnuTopDisplay.Click += new System.EventHandler(this.mnuTopDisplay_Click);
            // 
            // mnuDisplayNext
            // 
            this.mnuDisplayNext.Name = "mnuDisplayNext";
            this.mnuDisplayNext.Size = new System.Drawing.Size(180, 22);
            this.mnuDisplayNext.Text = "Next";
            this.mnuDisplayNext.Click += new System.EventHandler(this.mnuDisplayNext_Click);
            // 
            // mnuDisplayBack
            // 
            this.mnuDisplayBack.Name = "mnuDisplayBack";
            this.mnuDisplayBack.Size = new System.Drawing.Size(180, 22);
            this.mnuDisplayBack.Text = "Back";
            // 
            // mnuDisplayAll
            // 
            this.mnuDisplayAll.Name = "mnuDisplayAll";
            this.mnuDisplayAll.Size = new System.Drawing.Size(180, 22);
            this.mnuDisplayAll.Text = "All";
            // 
            // mnuDisplayClear
            // 
            this.mnuDisplayClear.Name = "mnuDisplayClear";
            this.mnuDisplayClear.Size = new System.Drawing.Size(180, 22);
            this.mnuDisplayClear.Text = "Clear";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 415);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "BookShelf Application";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPublished;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPublished;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTopDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayNext;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayBack;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayAll;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayClear;
    }
}

