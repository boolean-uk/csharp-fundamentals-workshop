using workshop.console;

namespace workshop.tests;

public class BandTests
{   

    [Test]
    public void CheckBandHasMembers()
    {
        Person beard = new Person("Beard", Skill.Singer, 21000000);
        Person andy = new Person("Andy", "H", Skill.Drums, 33000000);
        Person jon = new Person("Jon", "S", Skill.Bass, 33500000);
        Person nigel = new Person("Nigel", "S", Skill.LeadGuitarist, 45000000);
        Band emptyreflection = new Band("Empty Reflection", new List<Person>() { beard, andy, jon, nigel });

        Assert.That(emptyreflection.Members.Count, Is.EqualTo(4));
    }

}
