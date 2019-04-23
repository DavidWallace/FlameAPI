using System;
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

    }
}
