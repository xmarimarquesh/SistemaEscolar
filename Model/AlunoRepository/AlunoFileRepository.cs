using System.Collections.Generic;
using Model;
using Database;
using static System.Console;
using System.IO;

public class AlunoFileRepository : IRepository<Aluno>
{
    private DB<Aluno> data;

    public AlunoFileRepository()
    {
        data = DB<Aluno>.App;
        List<Aluno> alunos = data.All;
        data.Save(alunos);
    }

    public List<Aluno> All => data.All;

    public void Add(Aluno obj){
        List<Aluno> alunos = data.All;
        alunos.Add(obj);
        data.Save(alunos);
    }

    public Aluno getById(string id)
    {
        foreach (var aluno in data.All){
            if (aluno.Id == id)
                return aluno;
        }
        return null;
    }

    public void seeAll(){
        var alunos = data.All;

        WriteLine("ALUNOS: ");

        IRepository<Turma> turmaRepo = new TurmaFileRepository();

        foreach (var aluno in alunos)
        {
            var turma = turmaRepo.getById(aluno.IDTurma);
            
            if(turma != null){
                WriteLine($"""
                    ID={aluno.Id}) | {aluno.Nome} - IDADE {aluno.Idade} | TURMA {turma.descricao}
                    ----------------------------------------------------------------------------
                """);
            } else {
                WriteLine($"""
                    ID={aluno.Id}) | {aluno.Nome} - IDADE {aluno.Idade} | TURMA (não identificado)
                    ----------------------------------------------------------------------------
                """);
            }
        }
    }

}