using System.Collections.Generic;
using Model;
using Database;
using static System.Console;

public class ProfessorFileRepository : IRepository<Professor>
{
    private DB<Professor> data;

    public ProfessorFileRepository()
    {
        data = DB<Professor>.App;
        List<Professor> professors = data.All;
        data.Save(professors);
    }

    public List<Professor> All => data.All;

    public void Add(Professor obj){
        List<Professor> professors = data.All;
        professors.Add(obj);
        data.Save(professors);
    }

    public Professor getById(string id)
    {
        foreach (var prof in data.All){
            if (prof.ID == id)
                return prof;
        }
        return null;
    }

    public void seeAll(){
        var professors = data.All;

        WriteLine("PROFESSORES: ");

        IRepository<Disciplina> disciRepo = new DisciplinaFileRepository();
        
        foreach (var prof in professors)
        {
            var disci = disciRepo.getById(prof.IDDisciplina);

            WriteLine($"""
                ID={prof.ID}) | {prof.Nome} - FORMACAO {prof.Formacao} | DISCIPLINA {disci.descricao}
                --------------------------------------
            """);
        }
    }
}