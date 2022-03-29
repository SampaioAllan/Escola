namespace Escola
{
    public class Secretaria
    {
        public void cadastrarturmas()
        {
            var listaDeSalas = new List<SalaDeAula>();
            var confirmar = 0;
            do
            {
                Console.WriteLine("Deseja adicionar uma nova sala de aula?  1 = SIM | 2 = NÃO");
                confirmar =int.Parse (Console.ReadLine());
                if (confirmar == 1)
                {
                        Console.WriteLine("Qual a série?");
                        var serie = Console.ReadLine();
                        var professores = CadastrarPrimeirosProfessores();
                        var alunos = CadastrarPrimeirosAlunosDaTurma();
                        listaDeSalas.Add(new SalaDeAula (serie, alunos, professores));
                }
            }while(confirmar != 2);
            Console.WriteLine($"Você criou {listaDeSalas.Count}");
        }

        private List<Professor> CadastrarPrimeirosProfessores()
        {
            var confirmar=0;
            var primeirosProfessores = new List<Professor>();
            do
            {
                Console.WriteLine("Qual a disciplina do professor?");
                var disciplina = Console.ReadLine();
                primeirosProfessores.Add(new Professor(CadastrarPessoa(), disciplina));
                Console.WriteLine("Deseja adicionar novos professores? 1= S | 2 = N");
                confirmar = int.Parse(Console.ReadLine());
            }while (confirmar == 1 );
            return primeirosProfessores;
        }

        private List<Aluno> CadastrarPrimeirosAlunosDaTurma()
        {
            var confirmar = 0;
            var primeirosAlunos = new List<Aluno>();
            do
            {
                var pessoa = CadastrarPessoa();
                primeirosAlunos.Add(new Aluno(pessoa));
                Console.WriteLine("Deseja adicionar novos alunos? 1= S | 2 = N");
                confirmar = int.Parse(Console.ReadLine());
            }while (confirmar == 1);
            return primeirosAlunos;
        }
        
        private Pessoa CadastrarPessoa()
        {
            Console.WriteLine("Qual o nome? ");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual o CPF? ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento? ");
            var dataNascimento = DateTime.Parse(Console.ReadLine());
            return new Pessoa(nome, dataNascimento, cpf);
        }
    }
}