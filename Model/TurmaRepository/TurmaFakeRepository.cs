using System.Collections.Generic;
using Model;

public class TurmaFakeRepository : IRepository<Turma>
{
    List<Turma> turmas = [];

    public TurmaFakeRepository()
    {
        turmas.Add(new (){
            descricao = "DTA 2",
        });
    }

    public List<Turma> All => turmas;

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
    
    public void Add(Turma obj)
        => turmas.Add(obj);

    public Turma getById(string id)
    {
        throw new System.NotImplementedException();
    }
}