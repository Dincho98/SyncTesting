﻿namespace PCPOS
{
    partial class frmOtpremnicaNaSkladiste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOtpremnicaNaSkladiste));
            this.lblNaDan = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSifra_robe = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbPos_partner = new System.Windows.Forms.GroupBox();
            this.cmbSkladisteDo = new System.Windows.Forms.ComboBox();
            this.rtbNapomena = new System.Windows.Forms.TextBox();
            this.chbSNBC = new System.Windows.Forms.CheckBox();
            this.chbBezPdVa = new System.Windows.Forms.CheckBox();
            this.cbKomercijalist = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbOtprema = new System.Windows.Forms.ComboBox();
            this.cbVD = new System.Windows.Forms.ComboBox();
            this.cbIzjava = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtIzradio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSkladiste = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojOtpremnice = new System.Windows.Forms.TextBox();
            this.nmGodinaOtpremnice = new System.Windows.Forms.NumericUpDown();
            this.dgw = new PCPOS.frmOtpremnicaNaSkladiste.MyDataGrid();
            this.label18 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOpenRoba = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteAllFaktura = new System.Windows.Forms.Button();
            this.btnSveFakture = new System.Windows.Forms.Button();
            this.btnNoviUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.br = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rabat_iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_bez_pdva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos_bez_pdva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos_ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_stavka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_roba_prodaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduzmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porez_potrosnja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPos_partner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodinaOtpremnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaDan
            // 
            this.lblNaDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNaDan.AutoSize = true;
            this.lblNaDan.BackColor = System.Drawing.Color.Transparent;
            this.lblNaDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaDan.Location = new System.Drawing.Point(18, 570);
            this.lblNaDan.Name = "lblNaDan";
            this.lblNaDan.Size = new System.Drawing.Size(0, 13);
            this.lblNaDan.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(307, 551);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(155, 23);
            this.textBox3.TabIndex = 102;
            this.textBox3.Text = "PDV:";
            // 
            // txtSifra_robe
            // 
            this.txtSifra_robe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSifra_robe.Location = new System.Drawing.Point(12, 274);
            this.txtSifra_robe.Name = "txtSifra_robe";
            this.txtSifra_robe.Size = new System.Drawing.Size(187, 26);
            this.txtSifra_robe.TabIndex = 32;
            this.txtSifra_robe.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.txtSifra_robe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifra_robe_KeyDown);
            this.txtSifra_robe.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(468, 551);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(189, 23);
            this.textBox2.TabIndex = 101;
            this.textBox2.Text = "Bez PDV-a:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(663, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 23);
            this.textBox1.TabIndex = 100;
            this.textBox1.Text = "Ukupno sa PDV-om:";
            // 
            // rbPos_partner
            // 
            this.rbPos_partner.BackColor = System.Drawing.Color.Transparent;
            this.rbPos_partner.Controls.Add(this.cmbSkladisteDo);
            this.rbPos_partner.Controls.Add(this.rtbNapomena);
            this.rbPos_partner.Controls.Add(this.chbSNBC);
            this.rbPos_partner.Controls.Add(this.chbBezPdVa);
            this.rbPos_partner.Controls.Add(this.cbKomercijalist);
            this.rbPos_partner.Controls.Add(this.label12);
            this.rbPos_partner.Controls.Add(this.cbOtprema);
            this.rbPos_partner.Controls.Add(this.cbVD);
            this.rbPos_partner.Controls.Add(this.cbIzjava);
            this.rbPos_partner.Controls.Add(this.label13);
            this.rbPos_partner.Controls.Add(this.dtpDatum);
            this.rbPos_partner.Controls.Add(this.label11);
            this.rbPos_partner.Controls.Add(this.label8);
            this.rbPos_partner.Controls.Add(this.label24);
            this.rbPos_partner.Controls.Add(this.label17);
            this.rbPos_partner.Controls.Add(this.label4);
            this.rbPos_partner.Controls.Add(this.label28);
            this.rbPos_partner.Controls.Add(this.txtIzradio);
            this.rbPos_partner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPos_partner.Location = new System.Drawing.Point(12, 109);
            this.rbPos_partner.Name = "rbPos_partner";
            this.rbPos_partner.Size = new System.Drawing.Size(998, 142);
            this.rbPos_partner.TabIndex = 24;
            this.rbPos_partner.TabStop = false;
            // 
            // cmbSkladisteDo
            // 
            this.cmbSkladisteDo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSkladisteDo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSkladisteDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkladisteDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSkladisteDo.FormattingEnabled = true;
            this.cmbSkladisteDo.Location = new System.Drawing.Point(100, 15);
            this.cmbSkladisteDo.Name = "cmbSkladisteDo";
            this.cmbSkladisteDo.Size = new System.Drawing.Size(208, 24);
            this.cmbSkladisteDo.TabIndex = 108;
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Location = new System.Drawing.Point(416, 15);
            this.rtbNapomena.Multiline = true;
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.rtbNapomena.Size = new System.Drawing.Size(208, 112);
            this.rtbNapomena.TabIndex = 13;
            this.rtbNapomena.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.rtbNapomena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbNapomena_KeyDown_1);
            this.rtbNapomena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbNapomena_KeyPress);
            this.rtbNapomena.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // chbSNBC
            // 
            this.chbSNBC.AutoSize = true;
            this.chbSNBC.Checked = true;
            this.chbSNBC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSNBC.Enabled = false;
            this.chbSNBC.Location = new System.Drawing.Point(338, 84);
            this.chbSNBC.Name = "chbSNBC";
            this.chbSNBC.Size = new System.Drawing.Size(271, 21);
            this.chbSNBC.TabIndex = 107;
            this.chbSNBC.Text = "Izradi otpremnicu s nabavnim cijenama";
            this.chbSNBC.UseVisualStyleBackColor = true;
            this.chbSNBC.Visible = false;
            this.chbSNBC.CheckedChanged += new System.EventHandler(this.chbSNBC_CheckedChanged);
            // 
            // chbBezPdVa
            // 
            this.chbBezPdVa.AutoSize = true;
            this.chbBezPdVa.Enabled = false;
            this.chbBezPdVa.Location = new System.Drawing.Point(338, 57);
            this.chbBezPdVa.Name = "chbBezPdVa";
            this.chbBezPdVa.Size = new System.Drawing.Size(202, 21);
            this.chbBezPdVa.TabIndex = 106;
            this.chbBezPdVa.Text = "Izradi otpremnicu bez pdv-a";
            this.chbBezPdVa.UseVisualStyleBackColor = true;
            this.chbBezPdVa.Visible = false;
            this.chbBezPdVa.CheckedChanged += new System.EventHandler(this.chbBezPdVa_CheckedChanged);
            // 
            // cbKomercijalist
            // 
            this.cbKomercijalist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbKomercijalist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKomercijalist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKomercijalist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbKomercijalist.FormattingEnabled = true;
            this.cbKomercijalist.Location = new System.Drawing.Point(780, 15);
            this.cbKomercijalist.Name = "cbKomercijalist";
            this.cbKomercijalist.Size = new System.Drawing.Size(208, 24);
            this.cbKomercijalist.TabIndex = 14;
            this.cbKomercijalist.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.cbKomercijalist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbKomercijalist_KeyDown);
            this.cbKomercijalist.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(675, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Komercijalista:";
            // 
            // cbOtprema
            // 
            this.cbOtprema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOtprema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOtprema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtprema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbOtprema.FormattingEnabled = true;
            this.cbOtprema.Location = new System.Drawing.Point(780, 74);
            this.cbOtprema.Name = "cbOtprema";
            this.cbOtprema.Size = new System.Drawing.Size(208, 24);
            this.cbOtprema.TabIndex = 16;
            this.cbOtprema.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.cbOtprema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbOtprema_KeyDown);
            this.cbOtprema.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // cbVD
            // 
            this.cbVD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbVD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbVD.FormattingEnabled = true;
            this.cbVD.Location = new System.Drawing.Point(100, 44);
            this.cbVD.Name = "cbVD";
            this.cbVD.Size = new System.Drawing.Size(208, 24);
            this.cbVD.TabIndex = 10;
            this.cbVD.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.cbVD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbVD_KeyDown);
            this.cbVD.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // cbIzjava
            // 
            this.cbIzjava.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbIzjava.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbIzjava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbIzjava.FormattingEnabled = true;
            this.cbIzjava.Location = new System.Drawing.Point(100, 103);
            this.cbIzjava.Name = "cbIzjava";
            this.cbIzjava.Size = new System.Drawing.Size(208, 24);
            this.cbIzjava.TabIndex = 12;
            this.cbIzjava.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.cbIzjava.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbIzjava_KeyDown);
            this.cbIzjava.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(720, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Izradio:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm:ss";
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(100, 74);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(208, 23);
            this.dtpDatum.TabIndex = 11;
            this.dtpDatum.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.dtpDatum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDatum_KeyDown);
            this.dtpDatum.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(46, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Izjava:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(329, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Napomena:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.Location = new System.Drawing.Point(707, 78);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 17);
            this.label24.TabIndex = 27;
            this.label24.Text = "Otprema:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(18, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Vrsta dok.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Datum:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label28.Location = new System.Drawing.Point(20, 18);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 17);
            this.label28.TabIndex = 31;
            this.label28.Text = "Odredište:";
            // 
            // txtIzradio
            // 
            this.txtIzradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIzradio.Location = new System.Drawing.Point(780, 45);
            this.txtIzradio.Name = "txtIzradio";
            this.txtIzradio.ReadOnly = true;
            this.txtIzradio.Size = new System.Drawing.Size(208, 23);
            this.txtIzradio.TabIndex = 15;
            this.txtIzradio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIzradio_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbSkladiste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBrojOtpremnice);
            this.groupBox1.Controls.Add(this.nmGodinaOtpremnice);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 45);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSkladiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSkladiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(416, 14);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(208, 24);
            this.cbSkladiste.TabIndex = 3;
            this.cbSkladiste.SelectedIndexChanged += new System.EventHandler(this.cbSkladiste_SelectedIndexChanged);
            this.cbSkladiste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSkladiste_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(335, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Skladište:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj otpremnice:";
            // 
            // txtBrojOtpremnice
            // 
            this.txtBrojOtpremnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBrojOtpremnice.Location = new System.Drawing.Point(141, 15);
            this.txtBrojOtpremnice.Name = "txtBrojOtpremnice";
            this.txtBrojOtpremnice.Size = new System.Drawing.Size(80, 23);
            this.txtBrojOtpremnice.TabIndex = 1;
            this.txtBrojOtpremnice.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.txtBrojOtpremnice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrojOtpremnice_KeyDown_1);
            this.txtBrojOtpremnice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.provjera_KeyPress);
            this.txtBrojOtpremnice.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
            // 
            // nmGodinaOtpremnice
            // 
            this.nmGodinaOtpremnice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nmGodinaOtpremnice.Location = new System.Drawing.Point(224, 15);
            this.nmGodinaOtpremnice.Name = "nmGodinaOtpremnice";
            this.nmGodinaOtpremnice.Size = new System.Drawing.Size(76, 23);
            this.nmGodinaOtpremnice.TabIndex = 2;
            this.nmGodinaOtpremnice.Enter += new System.EventHandler(this.TRENUTNI_Enter);
            this.nmGodinaOtpremnice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrojOtpremnice_KeyDown_1);
            this.nmGodinaOtpremnice.Leave += new System.EventHandler(this.NAPUSTENI_Leave);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.jmj,
            this.kolicina,
            this.porez,
            this.mpc,
            this.rabat,
            this.rabat_iznos,
            this.cijena_bez_pdva,
            this.iznos_bez_pdva,
            this.iznos_ukupno,
            this.vpc,
            this.nc,
            this.id_stavka,
            this.id_roba_prodaja,
            this.oduzmi,
            this.porez_potrosnja});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgw.GridColor = System.Drawing.Color.Gainsboro;
            this.dgw.Location = new System.Drawing.Point(12, 306);
            this.dgw.MultiSelect = false;
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 30;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(998, 239);
            this.dgw.TabIndex = 19;
            this.dgw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellClick);
            this.dgw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellEndEdit);
            this.dgw.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellValidated);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(12, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "Šifra artikla/usluge:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnObrisi.Image = global::PCPOS.Properties.Resources.Close;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Location = new System.Drawing.Point(875, 257);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(135, 43);
            this.btnObrisi.TabIndex = 36;
            this.btnObrisi.Text = "   Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOpenRoba
            // 
            this.btnOpenRoba.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenRoba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenRoba.Image = global::PCPOS.Properties.Resources._1059;
            this.btnOpenRoba.Location = new System.Drawing.Point(205, 272);
            this.btnOpenRoba.Name = "btnOpenRoba";
            this.btnOpenRoba.Size = new System.Drawing.Size(39, 31);
            this.btnOpenRoba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenRoba.TabIndex = 37;
            this.btnOpenRoba.TabStop = false;
            this.btnOpenRoba.Click += new System.EventHandler(this.btnOpenRoba_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::PCPOS.Properties.Resources.Actions_application_exit_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(880, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "Izlaz      ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteAllFaktura
            // 
            this.btnDeleteAllFaktura.Enabled = false;
            this.btnDeleteAllFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteAllFaktura.Image = global::PCPOS.Properties.Resources.Recyclebin_Empty;
            this.btnDeleteAllFaktura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllFaktura.Location = new System.Drawing.Point(564, 12);
            this.btnDeleteAllFaktura.Name = "btnDeleteAllFaktura";
            this.btnDeleteAllFaktura.Size = new System.Drawing.Size(156, 40);
            this.btnDeleteAllFaktura.TabIndex = 42;
            this.btnDeleteAllFaktura.Text = "Obriši otpremnicu";
            this.btnDeleteAllFaktura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllFaktura.UseVisualStyleBackColor = true;
            this.btnDeleteAllFaktura.Click += new System.EventHandler(this.btnDeleteAllFaktura_Click);
            // 
            // btnSveFakture
            // 
            this.btnSveFakture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSveFakture.Image = global::PCPOS.Properties.Resources._10591;
            this.btnSveFakture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveFakture.Location = new System.Drawing.Point(420, 12);
            this.btnSveFakture.Name = "btnSveFakture";
            this.btnSveFakture.Size = new System.Drawing.Size(138, 40);
            this.btnSveFakture.TabIndex = 41;
            this.btnSveFakture.Text = "Sve otpremnice";
            this.btnSveFakture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSveFakture.UseVisualStyleBackColor = true;
            this.btnSveFakture.Click += new System.EventHandler(this.btnSveFakture_Click);
            // 
            // btnNoviUnos
            // 
            this.btnNoviUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNoviUnos.Image = global::PCPOS.Properties.Resources.folder_open_icon;
            this.btnNoviUnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviUnos.Location = new System.Drawing.Point(12, 12);
            this.btnNoviUnos.Name = "btnNoviUnos";
            this.btnNoviUnos.Size = new System.Drawing.Size(130, 40);
            this.btnNoviUnos.TabIndex = 40;
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
            this.btnOdustani.Location = new System.Drawing.Point(148, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 40);
            this.btnOdustani.TabIndex = 39;
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
            this.btnSpremi.Location = new System.Drawing.Point(284, 12);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 40);
            this.btnSpremi.TabIndex = 38;
            this.btnSpremi.Text = "Spremi   ";
            this.btnSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // br
            // 
            this.br.FillWeight = 50F;
            this.br.HeaderText = "Br.";
            this.br.Name = "br";
            this.br.ReadOnly = true;
            // 
            // sifra
            // 
            this.sifra.FillWeight = 61.10954F;
            this.sifra.HeaderText = "Šifra";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.FillWeight = 61.10954F;
            this.naziv.HeaderText = "Naziv robe ili usluge";
            this.naziv.MinimumWidth = 130;
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // jmj
            // 
            this.jmj.HeaderText = "JMJ";
            this.jmj.Name = "jmj";
            this.jmj.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.FillWeight = 61.10954F;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            // 
            // porez
            // 
            this.porez.HeaderText = "Porez";
            this.porez.Name = "porez";
            this.porez.ReadOnly = true;
            // 
            // mpc
            // 
            this.mpc.HeaderText = "MPC";
            this.mpc.Name = "mpc";
            // 
            // rabat
            // 
            this.rabat.FillWeight = 61.10954F;
            this.rabat.HeaderText = "Rabat%";
            this.rabat.Name = "rabat";
            this.rabat.Visible = false;
            // 
            // rabat_iznos
            // 
            this.rabat_iznos.HeaderText = "Rabat iznos";
            this.rabat_iznos.Name = "rabat_iznos";
            this.rabat_iznos.ReadOnly = true;
            this.rabat_iznos.Visible = false;
            // 
            // cijena_bez_pdva
            // 
            this.cijena_bez_pdva.FillWeight = 120F;
            this.cijena_bez_pdva.HeaderText = "Cijena bez pdv-a";
            this.cijena_bez_pdva.Name = "cijena_bez_pdva";
            this.cijena_bez_pdva.ReadOnly = true;
            this.cijena_bez_pdva.Visible = false;
            // 
            // iznos_bez_pdva
            // 
            this.iznos_bez_pdva.FillWeight = 120F;
            this.iznos_bez_pdva.HeaderText = "Iznos bez pdv-a";
            this.iznos_bez_pdva.Name = "iznos_bez_pdva";
            this.iznos_bez_pdva.ReadOnly = true;
            this.iznos_bez_pdva.Visible = false;
            // 
            // iznos_ukupno
            // 
            this.iznos_ukupno.HeaderText = "Iznos ukupno";
            this.iznos_ukupno.Name = "iznos_ukupno";
            this.iznos_ukupno.ReadOnly = true;
            // 
            // vpc
            // 
            this.vpc.HeaderText = "VPC";
            this.vpc.Name = "vpc";
            this.vpc.ReadOnly = true;
            this.vpc.Visible = false;
            // 
            // nc
            // 
            this.nc.HeaderText = "NBC";
            this.nc.Name = "nc";
            this.nc.ReadOnly = true;
            this.nc.Visible = false;
            // 
            // id_stavka
            // 
            this.id_stavka.HeaderText = "id_stavka";
            this.id_stavka.Name = "id_stavka";
            this.id_stavka.Visible = false;
            // 
            // id_roba_prodaja
            // 
            this.id_roba_prodaja.HeaderText = "id_roba_prodaja";
            this.id_roba_prodaja.Name = "id_roba_prodaja";
            this.id_roba_prodaja.Visible = false;
            // 
            // oduzmi
            // 
            this.oduzmi.HeaderText = "oduzmi";
            this.oduzmi.Name = "oduzmi";
            this.oduzmi.Visible = false;
            // 
            // porez_potrosnja
            // 
            this.porez_potrosnja.HeaderText = "porez_potrosnja";
            this.porez_potrosnja.Name = "porez_potrosnja";
            this.porez_potrosnja.Visible = false;
            // 
            // frmOtpremnicaNaSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1022, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteAllFaktura);
            this.Controls.Add(this.btnSveFakture);
            this.Controls.Add(this.btnNoviUnos);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOpenRoba);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblNaDan);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSifra_robe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbPos_partner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.label18);
            this.Name = "frmOtpremnicaNaSkladiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otpremnica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GasenjeForme_FormClosing);
            this.Load += new System.EventHandler(this.frmOtpremnica_Load);
            this.rbPos_partner.ResumeLayout(false);
            this.rbPos_partner.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGodinaOtpremnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenRoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaDan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtSifra_robe;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox rbPos_partner;
        private System.Windows.Forms.ComboBox cbOtprema;
        private System.Windows.Forms.ComboBox cbVD;
        private System.Windows.Forms.ComboBox cbIzjava;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtIzradio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBrojOtpremnice;
        private System.Windows.Forms.NumericUpDown nmGodinaOtpremnice;
        private System.Windows.Forms.ComboBox cbSkladiste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKomercijalist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.PictureBox btnOpenRoba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteAllFaktura;
        private System.Windows.Forms.Button btnSveFakture;
        private System.Windows.Forms.Button btnNoviUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox rtbNapomena;
        private frmOtpremnicaNaSkladiste.MyDataGrid dgw;
        private System.Windows.Forms.CheckBox chbBezPdVa;
        private System.Windows.Forms.CheckBox chbSNBC;
        private System.Windows.Forms.ComboBox cmbSkladisteDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn br;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn porez;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabat;
        private System.Windows.Forms.DataGridViewTextBoxColumn rabat_iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_bez_pdva;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos_bez_pdva;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos_ukupno;
        private System.Windows.Forms.DataGridViewTextBoxColumn vpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_stavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_roba_prodaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduzmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn porez_potrosnja;
    }
}