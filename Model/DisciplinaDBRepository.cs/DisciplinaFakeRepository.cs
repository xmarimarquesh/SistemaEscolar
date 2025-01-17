using System.Collections.Generic;
using Model;

public class DisciplinaFakeRepository : IRepository<Disciplina>
{
    List<Disciplina> disciplinas = [];

    public DisciplinaFakeRepository()
    {
        disciplinas.Add(new (){
            descricao = "Java Básico",
            periodo = 1
        });

        disciplinas.Add(new (){
            descricao = "Java Avançado",
            periodo = 2
        });
    }

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
    
    public List<Disciplina> All => disciplinas;

    public void Add(Disciplina obj)
        => disciplinas.Add(obj);

    public Disciplina getById(string id)
    {
        throw new System.NotImplementedException();
    }
}