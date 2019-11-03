using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DepartmentBusiness
    {
        Database.DepartmentDatabase db = new Database.DepartmentDatabase();

        public void Inserir(Database.Entities.tb_department department)
        {
            db.Inserir(department);
        }

        public Database.Entities.tb_department ConsultarPorID(int id)
        {
            Database.DepartmentDatabase dbdepartment = new Database.DepartmentDatabase();
            Database.Entities.tb_department department = dbdepartment.ConsultaPorID(id);

            return department;
        }

        public List<Database.Entities.tb_department> Consultar(Database.Entities.tb_department department)
        {
            Database.DepartmentDatabase dbdepartment = new Database.DepartmentDatabase();
            List<Database.Entities.tb_department> list = new List<Database.Entities.tb_department>();

            list = dbdepartment.ConsultarPorNome(department);

            return list;
        }

        public List<Database.Entities.tb_department> ConsultarTodos()
        {
            List<Database.Entities.tb_department> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_department accounts)
        {
            Database.DepartmentDatabase db = new Database.DepartmentDatabase();
            db.Alterar(accounts);
        }

        public void Remover(int id)
        {
            Database.DepartmentDatabase db = new Database.DepartmentDatabase();
            db.Remover(id);
        }
    }
}
