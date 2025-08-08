
//I want to put on a music festival called Boolean Fest
//To work out who should be headlining the festival, i want to list bands by the total networth of members

//I want to know a Line Up of Bands that play Boolean Fest
//I want to list all band members that play Boolean Fest
//Band members have skills like singer, lead guitarist, bass, guitarist
//Band members could be known as either their firstname and surname or nickname


//rhcp
using System.Globalization;
using workshop.console;

Person anthony = new Person("Anthony", "Kiedis", Skill.Singer, 10000000);
Person chad = new Person("Chad", "Smith", Skill.Drums, 11000000);
Person john = new Person("John", "Frusciante", Skill.LeadGuitarist, 4000000);
Person flea = new Person("Flea", Skill.Bass, 9000000);
Band rhcp = new Band("RedHotChilliPeppers", new List<Person>() { anthony, chad, john, flea });

Person axel = new Person("Axel", "R", Skill.Singer, 10000000);
Person slash = new Person("Slash", Skill.LeadGuitarist, 11000000);
Person izzy = new Person("Izzy", "S", Skill.Guitarist, 1000000);
Person matt = new Person("Matt", "S", Skill.Drums, 1000000);
Band gnr = new Band("Guns and Roses", new List<Person>() { axel, slash, izzy, matt });

Person beard = new Person("Beard", Skill.Singer, 21000000);
Person andy = new Person("Andy", "H", Skill.Drums, 33000000);
Person jon = new Person("Jon", "S", Skill.Bass, 33500000);
Person nigel = new Person("Nigel", "S", Skill.LeadGuitarist, 45000000);
Band emptyreflection = new Band("Empty Reflection", new List<Person>() { beard, andy, jon, nigel });


//could sneak another member into the band and bypass the constructor as we expose the list!
//rhcp.Members.Add(new Person("Sibbs", Skill.LeadGuitarist, 250000000));


BooleanFest booleanfest = new BooleanFest(new List<Band>() { rhcp, emptyreflection, gnr });

booleanfest.BandsByNetWorth.ForEach(band => Console.WriteLine($"{band.Name} {band.BandNetWorth.ToString("C", CultureInfo.GetCultureInfo("en-US"))}"));


rhcp.Members.ForEach(person =>Console.WriteLine(person.KnownAs));

foreach(Person person in rhcp.Members)
{
    Console.WriteLine(person.KnownAs);
}