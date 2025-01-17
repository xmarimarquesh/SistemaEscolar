using System.Collections.Generic;

using Database;

namespace Model.ProfessorRepository;

public class ProfessorDBRepository : IRepository<Professor>
{
    protected DBSqlServer<Professor> db;

    public ProfessorDBRepository()
    {
        db = new DBSqlServer<Professor>(
            "CA-C-0064P\\SQLEXPRESS",
            "SistemaEscolar"
        );
    }
    public List<Professor> All => db.All;

    public void Add(Professor obj)
    {
        db.Save(obj);
    }

    public Professor getById(string id)
    {
        throw new System.NotImplementedException();
    }

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
}