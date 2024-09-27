using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Core.System
{
    public static class ConnectionStrings
    {
        public static string LocalConnectionString { get; } = "Server=localhost\\SQLEXPRESS;Database=MedicaNow;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
