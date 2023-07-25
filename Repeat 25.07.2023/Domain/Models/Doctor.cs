using Domain.Models;
using System;

namespace Methods_Services.Models
{
    internal class Doctor : BaseEntity
    {
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Addres { get; set; }
        public DateTime Birthday { get; set; }

    }
}
