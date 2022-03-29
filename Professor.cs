namespace Escola
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; }
        public Professor(string nome, DateTime dataNascimento, string cpf, string disciplina) : base(nome, dataNascimento, cpf)
        {
            Disciplina=disciplina;
        }
        public Professor (Pessoa pessoa, string disciplina) : base (pessoa.Nome, pessoa.DataNascimento, pessoa.CPF)
        {
            Disciplina=disciplina;
        }
    }
}