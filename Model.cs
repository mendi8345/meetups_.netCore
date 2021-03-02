using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace meetupProj.net
{
	public class Model
	{

		 static Model() {
			seedDb();
		}
		public static Meetup[] Meetups;
		public static Person[] People;

		
		public static void seedDb()
		{
			
			People = new Person[] {
		new Person(1,"מנדי כהן","mend@8345@gmail.com","0532530265",@"https://meetups-images.s3-eu-west-1.amazonaws.com/Image+3-1%402x.png"),
		new Person(2 ,"ישראל ישראלי","mend@8345@gmail.com","0532530265",@"https://meetups-images.s3-eu-west-1.amazonaws.com/Image+4-1%402x.png"),
		new Person(3 ,"חיה שחר","mend@8345@gmail.com","0532530265",@"https://meetups-images.s3-eu-west-1.amazonaws.com/Image+3-1%402x.png"),
		new Person(4 ,"יעל דבש","mend@8345@gmail.com","0532530265",@"https://meetups-images.s3-eu-west-1.amazonaws.com/Image+4-1%402x.png"),
		new Person(5 ,"אלכסה מזרחי","mend@8345@gmail.com","0532530265",@"https://meetups-images.s3-eu-west-1.amazonaws.com/Image+1%402x.png"),
		};

			Meetups = new Meetup[] {
				new Meetup(1, new DateTime(2021,12,10,16,45,0), "ירושלים", "Aws metting about EC2,Rds,S3", People),
				new Meetup(2,new DateTime(2021,11,11,16,45,0), "תל אביב", "הרצאה בנושא תכנות באנגולר  ", People),
				new Meetup(3, new DateTime(2021,12,12,16,45,0), "טבריה", "הרצאה מרתקת בנושאים מרתקים", People),
				new Meetup(4, new DateTime(2021,10,13,16,45,0), "רמת גן", "Aws metting about EC2,Rds,S3", People),
				new Meetup(5, new DateTime(2021,11,14,16,45,0), "חיפה", "Aws metting about EC2,Rds,S3", People),
				new Meetup(6, new DateTime(2021,12,15,16,45,0), "ירושלים", "הרצאה בנושא תכנות באנגולר  ", People),
				new Meetup(7, new DateTime(2021,12,16,16,45,0), "ירושלים", "הרצאה מרתקת בנושאים מרתקים", People),
				new Meetup(8, new DateTime(2021,12,17,16,45,0), "ירושלים", "Aws metting about EC2,Rds,S3", People),
					new Meetup(9, new DateTime(2021,11,18,16,45,0), "ירושלים", "Aws metting about EC2,Rds,S3", People),
			//	new Meetup(10, "2021-03-29", "ירושלים", "הרצאה בנושא תכנות באנגולר  ", People),
			//	new Meetup(3, "2021-03-29", "ירושלים", "הרצאה מרתקת בנושאים מרתקים", People),
			//	new Meetup(4, "2021-03-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
			//	new Meetup(5, "2021-03-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
			//	new Meetup(6, "2021-03-29", "ירושלים", "הרצאה בנושא תכנות באנגולר  ", People),
			//	new Meetup(7, "2021-03-29", "ירושלים", "הרצאה מרתקת בנושאים מרתקים", People),
			//	new Meetup(8, "2021-03-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
			};
		}
		public static Meetup[] getAllMeetups()
		{
			return Meetups;

		}
		public static Meetup[] getMeetupsBetween(string from, string to)
		{
			List<Meetup> filterdMeetups=new List<Meetup> ()	;

			DateTime startDate = DateTime.ParseExact(from, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			DateTime endDate = DateTime.ParseExact(to, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			foreach (var m in Meetups)
			{
				if (m.Date>startDate && m.Date<endDate)
				{
					filterdMeetups.Add(m);
					System.Diagnostics.Debug.WriteLine(filterdMeetups.ToString());

				}
			}

			return filterdMeetups.ToArray();

		}
	}
}
