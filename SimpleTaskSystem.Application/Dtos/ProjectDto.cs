﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Dtos
{
   public  class ProjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class GetProjectOutput
    {
        public List<ProjectDto> Projects { get; set; }
    }
}
