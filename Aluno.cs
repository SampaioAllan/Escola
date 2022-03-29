namespace Escola
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, DateTime dataNascimento, string cpf) : base(nome, dataNascimento, cpf)
        {
        }
        public Aluno(Pessoa pessoa) : base(pessoa.Nome, pessoa.DataNascimento, pessoa.CPF)
        {
        }
    }
}