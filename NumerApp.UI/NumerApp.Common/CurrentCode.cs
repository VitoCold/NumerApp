using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerApp.Common
{
    public static class CurrentCode
    {
        public static string Codigo(string abr,int cantidad)
        {
            var result = string.Empty;

            result = string.Format($"{abr}-{cantidad.ToString("0000")}-{DateTime.Now.Year}");

            return result;
        }
    }
}
