using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodeStoel
{
    internal class Stoel
    {
        // Fields (eigenschappen)
        private string _kleur;
        private int _zithoogte;
        private int _vertstellen;

        // Constructor
        public Stoel(string ingegevenKleur, int ingegevenZithoogte, int verstellen)
        {
            _kleur = ingegevenKleur;
            _zithoogte = ingegevenZithoogte;
            _vertstellen = ingegevenZithoogte + verstellen;
        }


        // Functions (handelingen)
        public string kleurtje()
        {
            return "De kleur van de stoel is: " + _kleur;
        }

        public int getZithoogte()
        {
            return _zithoogte;
        }

        public int verstellen()
        {
            return _vertstellen;
        }
    }
}
