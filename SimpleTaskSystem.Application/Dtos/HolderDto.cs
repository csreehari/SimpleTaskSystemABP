using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem.Dtos
{
    public class HolderDto
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string ParkingSlotNumber { get; set; }
    }

    public class GetHoldersOutput
    {
        public List<HolderDto> Holders { get; set; }
    }
    
}
