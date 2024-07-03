public class Saving
{
    public List<string> _currententry = new List<string>();
    public string _filename;
       
    
    public void ToTxt(List<Prompts> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Prompts p in entries)
            {
                outputFile.WriteLine($"{p._datenow}|{p._pickedq}|{p._J_entry}|");
            }
        }
    }
    public List<Prompts> FromTxt()
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);
        List<Prompts> result = new List<Prompts>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Prompts p = new Prompts();
            p._datenow = parts[0];
            p._pickedq = parts[1];
            p._J_entry = parts[2];
            result.Add(p);

        }
        return result;
    }
}
