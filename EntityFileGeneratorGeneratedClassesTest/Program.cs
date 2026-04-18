// See https://aka.ms/new-console-template for more information
using GeneratedNoitaClasses;
using System.Runtime.CompilerServices;
using System.Text.Json;
List<EntityFile> entities = new List<EntityFile>();

int FailedAt(NoitaStream a, NoitaStream b)
{
    var arr1 = a.ToArray();
    var arr2 = b.ToArray();
    if(arr1.Length != arr2.Length)
    {
        throw new Exception("Length not equal! " + arr1.Length + " " + arr2.Length);
    }

    for(int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            throw new Exception("Failed");
            //Console.WriteLine("The error is at: " + i);
            //return i;
        }
    }
    return -1;
}

int fails = 0;
int successes = 0;

foreach(string filename in Directory.GetFiles("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\", "entities_*.bin"))
{
//    try
//    {
        EntityFile ef = new EntityFile();
        var lzcontent = LZFile.ReadFile(filename);
        ef.Read(lzcontent);
        string entity_json = JsonSerializer.Serialize(ef);//!, typeof(EntityFile), NoitaCSharpJSONSerializer.Default);
        EntityFile ef2 = JsonSerializer.Deserialize<EntityFile>(entity_json);


        NoitaStream memoryStream = new NoitaDebugStream(lzcontent);
        ef2.Write(memoryStream);

        if (FailedAt(lzcontent, memoryStream) != -1)
        {
            //Console.WriteLine("Uh oh stinky " + filename);
        }
        else
        {
            successes++;
            //Console.WriteLine("Perfection " + filename);

        }
    //} catch(Exception e)
    //{
    //    fails++;
    //    Console.WriteLine(e);
    //    throw new Exception("Ah shit");
    //}
}

Console.WriteLine("Successes: " + successes + " Errors " + fails);

//Console.WriteLine("Done!");
//Console.ReadLine();
