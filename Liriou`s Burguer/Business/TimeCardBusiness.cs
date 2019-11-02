using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class TimeCardBusiness
    {

        public void Inserir(Database.Entities.tb_timecard timecard)
        {
            Database.TimeCardDatabase DB = new Database.TimeCardDatabase();
            DB.Inserir(timecard);
        }

        public List<Database.Entities.tb_timecard> Consultar()
        {
            Database.TimeCardDatabase DB = new Database.TimeCardDatabase();
            List<Database.Entities.tb_timecard> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_timecard timecard, Database.Entities.tb_points points)
        {
            Database.TimeCardDatabase DB = new Database.TimeCardDatabase();
            DB.Alterar(timecard, points);
        }

        public void Remover(int id)
        {
            Database.TimeCardDatabase DB = new Database.TimeCardDatabase();
            DB.Remover(id);
        }
    }
}
