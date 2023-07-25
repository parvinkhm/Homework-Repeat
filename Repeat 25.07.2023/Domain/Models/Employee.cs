using Domain.Models;

namespace Methods_Services.Models
{
    public class Employee :BaseEntity
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

    }
}
