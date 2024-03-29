﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Statu
    {
        public Statu()
        {
            InternLeaveDetails = new HashSet<InternLeaveDetail>();
            InternLeaves = new HashSet<InternLeave>();
        }

        public int StatuId { get; set; }
        public string StatuName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<InternLeaveDetail> InternLeaveDetails { get; set; }
        public virtual ICollection<InternLeave> InternLeaves { get; set; }
    }
}
