
/*
 * This class is INCOMPLETE: this version has been provided to allow
 * testing of the excavation form - if you make any changes to the implemented
 * parts of the class, you will need to make sure that you check frmExcavation
 * AND frmAddItem and refactor those classes accordingly
 */

using System;

namespace DigBrotherCentral
{
    [Serializable()]
    public class CVolunteer : System.Object
    {
        private int nVolID; //unique reference for this volunteer
        private string strName;
        private string strLocation; //where is this volunteer based?

        public CVolunteer() //default constructor
        {
            nVolID = -1; //default value
            strName = "not set";
            strLocation = "not set";
        }
        public CVolunteer(int volId, string name, string location)
        {
            nVolID = volId; //default value
            strName = name;
            strLocation = location;
        }

        public int VolunteerID
        {
            get { return nVolID; }
            set { nVolID = value; }
        }
        public string VolunteerName
        {
            get { return strName; }
            set { strName = value; }
        }
        public string Location
        {
            get { return strLocation; }
            set { strLocation = value; }
        }
        public string DisplayData()
        {
            return "("+nVolID.ToString()+") "+strName+"; "+strLocation;
        }
    }
}