using System;
using System.Collections.Generic;
using System.Linq;
using FlameAPI.Model.Context;
using FlameAPI.Model.Entities;

namespace FlameAPI.Services.Repositories
{
    public interface IProjectRepository
    {
        ProjectsDTO getProject(int projID);

        IQueryable<Projects> listProjects(int userID);

        Boolean insertProject(ProjectsDTO project);

        Boolean updateProject(ProjectsDTO project);

        IQueryable<Projects> listAllProjects();

        List<string> samplesForUser(int id);

        Samples getSample(int id);

        Boolean updateSample(Samples sample);

        StepSequencer getStepSeq(int id);

        Boolean updateStepSeqForUser(StepSequencer stepSeq);
    }
}
