using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extenstions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateOnly date)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            var age = today.Year - date.Year;
            if (date > today.AddYears(-age)) age--; // check if birthday already happened this year
            return age;
        }
    }
}