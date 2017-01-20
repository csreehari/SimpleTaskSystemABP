using SimpleTaskSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Services
{
    public interface IProjectRepository
    {
        List<Project> GetProjects();
    }
}
