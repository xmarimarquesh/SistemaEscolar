using System.Collections.Generic;
using Model;

public class DiciplinaFakeRepository : IRepository<Diciplina>
{
    List<Diciplina> diciplinas = [];

    public DiciplinaFakeRepository()
    {
        diciplinas.Add(new (){
            descricao = "Java Básico",
            periodo = 1
        });

        diciplinas.Add(new (){
            descricao = "Java Avançado",
            periodo = 2
        });
    }
    
    public List<Diciplina> All => diciplinas;

    public void Add(Diciplina obj)
        => diciplinas.Add(obj);
}