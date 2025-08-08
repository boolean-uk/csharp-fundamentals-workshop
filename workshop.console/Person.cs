using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    /// <summary>
    /// Class Blueprint for members of a band
    /// </summary>
    public class Person
    {
        
        private string? _firstname;
        private string? _surname;
        private string? _nickname;
        private Skill _specialty;
        private int _networth;
        


        public Person(string nickname, Skill specialty, int networth)
        {
            _nickname = nickname;
            _specialty = specialty;
            _networth = networth;
        }
        public Person(string firstname, string surname, Skill specialty, int networth)
        {
            _firstname = firstname;
            _surname = surname;
            _specialty = specialty;
            _networth = networth;
        } 

        //private methods

        //public methods


        public string KnownAs { get { return _nickname is null ? $"{_firstname} {_surname}" : $"{_nickname}"; } }
        public Skill Specialty { get { return _specialty; } }
        public int NetWorth { get { return _networth; } }
       

    }
}
