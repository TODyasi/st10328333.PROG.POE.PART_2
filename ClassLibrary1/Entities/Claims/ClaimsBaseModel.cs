using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Domain.Entities.Claims
{
    public class ClaimsBaseModel
    {
        public int ClaimId { get; set; } // Unique identifier for the claim

        public string Title { get; set; } // Title of the claim (e.g., "Travel to Conference")

        public string Description { get; set; } // Detailed explanation of the claim

        public DateTime DateCreated { get; set; } // Date when the claim was created

        public ClaimStatus ClaimStatus { get; set; } // Current status of the claim (e.g., Draft, Submitted, Approved, Rejected)

        public DateTime? DateSubmitted { get; set; } // Date when the claim was submitted; nullable in case it's not yet submitted

        public ClaimType ClaimType { get; set; } // Type of claim being submitted (e.g., Travel, Salary Complaint)

        public decimal Amount { get; set; } // Total claim amount in South African Rand (ZAR)

        public string ModuleCode { get; set; } // Reference to the associated module the lecturer is teaching

        // New properties to accommodate additional requirements
        public decimal HoursWorked { get; set; } // Total hours worked for the claim, used to calculate the claim amount

        public decimal HourlyRate { get; set; } // Hourly rate associated with the claim, used to calculate the total claim amount

        public string AdditionalNotes { get; set; } // Any additional notes or comments related to the claim

        public const int MaxFileSize = 5 * 1024 * 1024; // Maximum file size limit (5 MB) for uploaded documents

        public readonly string[] AllowedFileFormats = { ".pdf", ".docx", ".jpg" }; // Allowed file formats for uploads
        public List<UploadedDocuments> UploadedDocuments { get; set; } = new List<UploadedDocuments>();

        // Business logic methods for managing claims

        /// <summary>
        /// Submits the claim, changing its status to Submitted and recording the submission date.
        /// </summary>
        public void SubmitClaim()
        {
            if (ClaimStatus == ClaimStatus.Draft)
            {
                ClaimStatus = ClaimStatus.Submitted; // Update status to Submitted
                DateSubmitted = DateTime.Now; // Record the date of submission
            }
        }

        /// <summary>
        /// Approves the claim, changing its status to Approved.
        /// </summary>
        public void ApproveClaim()
        {
            if (ClaimStatus == ClaimStatus.Submitted)
            {
                ClaimStatus = ClaimStatus.Approved; // Update status to Approved
            }
        }

        /// <summary>
        /// Rejects the claim, changing its status to Rejected.
        /// </summary>
        public void RejectClaim()
        {
            if (ClaimStatus == ClaimStatus.Submitted)
            {
                ClaimStatus = ClaimStatus.Rejected; // Update status to Rejected
            }
        }

        /// <summary>
        /// Adds a document link to the UploadedDocuments list.
        /// </summary>
        /// <param name="documentLink">The link to the uploaded document.</param>
        public void AddDocument(string documentLink)
        {
            if (UploadedDocuments == null)
            {
                UploadedDocuments = new List<string>(); // Initialize the list if it's null
            }
            UploadedDocuments.Add(documentLink); // Add the document link to the list
        }

        /// <summary>
        /// Validates the file upload based on size and format restrictions.
        /// </summary>
        /// <param name="fileSize">Size of the uploaded file in bytes.</param>
        /// <param name="fileExtension">File extension of the uploaded document.</param>
        /// <returns>True if the file meets the criteria; otherwise, false.</returns>
        public bool ValidateFileUpload(long fileSize, string fileExtension)
        {
            return fileSize <= MaxFileSize && AllowedFileFormats.Contains(fileExtension.ToLower()); // Check size and format
        }
    }
}
