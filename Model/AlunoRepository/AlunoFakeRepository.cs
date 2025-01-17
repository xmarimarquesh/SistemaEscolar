using System.Collections.Generic;
using Model;

public class AlunoFakeRepository : IRepository<Aluno>
{
    List<Aluno> alunos = [];

    public AlunoFakeRepository()
    {
        alunos.Add(new (){
            Nome = "Mariana",
            Idade = 18
        });
        alunos.Add(new (){
            Nome = "Nickolas",
            Idade = 21
        });
    }

    public List<Aluno> All => alunos;

    public void Add(Aluno obj)
        => alunos.Add(obj);

    public Aluno getById(string id)
    {
        throw new System.NotImplementedException();
    }

    public void seeAll()
    {
        throw new System.NotImplementedException();
    }

    // public Aluno findById(int id){
    //     foreach (var aluno in alunos){
    //         if(aluno.Id == id){
    //             return aluno;
    //         }
    //     }
    //     return null;
    // }
}