using System.Collections.Generic;
using Model;

public class AlunoFakeRepository : IRepository<Aluno>
{
    List<Aluno> alunos = [];

    public AlunoFakeRepository()
    {
        alunos.Add(new (){
            Id = 1,
            Nome = "Mariana",
            Idade = 18
        });
        alunos.Add(new (){
            Id = 2,
            Nome = "Nickolas",
            Idade = 21
        });
    }

    public List<Aluno> All => alunos;

    public void Add(Aluno obj)
        => alunos.Add(obj);

    public Aluno findById(int id){
        foreach (var aluno in alunos){
            if(aluno.Id == id){
                return aluno;
            }
        }
        return null;
    }
}