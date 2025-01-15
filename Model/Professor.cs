using System.Collections.Generic;
using Database;

namespace Model;

public class Professor : DatabaseObject
{
    
    public string Nome { get; set; }
    public string Formacao { get; set; }
    public List<Diciplina> diciplinas { get; set; }

    protected override void LoadFrom(string[] data)
    {
        Nome = data[0];
        Formacao = data[1];
    }

    protected override string[] SaveTo()
        => new string[]
            {
                Nome,
                Formacao
            };
}