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

		[HttpPost]
		public IActionResult Create([FromBody] Club item)
		{
			if (item == null)
			{
				return BadRequest();
			}

			_context.Clubs.Add(item);
			_context.SaveChanges();

			return CreatedAtRoute("GetClub", new { id = item.Id }, item);
		}

		[HttpPut("{id}")]
		public IActionResult Update(long id, [FromBody] Club item)
		{
			if (item == null || item.Id != id)
			{
				return BadRequest();
			}

			var club = _context.Clubs.FirstOrDefault(t => t.Id == id);
			if (club == null)
			{
				return NotFound();
			}


			club.ClubName = item.ClubName;

			_context.Clubs.Update(club);
			_context.SaveChanges();
			return new NoContentResult();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			var club = _context.Clubs.First(t => t.Id == id);
			if (club == null)
			{
				return NotFound();
			}

			_context.Clubs.Remove(club);
			_context.SaveChanges();
			return new NoContentResult();
		}


	}
}
