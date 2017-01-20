using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Dtos
{
    public class SeekerDto
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }

    public class GetSeekersOutput
    {
        public List<SeekerDto> Seekers { get; set; }
    }
}
