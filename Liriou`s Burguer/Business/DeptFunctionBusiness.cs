using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DeptFunctionBusiness
    {
        Database.DeptFunctionDatabase db = new Database.DeptFunctionDatabase();
        public void Inserir(Database.Entities.tb_deptfunction defu)
        {
            if (defu.nm_department == string.Empty)
            {
                throw new ArgumentException("Departamento Obrigatório!");
            }
            if (defu.nm_function == string.Empty)
            {
                throw new ArgumentException("Cargo Obrigatório!");
            }

            Database.EmployeesDatabase DB = new Database.EmployeesDatabase();
            defu.id_emp = DB.InsertEmp(Model.EmployeesModel.CPF);

            db.Inserir(defu);
        }
    }
}
