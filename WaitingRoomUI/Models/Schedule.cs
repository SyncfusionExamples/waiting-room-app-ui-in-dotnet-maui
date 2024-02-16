using System;


namespace WaitingRoomUI.Models
{
	public class Schedule
	{
		private string picture;
		private string minutes;
		private string description;
		private string time;
		private bool playBasket;
		private bool readArticle;

		public string Picture
		{
			get { return picture; }
			set { picture = value; }
		}

		public string Minutes
		{
			get { return minutes; }
			set { minutes = value; }
		}

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public string Time
		{
			get { return time; }
			set { time = value; }
		}

		public bool PlayBasket
		{
			get { return playBasket; }
			set { playBasket = value; }
		}

		public bool ReadArticle
		{
			get { return readArticle; }
			set { readArticle = value;  }
		}

    }
}

