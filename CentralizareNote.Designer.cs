namespace proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListView1 = new System.Windows.Forms.ListView();
            this.idStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anStudiu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numeDisciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtAnStudiu = new System.Windows.Forms.TextBox();
            this.txtSpecializare = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtGrupa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeDisciplina = new System.Windows.Forms.TextBox();
            this.txtNrCredite = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.salveaza = new System.Windows.Forms.Button();
            this.Deschide = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.validare = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.AllowDrop = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idStudent,
            this.nume,
            this.anStudiu,
            this.specializare,
            this.serie,
            this.grupa,
            this.numeDisciplina,
            this.credite,
            this.nota});
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(12, 46);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(984, 398);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // idStudent
            // 
            this.idStudent.Text = "Id";
            this.idStudent.Width = 72;
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            this.nume.Width = 149;
            // 
            // anStudiu
            // 
            this.anStudiu.Text = "An studiu";
            this.anStudiu.Width = 74;
            // 
            // specializare
            // 
            this.specializare.Text = "Specializare";
            this.specializare.Width = 139;
            // 
            // serie
            // 
            this.serie.Text = "Serie";
            this.serie.Width = 56;
            // 
            // grupa
            // 
            this.grupa.Text = "Grupa";
            this.grupa.Width = 86;
            // 
            // numeDisciplina
            // 
            this.numeDisciplina.Text = "Nume disciplina";
            this.numeDisciplina.Width = 182;
            // 
            // credite
            // 
            this.credite.Text = "Credite";
            this.credite.Width = 75;
            // 
            // nota
            // 
            this.nota.Text = "Nota";
            this.nota.Width = 79;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.printToolStripMenuItem,
            this.graficToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(1253, 71);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(206, 22);
            this.txtIdStudent.TabIndex = 2;
            this.txtIdStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdStudent_KeyDown);
            this.txtIdStudent.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdStudent_Validating);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(1253, 112);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(206, 22);
            this.txtNume.TabIndex = 3;
            this.txtNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNume_KeyDown);
            this.txtNume.Validating += new System.ComponentModel.CancelEventHandler(this.txtNume_Validating);
            // 
            // txtAnStudiu
            // 
            this.txtAnStudiu.Location = new System.Drawing.Point(1253, 152);
            this.txtAnStudiu.Name = "txtAnStudiu";
            this.txtAnStudiu.Size = new System.Drawing.Size(206, 22);
            this.txtAnStudiu.TabIndex = 4;
            this.txtAnStudiu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnStudiu_KeyDown);
            this.txtAnStudiu.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnStudiu_Validating);
            // 
            // txtSpecializare
            // 
            this.txtSpecializare.Location = new System.Drawing.Point(1253, 197);
            this.txtSpecializare.Name = "txtSpecializare";
            this.txtSpecializare.Size = new System.Drawing.Size(206, 22);
            this.txtSpecializare.TabIndex = 5;
            this.txtSpecializare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpecializare_KeyDown);
            this.txtSpecializare.Validating += new System.ComponentModel.CancelEventHandler(this.txtSpecializare_Validating);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(1253, 240);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(206, 22);
            this.txtSerie.TabIndex = 6;
            this.txtSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerie_KeyDown);
            this.txtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerie_Validating);
            // 
            // txtGrupa
            // 
            this.txtGrupa.Location = new System.Drawing.Point(1253, 285);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.Size = new System.Drawing.Size(206, 22);
            this.txtGrupa.TabIndex = 7;
            this.txtGrupa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrupa_KeyDown);
            this.txtGrupa.Validating += new System.ComponentModel.CancelEventHandler(this.txtGrupa_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1137, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1137, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1137, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "An studiu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1137, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Specializare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1137, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Serie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1137, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grupa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1137, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nume disciplina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1137, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Numar de credite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1137, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nota";
            // 
            // txtNumeDisciplina
            // 
            this.txtNumeDisciplina.Location = new System.Drawing.Point(1253, 333);
            this.txtNumeDisciplina.Name = "txtNumeDisciplina";
            this.txtNumeDisciplina.Size = new System.Drawing.Size(206, 22);
            this.txtNumeDisciplina.TabIndex = 17;
            this.txtNumeDisciplina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeDisciplina_KeyDown);
            this.txtNumeDisciplina.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeDisciplina_Validating);
            // 
            // txtNrCredite
            // 
            this.txtNrCredite.Location = new System.Drawing.Point(1253, 382);
            this.txtNrCredite.Name = "txtNrCredite";
            this.txtNrCredite.Size = new System.Drawing.Size(206, 22);
            this.txtNrCredite.TabIndex = 18;
            this.txtNrCredite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNrCredite_KeyDown);
            this.txtNrCredite.Validating += new System.ComponentModel.CancelEventHandler(this.txtNrCredite_Validating);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(1253, 428);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(206, 22);
            this.txtNota.TabIndex = 19;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // salveaza
            // 
            this.salveaza.Location = new System.Drawing.Point(389, 454);
            this.salveaza.Name = "salveaza";
            this.salveaza.Size = new System.Drawing.Size(97, 46);
            this.salveaza.TabIndex = 20;
            this.salveaza.Text = "Salveaza";
            this.salveaza.UseVisualStyleBackColor = true;
            this.salveaza.Click += new System.EventHandler(this.salveaza_Click);
            // 
            // Deschide
            // 
            this.Deschide.Location = new System.Drawing.Point(561, 454);
            this.Deschide.Name = "Deschide";
            this.Deschide.Size = new System.Drawing.Size(97, 46);
            this.Deschide.TabIndex = 21;
            this.Deschide.Text = "Deschide";
            this.Deschide.UseVisualStyleBackColor = true;
            this.Deschide.Click += new System.EventHandler(this.Deschide_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // validare
            // 
            this.validare.Location = new System.Drawing.Point(1307, 456);
            this.validare.Name = "validare";
            this.validare.Size = new System.Drawing.Size(97, 46);
            this.validare.TabIndex = 22;
            this.validare.Text = "Validare";
            this.validare.UseVisualStyleBackColor = true;
            this.validare.Click += new System.EventHandler(this.validare_Click);
            this.validare.Validating += new System.ComponentModel.CancelEventHandler(this.validare_Validating);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(872, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "nume"});
            this.listBox1.Location = new System.Drawing.Point(70, 448);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 512);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.validare);
            this.Controls.Add(this.Deschide);
            this.Controls.Add(this.salveaza);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtNrCredite);
            this.Controls.Add(this.txtNumeDisciplina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtSpecializare);
            this.Controls.Add(this.txtAnStudiu);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtAnStudiu;
        private System.Windows.Forms.TextBox txtSpecializare;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtGrupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeDisciplina;
        private System.Windows.Forms.TextBox txtNrCredite;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button salveaza;
        private System.Windows.Forms.ColumnHeader idStudent;
        private System.Windows.Forms.ColumnHeader nume;
        private System.Windows.Forms.ColumnHeader anStudiu;
        private System.Windows.Forms.ColumnHeader specializare;
        private System.Windows.Forms.ColumnHeader serie;
        private System.Windows.Forms.ColumnHeader grupa;
        private System.Windows.Forms.ColumnHeader numeDisciplina;
        private System.Windows.Forms.ColumnHeader credite;
        private System.Windows.Forms.ColumnHeader nota;
        private System.Windows.Forms.Button Deschide;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button validare;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
    }
}

