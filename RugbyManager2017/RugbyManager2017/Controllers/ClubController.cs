using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RugbyManager2017.Models;

namespace RugbyManager2017.Controllers
{
    [Route("api/[controller]")]
    public class ClubController : Controller
    {
        private readonly ClubContext _context;

        public ClubController(ClubContext context)
        {
            _context = context;
        }

		[HttpGet]
		public IEnumerable<Club> GetAll()
		{
			return _context.Clubs.ToList();
		}

		[HttpGet("{id}", Name = "GetClub")]
		public IActionResult GetById(long id)
		{
			var item = _context.Clubs.FirstOrDefault(t => t.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

    }
}
