using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Domain.Entities.Claims
{
    public class UploadedDocuments
    {
        public int ClaimId { get; set; } // ID of the claim associated with this document
        public string FilePath { get; set; } // Path to the uploaded document
        public DateTime UploadDate { get; set; } // Date when the document was uploaded
    }
}
