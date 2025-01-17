using System.Collections.Generic;
using Model;
using Database;
using System.IO;
using System;
using static System.Console;

public class TurmaRepository : IRepository<Turma>
{
    private DB<Turma> data;

    public TurmaRepository()
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

        IRepository<Professor> profRepo = new ProfessorRepository();
        IRepository<Aluno> alunoRepo = new AlunoRepository();
        
        foreach (var turma in turmas)
        {
            var prof = profRepo.getById(turma.IDProf);
            var alunos = alunoRepo.All;
            
            WriteLine($"""
                ID={turma.ID}) | {turma.descricao} | PROFESSOR {prof.Nome}
                --------------------------------------
            """);

            foreach (var aluno in alunos)
            {
                if(aluno.IDTurma == turma.ID)
                    WriteLine(" - "+aluno.Nome);
            }

        }
    }
}