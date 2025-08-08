using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    public class Band
    {
        private string _name;
        private List<Person> _members;

        public Band(string name, List<Person> members)
        {
            _name = name;
            _members = members;
        }
        public List<Person> Members { get { return _members; } }
        public int BandNetWorth { get { return _members.Sum(person => person.NetWorth); } }
        public string Name { get { return _name; } }
        public List<Person> Search(string query)
        {
            List<Person> results = _members.Where(member => member.KnownAs.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

            return results;
        }
    }
}
