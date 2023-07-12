using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    [Serializable]
    public class Discipline : Studenti
    {
        public string numeDisciplina;
        public int credite;

        public object Items { get; internal set; }

        public Discipline(int idStudent, string nume, int anStudiu, string specializare, char serie, int grupa,
            string numeDisciplina, int credite) : base(idStudent, nume, anStudiu, specializare, serie, grupa)
        {
            this.numeDisciplina = numeDisciplina;
            this.credite = credite;
        }

        public Discipline() 
        {

        }
    }
}
