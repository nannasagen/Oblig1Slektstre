using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Slektstre
{
   public class FamilyApp
    {
        public List<Person> People;
        public string WelcomeMessage { get; set; }
        public string CommandPrompt { get; set; }


        public FamilyApp(params Person[] persons)
        {
            People = new List<Person>(persons);
        }


        public string HandleCommand(string? command)
        {
            var text = "";
            var splitCommand = command.Split(" ");
            if (command == "liste")
            {
                foreach (var person in People)
                {
                    text += person.GetDescription();
                    text += "\n";
                }
            }

            if (splitCommand[0] == "vis")
            {
                Person ourPerson = null;
                ourPerson = FindPerson(splitCommand[1]);
                if (ourPerson == null) return "";
                text += ourPerson.GetDescription();
                var kids = FindChildren(ourPerson);
                if (kids.Length == 0) return text;
                text += "\n  Barn:\n";
                foreach (var kid in kids)
                {
                    text += $"    {kid.FirstName} (Id={kid.Id}) Født: {kid.BirthYear}\n";
                }
            }
            return text;
        }

        private Person FindPerson(string s)
        {
            int id = Convert.ToInt32(s);
            foreach (var person in People)
            {
                if (person.Id!= id)continue;
                return person;
            }

            return null;
        }

        private Person[] FindChildren(Person p)
        {
            var kids = new List<Person>();
            foreach (var person in People)
            {
                if (p.Id == person.Father?.Id || p.Id == person.Mother?.Id)
                {
                    kids.Add(person);
                }
            }

            return kids.ToArray();
        }
    }
}
