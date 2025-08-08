
//I want to put on a music festival called Boolean Fest
//I want to know a Line Up of Bands that play Boolean Fest
//I want to list all band members that play Boolean Fest
//Band members have skills like singer, lead guitarist, bass, guitarist
//Band members could be known as either their firstname and surname or nickname
//To work out who should be headlining the festival, i want to list bands by the total networth of members

//rhcp
using workshop.console;

Person anthony = new Person("Anthony", "Kiedis", Skill.Singer, 10000000);
Person chad = new Person("Chad", "Smith", Skill.Drums, 11000000);
Person john = new Person("John", "Frusciante", Skill.LeadGuitarist, 4000000);
Person flea = new Person("Flea", Skill.Bass, 9000000);

Band rhcp = new Band("RedHotChilliPeppers", new List<Person>() { anthony, chad, john, flea });

rhcp.Members.Add(new Person("Sibbs", Skill.LeadGuitarist, 250000000));



rhcp.Members.ForEach(person =>Console.WriteLine(person.KnownAs));

foreach(Person person in rhcp.Members)
{
    Console.WriteLine(person.KnownAs);
}