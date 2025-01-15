// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Collections.Generic;
using Model;
using System;


IRepository<Aluno> alunoRepo = null;
IRepository<Professor> profRepo = null;
IRepository<Diciplina> diciRepo = null;
IRepository<Turma> turmaRepo = null;

alunoRepo = new AlunoFakeRepository();
profRepo = new ProfessorFakeRepository();
diciRepo = new DiciplinaFakeRepository();
turmaRepo = new TurmaFakeRepository();

while (true)
{
    try
    {
        Clear();
        WriteLine("""
            1 - Cadastrar Professor
            2 - Cadastrar Aluno
            3 - Cadastrar Turma
            4 - Cadastrar Diciplina
            5 - Ver Professores
            6 - Ver Alunos
            7 - Ver Turmas
            8 - Ver Diciplinas
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
                WriteLine("Quantidade de diciplinas: ");
                int qtd_dici = int.Parse(ReadLine());
                List<Diciplina> dicis = [];
                for(int i = 0; i<qtd_dici; i++){
                    WriteLine("Descicao da diciplina: ");
                    string desc = ReadLine();
                    WriteLine("Periodo da diciplina: ");
                    int per = int.Parse(ReadLine());

                    dicis.Add(new(){descricao = desc, periodo = per});
                }

                prof.diciplinas = dicis;
                profRepo.Add(prof);

                break;
            case 2:
                Aluno aluno = new();

                WriteLine("Insira o id do aluno: ");
                aluno.Id = int.Parse(ReadLine());
                WriteLine("Insira o nome do aluno: ");
                aluno.Nome = ReadLine();
                WriteLine("Insira a idade do aluno: ");
                aluno.Idade = int.Parse(ReadLine());

                alunoRepo.Add(aluno);

                break;
            case 3:

                List<Aluno> alunoss = [];

                Turma turma = new();

                WriteLine("Insira o nome do Turma: ");
                turma.descricao = ReadLine();
                WriteLine("Insira a quantidade de alunos: ");
                int qtd_alunos = int.Parse(ReadLine());

                var al = alunoRepo.All;

                for(int i=0; i<qtd_alunos; i++)
                {
                    foreach (var a in al)
                    {
                        WriteLine($"""
                            ID-{a.Id} | {a.Nome} - {a.Idade}
                            -------------------
                        """);
                    }
                    WriteLine("Insira o id do aluno: ");
                    int id = int.Parse(ReadLine());

                    foreach (var b in al)
                    {
                        if (b.Id == id){
                            WriteLine("SIMM" + b.Id);
                            alunoss.Add(new(){Id = b.Id, Nome = b.Nome, Idade = b.Idade});
                        }
                    }

                    Clear();
                }

                turma.alunos = alunoss;
                turmaRepo.Add(turma);

                break;
            case 4:
                Diciplina diciplina = new();

                WriteLine("Insira a descricao da diciplina: ");
                diciplina.descricao = ReadLine();
                WriteLine("Insira o periodo da diciplina: ");
                diciplina.periodo = int.Parse(ReadLine());

                diciRepo.Add(diciplina);
                break;
            case 5:
                var profs = profRepo.All;
                foreach (var pro in profs)
                {
                    WriteLine($"""
                        {pro.Nome} - {pro.Formacao}
                        ---
                    """);
                    WriteLine("Diciplinas: ");
                    foreach(var d in pro.diciplinas){
                        WriteLine($"""
                        {d.descricao} - {d.periodo}° periodo
                        ----------------------
                    """);
                    }
                }
                break;
            case 6:
                var alunos = alunoRepo.All;
                foreach (var alu in alunos)
                {
                    WriteLine($"""
                        {alu.Id}) {alu.Nome} - {alu.Idade}
                        -------------------
                    """);
                }
                break;
            case 7:
                var turmas = turmaRepo.All;
                foreach (var tur in turmas)
                {
                    WriteLine($">>> {tur.descricao} -------------------");
                    WriteLine("Alunos:");
                    foreach(var alun in tur.alunos){
                        WriteLine($"""
                            ID-{alun.Id} | {alun.Nome} - {alun.Idade}
                            -------------------
                        """);
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
