using SimpleTaskSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTaskSystem.Dtos;
using AutoMapper;
using Abp.Application.Services;

namespace SimpleTaskSystem.AppServices
{
    public class ProjectsAppService : ApplicationService, IProjectsAppService
    {
        private IProjectRepository _projectRepository;
        public ProjectsAppService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public GetProjectOutput GetProjects()
        {
            var projects = _projectRepository.GetProjects();
            return new GetProjectOutput
            {
                Projects = Mapper.Map<List<ProjectDto>>(projects)

            };
        }
    }
}
