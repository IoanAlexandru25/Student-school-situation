using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    [Serializable]
    public class Studenti
    {
        public int idStudent;
        public string nume;
        public int anStudiu;
        public string specializare;
        public char serie;
        public int grupa;

        public object Items { get; internal set; }
        

        public Studenti(int idStudent, string nume, int anStudiu, string specializare, char serie, int grupa)
        {
            this.idStudent = idStudent;
            this.nume = nume;
            this.anStudiu = anStudiu;
            this.specializare = specializare;
            this.serie = serie;
            this.grupa = grupa;
        }
        public Studenti()
        {

        }
    }
}
