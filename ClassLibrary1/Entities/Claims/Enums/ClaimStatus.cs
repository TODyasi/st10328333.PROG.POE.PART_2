using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Domain.Entities.Claims
{
    public enum ClaimStatus
    {
        Draft,
        Submitted,
        Approved,
        Rejected,
        UnderReview
    }
}
