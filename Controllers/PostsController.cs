using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlameAPI.Model.Context;
using FlameAPI.Model.Entities;
using FlameAPI.Services.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly EntityContext _context;
        private IPostsReporitory _postsRepository;

        public PostsController(EntityContext context, IPostsReporitory postsRepository)
        {
            _context = context;
            _postsRepository = postsRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_postsRepository.getPostsForUser(1));

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_postsRepository.getPostsForUser(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Posts value) {
            _postsRepository.insertPost(value);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
