using System;

namespace BookShelf
{
	public class CBook : System.Object
	{
		private string strTitle;
		private string strAuthor;
		private string strPublisher;
		private int nPublishDate;
		public CBook()
		{
			strTitle = "nothing";
			strAuthor = "no one";
			strPublisher = "empty";
			nPublishDate = 1900;
		}
		public CBook(string title, string author, string publisher, int pubDate) //custom constructor
		{
			strTitle = title;
			strAuthor = author;
			strPublisher = publisher;
			nPublishDate = pubDate;
		}
		public CBook(CBook book) //copy constructor
		{
			strTitle = book.Title;
            strAuthor = book.Author;
            strPublisher = book.Publisher;
			nPublishDate = book.PublishDate;
		}
		public string Title //Code to control the Title Property
		{
            get{return strTitle;}
            set{strTitle = value;}
		}
        public string Author
        {
            get { return strAuthor; }
            set { strAuthor = value; }
        }
        public string Publisher
        {
            get { return strPublisher; }
            set { strPublisher = value; }
        }
		public int PublishDate
		{
            get{return nPublishDate;}
            set{nPublishDate = value;}
		}
	}
}
