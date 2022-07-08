using EClerx.LayeredDemo.DAL;
using System.Data;

namespace EClerx.LayeredDemo.BLL
{
    public class EmployeeBLL
    {
        public DataTable GetEmployees(string state)
        {
            Employee employee = new Employee();
            var dt = employee.GetEmployees(state);
            return dt;
        }
    }
}
