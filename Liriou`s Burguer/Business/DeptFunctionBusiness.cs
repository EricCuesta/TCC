using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liriou_s_Burguer.Database.Entities;

namespace Liriou_s_Burguer.Business
{
    class DeptFunctionBusiness
    {
        Database.DeptFunctionDatabase db = new Database.DeptFunctionDatabase();

        public void Insirir(tb_deptfunction defu, int id)
        {
            defu.id_emp = id;

            db.Inserir(defu);
        }

        public string VericarParametros(tb_deptfunction defu)
        {
            if (defu.nm_department == string.Empty)
            {
                return "Departamento Obrigatório!";
            }
            if (defu.nm_function == string.Empty)
            {
                return "Cargo Obrigatório!";
            }

            return string.Empty;
        }

        public void Alterar(tb_deptfunction defu, int id)
        {
            defu.id_emp = id;

            db.Alterar(defu);
        }

        public tb_deptfunction ConsultarPorID(int id)
        {
            return db.ConsultarPorID(id);
        }

        public void Remover(tb_deptfunction defu)
        {
            db.Remover(defu);
        }
    }
}
