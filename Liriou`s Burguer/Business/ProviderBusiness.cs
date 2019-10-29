using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liriou_s_Burguer.Business
{
    class ProviderBusiness
    {
        Database.ProviderDatabase db = new Database.ProviderDatabase();

        public void Inserir(Database.Entities.tb_provider provider)
        {
            if (provider.nm_provider == string.Empty)
                throw new ArgumentException("O campo fornecedor deve ser preenchido");
            if (provider.nm_name == string.Empty)
                throw new ArgumentException("O campo nome fantásia deve ser preenchido");
            if (provider.ds_typePerson == string.Empty)
                throw new ArgumentException("O campo tipo de pessoa deve ser definido");
            if (provider.nr_identification == string.Empty)
                throw new ArgumentException("O campo de indentificação deve ser definido");
            if (provider.ds_country == string.Empty)
                throw new ArgumentException("O campo país deve ser preenchido");
            if (provider.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser definido");
            if (provider.ds_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (provider.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (provider.nr_cellphone == string.Empty && provider.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (provider.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");

            db.Inserir(provider);
        }

        public Database.Entities.tb_provider ConsultarPorID(int id)
        {
            Database.ProviderDatabase dbprovider = new Database.ProviderDatabase();
            Database.Entities.tb_provider provider = dbprovider.ConsultaPorID(id);

            return provider;
        }

        public List<Database.Entities.tb_provider> Consultar(Database.Entities.tb_provider provider)
        {
            Database.ProviderDatabase dbprovider = new Database.ProviderDatabase();
            List<Database.Entities.tb_provider> list = new List<Database.Entities.tb_provider>();

            if (provider.nm_provider == string.Empty)
                list = dbprovider.ConsultarPorNome(provider);
            else if (provider.ds_typePerson == string.Empty)
                list = dbprovider.ConsultarPorTipoDePessoa(provider);


            return list;
        }

        public List<Database.Entities.tb_provider> ConsultarTodos()
        {
            List<Database.Entities.tb_provider> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_provider provider)
        {
            if (provider.nm_provider == string.Empty)
                throw new ArgumentException("O campo fornecedor deve ser preenchido");
            if (provider.nm_name == string.Empty)
                throw new ArgumentException("O campo nome fantásia deve ser preenchido");
            if (provider.ds_typePerson == string.Empty)
                throw new ArgumentException("O campo tipo de pessoa deve ser definido");
            if (provider.nr_identification == string.Empty)
                throw new ArgumentException("O campo de indentificação deve ser definido");
            if (provider.ds_country == string.Empty)
                throw new ArgumentException("O campo país deve ser preenchido");
            if (provider.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser definido");
            if (provider.ds_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (provider.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (provider.nr_cellphone == string.Empty && provider.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (provider.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");

            db.Alterar(provider);
        }

        public void Deletar(int id)
        {
            db.Deletar(id);
        }
    }
}
