using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    public partial class frmMain : Form
    {
        private ArrayList arrBooks;
        private int nCurrentBook;
        private CBook firstBook, currBook;


        public frmMain()
        {
            InitializeComponent();
            arrBooks = new ArrayList();
            nCurrentBook = 0;
            LoadBookList();
        }

        public void LoadBookList()
        {
            // a book using the default constructor
            firstBook = new CBook();
            firstBook.Title = "The Lord of the Rings";
            firstBook.Author = "JRR Tolkien";
            firstBook.Publisher = "Penguin";
            firstBook.PublishDate = 1935;
            arrBooks.Add(firstBook);
            //a book using the custom one-step constructor
            currBook = new CBook("Sharpe's Rifles", "Bernard Cornwell", "Harper Collins", 1987);
            arrBooks.Add(currBook);
            //a book using the copy constructor – you’ll have two books the same
            currBook = new CBook(firstBook);
            arrBooks.Add(currBook);

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveNext();
        }
        private void MoveNext()
        {
            if (nCurrentBook < arrBooks.Count)
            { nCurrentBook++; }
            UpdateDisplay();
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            MoveBack();
        }
        private void MoveBack()
        {
            if (nCurrentBook > 0)
            { nCurrentBook--; }
            UpdateDisplay();
        }




        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        public void ShowAll()
        {
            nCurrentBook = arrBooks.Count;
            UpdateDisplay();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            lbxOutput.Items.Clear();
            nCurrentBook = 0;
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            Additems();
        }

        private void Additems()
        {
            firstBook = new CBook();
            firstBook.Title = txtTitle.Text;
            firstBook.Author = txtAuthor.Text; 
            firstBook.Publisher = txtPublisher.Text;
            firstBook.PublishDate = Int32.Parse(txtPublished.Text);
            arrBooks.Add(firstBook);
            ShowAll();

            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtPublished.Text = "";
        }




        private void mnuDisplayNext_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void mnuTopDisplay_Click(object sender, EventArgs e)
        {
            if (nCurrentBook >= arrBooks.Count)
            {
                mnuDisplayNext.Enabled = false;
                mnuDisplayAll.Enabled = false;
            }
            else
            {
                mnuDisplayNext.Enabled = true;
                mnuDisplayAll.Enabled = true;
            }

            if (nCurrentBook <= arrBooks.Count)
            {
                mnuDisplayBack.Enabled = false;
                mnuDisplayAll.Enabled = false;
            }
            else
            {
                mnuDisplayBack.Enabled = true;
                mnuDisplayAll.Enabled = true;
            }

        }





        private void mnuDisplayExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        public void UpdateDisplay()
        {
            lbxOutput.Items.Clear();
            string strOutput;
            for (int i = 0; i < nCurrentBook; i++)
            {
                currBook = (CBook)arrBooks[i];
                strOutput = currBook.Title + ", " + currBook.Author + " published by " + currBook.Publisher + " in " + currBook.PublishDate.ToString();
                lbxOutput.Items.Add(strOutput);
            }
        }
    }
}
