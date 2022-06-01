using MiniOrm.Data;

public class StartUp
{
    public static void Main()
    {
        string ssmsConnectionString =
            "Server=DESKTOP-6SUDEUL\\SQLEXPRESS;Database=MiniOrm;Trusted_Connection=True;MultipleActiveResultSets=true";

        var context = new CourseContext(ssmsConnectionString);

        var selectedPerson = context.People.First();
        var allPeople = context.People.ToArray();

        foreach (var person in allPeople)
        {
            Console.WriteLine(person.Name + " lives in " + person.Town.Name);
        }


        Console.WriteLine(selectedPerson.Name);
    }
}