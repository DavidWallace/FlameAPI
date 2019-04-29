using System;
using System.Collections.Generic;
using System.Linq;
using FlameAPI.Model.Context;
using FlameAPI.Model.Entities;

namespace FlameAPI.Services.Repositories
{
    public class ProjectRepository : IProjectRepository
    {

        private static EntityContext _context;

        public ProjectRepository(EntityContext context)
        {
            _context = context;
        }

        public ProjectsDTO getProject(int projID)
        {
            ProjectsDTO projects = new ProjectsDTO();
            Projects prv = _context.Projects.Where(d => d.id == projID).SingleOrDefault();

            var entity = new Projects();
            projects.id = projID;
            projects.author = prv.author;
            projects.bpm = prv.bpm;
            projects.sampleRate = prv.sampleRate;
            projects.name = prv.name;
            projects.timestamp = DateTime.UtcNow.ToUniversalTime();

            //Must be instantiated
            projects.padPerformer = new List<Samples>();
            projects.padPerformer.AddRange(_context.Samples.Where(smp => smp.projID == projID).ToList());

            projects.stepSequencer = new List<StepSequencer>();
            projects.stepSequencer.AddRange(_context.StepSequencer.Where(smp => smp.projID == 37).ToList());

            return projects;
        }

        public IQueryable<Projects> listProjects(int userID)
        {

            return _context.Projects.Where(d => d.author == userID);
        }

        public IQueryable<Projects> listAllProjects()
        {

            return _context.Projects;
        }

        public List<string> samplesForUser(int id)
        {

            return _context.Samples.Where(u => u.user == id).Select(a => a.name).ToList();
        }

        public Samples getSample(int id)
        {
            return _context.Samples.Where(u => u.id == id).FirstOrDefault();
        }

        public StepSequencer getStepSeq(int id)
        {
            return _context.StepSequencer.Where(u => u.id == id).FirstOrDefault();
        }

        public Boolean updateStepSeqForUser(StepSequencer stepSeq)
        {
            _context.StepSequencer.Update(stepSeq);

            return Save();
        }

        Func<bool> Save = () => { return (_context.SaveChanges() >= 0); };

        public Boolean insertProject(ProjectsDTO project)
        {
            //TODO Automap entities for code reduction
            var entity = new Projects();
            entity.author = project.author;
            entity.bpm = Convert.ToString(project.bpm);
            entity.sampleRate = project.sampleRate;
            entity.name = project.name;
            entity.timestamp = DateTime.UtcNow.ToUniversalTime();

            _context.Projects.Add(entity);


            var result = Save();

            if (result == true)
            {
                project.stepSequencer.ForEach(ss => { ss.projID = _context.Projects.Last().id; ss.user = _context.Projects.Last().author; });
                project.padPerformer.ForEach(ss => { ss.projID = _context.Projects.Last().id; ss.user = _context.Projects.Last().author; });

                project.stepSequencer.ToList().ForEach(ss => _context.StepSequencer.Add(ss));
                project.padPerformer.ToList().ForEach(ss => _context.Samples.Add(ss));
            }


            return Save();
        }

        public Boolean updateSample(Samples sample)
        {
            _context.Samples.Update(sample);

            return Save();
        }

        public Boolean updateProject(ProjectsDTO project)
        {
            //TODO Automap entities for code reduction
            var entity = new Projects();
            entity.id = project.id;
            entity.author = project.author;
            entity.bpm = Convert.ToString(project.bpm);
            entity.sampleRate = project.sampleRate;
            entity.name = project.name;
            entity.timestamp = DateTime.UtcNow.ToUniversalTime();

            _context.Projects.Update(entity);


            var result = Save();

            if (result == true)
            {
                project.stepSequencer.ForEach(ss => { ss.projID = _context.Projects.Last().id; ss.user = _context.Projects.Last().author; });
                project.padPerformer.ForEach(ss => {ss.projID = _context.Projects.Last().id; ss.user = _context.Projects.Last().author; });

                project.stepSequencer.ToList().ForEach(ss => _context.StepSequencer.Update(ss));
                project.padPerformer.ToList().ForEach(ss => _context.Samples.Update(ss));
            }


            return Save();
        }
    }
}