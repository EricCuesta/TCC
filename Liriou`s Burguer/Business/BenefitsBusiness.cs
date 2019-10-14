using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class BenefitsBusiness
    {
        public void Inserir(Database.Entities.tb_benefits benefits)
        {
            Database.BenefitsDatabase DB = new Database.BenefitsDatabase();
            DB.Inserir(benefits);
        }

        public List<Database.Entities.tb_benefits> Consultar()
        {
            Database.BenefitsDatabase DB = new Database.BenefitsDatabase();
            List<Database.Entities.tb_benefits> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_benefits benefits)
        {
            Database.BenefitsDatabase DB = new Database.BenefitsDatabase();
            DB.Alterar(benefits);
        }

        public void Remover(int id)
        {
            Database.BenefitsDatabase DB = new Database.BenefitsDatabase();
            DB.Remover(id);
        }

    }
}
