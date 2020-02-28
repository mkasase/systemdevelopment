using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DigBrotherCentral
{
    public partial class frmAddItem : Form
    {
        private ArrayList arrItems;
        private bool bVolunteer;
        private ArrayList arrEquipment;
        private ArrayList arrVolunteers;
        private ArrayList arrResults;

        public frmAddItem()
        {
            InitializeComponent();
            arrItems = new ArrayList();
            bVolunteer = true;
            arrEquipment = new ArrayList();
            arrEquipment.Add(new CEquipment("Trowel",10));
            arrEquipment.Add(new CEquipment("Theodolite",2));
            arrEquipment.Add(new CEquipment("Sorting Tables", 3));
            arrEquipment.Add(new CEquipment("Ground penetrating radar", 3));
            arrEquipment.Add(new CEquipment("Magnetometer", 1));
            arrEquipment.Add(new CEquipment("Trolley-mounted GPR", 1));
            arrEquipment.Add(new CEquipment("Hard hat", 15));
            arrVolunteers = new ArrayList();
            arrVolunteers.Add(new CVolunteer(111, "Adam Adamson", "Lancaster University"));
            arrVolunteers.Add(new CVolunteer(112, "Ben Benson", "Southampton University"));
            arrVolunteers.Add(new CVolunteer(113, "Carl Carlson", "UCL London"));
            arrVolunteers.Add(new CVolunteer(114, "Debbie Debson", "University of Portsmouth"));
            arrVolunteers.Add(new CVolunteer(115, "Eric Ericson", "Bristol University"));
            arrResults = new ArrayList();
        }

        public ArrayList SelectedItems
        {
            get 
            {
                arrResults.Clear();
                string strMatch = "";
                foreach (Object obj in lbxItems.SelectedItems)
                {
                    strMatch = obj.ToString();
                    if(bVolunteer)
                    {
                        foreach (Object obj2 in arrVolunteers)
                        {
                            CVolunteer vol = (CVolunteer)obj2;
                            if(strMatch.Equals(vol.DisplayData()))
                                arrResults.Add(obj2);
                        }
                    }
                    else
                    {
                        foreach (Object obj2 in arrEquipment)
                        {
                            CEquipment equ = (CEquipment)obj2;
                            if (strMatch.Equals(equ.DisplayData()))
                                arrResults.Add(obj2);
                        }
                    }
                }
                return arrResults; 
            }
        }
        public bool IsVolunteer
        {
            set 
            {
                bVolunteer = value;
                UpdateDisplay();
            }
        }
        private void UpdateDisplay()
        {
            lbxItems.Items.Clear();
            if (bVolunteer)
            {
                arrItems = arrVolunteers;
                this.Text = "Add Volunteers";
                lblUseInstruction.Text = "Select any volunteers from the list below. Use Ctrl to make multiple selections";
            }
            else
            {
                arrItems = arrEquipment;
                this.Text = "Add Equipment";
                lblUseInstruction.Text = "Select any items of equipment from the list below. Use Ctrl to make multiple selections";
            }
            foreach (Object obj in arrItems)
            {
                string strNext = "";
                if (bVolunteer)
                {
                    CVolunteer nextVol = (CVolunteer)obj;
                    strNext = nextVol.DisplayData();
                }
                else
                {
                    CEquipment nextEqu = (CEquipment)obj;
                    strNext = nextEqu.DisplayData();
                }
                lbxItems.Items.Add(strNext);
            }
        }
    }
}
