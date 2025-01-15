using System.Collections.Generic;
using Model;

public class TurmaFakeRepository : IRepository<Turma>
{
    List<Turma> turmas = [];

    public TurmaFakeRepository()
    {
        turmas.Add(new (){
            descricao = "DTA 2",
            alunos = [new ()
            {
                Id = 1,
                Nome = "Mariana",
                Idade = 12
            }, new() {
                Id = 6,
                Nome = "Juliana",
                Idade = 10
            }],
            
        });
    }

    public List<Turma> All => turmas;

    public void Add(Turma obj)
        => turmas.Add(obj);
}