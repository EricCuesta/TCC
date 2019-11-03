using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (client.nr_rg == string.Empty)
                throw new ArgumentException("O campo RG deve ser preenchido");
            if (client.nr_cpf == string.Empty)
                throw new ArgumentException("O campo CPF deve ser preenchido");
            if (client.ds_sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (client.ds_sex == "Masculino")
                client.ds_sex = "M";
            else
                client.ds_sex = "F";
            if (client.ds_state == string.Empty)
                throw new ArgumentException("O campo Estado deve ser preenchido");
            if (client.nr_cep == string.Empty)
                throw new ArgumentException("O campo CEP deve ser preenchido");
            if (client.nr_cellphone == string.Empty && client.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (client.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(client.ds_email);
            if (match.Success == false)
                throw new ArgumentException(client.ds_email + " é um e-mail inválido!");

            db.Inserir(client);
        }

        public Database.Entities.tb_client ConsultarPorID(int id)
        {
            Database.Entities.tb_client client = db.ConsultaPorID(id);

            return client;
        }

        public List<Database.Entities.tb_client> Consultar(Database.Entities.tb_client client)
        {
            List<Database.Entities.tb_client> list = new List<Database.Entities.tb_client>();


            if (client.nr_rg == string.Empty && client.ds_sex == null)
                list = db.ConsultarPorNome(client);
            else if (client.nm_firstName == string.Empty && client.ds_sex == null)
                list = db.ConsultarPorRG(client);
            else if (client.nm_firstName == string.Empty && client.nr_rg == string.Empty)
                list = db.ConsultarPorSexo(client);
            else if (client.ds_sex == null)
                list = db.ConsultarPorNomeRG(client);
            else if (client.nm_firstName != string.Empty && client.ds_sex != null)
                list = db.ConsultarPorNomeSexo(client);
            else if (client.nr_rg != string.Empty && client.ds_sex != null)
                list = db.ConsultarPorRGSexo(client);

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
            if (client.nr_rg == string.Empty)
                throw new ArgumentException("O campo rg deve ser preenchido");
            if (client.nr_cpf == string.Empty)
                throw new ArgumentException("O campo cpf deve ser preenchido");
            if (client.ds_sex == string.Empty)
                throw new ArgumentException("O campo sexo deve ser preenchido");
            if (client.ds_sex == "Masculino")
                client.ds_sex = "M";
            else
                client.ds_sex = "F";
            if (client.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser preenchido");
            if (client.nr_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (client.nr_cellphone == string.Empty && client.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (client.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(client.ds_email);
            if (match.Success == false)
                throw new ArgumentException(client.ds_email + " é um e-mail inválido!");

            db.Alterar(client);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
