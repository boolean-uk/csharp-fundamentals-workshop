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
    }
}
