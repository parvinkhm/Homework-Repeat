using Service.Services;

namespace Methods_Services.Controllers
{
    public class EmployeController
    {
        private EmployeeService _employeeService;
        public EmployeController()
        {
            _employeeService = new EmployeeService();
        }
        public void GetAllEmployees()
        {
            var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Id}, {employee.Name}, {employee.Surname}, {employee.Age}, {employee.Salary}$";

                Console.WriteLine(result);
            }
        }

        public void GetEmployeeById()
        {
            int id = 2;
            var employee = _employeeService.GetById(id);
            Console.WriteLine(employee.Id + ","+  employee.Name);

        }
    }
}
