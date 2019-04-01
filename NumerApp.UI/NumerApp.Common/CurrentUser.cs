using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace NumerApp.Common
{
    public static class CurrentUser
    {
        public static string GetUser()
        {
            var result = String.Empty;

            result = WindowsIdentity.GetCurrent().Name;

            return result;
        }
    }
}
