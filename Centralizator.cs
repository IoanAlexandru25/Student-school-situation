using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    [Serializable]
    public class Centralizator : Discipline
    {
        public int nota;

        public Centralizator(int idStudent, string nume, int anStudiu, string specializare, char serie, int grupa,
            string numeDisciplina, int credite, int nota) : base(idStudent, nume, anStudiu, specializare, serie, grupa,
                numeDisciplina, credite)
        {
            this.nota = nota;
        }
        public Centralizator() 
        {
            nota = 0;
        }

        
    }
}
