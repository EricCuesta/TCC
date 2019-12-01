using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class DeptFunctionDatabase
    {
        Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
        public void Inserir(Entities.tb_deptfunction defu)
        {
            DB.tb_deptfunction.Add(defu);

            DB.SaveChanges();
        }

        public void Alterar(Entities.tb_deptfunction defu)
        {
            Entities.tb_deptfunction tb = DB.tb_deptfunction.FirstOrDefault(t => t.id_emp == defu.id_emp);
            tb.nm_department = defu.nm_department;
            tb.nm_function = defu.nm_function;

            DB.SaveChanges();
        }

        public Entities.tb_deptfunction ConsultarPorID(int id)
        {
            return DB.tb_deptfunction.FirstOrDefault(t => t.id_emp == id);
        }

        public void Remover(Entities.tb_deptfunction defu)
        {
            DB.tb_deptfunction.Remove(defu);

            DB.SaveChanges();
        }
    }
}
