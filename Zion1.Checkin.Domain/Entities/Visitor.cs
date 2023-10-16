using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zion1.Common.Domain.Entities;

namespace Zion1.Checkin.Domain.Entities
{
    public class Visitor : BaseEntity<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<CheckinRequest> CheckinRequest { get; set; }
    }
}
