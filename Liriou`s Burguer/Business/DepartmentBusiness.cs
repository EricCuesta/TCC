using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class DepartmentBusiness
    {
        public void Inserir(Database.Entities.tb_department department)
        {
            Database.DepartmentDatabase DB = new Database.DepartmentDatabase();
            DB.Inserir(department);
        }

        public List<Database.Entities.tb_department> Consultar()
        {
            Database.DepartmentDatabase DB = new Database.DepartmentDatabase();
            List<Database.Entities.tb_department> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_department accounts)
        {
            Database.DepartmentDatabase DB = new Database.DepartmentDatabase();
            DB.Alterar(accounts);
        }

        public void Remover(int id)
        {
            Database.DepartmentDatabase DB = new Database.DepartmentDatabase();
            DB.Remover(id);
        }
    }
}
