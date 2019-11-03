using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class TimeCardBusiness
    {
        Database.TimeCardDatabase db = new Database.TimeCardDatabase();

        public void Inserir(Database.Entities.tb_timecard timecard)
        {
            db.Inserir(timecard);
        }

        public List<Database.Entities.tb_timecard> Consultar()
        {
            List<Database.Entities.tb_timecard> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_timecard timecard, Database.Entities.tb_points points)
        {
            db.Alterar(timecard, points);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
