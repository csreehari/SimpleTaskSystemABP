using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Models
{

    public class Project :Entity
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
