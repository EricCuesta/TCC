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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Dependents { get; set; }
        public string State{ get; set; }
        public string Country { get; set; }
        public string CEP { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string Cellphone { get; set; }
        public string Tellphone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; }
    }
}
