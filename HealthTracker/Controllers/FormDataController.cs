using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HealthTracker.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HealthTracker.Controllers
{
    [Route("api/[controller]")]
    public class FormDataController : Controller
    {
        private readonly FormDataContext _context;
        public FormDataController(FormDataContext context)
        {
            _context = context;
            if(_context.FormDatas.Count() ==0)
            {
                _context.FormDatas.Add(new FormData { Mood = "Happy" });
                _context.SaveChanges();
            }
        }

        //GET: ALL
        [Authorize]
        [HttpGet]
        public IEnumerable<FormData> GetAll()
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _context.FormDatas.ToList();
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var item = _context.FormDatas.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item); 
        }

        // POST api/values

        [HttpPost]
        public IActionResult Post([FromBody]FormData item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _context.FormDatas.Add(item);
            _context.SaveChanges();
            return CreatedAtRoute("GetById", new { id = item.Id }, item);
        }

        // PUT api/values/5


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]FormData item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }
            var formdata = _context.FormDatas.FirstOrDefault(t => t.Id == id);
            if (formdata == null)
            {
                return NotFound();
            }
            formdata.Mood = item.Mood;
            formdata.Breakfast = item.Breakfast;
            formdata.Lunch = item.Lunch;
            formdata.Dinner = item.Dinner;
            formdata.Snacks = item.Snacks;
            formdata.ExerciseBehaviors = item.ExerciseBehaviors;
            formdata.Drank = item.Drank;
            formdata.BehaviorActivity = item.BehaviorActivity;
            formdata.Sexed = item.Sexed;
            formdata.Smoked = item.Smoked;
            formdata.PostDate = item.PostDate;

            _context.FormDatas.Update(formdata);
            _context.SaveChanges();
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var formdata = _context.FormDatas.FirstOrDefault(t => t.Id == id);
            if (formdata == null)
            {
                return NotFound();
            }
            _context.FormDatas.Remove(formdata);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
