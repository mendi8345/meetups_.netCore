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

		public Meetup[] Get()
		{
			Meetup[] meetups = Model.getAllMeetups();
			return meetups;
		}
	}
}
