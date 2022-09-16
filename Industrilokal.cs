using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arv4
{
    internal class Industrilokal : Fastighet
    {
        private string _tillhörFöretag;
        private string _anställda;

        public Industrilokal(string tillhörFöretag, string anställda, int antalKvadratmeter,string adress)
        {
            this._tillhörFöretag = tillhörFöretag;
            this._anställda = anställda;
            this._adress = adress;
            this._antalKvadratmeter = antalKvadratmeter;
        }

        public string GetFastighet()
        {
            return $"Företag: {_tillhörFöretag}\n" +
                   $"Anställda: {_anställda}\n" +
                   $"Adress: {_adress}\n" +
                   $"Kvadratmeter: {_antalKvadratmeter}";
        }
    }
}
