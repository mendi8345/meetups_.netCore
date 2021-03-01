using System;

namespace meetupProj.net
{
	public class Meetup
	{
		public Meetup()
		{
		}

		public Meetup(int id, string date, string location, string description, Person[]subscribers)
		{
			Id = id;
			Date = date;
			Location = location;
			this.description = description;
			this.subscribers = subscribers;
		}

		public int Id { get; set; }
		public string Date { get; set; }
		public string Location { get; set; }
		public string description { get; set; }
		public Person[] subscribers { get; set; }
	}
}
