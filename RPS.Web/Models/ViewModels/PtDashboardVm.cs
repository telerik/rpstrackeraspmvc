using RPS.Core.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPS.Web.Models.ViewModels
{
    public class PtDashboardVm
    {
        public DateTime? DateStart { get; set;}
        public DateTime? DateEnd { get; set; }

        public PtDashboardStatusCounts StatusCounts { get; set; }

        public PtDashboardFilteredIssues FilteredIssues { get; set; }

        public PtDashboardVm(PtDashboardStatusCounts statusCounts, PtDashboardFilteredIssues filteredIssues)
        {
            StatusCounts = statusCounts;
            FilteredIssues = filteredIssues;
        }
    }
}