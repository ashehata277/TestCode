


using System.Runtime.CompilerServices;

var p1 = new PersonChild { Id = 1, Name = "Ahmed" ,timeTest = DateTime.Now ,ChildName="Mohamed"};
var p2 = p1.GetClone();



p2.PersonLists.Add(new PersonList { Id = 20, Number = 25 });
p2.timeTest=p2.timeTest.AddDays(10);


Console.ReadKey();
public record Person 
{
    public Person()
    {
        PersonLists.Add(new PersonList { Id = 10, Number = 15 });
        PersonLists.Add(new PersonList { Id = 15, Number = 20 });
    }
    public int Id { get; init; }
    public string Name { get; init; }
    public DateTime timeTest { get; set; }
    public TimeOnly time { get; set; }
    public DateOnly dateOnly{ get; set; }
    public List<PersonList> PersonLists { get; set; } = new List<PersonList>();


    public Person GetClone()
    {
        var newInstance = this with { PersonLists = new List<PersonList>() };
        newInstance.PersonLists.AddRange(PersonLists);
        return newInstance;
    }
}
public record PersonList 
{
    public int Id { get; init; }
    public int Number { get; init; }
}


public record PersonChild  : Person
{
    public string ChildName { get; set; }
}



