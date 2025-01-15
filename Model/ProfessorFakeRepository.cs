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
            diciplinas = [new ()
            {
                descricao = "Ingles Básico",
                periodo = 3
            }, new() {
                descricao = "Ingles Avancado",
                periodo = 5
            }]  
        });

        professores.Add(new(){
            Nome = "Joao", 
            Formacao = "Doutor",
            diciplinas = [new ()
            {
                descricao = "Java Básico",
                periodo = 1
            }, new() {
                descricao = "Java Avancado",
                periodo = 2
            }]  
        });

        
    }
    public List<Professor> All => professores;

    public void Add(Professor obj) 
        => professores.Add(obj);

}