using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Model
{
     class EmployeesModel
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public int dependents { get; set; }
        public string sex { get; set; }
        public DateTime birth { get; set; }
        public string state{ get; set; }
        public string CEP { get; set; }
        public string address { get; set; }
        public string note { get; set; }   
        public string cellphone { get; set; }
        public string tellphone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
