using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class EmployeesDatabase
    {
        public Entities.tb_employees Verificar(Entities.tb_employees verificar)
        {
            Entities.liriousdbEntities1 db = new Entities.liriousdbEntities1();
            Entities.tb_employees database = db.tb_employees.FirstOrDefault(l => l.ds_cpf == verificar.ds_cpf ||
                                                                                 l.ds_rg == verificar.ds_rg ||
                                                                                 l.mr_tellphone == verificar.mr_tellphone ||
                                                                                 l.mr_cellphone == verificar.mr_cellphone);
            return database;
        }

        public void AlterarRecuperação(Entities.tb_employees alterar)
        {
            Entities.liriousdbEntities1 db = new Entities.liriousdbEntities1();
            Entities.tb_employees novo = db.tb_employees.First(u => u.id_emp == Model.UsuarioLogado.ID);

            novo.ds_password = alterar.ds_password;

            db.SaveChanges();
        }
    }
}
