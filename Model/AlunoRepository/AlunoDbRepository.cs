using System.Collections.Generic;
using Database;

namespace Model.AlunoRepository;

public class AlunoDBRepository : IRepository<Aluno>
{
    protected DBSqlServer<Aluno> db;
    public AlunoDBRepository()
    {
        db = new DBSqlServer<Aluno>(
            "CA-C-0064P\\SQLEXPRESS",
            "SistemaEscolar"
        );
    }
    public List<Aluno> All => db.All;

    public void Add(Aluno obj)
    {
        db.Save(obj);
    }

    public Aluno getById(string id)
    {
        throw new System.NotImplementedException();
    }

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
}