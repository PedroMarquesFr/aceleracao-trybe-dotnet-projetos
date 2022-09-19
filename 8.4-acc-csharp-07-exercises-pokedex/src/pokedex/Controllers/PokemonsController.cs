using pokedex.Models;
using pokedex.Services;
using pokedex.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly IPokemonService Service;
        public PokemonsController(IPokemonService service)
        {
            Service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PokemonCatched>> Get()
        {
            var output = Service.GetAllItems();
            return Ok(output);
        }

        [HttpGet("{id}")]
        public ActionResult<PokemonCatched> GetById(int id)
        {

            var output = Service.GetById(id);
            if (output == null)
            {
                return NotFound("Customer not found");
            }
            return Ok(output);

        }

        [HttpPost]
        public ActionResult Post([FromBody] PokemonCatched request)
        {
            if (request.Id == null) return BadRequest();
            var result = Service.Add(request);
            return Ok(result);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PokemonCatched request)
        {
            bool result = Service.Put(id, request);
            if (!result) return NotFound();
            return Ok();
        }



        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var wasDeleted = Service.Remove(id);
            if (!wasDeleted) return NotFound();
            return NoContent();
        }
    }
}