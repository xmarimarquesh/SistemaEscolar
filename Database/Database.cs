using System.Collections.Generic;
using System.Xml.Linq;

namespace Database;

public abstract class Database<T>
{
    private string basePath;
    public string DBPath;
    public List<T> All;
    protected static Database<T> temp = null;
    protected static Database<T> app = null;
    protected static Database<T> custom = null;

    protected abstract List<string> openFile();
    protected abstract bool saveFile(List<string> lines);
    public abstract void Save(List<T> all);
}