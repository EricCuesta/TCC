using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Database
{
    class TimeCardDatabase
    {
        public void Inserir(Entities.tb_timecard timecard)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            DB.tb_timecard.Add(timecard);

            DB.SaveChanges();
        }

        public List<Entities.tb_timecard> Consultar()
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            List<Entities.tb_timecard> list = DB.tb_timecard.ToList();

            return list;
        }

        public void Alterar(Entities.tb_timecard timecard, Entities.tb_points points)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_timecard list = DB.tb_timecard.First(t => t.id_timecard == timecard.id_timecard);
            Entities.tb_points list1 = DB.tb_points.First(t => t.id_point == points.id_point);
            list1.dt_date = list1.dt_date;
            list1.vl_cameIn = list1.vl_cameIn;
            list1.vl_exited = list1.vl_exited;
            list.vl_fixedIntInput = list.vl_fixedIntInput;
            list.vl_fixedIntOutput = list.vl_fixedIntOutput;
            list1.vl_hoursToPay = list1.vl_hoursToPay;
            list.vl_input = list.vl_input;
            list1.vl_intervalInput = list1.vl_intervalInput;
            list1.vl_intervalOutput = list1.vl_intervalOutput;
            list.vl_output = list.vl_output;
            DB.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.liriousdbEntities DB = new Entities.liriousdbEntities();
            Entities.tb_timecard remover = DB.tb_timecard.First(t => t.id_timecard == id);

            DB.tb_timecard.Remove(remover);
            DB.SaveChanges();
        }
    }
}
