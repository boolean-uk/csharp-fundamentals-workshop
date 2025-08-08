using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.console;

namespace workshop.tests
{
    public class PersonTest
    {
        [Test]
        public void TestPersonKnownAsIsSibbs()
        {
            //arrange
            Person sibbs = new Person("Sibbs", Skill.LeadGuitarist, 45000000);
            string expected = "Sibbs";
            //act

            //assert
            Assert.That(sibbs.KnownAs == expected);
        }
    }
}
