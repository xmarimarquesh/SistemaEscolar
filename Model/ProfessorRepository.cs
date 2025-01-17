using System.Collections.Generic;
using Model;
using Database;
using static System.Console;

public class ProfessorRepository : IRepository<Professor>
{
    private DB<Professor> data;

    public ProfessorRepository()
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
        throw new System.NotImplementedException();
    }

    public void seeAll(){
        var professors = data.All;

        WriteLine("PROFESSORES: ");

        IRepository<Disciplina> disciRepo = new DisciplinaRepository();
        
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