namespace Solid.OCP
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; private set; }

        public PessoaFisica(string name, string cpf) : base(name)
        {
            Cpf = cpf;
        }
    }
}
