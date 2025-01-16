// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Collections.Generic;
using Model;
using System;

IRepository<Aluno> alunoRepo = new AlunoRepository();
IRepository<Professor> profRepo = new ProfessorRepository();
IRepository<Disciplina> diciRepo = new DisciplinaRepository();
IRepository<Turma> turmaRepo = new TurmaRepository();

while (true)
{
    try
    {
        Clear();
        WriteLine("""
            1 - Cadastrar Professor
            2 - Cadastrar Aluno
            3 - Cadastrar Turma
            4 - Cadastrar Disciplina
            5 - Ver Professores
            6 - Ver Alunos
            7 - Ver Turmas
            8 - Ver Disciplinas
            9 - Sair
        """);

        int option = int.Parse(ReadLine());

        switch (option)
        {
            case 1:
                Professor prof = new();

                WriteLine("Insira o nome do professor: ");
                prof.Nome = ReadLine();
                WriteLine("Insira a formação do professor: ");
                prof.Formacao = ReadLine();
                WriteLine("ID da disciplina: ");
                prof.IDDisciplina = ReadLine();

                profRepo.Add(prof);

                break;
            case 2:
                Aluno aluno = new();

                WriteLine("Insira o nome do aluno: ");
                aluno.Nome = ReadLine();
                WriteLine("Insira a idade do aluno: ");
                aluno.Idade = int.Parse(ReadLine());
                WriteLine("Insira o ID da turma do aluno: ");
                aluno.IDTurma = ReadLine();

                alunoRepo.Add(aluno);

                break;
            case 3:

                List<Aluno> alunoss = [];

                Turma turma = new();

                WriteLine("Insira o nome da Turma: ");
                turma.descricao = ReadLine();
                WriteLine("Insira o ID do professor da Turma: ");
                turma.IDProf = ReadLine();

                var al = alunoRepo.All;

                turmaRepo.Add(turma);
                

                break;
            case 4:
                Disciplina disciplina = new();

                WriteLine("Insira a descricao da disciplina: ");
                disciplina.descricao = ReadLine();
                WriteLine("Insira o periodo da disciplina: ");
                disciplina.periodo = int.Parse(ReadLine());

                diciRepo.Add(disciplina);
                break;
            case 5:
                var profs = profRepo.All;
                foreach (var pro in profs)
                {
                    WriteLine($"""
                        {pro.Nome} - {pro.Formacao} | {pro.IDDisciplina}
                        ---
                    """);
                }
                
                break;
            case 6:
                alunoRepo.seeAll();
                break;
            case 7:
                var turmas = turmaRepo.All;
                var alu = alunoRepo.All;
                var profe = profRepo.All;

                foreach (var tur in turmas)
                {
                    WriteLine($">>> {tur.descricao} -------------------");
                    foreach(var pr in profe){
                        if(tur.IDProf == pr.ID)
                            WriteLine("Professor: "+pr.Nome);
                    }
                    WriteLine("IDT: "+tur.IDProf);
                    WriteLine("Alunos:");

                    foreach(var alun in alu){
                        if(alun.IDTurma == tur.ID){
                            WriteLine($"""
                                ID-{alun.Id} | {alun.Nome} - {alun.Idade}
                                -------------------
                            """);
                        }
                    }
                }
                break;
            case 8:
                var diciplis = diciRepo.All;
                foreach (var dic in diciplis)
                {
                    WriteLine($"""
                        {dic.descricao} - {dic.periodo}° período
                        -------------------
                    """);
                }
                break;
            case 9:
                return;
            default: 
                break;
        }
    }
    catch 
    {
        WriteLine("Erro na aplicação, por favor consulte a equipe TI");
    }

    WriteLine("Pressione qualquer tecla para continuar");
    ReadKey(true);
}
