
/* 
 * This class has been provided purely to support the development
 * of the excavation class and its associated form - you ARE NOT expected to 
 * complete this class, or make any changes to it. If your version of 
 * the custom classes requires changes (to data types etc) you may change it
 * but don't spend lots of time doing so
*/

using System;

namespace DigBrotherCentral
{
    public class CEquipment : System.Object
    {
        private string strDescription;
        private int nCount;

        public CEquipment()
        {
            strDescription = "";
            nCount = 0;
        }
        public CEquipment(string description, int count)
        {
            strDescription = description;
            nCount = count;
        }
        public string Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }
        public int Count
        {
            get { return nCount; }
            set { nCount = value; }
        }
        public string DisplayData()
        {
            return strDescription + " {" + nCount.ToString() + ")";
        }
    }
}