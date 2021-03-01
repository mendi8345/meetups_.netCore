using System;
using System.Collections.Generic;
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
		new Person(1,"מנדי כהן","mend@8345@gmail.com","0532530265",@"C:\Users\USER\Desktop\visualStudio\angular\meetup-project\meetup-project\src\assets\Image 1-2@2x.png"),
		new Person(2 ,"ישראל ישראלי","mend@8345@gmail.com","0532530265",@"C:\Users\USER\Desktop\visualStudio\angular\meetup-project\meetup-project\src\assets\Image 1-2@2x.png"),
		new Person(3 ,"חיה שחר","mend@8345@gmail.com","0532530265",@"C:\Users\USER\Desktop\visualStudio\angular\meetup-project\meetup-project\src\assets\Image 1-2@2x.png"),
		new Person(4 ,"יעל דבש","mend@8345@gmail.com","0532530265",@"C:\Users\USER\Desktop\visualStudio\angular\meetup-project\meetup-project\src\assets\Image 1-2@2x.png"),
		new Person(5 ,"אלכסה מזרחי","mend@8345@gmail.com","0532530265",@"C:\Users\USER\Desktop\visualStudio\angular\meetup-project\meetup-project\src\assets\Image 1-2@2x.png"),
		};

			Meetups = new Meetup[] {
				new Meetup(1, "2021-03-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
				new Meetup(2, "2021-01-29", "תל אביב", "הרצאה בנושא תכנות באנגולר  ", People),
				new Meetup(3, "2021-02-29", "טבריה", "הרצאה מרתקת בנושאים מרתקים", People),
				new Meetup(4, "2021-04-29", "רמת גן", "Aws metting about EC2,Rds,S3", People),
				new Meetup(5, "2021-03-29", "חיפה", "Aws metting about EC2,Rds,S3", People),
				new Meetup(6, "2021-03-29", "ירושלים", "הרצאה בנושא תכנות באנגולר  ", People),
				new Meetup(7, "2021-04-29", "ירושלים", "הרצאה מרתקת בנושאים מרתקים", People),
				new Meetup(8, "2021-05-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
					new Meetup(9, "2021-03-29", "ירושלים", "Aws metting about EC2,Rds,S3", People),
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
	}
}
