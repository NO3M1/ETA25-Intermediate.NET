using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETA25_Intermediate_C_.Session1
{
    public static class EmployeeUtilities
    {
        public static int CalculateSeniorityInYears(DateTime joindate)
        {
            return DateTime.UtcNow.Year - joindate.Year;    
        }
    }
}
