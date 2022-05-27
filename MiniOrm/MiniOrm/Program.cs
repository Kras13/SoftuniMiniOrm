using MiniOrm.Data;

public class StartUp
{
    public static void Main()
    {
        var context = new CourseContext(
            "Server=DESKTOP-6SUDEUL\\SQLEXPRESS;Database=MiniOrm;Trusted_Connection=True;MultipleActiveResultSets=true");

        var selectedPerson = context.People.First();

        // in new branch

        Console.WriteLine(selectedPerson.Name);
    }
}