using System.Runtime.CompilerServices;
using JSON;
class Program
{
    static void Main(string[] args)
    {
        string fileName = "C:\\Users\\kwaligorska\\RiderProjects\\JSON\\JSON\\test.json";
        string jsonText = File.ReadAllText(fileName);
        Director? director = Newtonsoft.Json.JsonConvert.DeserializeObject<Director>(jsonText);
    }
}