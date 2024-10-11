using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS.Domain.Entities.Claims
{
    public enum ClaimType
    {

        TravelExpenses,                       // For claims related to travel costs
        AccommodationExpenses,                // For claims related to lodging or accommodation
        ConferenceAndSeminarFees,            // For claims covering registration fees for conferences or seminars
        TeachingMaterialsExpenses,            // For claims related to educational materials
        InternetAndDataCosts,                 // For claims covering internet or data expenses
        PrintingAndStationeryExpenses,        // For claims related to printing or stationery supplies
        ResearchProjectExpenses,              // For claims related to research expenses
        FieldworkAndPracticumExpenses,       // For claims associated with fieldwork or practicum costs
        ProfessionalDevelopmentExpenses,      // For claims regarding professional development activities
        SubsistenceAllowanceClaims,           // For claims related to daily living expenses during work
        AdministrativeFeesClaims,             // For claims related to administrative costs
        HealthAndSafetyEquipmentClaims,       // For claims concerning health and safety equipment purchases
        MiscellaneousExpenses,                 // For claims that don't fit into other categories
        SalaryOrCommissionDispute              // New claim type for disputes regarding salary or commission
    }
}
}
