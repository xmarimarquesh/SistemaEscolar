using System.Collections.Generic;
using Database;

namespace Model.TurmaRepository;

public class TurmaDBRepository : IRepository<Turma>
{
    protected DBSqlServer<Turma> db;
    public TurmaDBRepository()
    {
        db = new DBSqlServer<Turma>(
            "CA-C-0064P\\SQLEXPRESS",
            "SistemaEscolar"
        );
    }
    public List<Turma> All => db.All;

    public void Add(Turma obj)
    {
        db.Save(obj);
    }

    public Turma getById(string id)
    {
        throw new System.NotImplementedException();
    }

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
}