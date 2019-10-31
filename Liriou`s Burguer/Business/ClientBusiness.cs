using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ClientBusiness
    {
        Database.ClientDatabase db = new Database.ClientDatabase();

        public void Inserir(Database.Entities.tb_client client)
        {
            if (client.nm_firstName == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (client.nm_lastName == string.Empty)
                throw new ArgumentException("O campo sobrenome deve ser preenchido");
            if (client.ds_rg == string.Empty)
                throw new ArgumentException("O campo rg deve ser preenchido");
            if (client.ds_cpf == string.Empty)
                throw new ArgumentException("O campo cpf deve ser preenchido");
            if (client.ds_sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (client.ds_sex == "Masculino")
                client.ds_sex = "M";
            else
                client.ds_sex = "F";
            if (client.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser preenchido");
            if (client.ds_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (client.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (client.nr_cellphone == string.Empty && client.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (client.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");

            db.Inserir(client);
        }

        public Database.Entities.tb_client ConsultarPorID(int id)
        {
            Database.ClientDatabase dbclient = new Database.ClientDatabase();
            Database.Entities.tb_client client = dbclient.ConsultaPorID(id);

            return client;
        }

        public List<Database.Entities.tb_client> ConsultarPorNome(Database.Entities.tb_client client)
        {
            Database.ClientDatabase dbclient = new Database.ClientDatabase();
            List<Database.Entities.tb_client> list = new List<Database.Entities.tb_client>();

            if (client.nm_firstName != string.Empty)
                list = dbclient.ConsultarPorNome(client);

            return list;
        }

        public List<Database.Entities.tb_client> Consultar(Database.Entities.tb_client client)
        {
            Database.ClientDatabase dbclient = new Database.ClientDatabase();
            List<Database.Entities.tb_client> list = new List<Database.Entities.tb_client>();

            if (client.nm_firstName == string.Empty)
                list = dbclient.ConsultarPorNome(client);
            else if (client.ds_rg == string.Empty)
                list = dbclient.ConsultarPorRG(client);
            else if (client.ds_sex == string.Empty)
                list = dbclient.ConsultarPorSexo(client);

            return list;
        }

        public List<Database.Entities.tb_client> ConsultarTodos()
        {
            List<Database.Entities.tb_client> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_client client)
        {
            if (client.nm_firstName == string.Empty)
                throw new ArgumentException("O campo nome deve ser preenchido");
            if (client.nm_lastName == string.Empty)
                throw new ArgumentException("O campo sobrenome deve ser preenchido");
            if (client.ds_rg == string.Empty)
                throw new ArgumentException("O campo rg deve ser preenchido");
            if (client.ds_cpf == string.Empty)
                throw new ArgumentException("O campo cpf deve ser preenchido");
            if (client.ds_sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (client.ds_sex == "M")
                client.ds_sex = "Masculino";
            else
                client.ds_sex = "Feminino";
            if (client.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser preenchido");
            if (client.ds_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (client.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (client.nr_cellphone == string.Empty && client.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (client.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");

            db.Alterar(client);
        }

        public void Deletar(int id)
        {
            db.Deletar(id);
        }
    }
}
