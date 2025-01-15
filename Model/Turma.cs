using System.Collections.Generic;
using Database;

namespace Model;

public class Turma : DatabaseObject
{
    public string id_alunos { get; set; }
    public List<Aluno> alunos { get; set; }
    public string descricao { get; set; }

    protected override void LoadFrom(string[] data)
    {   
        id_alunos = data[0];

        AlunoFakeRepository alunoRepo = new AlunoFakeRepository();
        List<Aluno> alunos_list = [];

        foreach(var a in id_alunos){
            Aluno aluno = alunoRepo.findById(int.Parse(a.ToString()));
            if(aluno != null){
                alunos_list.Add(aluno);
            }       
        }

        alunos = alunos_list;
        descricao = data[1];
    }

    protected override string[] SaveTo()
        => new string[]
            {
                descricao,
                id_alunos
            };
}