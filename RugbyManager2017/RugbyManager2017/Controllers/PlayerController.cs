using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RugbyManager2017.Models;

namespace RugbyManager2017.Controllers
{
	[Route("api/[controller]")]
	public class PlayerController : Controller
	{
		private readonly PlayerContext _context;

		public PlayerController(PlayerContext context)
		{
			_context = context;

			if (_context.Players.Count() == 0)
			{
				_context.Players.Add(new Player { PlayerClassName = "Ken Owens" });
				_context.SaveChanges();
			}
		}

		[HttpGet]
		public IEnumerable<Player> GetAll()
		{
			return _context.Players.ToList();
		}

		[HttpGet("{id}", Name = "GetPlayer")]
		public IActionResult GetById(long id)
		{
			var item = _context.Players.FirstOrDefault(t => t.Id == id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		[HttpPost]
		public IActionResult Create([FromBody] Player item)
		{
			if (item == null)
			{
				return BadRequest();
			}

			_context.Players.Add(item);
			_context.SaveChanges();

			return CreatedAtRoute("GetPlayer", new { id = item.Id }, item);
		}

	}
}