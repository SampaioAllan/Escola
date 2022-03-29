namespace Escola
{
    public class SalaDeAula
    {
        public string Serie { get; set; }
        public List<Aluno> Alunos { get; private set; }
        public List<Professor> Professores { get; set; }

        public SalaDeAula(string serie, List<Aluno> listaAlunosIniciais, List<Professor> primeirosProfessores)
        {
            Professores= primeirosProfessores;
            Serie= serie;
            Alunos= listaAlunosIniciais;
        }   

        public void AdicionarAluno(string nome, DateTime dataNascimento, string cpf)
        {
            Alunos.Add(new Aluno(nome, dataNascimento, cpf));
        }
        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoverAluno(string cpf)
        {
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void AdicionarProfessor(string nome, DateTime dataNascimento, string cpf, string disciplina)
        {
            Professores.Add(new Professor(nome, dataNascimento, cpf, disciplina));
        }
        public void AdicionarProfessor(Professor professor)
        {
            Professores.Add(professor);
        }
         public void RemoverProfessor(string cpf)
         {
            Professores.RemoveAll(professor => professor.CPF == cpf);
         }
    }
}