using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DigBrotherCentral
{
    public enum eState { search, add, edit, delete, error}
    public enum eEra {undetermined, mesolithic, neolithic, bronze_age, iron_age, roman,
        dark_age, anglo_saxon, norman, medieval, tudor, stuart, georgian, victorian,
        world_war1, world_war2, post_war, modern, error}
    public enum eFind {china, pottery, glass, metal, wood, leather, other, error}

    public partial class frmExcavations : Form
    {
        private ArrayList arrExcavations; //to hold the current list of excavations
        private String strFileName; //the name of the currently open file
        private eState currState; //keeps track of the current task
        private DateTime dtExcavationDate; //provided to help with testing display/ custom classes

        public frmExcavations()
        {
            InitializeComponent();
            arrExcavations = new ArrayList();
            strFileName = "";
            currState = eState.search; //the default state
            dtExcavationDate = DateTime.Now;
            dtExcavationDate.AddDays(1);
            LoadExcavationList(strFileName);
            UpdateDisplay(); //a custom method to keep the interface up to date
        }



        private void LoadExcavationList(string fileName)
        {//use this to load the list of excavations to be held in arrExcavations
            //Stream read = File.Open(strFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //BinaryFormatter binF = new BinaryFormatter();
            //binF.Serialize(read, arrExcavations);
            //read.Close();
        }

        /*TIP*/
        //Start with Save, then tackle Load - this will allow you to avoid some of the
        //issues from BookShelf with naming conventions etc
        private void SaveExcavationList(string fileName)
        {//use this to save the list of excavations to be held in arrExcavations
            Stream write = File.Open(strFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter binF = new BinaryFormatter();
            binF.Serialize(write, arrExcavations);
            write.Close();
        }

        private void UpdateDisplay()
        {// use this method to update the display
            if (lbxExcavations.SelectedIndex == -1)
            {// if nothing is selected in the listbox OR the listbox is empty
                //provide code that will clear the display
            }

            if (currState == eState.search)
            {// this is the normal state - users should not be able to change the content
                //of anything in the excavation details groupbox
                //users shouldn't be able to use the OK and Cancel buttons in the Tools groupbox
            }
            else if (currState == eState.add)
            { }
            else if (currState == eState.edit)
            { }
            else if (currState == eState.delete)
            { }
            else
            {
                //the state must be error
                //use this to generate a warning error for yourself
                //to be used during development
            }
        }


        #region Incomplete Event Handlers

        private void btnAddVolunteer_Click(object sender, EventArgs e)
        {
            frmAddItem dlg = new frmAddItem();
            dlg.IsVolunteer = true; //use the dialog to add volunteers
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.SelectedItems.Count; i++)
                {
                    CVolunteer vol = (CVolunteer)dlg.SelectedItems[i];
                    if (!lbxVolunteers.Items.Contains(vol.DisplayData()))
                    {
                        lbxVolunteers.Items.Add(vol.DisplayData());
                    }
                }
            }
        }

        private void btnRemoveVolunteer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEquip_Click(object sender, EventArgs e)
        {
            frmAddItem dlg = new frmAddItem();
            dlg.IsVolunteer = false; //use the dialog to add equipment
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.SelectedItems.Count; i++)
                {
                    CEquipment Eqp = (CEquipment)dlg.SelectedItems[i];
                    if (!lbxEquipment.Items.Contains(Eqp.DisplayData()))
                    {
                        lbxEquipment.Items.Add(Eqp.DisplayData());
                    }
                }

            }
        }

        private void btnRemoveEquip_Click(object sender, EventArgs e)
        {
           
            frmAddItem dlg = new frmAddItem();
            dlg.IsVolunteer = false; //use the dialog to add equipment
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlg.SelectedItems.Count; i++)
                {
                    CEquipment Eqp = (CEquipment)dlg.SelectedItems[i];
                    if (!lbxEquipment.Items.Contains(Eqp.DisplayData()))
                    {
                        lbxEquipment.Items.Remove(Eqp.DisplayData());
                    }
                }

            }
        }

        #endregion


        #region Code supplied for operational reasons - do not edit

        private void btnViewFinds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Implementing this option is outside the scope of the SWS");
        }

        #endregion



        public void additems()
        {

            //arrExcavations.Add();
            txtSiteName.Text = "";
            txtExcavDate.Text = "";
            cboSiteAge.Text = "";

        }


        public void removeitems()
        {
            for (int i = 0; i < arrExcavations.Count; i++)
            {
                //lbxExcavations.Items.Remove();
            }
        }


        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            cdlgSave.ShowDialog();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            cdlgSave.ShowDialog();
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            lbxExcavations.Items.Clear(); // Empty the listbox 
        }

        private void mnuEditNext_Click(object sender, EventArgs e)
        {
            //Next in the listbox
            UpdateDisplay();
        }

        private void mnuEditPrev_Click(object sender, EventArgs e)
        {
            //previous to the next listbox
            UpdateDisplay();
        }

        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            additems();
        }

        private void mnuEditEdit_Click(object sender, EventArgs e)
        {
            //editItems();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void mnuEditDelete_Click(object sender, EventArgs e)
        {
            lbxExcavations.Items.Remove(0);
            UpdateDisplay();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes application
        }

        public void nextExcavation()
        {
            if  ( 0 < arrExcavations.Count)
            { }
            UpdateDisplay();
        }

        public void prevExcavation()
        {
            if (0 > arrExcavations.Count) {}
            UpdateDisplay();
        }








        private void btnBackEx_Click(object sender, EventArgs e)
        {

        }

        private void btnForwardEx_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEx_Click(object sender, EventArgs e)
        {
            additems();
        }

        private void btnEditEx_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEx_Click(object sender, EventArgs e)
        {
            lbxExcavations.Items.Remove(0);
            UpdateDisplay();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes application
        }

    }
}
