using RequestsManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RequestsManagementService.Tools
{
    public static class DbFunctions
    {
        public static List<Users> GetAllClients()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).ToList();
        }

        public static List<Users> GetAllPerformers()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 3).ToList();
        }

        public static Users GetClientById(Int32 id)
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).FirstOrDefault(u => u.Id == id);
        }

        public static Users GetUserByLogin(String login)
        {
            return RequestsManagementEntities.GetContext().Users.FirstOrDefault(u => u.Login == login);
        }

        public static List<String> GetAllClientsLogins()
        {
            return RequestsManagementEntities.GetContext().Users.Where(u => u.RoleId == 4).Select(u => u.Login).ToList();
        }

        public static List<String> GetAllStatusNames()
        {
            return RequestsManagementEntities.GetContext().Statuses.Select(s => s.Name).ToList();
        }

        public static Statuses GetStatusByName(String name)
        {
            return RequestsManagementEntities.GetContext().Statuses.FirstOrDefault(u => u.Name == name);
        }

        public static List<Requests> GetAllRequests()
        {
            return RequestsManagementEntities.GetContext().Requests.ToList();
        }
    }
}
