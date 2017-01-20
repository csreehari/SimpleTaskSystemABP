using Abp.Application.Services;
using SimpleTaskSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Services
{
    public interface IProjectAppService : IApplicationService
    {
        GetProjectOutput GetProjects();
    }
}
