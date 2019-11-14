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
    }
}
