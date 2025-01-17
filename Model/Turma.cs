using System.Collections.Generic;
using Database;

namespace Model;

public class Turma : DatabaseObject
{
    public string ID { get; set; }
    public string descricao { get; set; }
    public string IDProf { get; set; }

    public Turma() => ID = GetNewId;

    protected override void LoadFrom(string[] data)
    {   
        ID = data[0];
        descricao = data[1];
        IDProf = data[2];
    }

    protected override string[] SaveTo()
        => new string[]
            {
                ID,
                descricao,
                IDProf
            };
}