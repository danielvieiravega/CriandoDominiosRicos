using System.Data.SqlClient;
using Solid.SRP.Services;

namespace Solid.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void ChangeName(string name)
        {
            Name = name;
            //Isso é responsabilidade do Fornecedor

            //disparar evento apra informar o RH sobre a mudança de nome
            NotificationService.Notify("rh@minhaempresa.com");
        }

        public void Salvar()
        {
            var conn = new SqlConnection("");
            var cmd = new SqlCommand("insert into ...");

            //precisa saber como conectar num banco
            //precisa saber senhas etc

            //isso é responsabilidade do repositorio de Fornecedor
        }
    }
}
