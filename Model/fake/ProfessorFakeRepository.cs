using System.Collections.Generic;

namespace Model;

public class ProfessorFakeRepository : IRepository<Professor>
{
    List<Professor> professores = [];

    public ProfessorFakeRepository()
    {
        professores.Add(new(){
            Nome = "Pedro", 
            Formacao = "Lecionador",
            IDDisciplina = "1"
        });

        professores.Add(new(){
            Nome = "Joao", 
            Formacao = "Doutor",
            IDDisciplina = "2"
        });

        
    }
    public void seeAll()
    {
        throw new System.NotImplementedException();
    }
    public List<Professor> All => professores;

    public void Add(Professor obj) 
        => professores.Add(obj);

    public Professor getById(string id)
    {
        throw new System.NotImplementedException();
    }
}