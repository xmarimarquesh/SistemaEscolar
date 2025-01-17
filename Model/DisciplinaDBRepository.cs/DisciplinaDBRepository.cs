using System.Collections.Generic;
using Database;
using static System.Console;

namespace Model.DisciplinaRepository;

public class DisciplinaDBRepository : IRepository<Disciplina>
{
    protected DBSqlServer<Disciplina> db;
    public DisciplinaDBRepository()
    {
        db = new DBSqlServer<Disciplina>(
            "CA-C-0064P\\SQLEXPRESS",
            "SistemaEscolar"
        );
    }
    public List<Disciplina> All => db.All;

    public void Add(Disciplina obj)
    {
        db.Save(obj);
    }

    public Disciplina getById(string id)
    {
        throw new System.NotImplementedException();
    }

    public void seeAll()
    {
        var disciplinas = All;

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