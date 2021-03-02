using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace meetupProj.net.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MeetupController : ControllerBase
	{




		[HttpGet]
		[HttpGet("GetAll")]
		public Meetup[] GetAll()
		{
			Meetup[] meetups = Model.getAllMeetups();
			return meetups;
		}
		[HttpGet("GetMeetupsBetweenDates/{startDate}/{endDate}")]
		public Meetup[] GetMeetupsBetweenDates(string startDate,string endDate)
		{
			Console.WriteLine("wow");
			Meetup[] meetups = Model.getAllMeetups();
			return Model.getMeetupsBetween(startDate, endDate);
			//return Model.getAllMeetups();

		}
	}
}
