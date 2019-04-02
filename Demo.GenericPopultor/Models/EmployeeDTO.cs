using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.GenericPopultor.Models
{
    class EmployeeDTO
    {
        public string CLFirstName { get; set; }
        public string JobTitle { get; set; }
        public string Community { get; set; }
        public decimal Actual_Bonus { get; set; }
        public decimal MI_Bonus { get; set; }

        public string EmployeeType { get; set; }

    }
}
