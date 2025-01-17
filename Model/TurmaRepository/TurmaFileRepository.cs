using System.Collections.Generic;
using Model;
using Database;
using System.IO;
using System;
using static System.Console;

public class TurmaFileRepository : IRepository<Turma>
{
    private DB<Turma> data;

    public TurmaFileRepository()
    {
        data = DB<Turma>.App;
        List<Turma> turmas = data.All;
        data.Save(turmas);
    }

    public List<Turma> All => data.All;

    public void Add(Turma obj){
        List<Turma> turmas = data.All;
        turmas.Add(obj);
        data.Save(turmas);
    }

    public Turma getById(string id){
        foreach (var turma in data.All){
            if (turma.ID == id)
                return turma;
        }
        return null;
    }

    public void seeAll(){
        var turmas = data.All;

        WriteLine("TURMAS: ");

        IRepository<Professor> profRepo = new ProfessorFileRepository();
        IRepository<Aluno> alunoRepo = new AlunoFileRepository();
        
        foreach (var turma in turmas)
        {
            var prof = profRepo.getById(turma.IDProf);
            var alunos = alunoRepo.All;
            
            WriteLine($"""
                -----------------------------------------------------------------
                ID={turma.ID}) | {turma.descricao} | Professor: {prof.Nome}
            """);

            List<Aluno> alunos_da_turma = new();

            foreach (var aluno in alunos)
                {
                    if(aluno.IDTurma == turma.ID)
                        alunos_da_turma.Add(aluno);
                }

            if(alunos_da_turma.Count > 0){
                WriteLine("Alunos:");
                foreach (var aluno in alunos_da_turma)
                {
                    WriteLine(" - "+aluno.Nome);
                }
            } else {
                WriteLine("Sem alunos");
            }

        }
    }
}