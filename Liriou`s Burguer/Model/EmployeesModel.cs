using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Model
{
    static class EmployeesModel
    {
        public static int ID { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string RG { get; set; }
        public static string CPF { get; set; }
        public static int dependents { get; set; }
        public static string sex { get; set; }
        public static string birth { get; set; }
        public static string state { get; set; }
        public static string CEP { get; set; }
        public static string address { get; set; }
        public static string note { get; set; }   
        public static string cellphone { get; set; }
        public static string tellphone { get; set; }
        public static string email { get; set; }
        public static string password { get; set; }
        public static bool manager { get; set; }
        public static bool employeer { get; set; }
        public static bool RH { get; set; }
        public static bool financial { get; set; }
        public static bool stock { get; set; }
        public static bool CRM { get; set; }
        public static bool Provider { get; set; }
    }
}
