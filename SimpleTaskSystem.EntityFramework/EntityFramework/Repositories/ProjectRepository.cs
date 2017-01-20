using SimpleTaskSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTaskSystem.Models;

namespace SimpleTaskSystem.EntityFramework.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public List<Project> GetProjects()
        {
            var projects = new List<Project>();
            using (var db = new SimpleTaskSystemDbContext())
            {
                projects = db.Projects.ToList();
            }
            return projects;
        }
    }
}
