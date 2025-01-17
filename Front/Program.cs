// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Collections.Generic;
using Model;
using System;

IRepository<Aluno> alunoRepo = new AlunoFileRepository();
IRepository<Professor> profRepo = new ProfessorFileRepository();
IRepository<Disciplina> diciRepo = new DisciplinaFileRepository();
IRepository<Turma> turmaRepo = new TurmaFileRepository();

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

                WriteLine("DISCIPLINAS DISPONÍVEIS: ");
                diciRepo.seeAll();

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

                WriteLine("Turmas Diponíveis: ");
                turmaRepo.seeAll();

                WriteLine("Insira o ID da turma do aluno: ");
                aluno.IDTurma = ReadLine();

                alunoRepo.Add(aluno);

                break;
            case 3:

                List<Aluno> alunoss = [];

                Turma turma = new();

                WriteLine("Insira o nome da Turma: ");
                turma.descricao = ReadLine();

                WriteLine("Professores: ");
                profRepo.seeAll();

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
                profRepo.seeAll();
                break;
            case 6:
                alunoRepo.seeAll();
                break;
            case 7:
                turmaRepo.seeAll();
                break;
            case 8:
                diciRepo.seeAll();
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
