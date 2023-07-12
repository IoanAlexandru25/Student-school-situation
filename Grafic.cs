using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    [Serializable]
    public partial class Grafic : Form
    {
        int nr_observatii;
        int[] notee;
        int[] id_urii;
        public Grafic(int nr_obs, int[] note, int[] id_uri)
        {
            InitializeComponent();
            textBox1.Text=nr_obs.ToString();
            nr_observatii = nr_obs;
            notee = note;
            id_urii = id_uri;
        }

        private void Grafic_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
