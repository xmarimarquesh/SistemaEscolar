using System.Collections.Generic;
using Model;
using Database;
using System.IO;
using static System.Console;

public class DisciplinaRepository : IRepository<Disciplina>
{
    private DB<Disciplina> data;

    public DisciplinaRepository()
    {
        data = DB<Disciplina>.App;
        List<Disciplina> disciplinas = data.All;
        data.Save(disciplinas);
    }

    public List<Disciplina> All => data.All;

    public void Add(Disciplina obj){
        List<Disciplina> disciplinas = data.All;
        disciplinas.Add(obj);
        data.Save(disciplinas);
    }

    public Disciplina getById(string id)
    {
        foreach (var disciplina in data.All){
            if (disciplina.ID == id)
                return disciplina;
        }
        return null;
    }

    public void seeAll(){
        var disciplinas = data.All;

        WriteLine("DISCIPLINAS: ");
        foreach (var disci in disciplinas)
        {
            WriteLine($"""
                ID={disci.ID}) | {disci.descricao} - {disci.periodo}° período
                --------------------------------------
            """);
        }
    }
}