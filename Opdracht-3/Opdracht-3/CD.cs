using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_3
{
    class CD
    {
        public string uitvoerder;
        public string titel;

        public CD(string Uitvoerder, string Titel)
        {
            uitvoerder = Uitvoerder;
            titel = Titel;
        }
        public CD()
        {
            titel = "Titel";
            uitvoerder = "Uitvoerder";
        }
        //REMEMBER!!
        //Optie 2: (check main)

        //public override string ToString()
        //{
        //    return this.titel + " - " + this.uitvoerder;
        //}
    }
}
