using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Slektstre
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int? BirthYear;
        public int? DeathYear;
        public int Id;

        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            var text = "";
            if (FirstName != null) text += $"{FirstName} ";
            if (LastName != null) text += $"{LastName} ";
            text += $"(Id={Id}) ";
            if (BirthYear != null) text += $"Født: {BirthYear} ";
            if (DeathYear != null) text += $"Død: {DeathYear} ";

            if (Father != null) text += GetParentDescription();
            if (Mother != null) text += GetParentDescription(false);

            return text.Trim();
        }

        private string GetParentDescription(bool isFather = true)
        {
            var parent = isFather ? Father : Mother;
            var parentString = isFather ? "Far: " : "Mor: ";
            return $"{parentString}{parent.FirstName} (Id={parent.Id}) ";
        }
    }
}
// Skal returnere bruker input, blir det noe readlne i en variabel eller to kanskje?
// Skal jeg lage en liste med informasjons feltene, slik at input blir pushet inn i den?
// Er id noe som kommer automatisk uten at brukeren selv legger det inn? Det virker jo sånn med tanke på at hvis ingen av feltene er utfylt returneres alikevel en id.
// Jeg tror id skal være noe som blir lagt til i GetDescription automatisk, så noe++; kanskje?
// Du skal kunne ha muligheten til å vise id til en bestemt person og deres gren av slektstreet, men også en liste over alle med id, navn osv.
// ID må være public da du skal kunne hente den ut mange steder. Det må du kunne med alt egentlig.
// Jeg vil lage en liste med feltene slik at jeg 
// $"{firstName} {userinput} {lastName} {userInput}" etc