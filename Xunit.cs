using System;
using System.Collections.Generic;
using FlameAPI.Model.Entities;
using FlameAPI.Services.Repositories;
using Xunit;
namespace FlameAPI
{
    public class Xunit
    {
    
        private ProjectRepository _projectRepository;
        [Fact]

        public void returnsProjectList()
        {
            var y = _projectRepository.listAllProjects();


            Assert.IsType<List<Projects>>(y);
        }

        public void returnsProject()
        {
            var y = _projectRepository.getProject(5);


            Assert.IsType<Projects>(y);
        }

        [Fact]
        public void returnsNull()
        {
            var y = _projectRepository.getProject(-1);


            Assert.NotNull(y);
        }

        [Fact]
        public void returnsUnique()
        {
            var y = _projectRepository.getProject(5);
            var x = _projectRepository.getProject(6);


            Assert.NotSame(y, x);
        }

    }
}
