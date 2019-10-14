using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ClientBusiness
    {
        public void Inserir(Database.Entities.tb_client client)
        {
            Database.ClientDatabase DB = new Database.ClientDatabase();
            DB.Inserir(client);
        }

        public List<Database.Entities.tb_client> Consultar()
        {
            Database.ClientDatabase DB = new Database.ClientDatabase();
            List<Database.Entities.tb_client> list = DB.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_client client)
        {
            Database.ClientDatabase DB = new Database.ClientDatabase();
            DB.Alterar(client);
        }

        public void Remover(int id)
        {
            Database.ClientDatabase DB = new Database.ClientDatabase();
            DB.Remover(id);
        }
    }
}
