using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RM17.Models;

namespace RM17.Controllers
{
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly TeamContext _context;

        public TeamController(TeamContext context)
        {
            _context = context;
        }

		[HttpGet]
		public IEnumerable<Team> GetAll()
		{
			return _context.Teams.ToList();
		}

		[HttpGet("{id}", Name = "GetTeam")]
		public IActionResult GetById(long id)
		{
			var item = _context.Teams.FirstOrDefault(t => t.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		[HttpPost]
		public IActionResult Create([FromBody] Team item)
		{
			if (item == null)
			{
				return BadRequest();
			}

			_context.Teams.Add(item);
			_context.SaveChanges();

			return CreatedAtRoute("GetTeam", new { id = item.Id }, item);
		}

		[HttpPut("{id}")]
		public IActionResult Update(long id, [FromBody] Team item)
		{
			if (item == null || item.Id != id)
			{
				return BadRequest();
			}

			var team = _context.Teams.FirstOrDefault(t => t.Id == id);
			if (team == null)
			{
				return NotFound();
			}

			team.teamName = item.teamName;

			_context.Teams.Update(team);
			_context.SaveChanges();
			return new NoContentResult();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			var team = _context.Teams.First(t => t.Id == id);
			if (team == null)
			{
				return NotFound();
			}

			_context.Teams.Remove(team);
			_context.SaveChanges();
			return new NoContentResult();
		}


	}
}
