using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalExpertise.DAL;
using GlobalExpertise.models;

namespace GlobalExpertise.services
{
    class Users
    {
        EnterpriseContext databaseContext;
        public Users () {
            databaseContext = new EnterpriseContext();
        }

        public Employee getEmployee(string username, string password)
        {
            return databaseContext.Employees.Where(e => e.Email == username && e.Password == password).SingleOrDefault<Employee>();
        }
    }
}
