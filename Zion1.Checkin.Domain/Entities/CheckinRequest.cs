using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zion1.Common.Domain.Entities;

namespace Zion1.Checkin.Domain.Entities
{
    public class CheckinRequest : BaseEntity<int>
    {
        public string Request { get; set; } = string.Empty;

    }
}
