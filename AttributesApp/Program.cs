using AttributesApp.Attributes;
// See https://aka.ms/new-console-template for more information
using AttributesApp.Models;
using System.Reflection;

var updates = new Update[] { new Update(1, "Security Updates."), new Update(2, "Enhancment Update.") };

updates.Download();
//updates.Install();
updates.UpdateAndInstall();
/********************************************/
var players = new List<Player>
{
    new Player
    {
        Id= 1,Name="Abed", BallControll=10, Dribbling=20, Passing=3000, Power= 0, Speed=1500 }
};

foreach (var player in players)
{
    var errors = new List<Error>();

    var properties = player.GetType().GetProperties();
    foreach (var property in properties)
    {
        var skillAttributes = property.GetCustomAttribute<SkillAttribute>();
        if (skillAttributes is not null)
        {
            var value = property.GetValue(player);
            if (!skillAttributes.IsValid(value))
                errors.Add(new Error(property.Name, $"Invalid value: {value}, Accepted Range is {skillAttributes.Min}-{skillAttributes.Max}"));
        }
    }

    if (!errors.Any())
        Console.WriteLine("all player values accepted");
    else
    {
        foreach (var error in errors)
        {
            Console.WriteLine(error.ToString());
        }
    }
}



Console.ReadLine();