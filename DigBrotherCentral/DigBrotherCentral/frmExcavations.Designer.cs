namespace DigBrotherCentral
{
    partial class frmExcavations
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFileTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPrev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cdlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.cdlgSave = new System.Windows.Forms.SaveFileDialog();
            this.lbxExcavations = new System.Windows.Forms.ListBox();
            this.lblExcavationList = new System.Windows.Forms.Label();
            this.gbxExcavDetails = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxEquipment = new System.Windows.Forms.ListBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.btnAddEquip = new System.Windows.Forms.Button();
            this.btnRemoveEquip = new System.Windows.Forms.Button();
            this.pnlVolunteers = new System.Windows.Forms.Panel();
            this.lbxVolunteers = new System.Windows.Forms.ListBox();
            this.lblVolunteerList = new System.Windows.Forms.Label();
            this.btnAddVolunteer = new System.Windows.Forms.Button();
            this.btnRemoveVolunteer = new System.Windows.Forms.Button();
            this.pnlFinds = new System.Windows.Forms.Panel();
            this.lblTotalFinds = new System.Windows.Forms.Label();
            this.chkFindsRecorded = new System.Windows.Forms.CheckBox();
            this.btnViewFinds = new System.Windows.Forms.Button();
            this.lblSiteAccess = new System.Windows.Forms.Label();
            this.rdbRural = new System.Windows.Forms.RadioButton();
            this.rdbUrban = new System.Windows.Forms.RadioButton();
            this.lblSiteNotes = new System.Windows.Forms.Label();
            this.lblSiteAge = new System.Windows.Forms.Label();
            this.lblExDate = new System.Windows.Forms.Label();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.cboSiteAge = new System.Windows.Forms.ComboBox();
            this.txtSiteNotes = new System.Windows.Forms.TextBox();
            this.txtExcavDate = new System.Windows.Forms.TextBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.gbxTools = new System.Windows.Forms.GroupBox();
            this.btnForwardEx = new System.Windows.Forms.Button();
            this.btnBackEx = new System.Windows.Forms.Button();
            this.btnDeleteEx = new System.Windows.Forms.Button();
            this.btnEditEx = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddEx = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.gbxExcavDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlVolunteers.SuspendLayout();
            this.pnlFinds.SuspendLayout();
            this.gbxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileTop,
            this.mnuEditTop,
            this.mnuHelpTop});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(588, 24);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuFileTop
            // 
            this.mnuFileTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileClose,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFileTop.Name = "mnuFileTop";
            this.mnuFileTop.Size = new System.Drawing.Size(37, 20);
            this.mnuFileTop.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(192, 22);
            this.mnuFileNew.Text = "&New Excavation List";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(192, 22);
            this.mnuFileOpen.Text = "&Open Excavation List...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(192, 22);
            this.mnuFileSave.Text = "&Save Excavation List";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(192, 22);
            this.mnuFileSaveAs.Text = "Save &As...";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(192, 22);
            this.mnuFileClose.Text = "&Close Excavation List";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(192, 22);
            this.mnuFileExit.Text = "E&xit Dig Brother";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEditTop
            // 
            this.mnuEditTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAdd,
            this.mnuEditEdit,
            this.mnuEditDelete,
            this.toolStripSeparator2,
            this.mnuEditNext,
            this.mnuEditPrev});
            this.mnuEditTop.Name = "mnuEditTop";
            this.mnuEditTop.Size = new System.Drawing.Size(39, 20);
            this.mnuEditTop.Text = "&Edit";
            // 
            // mnuEditAdd
            // 
            this.mnuEditAdd.Name = "mnuEditAdd";
            this.mnuEditAdd.Size = new System.Drawing.Size(209, 22);
            this.mnuEditAdd.Text = "&Add Excavation";
            this.mnuEditAdd.Click += new System.EventHandler(this.mnuEditAdd_Click);
            // 
            // mnuEditEdit
            // 
            this.mnuEditEdit.Name = "mnuEditEdit";
            this.mnuEditEdit.Size = new System.Drawing.Size(209, 22);
            this.mnuEditEdit.Text = "&Edit Current Excavation";
            this.mnuEditEdit.Click += new System.EventHandler(this.mnuEditEdit_Click);
            // 
            // mnuEditDelete
            // 
            this.mnuEditDelete.Name = "mnuEditDelete";
            this.mnuEditDelete.Size = new System.Drawing.Size(209, 22);
            this.mnuEditDelete.Text = "&Delete Current Excavation";
            this.mnuEditDelete.Click += new System.EventHandler(this.mnuEditDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuEditNext
            // 
            this.mnuEditNext.Name = "mnuEditNext";
            this.mnuEditNext.Size = new System.Drawing.Size(209, 22);
            this.mnuEditNext.Text = "Show &Next Excavation";
            this.mnuEditNext.Click += new System.EventHandler(this.mnuEditNext_Click);
            // 
            // mnuEditPrev
            // 
            this.mnuEditPrev.Name = "mnuEditPrev";
            this.mnuEditPrev.Size = new System.Drawing.Size(209, 22);
            this.mnuEditPrev.Text = "Show &Last Excavation";
            this.mnuEditPrev.Click += new System.EventHandler(this.mnuEditPrev_Click);
            // 
            // mnuHelpTop
            // 
            this.mnuHelpTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelpTop.Name = "mnuHelpTop";
            this.mnuHelpTop.Size = new System.Drawing.Size(44, 20);
            this.mnuHelpTop.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(179, 22);
            this.mnuHelpAbout.Text = "&About Dig Brother...";
            // 
            // cdlgOpen
            // 
            this.cdlgOpen.FileName = "Open Excavations";
            // 
            // lbxExcavations
            // 
            this.lbxExcavations.FormattingEnabled = true;
            this.lbxExcavations.Location = new System.Drawing.Point(12, 55);
            this.lbxExcavations.Name = "lbxExcavations";
            this.lbxExcavations.Size = new System.Drawing.Size(192, 95);
            this.lbxExcavations.TabIndex = 1;
            // 
            // lblExcavationList
            // 
            this.lblExcavationList.AutoSize = true;
            this.lblExcavationList.Location = new System.Drawing.Point(12, 39);
            this.lblExcavationList.Name = "lblExcavationList";
            this.lblExcavationList.Size = new System.Drawing.Size(99, 13);
            this.lblExcavationList.TabIndex = 2;
            this.lblExcavationList.Text = "Current Exavations:";
            // 
            // gbxExcavDetails
            // 
            this.gbxExcavDetails.Controls.Add(this.panel1);
            this.gbxExcavDetails.Controls.Add(this.pnlVolunteers);
            this.gbxExcavDetails.Controls.Add(this.pnlFinds);
            this.gbxExcavDetails.Controls.Add(this.lblSiteAccess);
            this.gbxExcavDetails.Controls.Add(this.rdbRural);
            this.gbxExcavDetails.Controls.Add(this.rdbUrban);
            this.gbxExcavDetails.Controls.Add(this.lblSiteNotes);
            this.gbxExcavDetails.Controls.Add(this.lblSiteAge);
            this.gbxExcavDetails.Controls.Add(this.lblExDate);
            this.gbxExcavDetails.Controls.Add(this.lblSiteName);
            this.gbxExcavDetails.Controls.Add(this.cboSiteAge);
            this.gbxExcavDetails.Controls.Add(this.txtSiteNotes);
            this.gbxExcavDetails.Controls.Add(this.txtExcavDate);
            this.gbxExcavDetails.Controls.Add(this.txtSiteName);
            this.gbxExcavDetails.Location = new System.Drawing.Point(221, 39);
            this.gbxExcavDetails.Name = "gbxExcavDetails";
            this.gbxExcavDetails.Size = new System.Drawing.Size(358, 497);
            this.gbxExcavDetails.TabIndex = 3;
            this.gbxExcavDetails.TabStop = false;
            this.gbxExcavDetails.Text = "Excavation Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.lbxEquipment);
            this.panel1.Controls.Add(this.lblEquipment);
            this.panel1.Controls.Add(this.btnAddEquip);
            this.panel1.Controls.Add(this.btnRemoveEquip);
            this.panel1.Location = new System.Drawing.Point(13, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 120);
            this.panel1.TabIndex = 22;
            // 
            // lbxEquipment
            // 
            this.lbxEquipment.FormattingEnabled = true;
            this.lbxEquipment.Location = new System.Drawing.Point(15, 28);
            this.lbxEquipment.Name = "lbxEquipment";
            this.lbxEquipment.Size = new System.Drawing.Size(198, 82);
            this.lbxEquipment.TabIndex = 15;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(13, 11);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(106, 13);
            this.lblEquipment.TabIndex = 16;
            this.lblEquipment.Text = "Equipment Available:";
            // 
            // btnAddEquip
            // 
            this.btnAddEquip.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddEquip.Location = new System.Drawing.Point(227, 49);
            this.btnAddEquip.Name = "btnAddEquip";
            this.btnAddEquip.Size = new System.Drawing.Size(91, 23);
            this.btnAddEquip.TabIndex = 17;
            this.btnAddEquip.Text = "Add...";
            this.btnAddEquip.UseVisualStyleBackColor = false;
            this.btnAddEquip.Click += new System.EventHandler(this.btnAddEquip_Click);
            // 
            // btnRemoveEquip
            // 
            this.btnRemoveEquip.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveEquip.Location = new System.Drawing.Point(227, 85);
            this.btnRemoveEquip.Name = "btnRemoveEquip";
            this.btnRemoveEquip.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveEquip.TabIndex = 18;
            this.btnRemoveEquip.Text = "Remove";
            this.btnRemoveEquip.UseVisualStyleBackColor = false;
            this.btnRemoveEquip.Click += new System.EventHandler(this.btnRemoveEquip_Click);
            // 
            // pnlVolunteers
            // 
            this.pnlVolunteers.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlVolunteers.Controls.Add(this.lbxVolunteers);
            this.pnlVolunteers.Controls.Add(this.lblVolunteerList);
            this.pnlVolunteers.Controls.Add(this.btnAddVolunteer);
            this.pnlVolunteers.Controls.Add(this.btnRemoveVolunteer);
            this.pnlVolunteers.Location = new System.Drawing.Point(13, 168);
            this.pnlVolunteers.Name = "pnlVolunteers";
            this.pnlVolunteers.Size = new System.Drawing.Size(329, 120);
            this.pnlVolunteers.TabIndex = 21;
            // 
            // lbxVolunteers
            // 
            this.lbxVolunteers.FormattingEnabled = true;
            this.lbxVolunteers.Location = new System.Drawing.Point(15, 28);
            this.lbxVolunteers.Name = "lbxVolunteers";
            this.lbxVolunteers.Size = new System.Drawing.Size(198, 82);
            this.lbxVolunteers.TabIndex = 9;
            // 
            // lblVolunteerList
            // 
            this.lblVolunteerList.AutoSize = true;
            this.lblVolunteerList.Location = new System.Drawing.Point(12, 9);
            this.lblVolunteerList.Name = "lblVolunteerList";
            this.lblVolunteerList.Size = new System.Drawing.Size(97, 13);
            this.lblVolunteerList.TabIndex = 10;
            this.lblVolunteerList.Text = "Current Volunteers:";
            // 
            // btnAddVolunteer
            // 
            this.btnAddVolunteer.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddVolunteer.Location = new System.Drawing.Point(227, 51);
            this.btnAddVolunteer.Name = "btnAddVolunteer";
            this.btnAddVolunteer.Size = new System.Drawing.Size(91, 23);
            this.btnAddVolunteer.TabIndex = 11;
            this.btnAddVolunteer.Text = "Add...";
            this.btnAddVolunteer.UseVisualStyleBackColor = false;
            this.btnAddVolunteer.Click += new System.EventHandler(this.btnAddVolunteer_Click);
            // 
            // btnRemoveVolunteer
            // 
            this.btnRemoveVolunteer.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveVolunteer.Location = new System.Drawing.Point(227, 89);
            this.btnRemoveVolunteer.Name = "btnRemoveVolunteer";
            this.btnRemoveVolunteer.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveVolunteer.TabIndex = 12;
            this.btnRemoveVolunteer.Text = "Remove";
            this.btnRemoveVolunteer.UseVisualStyleBackColor = false;
            this.btnRemoveVolunteer.Click += new System.EventHandler(this.btnRemoveVolunteer_Click);
            // 
            // pnlFinds
            // 
            this.pnlFinds.BackColor = System.Drawing.Color.LightGreen;
            this.pnlFinds.Controls.Add(this.lblTotalFinds);
            this.pnlFinds.Controls.Add(this.chkFindsRecorded);
            this.pnlFinds.Controls.Add(this.btnViewFinds);
            this.pnlFinds.Location = new System.Drawing.Point(13, 120);
            this.pnlFinds.Name = "pnlFinds";
            this.pnlFinds.Size = new System.Drawing.Size(329, 47);
            this.pnlFinds.TabIndex = 20;
            // 
            // lblTotalFinds
            // 
            this.lblTotalFinds.Location = new System.Drawing.Point(121, 13);
            this.lblTotalFinds.Name = "lblTotalFinds";
            this.lblTotalFinds.Size = new System.Drawing.Size(100, 23);
            this.lblTotalFinds.TabIndex = 6;
            this.lblTotalFinds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkFindsRecorded
            // 
            this.chkFindsRecorded.AutoSize = true;
            this.chkFindsRecorded.Location = new System.Drawing.Point(15, 17);
            this.chkFindsRecorded.Name = "chkFindsRecorded";
            this.chkFindsRecorded.Size = new System.Drawing.Size(107, 17);
            this.chkFindsRecorded.TabIndex = 5;
            this.chkFindsRecorded.Text = "Finds Recorded?";
            this.chkFindsRecorded.UseVisualStyleBackColor = true;
            // 
            // btnViewFinds
            // 
            this.btnViewFinds.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewFinds.Location = new System.Drawing.Point(227, 13);
            this.btnViewFinds.Name = "btnViewFinds";
            this.btnViewFinds.Size = new System.Drawing.Size(91, 23);
            this.btnViewFinds.TabIndex = 4;
            this.btnViewFinds.Text = "View Finds...";
            this.btnViewFinds.UseVisualStyleBackColor = false;
            this.btnViewFinds.Click += new System.EventHandler(this.btnViewFinds_Click);
            // 
            // lblSiteAccess
            // 
            this.lblSiteAccess.AutoSize = true;
            this.lblSiteAccess.Location = new System.Drawing.Point(274, 56);
            this.lblSiteAccess.Name = "lblSiteAccess";
            this.lblSiteAccess.Size = new System.Drawing.Size(66, 13);
            this.lblSiteAccess.TabIndex = 19;
            this.lblSiteAccess.Text = "Site Access:";
            // 
            // rdbRural
            // 
            this.rdbRural.AutoSize = true;
            this.rdbRural.Location = new System.Drawing.Point(277, 95);
            this.rdbRural.Name = "rdbRural";
            this.rdbRural.Size = new System.Drawing.Size(50, 17);
            this.rdbRural.TabIndex = 14;
            this.rdbRural.Text = "Rural";
            this.rdbRural.UseVisualStyleBackColor = true;
            // 
            // rdbUrban
            // 
            this.rdbUrban.AutoSize = true;
            this.rdbUrban.Checked = true;
            this.rdbUrban.Location = new System.Drawing.Point(277, 75);
            this.rdbUrban.Name = "rdbUrban";
            this.rdbUrban.Size = new System.Drawing.Size(54, 17);
            this.rdbUrban.TabIndex = 13;
            this.rdbUrban.TabStop = true;
            this.rdbUrban.Text = "Urban";
            this.rdbUrban.UseVisualStyleBackColor = true;
            // 
            // lblSiteNotes
            // 
            this.lblSiteNotes.AutoSize = true;
            this.lblSiteNotes.Location = new System.Drawing.Point(10, 416);
            this.lblSiteNotes.Name = "lblSiteNotes";
            this.lblSiteNotes.Size = new System.Drawing.Size(59, 13);
            this.lblSiteNotes.TabIndex = 8;
            this.lblSiteNotes.Text = "Site Notes:";
            // 
            // lblSiteAge
            // 
            this.lblSiteAge.AutoSize = true;
            this.lblSiteAge.Location = new System.Drawing.Point(10, 97);
            this.lblSiteAge.Name = "lblSiteAge";
            this.lblSiteAge.Size = new System.Drawing.Size(50, 13);
            this.lblSiteAge.TabIndex = 7;
            this.lblSiteAge.Text = "Site Age:";
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Location = new System.Drawing.Point(10, 56);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(89, 13);
            this.lblExDate.TabIndex = 6;
            this.lblExDate.Text = "Excavation Date:";
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(10, 26);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(59, 13);
            this.lblSiteName.TabIndex = 5;
            this.lblSiteName.Text = "Site Name:";
            // 
            // cboSiteAge
            // 
            this.cboSiteAge.FormattingEnabled = true;
            this.cboSiteAge.Items.AddRange(new object[] {
            "Undetermined",
            "Mesolithic",
            "Neolithic",
            "Bronze Age",
            "Iron Age",
            "Roman",
            "Dark Ages",
            "Anglo-Saxon",
            "Norman",
            "Medieval",
            "Tudor",
            "Stuart",
            "Georgian",
            "Victorian",
            "World War 1",
            "World War 2",
            "Post-War",
            "Modern"});
            this.cboSiteAge.Location = new System.Drawing.Point(75, 90);
            this.cboSiteAge.Name = "cboSiteAge";
            this.cboSiteAge.Size = new System.Drawing.Size(179, 21);
            this.cboSiteAge.TabIndex = 3;
            // 
            // txtSiteNotes
            // 
            this.txtSiteNotes.Location = new System.Drawing.Point(13, 432);
            this.txtSiteNotes.Multiline = true;
            this.txtSiteNotes.Name = "txtSiteNotes";
            this.txtSiteNotes.Size = new System.Drawing.Size(329, 57);
            this.txtSiteNotes.TabIndex = 2;
            // 
            // txtExcavDate
            // 
            this.txtExcavDate.Location = new System.Drawing.Point(105, 53);
            this.txtExcavDate.Name = "txtExcavDate";
            this.txtExcavDate.Size = new System.Drawing.Size(149, 20);
            this.txtExcavDate.TabIndex = 1;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(75, 19);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(267, 20);
            this.txtSiteName.TabIndex = 0;
            // 
            // gbxTools
            // 
            this.gbxTools.Controls.Add(this.btnForwardEx);
            this.gbxTools.Controls.Add(this.btnBackEx);
            this.gbxTools.Controls.Add(this.btnDeleteEx);
            this.gbxTools.Controls.Add(this.btnEditEx);
            this.gbxTools.Controls.Add(this.btnCancel);
            this.gbxTools.Controls.Add(this.btnOK);
            this.gbxTools.Controls.Add(this.btnAddEx);
            this.gbxTools.Location = new System.Drawing.Point(12, 161);
            this.gbxTools.Name = "gbxTools";
            this.gbxTools.Size = new System.Drawing.Size(200, 314);
            this.gbxTools.TabIndex = 4;
            this.gbxTools.TabStop = false;
            this.gbxTools.Text = "Excavation Tools";
            // 
            // btnForwardEx
            // 
            this.btnForwardEx.Location = new System.Drawing.Point(117, 31);
            this.btnForwardEx.Name = "btnForwardEx";
            this.btnForwardEx.Size = new System.Drawing.Size(75, 23);
            this.btnForwardEx.TabIndex = 6;
            this.btnForwardEx.Text = "Forward";
            this.btnForwardEx.UseVisualStyleBackColor = true;
            this.btnForwardEx.Click += new System.EventHandler(this.btnForwardEx_Click);
            // 
            // btnBackEx
            // 
            this.btnBackEx.Location = new System.Drawing.Point(14, 31);
            this.btnBackEx.Name = "btnBackEx";
            this.btnBackEx.Size = new System.Drawing.Size(75, 23);
            this.btnBackEx.TabIndex = 5;
            this.btnBackEx.Text = "Back";
            this.btnBackEx.UseVisualStyleBackColor = true;
            this.btnBackEx.Click += new System.EventHandler(this.btnBackEx_Click);
            // 
            // btnDeleteEx
            // 
            this.btnDeleteEx.Location = new System.Drawing.Point(14, 192);
            this.btnDeleteEx.Name = "btnDeleteEx";
            this.btnDeleteEx.Size = new System.Drawing.Size(178, 23);
            this.btnDeleteEx.TabIndex = 4;
            this.btnDeleteEx.Text = "Delete This Excavation";
            this.btnDeleteEx.UseVisualStyleBackColor = true;
            this.btnDeleteEx.Click += new System.EventHandler(this.btnDeleteEx_Click);
            // 
            // btnEditEx
            // 
            this.btnEditEx.Location = new System.Drawing.Point(14, 150);
            this.btnEditEx.Name = "btnEditEx";
            this.btnEditEx.Size = new System.Drawing.Size(178, 23);
            this.btnEditEx.TabIndex = 3;
            this.btnEditEx.Text = "Edit This Excavation";
            this.btnEditEx.UseVisualStyleBackColor = true;
            this.btnEditEx.Click += new System.EventHandler(this.btnEditEx_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(117, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(14, 272);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAddEx
            // 
            this.btnAddEx.Location = new System.Drawing.Point(14, 110);
            this.btnAddEx.Name = "btnAddEx";
            this.btnAddEx.Size = new System.Drawing.Size(178, 23);
            this.btnAddEx.TabIndex = 0;
            this.btnAddEx.Text = "Add New Excavation";
            this.btnAddEx.UseVisualStyleBackColor = true;
            this.btnAddEx.Click += new System.EventHandler(this.btnAddEx_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(75, 505);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmExcavations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 545);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxTools);
            this.Controls.Add(this.gbxExcavDetails);
            this.Controls.Add(this.lblExcavationList);
            this.Controls.Add(this.lbxExcavations);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmExcavations";
            this.Text = "Dig Brother - Excavations";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.gbxExcavDetails.ResumeLayout(false);
            this.gbxExcavDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVolunteers.ResumeLayout(false);
            this.pnlVolunteers.PerformLayout();
            this.pnlFinds.ResumeLayout(false);
            this.pnlFinds.PerformLayout();
            this.gbxTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.OpenFileDialog cdlgOpen;
        private System.Windows.Forms.SaveFileDialog cdlgSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTop;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpTop;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ListBox lbxExcavations;
        private System.Windows.Forms.Label lblExcavationList;
        private System.Windows.Forms.GroupBox gbxExcavDetails;
        private System.Windows.Forms.GroupBox gbxTools;
        private System.Windows.Forms.Button btnAddEx;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteEx;
        private System.Windows.Forms.Button btnEditEx;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtExcavDate;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.RadioButton rdbRural;
        private System.Windows.Forms.RadioButton rdbUrban;
        private System.Windows.Forms.Button btnRemoveVolunteer;
        private System.Windows.Forms.Button btnAddVolunteer;
        private System.Windows.Forms.Label lblVolunteerList;
        private System.Windows.Forms.ListBox lbxVolunteers;
        private System.Windows.Forms.Label lblSiteNotes;
        private System.Windows.Forms.Label lblSiteAge;
        private System.Windows.Forms.Label lblExDate;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Button btnViewFinds;
        private System.Windows.Forms.ComboBox cboSiteAge;
        private System.Windows.Forms.TextBox txtSiteNotes;
        private System.Windows.Forms.Button btnRemoveEquip;
        private System.Windows.Forms.Button btnAddEquip;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ListBox lbxEquipment;
        private System.Windows.Forms.Label lblSiteAccess;
        private System.Windows.Forms.Panel pnlFinds;
        private System.Windows.Forms.CheckBox chkFindsRecorded;
        private System.Windows.Forms.Panel pnlVolunteers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditNext;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPrev;
        private System.Windows.Forms.Button btnForwardEx;
        private System.Windows.Forms.Button btnBackEx;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.Label lblTotalFinds;
    }
}

