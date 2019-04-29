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
    public class ProjectsController : ControllerBase
    {
        private readonly EntityContext _context;
        private IProjectRepository _projectRepository;

        public ProjectsController(EntityContext context, IProjectRepository projectRepository)
        {
            _context = context;
            _projectRepository = projectRepository;
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProjectsDTO> Get(int id)
        {
            return Ok(_projectRepository.getProject(id));
        }

        [HttpGet("samplesForUser/{id}")]
        public ActionResult<String> samplesForUser(int id)
        {
            return Ok(_projectRepository.samplesForUser(id).Distinct()); //Only unique values
        }

        [HttpGet("getSample/{id}")]
        public ActionResult<Samples> getSample(int id)
        {
            return Ok(_projectRepository.getSample(id)); //Only unique values
        }

        [HttpGet("getStepSeqForUser/{id}")]
        public ActionResult<StepSequencer> getStepSeqForUser(int id)
        {
            return Ok(_projectRepository.getStepSeq(id)); //Only unique values
        }

        [HttpPut("updateSample/{id}")]
        public void getSample([FromBody] Samples sample)
        {
            _projectRepository.updateSample(sample); //Only unique values
        }

        [HttpPut("updateStepSeq/{id}")]
        public void updateStepSeq([FromBody] StepSequencer stepSeq)
        {
            _projectRepository.updateStepSeqForUser(stepSeq); //Only unique values
        }

        [HttpGet()]
        public ActionResult<ProjectsDTO> GetAll()
        {
            return Ok(_projectRepository.listAllProjects());
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] ProjectsDTO value)
        {
            _projectRepository.insertProject(value);

        }

        [HttpPut]
        public void Put([FromBody] ProjectsDTO value)
        {
            _projectRepository.updateProject(value);

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

