namespace Escola
{
    public class Pessoa
    {
        public string Nome { get; }
        public DateTime DataNascimento { get; }
        public string CPF { get; }
        public Pessoa(string nome, DateTime dataNascimento, string cpf)
        {
            Nome=nome;
            DataNascimento=dataNascimento;
            CPF=cpf;

        }

    }
}