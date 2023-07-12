using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtIdStudent;
            txtIdStudent.Focus();

            Centralizator c1 = new Centralizator(1, "Ionel Teodor", 2, "Infornatica Economica", 'D', 1053, "Analiza Matematica", 5, 8);
            ListViewItem item1 = new ListViewItem(c1.idStudent.ToString());
            item1.SubItems.Add(c1.nume);
            item1.SubItems.Add(c1.anStudiu.ToString());
            item1.SubItems.Add(c1.specializare);
            item1.SubItems.Add(c1.serie.ToString());
            item1.SubItems.Add(c1.grupa.ToString());
            item1.SubItems.Add(c1.numeDisciplina);
            item1.SubItems.Add(c1.credite.ToString()); 
            item1.SubItems.Add(c1.nota.ToString());
            item1.Tag = c1;

            ListView1.Items.Add(item1);
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            int idStudent = int.Parse(txtIdStudent.Text);
            string nume=txtNume.Text;
            int anStudiu=int.Parse(txtAnStudiu.Text);
            string specializare=txtSpecializare.Text;
            char serie=char.Parse(txtSerie.Text);
            int grupa=int.Parse(txtGrupa.Text);
            string numeDisciplina=txtNumeDisciplina.Text;
            int nrCredite = int.Parse(txtNrCredite.Text);
            int nota=int.Parse(txtNota.Text);

            Centralizator c1= new Centralizator(idStudent, nume, anStudiu, specializare, serie, grupa, numeDisciplina, nrCredite, nota);
            ListViewItem item1= new ListViewItem(c1.idStudent.ToString());
            item1.SubItems.Add(c1.nume);
            item1.SubItems.Add(c1.anStudiu.ToString());
            item1.SubItems.Add(c1.specializare);
            item1.SubItems.Add(c1.serie.ToString());
            item1.SubItems.Add(c1.grupa.ToString());
            item1.SubItems.Add(c1.numeDisciplina);
            item1.SubItems.Add(c1.credite.ToString());
            item1.SubItems.Add(c1.nota.ToString());
            item1.Tag = c1;
            ListView1.Items.Add(item1);
        }

        private void salveaza_Click(object sender, EventArgs e)
        {
            SaveFileDialog f= new SaveFileDialog();
            f.Filter = "Fisiere centralizator *.txt|*.txt ";
            f.CheckPathExists = true;
            if(f.ShowDialog() == DialogResult.OK) 
            {
                List<Centralizator> list = new List<Centralizator>();
                foreach(ListViewItem item in ListView1.Items)
                {
                    list.Add((Centralizator)item.Tag);
                }
                BinaryFormatter serializator = new BinaryFormatter();
                Stream file=File.Create(f.FileName);
                serializator.Serialize(file, list);
                file.Close();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ListView1.SelectedItems.Count > 0) 
            {
                ListViewItem lv = ListView1.SelectedItems[0];
                ListView1.SelectedItems[0].Text = txtIdStudent.Text.ToString();
                ListView1.SelectedItems[0].SubItems[1].Text = txtNume.Text;
                ListView1.SelectedItems[0].SubItems[2].Text = txtAnStudiu.Text.ToString();
                ListView1.SelectedItems[0].SubItems[3].Text = txtSpecializare.Text;
                ListView1.SelectedItems[0].SubItems[4].Text = txtSerie.Text.ToString();
                ListView1.SelectedItems[0].SubItems[5].Text = txtGrupa.Text.ToString();
                ListView1.SelectedItems[0].SubItems[6].Text = txtNumeDisciplina.Text;
                ListView1.SelectedItems[0].SubItems[7].Text = txtNrCredite.Text.ToString();
                ListView1.SelectedItems[0].SubItems[8].Text = txtNota.Text.ToString();
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = ListView1.SelectedItems[0];
                Centralizator c = (Centralizator)lvi.Tag;
                txtIdStudent.Text = c.idStudent.ToString();
                txtNume.Text = c.nume;
                txtAnStudiu.Text = c.anStudiu.ToString();
                txtSpecializare.Text = c.specializare;
                txtSerie.Text = c.serie.ToString();
                txtGrupa.Text = c.grupa.ToString();
                txtNumeDisciplina.Text = c.numeDisciplina;
                txtNrCredite.Text = c.credite.ToString();
                txtNota.Text = c.nota.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView1.SelectedItems[0];
                ListView1.Items.Remove(item);
            }
        }

        private void Deschide_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Fisiere centralizator *.txt|*.txt";
            f.CheckPathExists = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<Centralizator> list = new List<Centralizator>();
                BinaryFormatter serializator = new BinaryFormatter();
                try
                {
                    Stream file = File.OpenRead(f.FileName);
                    list.AddRange((List<Centralizator>)serializator.Deserialize(file));
                    file.Close();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "A aparut o eroare la deschiderea fisierului!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }



                foreach (Centralizator c in list)
                {
                    ListViewItem lv = new ListViewItem(
                        new string[]
                            {c.idStudent.ToString(), c.nume, c.anStudiu.ToString(), c.specializare, c.serie.ToString(), 
                                c.grupa.ToString(), c.numeDisciplina, c.credite.ToString(), c.nota.ToString()});
                    lv.Tag = c;
                    ListView1.Items.Add(lv);
                }
            }
        }

        private void validare_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtIdStudent_Validating(object sender, CancelEventArgs e)
        {
            checkIdStudent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.ContainerControl = this;
            errorProvider2.ContainerControl = this;
            ListView1.AllowDrop = true;
            //ListView1.DragDrop += new DragEventHandler(ListView1_DragDrop);
            //ListView1.DragEnter += new DragEventHandler(ListView1_DragEnter);
        }

        private bool checkIdStudent()
        {
            bool valid = true;
            if (txtIdStudent.Text == "")
            {
                errorProvider1.SetError(txtIdStudent, "Va rog introduceti un id");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(txtIdStudent, "");
            }
            return valid;
        }

        private void txtNume_Validating(object sender, CancelEventArgs e)
        {
            checkNume();
        }

        private bool checkNume()
        {
            bool valid = true;
            if (txtNume.Text == "")
            {
                errorProvider2.SetError(txtNume, "Va rog introduceti un nume");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtNume, "");
            }
            return valid;
        }

        private void txtAnStudiu_Validating(object sender, CancelEventArgs e)
        {
            checkAnStudiu();
        }

        private bool checkAnStudiu()
        {
            bool valid = true;
            if (txtAnStudiu.Text == "")
            {
                errorProvider2.SetError(txtAnStudiu, "Va rog introduceti un an");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtAnStudiu, "");
            }
            return valid;
        }

        private void txtSpecializare_Validating(object sender, CancelEventArgs e)
        {
            checkSpecializare();
        }

        private bool checkSpecializare()
        {
            bool valid = true;
            if(txtSpecializare.Text == "")
            {
                errorProvider2.SetError(txtSpecializare, "Va rog introduceti o specializare");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtSpecializare, "");
            }
            return valid;
        }

        private void txtSerie_Validating(object sender, CancelEventArgs e)
        {
            checkSerie();
        }

        private bool checkSerie()
        {
            bool valid = true;
            if(txtSerie.Text == "")
            {
                errorProvider2.SetError(txtSerie, "Va rog introduceti o serie");
                valid = false;
            }
            else 
            {
                errorProvider2.SetError(txtSerie, "");
            }
            return valid;
        }

        private void txtGrupa_Validating(object sender, CancelEventArgs e)
        {
            checkGrupa();
        }

        private bool checkGrupa()
        {
            bool valid = true;
            if(txtGrupa.Text == "")
            {
                errorProvider2.SetError(txtGrupa, "Va rog introduceti o grupa");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtGrupa, "");
            }
            return valid;
        }

        private void txtNumeDisciplina_Validating(object sender, CancelEventArgs e)
        {
            checkDisciplina();
        }

        private bool checkDisciplina()
        {
            bool valid = true;
            if(txtNumeDisciplina.Text == "")
            {
                errorProvider2.SetError(txtNumeDisciplina, "Va rog introduceti o disciplina");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtNumeDisciplina, "");
            }
            return valid;
        }

        private void txtNrCredite_Validating(object sender, CancelEventArgs e)
        {
            checkCredite();
        }

        private bool checkCredite()
        {
            bool valid = true;
            if(txtNrCredite.Text == "")
            {
                errorProvider2.SetError(txtNrCredite, "Va rog introduceti un numar de credite");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtNrCredite, "");
            }
            return valid;
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            checkNota();
        }

        private bool checkNota()
        {
            bool valid = true;
            if(txtNota.Text == "")
            {
                errorProvider2.SetError(txtNota, "Va rog introduceti o nota");
                valid = false;
            }
            else
            {
                errorProvider2.SetError(txtNota, "");
            }
            return valid;
        }
        private void check()
        {
            bool idStudent = checkIdStudent();
            bool nume = checkNume();
            bool anStudiu = checkAnStudiu();
            bool specializare = checkSpecializare();
            bool serie = checkSerie();
            bool grupa = checkGrupa();
            bool disciplina = checkDisciplina();
            bool credite = checkCredite();
            bool nota = checkNota();
            if (idStudent && nume && anStudiu && specializare && serie && grupa && disciplina && credite && nota) 
            {
                MessageBox.Show("Datele sunt valide!");
            }
            else
            {
                MessageBox.Show("Te rog verifica datele!");
            }
        }

        private void validare_Click(object sender, EventArgs e)
        {
            check();
        }

        private void txtIdStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNume.Focus();
            }
        }

        private void txtNume_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtAnStudiu.Focus();
            }
        }

        private void txtAnStudiu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSpecializare.Focus();
            }
        }

        private void txtSpecializare_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSerie.Focus();
            }
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtGrupa.Focus();
            }
        }

        private void txtGrupa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNumeDisciplina.Focus();
            }
        }

        private void txtNumeDisciplina_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNrCredite.Focus();
            }
        }

        private void txtNrCredite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtNota.Focus();
            }
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Font printFont = new Font("Times New Roman", 12);
            //Brush brush = Brushes.Black;
            //float lineHeight = printFont.GetHeight();
            //float x = e.MarginBounds.Left;
            //float y = e.MarginBounds.Top;

            //string currentDate = DateTime.Now.ToString("dd/mm/yyyy");
            //float dateX = e.MarginBounds.Right - e.Graphics.MeasureString(currentDate, printFont).Width;
            //float dateY = e.MarginBounds.Top;

            //e.Graphics.DrawString(currentDate, printFont, brush, dateX, dateY);
            //Font printFontTitle = new Font("Times New Roman", 16, FontStyle.Bold);
            //Brush brushTitle = Brushes.Black;
            //float lineHeightTitle = printFont.GetHeight();
            //float titleWidth = e.Graphics.MeasureString("Note", printFontTitle).Width;
            //float pageWidth = e.MarginBounds.Width;
            //float x2 = e.MarginBounds.Left + (pageWidth - titleWidth) / 2;
            //float y2 = e.MarginBounds.Top;

            //string title = "Note";
            //e.Graphics.DrawString(title, printFont, brushTitle, x2, y2);
            //y += lineHeightTitle * 5;



            //ListViewItem note = null;
            //foreach (ListViewItem item in ListView1.Items)
            //{
            //    ListViewItem centralizator = ListView1.SelectedItems[0];
            //    string idStudent = centralizator.SubItems[0].Text;
            //    string nume = centralizator.SubItems[1].Text;
            //    string anStudiu = centralizator.SubItems[2].Text;
            //    string specializare = centralizator.SubItems[3].Text;
            //    string serie = centralizator.SubItems[4].Text;
            //    string grupa = centralizator.SubItems[5].Text;
            //    string numeDisciplina = centralizator.SubItems[6].Text;
            //    string nrCredite = centralizator.SubItems[7].Text;
            //    string nota = centralizator.SubItems[8].Text;

            //    e.Graphics.DrawString("ID Student: " + idStudent, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Nume: " + nume, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("An studiu: " + anStudiu, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Specializare: " + specializare, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Serie: " + serie, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Grupa: " + grupa, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Disciplina: " + numeDisciplina, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Numar de credite: " + nrCredite, printFont, brush, x, y);
            //    y += lineHeight;
            //    e.Graphics.DrawString("Nota: " + nota, printFont, brush, x, y);
            //    y += lineHeight;

            //    y += lineHeight * 2;
            //}
            Font printFont = new Font("Times New Roman", 12);
            Brush brush = Brushes.Black;
            float lineHeight = printFont.GetHeight();
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            foreach (ListViewItem item in ListView1.Items)
            {
                string idStudent = item.SubItems[0].Text;
                string nume = item.SubItems[1].Text;
                string anStudiu = item.SubItems[2].Text;
                string specializare = item.SubItems[3].Text;
                string serie = item.SubItems[4].Text;
                string grupa = item.SubItems[5].Text;
                string numeDisciplina = item.SubItems[6].Text;
                string nrCredite = item.SubItems[7].Text;
                string nota = item.SubItems[8].Text;

                string line = $"{idStudent} {nume} {anStudiu} {specializare} {serie} {grupa} {numeDisciplina} {nrCredite} {nota}";

                e.Graphics.DrawString(line, printFont, brush, x, y);

                y += lineHeight;
            }


        }
      
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (ListView1.SelectedItems.Count > 0)
            //{
            //    PrintDocument printDocument = new PrintDocument();
            //    printDocument.PrintPage += printDocument1_PrintPage;
            //    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            //    printPreviewDialog.Document = printDocument;
            //    printPreviewDialog.WindowState = FormWindowState.Maximized;
            //    printPreviewDialog.PrintPreviewControl.Zoom = 1.0;
            //    printPreviewDialog.PrintPreviewControl.AutoZoom = false;
            //    printPreviewDialog.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Nu sunt date de printat!");
            //}
            if (ListView1.Items.Count == 0)
            {
                MessageBox.Show("Nu sunt date de printat!");
                return;
            }

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //private void ListView1_DragDrop(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}

        //private void ListView1_DragEnter(object sender, DragEventArgs e)
        //{
        //    ListView1.Items.Add(e.Data.ToString());
        //}

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            textBox1.Text = data;
            if(e.Effect == DragDropEffects.Copy) 
            {
                listBox1.Items.Remove(data);
            }
           
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = e.AllowedEffect;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedItems.Count > 0)
            {
                lb.DoDragDrop(lb.SelectedItems[0], DragDropEffects.Copy);
            }

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBox1.DataBindings.Clear();
            
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> note = new List<int>();
            List<int> id_uri = new List<int>();
            foreach (ListViewItem item in ListView1.Items) 
            {
                string notaText = item.SubItems[1].Text;
                string idText = item.SubItems[0].Text;
                int nota;
                int id;
                if(int.TryParse(notaText, out nota)) 
                {
                    note.Add(nota);
                }
                if(int.TryParse(idText, out id)) 
                {
                    id_uri.Add(id);
                }
            }
            int[] vector_note = note.ToArray();
            int[] vector_id_uri = id_uri.ToArray();

            int nr_obs = 0;
            foreach (ListViewItem item in ListView1.Items) 
            {
                nr_obs++;
            }
            Grafic form = new Grafic(nr_obs, vector_note, vector_id_uri);
            if(form.ShowDialog()== DialogResult.OK) 
            {
                form.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
