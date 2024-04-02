using RequestsManagementService.Models;
using System;
using System.Linq;

namespace RequestsManagementService.Tools
{
    public static class DbStatisticsCalculations
    {
        public static Int32 CountAllRequests()
        {
            return RequestsManagementEntities.GetContext().Requests.Count();
        }

        public static Int32 CountFinishedRequests()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 3);
        }

        public static Int32 CountRequestsInProcessing()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 1);
        }

        public static Int32 CountRequestsInExecutionProcess()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 2);
        }

        public static Int32 CountRequestsInPartiallyCompleted()
        {
            return RequestsManagementEntities.GetContext().Requests.Count(r => r.StatusId == 4);
        }
    }
}
