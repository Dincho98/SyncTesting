﻿namespace PCPOS.Robno
{
    partial class frmZapisnikopromjeniCijene
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZapisnikopromjeniCijene));
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSveFakture = new System.Windows.Forms.Button();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIzradio = new System.Windows.Forms.TextBox();
            this.txtBrojInventure = new System.Windows.Forms.TextBox();
            this.nmGodinaInventure = new System.Windows.Forms.NumericUpDown();
            this.cbSkladiste = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSifra_robe = new System.Windows.Forms.TextBox();
            this.btnOpenRoba = new System.Windows.Forms.PictureBox();
            this.br = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stara_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postotak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nova_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_stavka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodinaInventure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.br,
            this.sifra,
            this.naziv,
            this.stara_cijena,
            this.postotak,
            this.nova_cijena,
            this.pdv,
            this.iznos,
            this.kolicina,
            this.id_stavka});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgw.GridColor = System.Drawing.Color.Gainsboro;
            this.dgw.Location = new System.Drawing.Point(10, 232);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgw.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(979, 306);
            this.dgw.TabIndex = 8;
            this.dgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            this.dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEndEdit);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnObrisi.Image = global::PCPOS.Properties.Resources.Close;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Location = new System.Drawing.Point(858, 196);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 30);
            this.btnObrisi.TabIndex = 121;
            this.btnObrisi.Text = "   Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::PCPOS.Properties.Resources.Actions_application_exit_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(858, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Izlaz      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSveFakture
            // 
            this.btnSveFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSveFakture.Image = global::PCPOS.Properties.Resources._10591;
            this.btnSveFakture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveFakture.Location = new System.Drawing.Point(423, 10);
            this.btnSveFakture.Name = "btnSveFakture";
            this.btnSveFakture.Size = new System.Drawing.Size(130, 40);
            this.btnSveFakture.TabIndex = 12;
            this.btnSveFakture.Text = "Svi zapisnici  ";
            this.btnSveFakture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSveFakture.UseVisualStyleBackColor = true;
            this.btnSveFakture.Click += new System.EventHandler(this.btnSveFakture_Click);
            // 
            // btnNoviUnos
            // 
            this.btnNoviUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNoviUnos.Image = global::PCPOS.Properties.Resources.folder_open_icon;
            this.btnNoviUnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviUnos.Location = new System.Drawing.Point(9, 10);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(130, 40);
            this.btnNoviUnos.TabIndex = 9;
            this.btnNoviUnos.Text = "Novi unos   ";
            this.btnNoviUnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoviUnos.UseVisualStyleBackColor = true;
            this.btnNoviUnos.Click += new System.EventHandler(this.btnNoviUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOdustani.Image = global::PCPOS.Properties.Resources.undo;
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(147, 10);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 40);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani   ";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpremi.Location = new System.Drawing.Point(285, 10);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 40);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi   ";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Enabled = false;
            this.rtbNapomena.Location = new System.Drawing.Point(466, 95);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(239, 62);
            this.rtbNapomena.TabIndex = 5;
            this.rtbNapomena.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Broj unosa:";
            // 
            // txtIzradio
            // 
            this.txtIzradio.BackColor = System.Drawing.Color.White;
            this.txtIzradio.Enabled = false;
            this.txtIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIzradio.Location = new System.Drawing.Point(466, 66);
            this.txtIzradio.Name = "txtIzradio";
            this.txtIzradio.ReadOnly = true;
            this.txtIzradio.Size = new System.Drawing.Size(239, 26);
            this.txtIzradio.TabIndex = 4;
            // 
            // txtBrojInventure
            // 
            this.txtBrojInventure.BackColor = System.Drawing.Color.White;
            this.txtBrojInventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBrojInventure.Location = new System.Drawing.Point(109, 71);
            this.txtBrojInventure.Name = "txtBrojInventure";
            this.txtBrojInventure.Size = new System.Drawing.Size(121, 26);
            this.txtBrojInventure.TabIndex = 0;
            this.txtBrojInventure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrojInventure_KeyDown);
            // 
            // nmGodinaInventure
            // 
            this.nmGodinaInventure.BackColor = System.Drawing.Color.White;
            this.nmGodinaInventure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmGodinaInventure.Location = new System.Drawing.Point(231, 71);
            this.nmGodinaInventure.Name = "nmGodinaInventure";
            this.nmGodinaInventure.Size = new System.Drawing.Size(85, 26);
            this.nmGodinaInventure.TabIndex = 1;
            this.nmGodinaInventure.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrojInventure_KeyDown);
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSkladiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSkladiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkladiste.Enabled = false;
            this.cbSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(109, 100);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(207, 28);
            this.cbSkladiste.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatum.Location = new System.Drawing.Point(109, 131);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(207, 26);
            this.dtpDatum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Šifra artikla:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Datum naloga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(385, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "Izradio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(385, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Napomena:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(6, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 112;
            this.label17.Text = "Skladište:";
            // 
            // txtSifra_robe
            // 
            this.txtSifra_robe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSifra_robe.Location = new System.Drawing.Point(9, 200);
            this.txtSifra_robe.Name = "txtSifra_robe";
            this.txtSifra_robe.Size = new System.Drawing.Size(237, 26);
            this.txtSifra_robe.TabIndex = 6;
            this.txtSifra_robe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifra_robe_KeyDown);
            // 
            // btnOpenRoba
            // 
            this.btnOpenRoba.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRoba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRoba.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRoba.Image")));
            this.btnOpenRoba.Location = new System.Drawing.Point(249, 195);
            this.btnOpenRoba.Name = "btnOpenRoba";
            this.btnOpenRoba.Size = new System.Drawing.Size(39, 31);
            this.btnOpenRoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenRoba.TabIndex = 122;
            this.btnOpenRoba.TabStop = false;
            this.btnOpenRoba.Click += new System.EventHandler(this.btnOpenRoba_Click_1);
            // 
            // br
            // 
            this.br.FillWeight = 30F;
            this.br.HeaderText = "Broj";
            this.br.Name = "br";
            this.br.ReadOnly = true;
            // 
            // sifra
            // 
            this.sifra.FillWeight = 70.38838F;
            this.sifra.HeaderText = "Šifra";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.FillWeight = 150F;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // stara_cijena
            // 
            this.stara_cijena.HeaderText = "Stara cijena";
            this.stara_cijena.Name = "stara_cijena";
            this.stara_cijena.ReadOnly = true;
            // 
            // postotak
            // 
            this.postotak.HeaderText = "Postotak%";
            this.postotak.Name = "postotak";
            // 
            // nova_cijena
            // 
            this.nova_cijena.HeaderText = "Nova cijena";
            this.nova_cijena.Name = "nova_cijena";
            // 
            // pdv
            // 
            this.pdv.HeaderText = "PDV";
            this.pdv.Name = "pdv";
            this.pdv.ReadOnly = true;
            // 
            // iznos
            // 
            this.iznos.HeaderText = "Iznos";
            this.iznos.Name = "iznos";
            this.iznos.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // id_stavka
            // 
            this.id_stavka.HeaderText = "id_stavka";
            this.id_stavka.Name = "id_stavka";
            this.id_stavka.Visible = false;
            // 
            // frmZapisnikopromjeniCijene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 545);
            this.Controls.Add(this.btnOpenRoba);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSveFakture);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.rtbNapomena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIzradio);
            this.Controls.Add(this.txtBrojInventure);
            this.Controls.Add(this.nmGodinaInventure);
            this.Controls.Add(this.cbSkladiste);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSifra_robe);
            this.Name = "frmZapisnikopromjeniCijene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapisnik o promjeni cijene";
            this.Load += new System.EventHandler(this.frmZapisnikopromjeniCijene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodinaInventure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSveFakture;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIzradio;
        public System.Windows.Forms.TextBox txtBrojInventure;
        private System.Windows.Forms.NumericUpDown nmGodinaInventure;
        private System.Windows.Forms.ComboBox cbSkladiste;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSifra_robe;
        private System.Windows.Forms.PictureBox btnOpenRoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn br;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stara_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn postotak;
        private System.Windows.Forms.DataGridViewTextBoxColumn nova_cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stavka;
    }
}