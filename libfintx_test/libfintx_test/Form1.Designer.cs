﻿namespace libfintx_test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_hbci_meldung = new System.Windows.Forms.TextBox();
            this.btn_auftrag_bestätigen_tan = new System.Windows.Forms.Button();
            this.btn_überweisen = new System.Windows.Forms.Button();
            this.camt_053_abholen = new System.Windows.Forms.Button();
            this.camt_052_abholen = new System.Windows.Forms.Button();
            this.btn_umsätze_abholen = new System.Windows.Forms.Button();
            this.btn_kontostand_abfragen = new System.Windows.Forms.Button();
            this.btn_synchronisation = new System.Windows.Forms.Button();
            this.pBox_tan = new System.Windows.Forms.PictureBox();
            this.txt_tanverfahren = new System.Windows.Forms.TextBox();
            this.lbl_tanverfahren = new System.Windows.Forms.Label();
            this.txt_verwendungszweck = new System.Windows.Forms.TextBox();
            this.lbl_verwendungszweck = new System.Windows.Forms.Label();
            this.txt_betrag = new System.Windows.Forms.TextBox();
            this.lbl_betrag = new System.Windows.Forms.Label();
            this.txt_empfängerbic = new System.Windows.Forms.TextBox();
            this.lbl_empfängerbic = new System.Windows.Forms.Label();
            this.txt_empfängeriban = new System.Windows.Forms.TextBox();
            this.lbl_empfängeriban = new System.Windows.Forms.Label();
            this.txt_empfängername = new System.Windows.Forms.TextBox();
            this.lbl_empfängername = new System.Windows.Forms.Label();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.txt_hbci_version = new System.Windows.Forms.TextBox();
            this.lbl_hbci_version = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.txt_iban = new System.Windows.Forms.TextBox();
            this.lbl_iban = new System.Windows.Forms.Label();
            this.txt_bic = new System.Windows.Forms.TextBox();
            this.lbl_bic = new System.Windows.Forms.Label();
            this.txt_bankleitzahl = new System.Windows.Forms.TextBox();
            this.lbl_bankleitzahl = new System.Windows.Forms.Label();
            this.txt_kontonummer = new System.Windows.Forms.TextBox();
            this.lbl_kontonummer = new System.Windows.Forms.Label();
            this.btn_zugelassene_tanverfahren = new System.Windows.Forms.Button();
            this.btn_bankdaten_laden = new System.Windows.Forms.Button();
            this.btn_überweisungsdaten_laden = new System.Windows.Forms.Button();
            this.txt_tan = new System.Windows.Forms.TextBox();
            this.lbl_tan = new System.Windows.Forms.Label();
            this.btn_konten_anzeigen = new System.Windows.Forms.Button();
            this.btn_tan_medium_name_abfragen = new System.Windows.Forms.Button();
            this.chk_tracing = new System.Windows.Forms.CheckBox();
            this.chk_tracingFormatted = new System.Windows.Forms.CheckBox();
            this.lbl_bankleitzahl_zentrale = new System.Windows.Forms.Label();
            this.txt_bankleitzahl_zentrale = new System.Windows.Forms.TextBox();
            this.txt_tan_medium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_umsatzabruf_von = new System.Windows.Forms.DateTimePicker();
            this.chk_umsatzabruf_von = new System.Windows.Forms.CheckBox();
            this.chk_umsatzabruf_bis = new System.Windows.Forms.CheckBox();
            this.date_umsatzabruf_bis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_tan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_hbci_meldung
            // 
            this.txt_hbci_meldung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hbci_meldung.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_hbci_meldung.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hbci_meldung.Location = new System.Drawing.Point(0, 318);
            this.txt_hbci_meldung.Multiline = true;
            this.txt_hbci_meldung.Name = "txt_hbci_meldung";
            this.txt_hbci_meldung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_hbci_meldung.Size = new System.Drawing.Size(1551, 286);
            this.txt_hbci_meldung.TabIndex = 88;
            // 
            // btn_auftrag_bestätigen_tan
            // 
            this.btn_auftrag_bestätigen_tan.Location = new System.Drawing.Point(694, 273);
            this.btn_auftrag_bestätigen_tan.Name = "btn_auftrag_bestätigen_tan";
            this.btn_auftrag_bestätigen_tan.Size = new System.Drawing.Size(118, 39);
            this.btn_auftrag_bestätigen_tan.TabIndex = 81;
            this.btn_auftrag_bestätigen_tan.Text = "Mit TAN bestätigen";
            this.btn_auftrag_bestätigen_tan.UseVisualStyleBackColor = true;
            this.btn_auftrag_bestätigen_tan.Click += new System.EventHandler(this.btn_auftrag_bestätigen_tan_Click);
            // 
            // btn_überweisen
            // 
            this.btn_überweisen.Location = new System.Drawing.Point(608, 273);
            this.btn_überweisen.Name = "btn_überweisen";
            this.btn_überweisen.Size = new System.Drawing.Size(80, 39);
            this.btn_überweisen.TabIndex = 80;
            this.btn_überweisen.Text = "Überweisen";
            this.btn_überweisen.UseVisualStyleBackColor = true;
            this.btn_überweisen.Click += new System.EventHandler(this.btn_überweisen_Click);
            // 
            // camt_053_abholen
            // 
            this.camt_053_abholen.Location = new System.Drawing.Point(488, 273);
            this.camt_053_abholen.Name = "camt_053_abholen";
            this.camt_053_abholen.Size = new System.Drawing.Size(114, 39);
            this.camt_053_abholen.TabIndex = 79;
            this.camt_053_abholen.Text = "camt053 abholen";
            this.camt_053_abholen.UseVisualStyleBackColor = true;
            this.camt_053_abholen.Click += new System.EventHandler(this.camt_053_abholen_Click);
            // 
            // camt_052_abholen
            // 
            this.camt_052_abholen.Location = new System.Drawing.Point(364, 273);
            this.camt_052_abholen.Name = "camt_052_abholen";
            this.camt_052_abholen.Size = new System.Drawing.Size(118, 39);
            this.camt_052_abholen.TabIndex = 78;
            this.camt_052_abholen.Text = "camt052 abholen";
            this.camt_052_abholen.UseVisualStyleBackColor = true;
            this.camt_052_abholen.Click += new System.EventHandler(this.camt_052_abholen_Click);
            // 
            // btn_umsätze_abholen
            // 
            this.btn_umsätze_abholen.Location = new System.Drawing.Point(259, 273);
            this.btn_umsätze_abholen.Name = "btn_umsätze_abholen";
            this.btn_umsätze_abholen.Size = new System.Drawing.Size(99, 39);
            this.btn_umsätze_abholen.TabIndex = 77;
            this.btn_umsätze_abholen.Text = "Umsätze abholen";
            this.btn_umsätze_abholen.UseVisualStyleBackColor = true;
            this.btn_umsätze_abholen.Click += new System.EventHandler(this.btn_umsätze_abholen_Click);
            // 
            // btn_kontostand_abfragen
            // 
            this.btn_kontostand_abfragen.Location = new System.Drawing.Point(133, 273);
            this.btn_kontostand_abfragen.Name = "btn_kontostand_abfragen";
            this.btn_kontostand_abfragen.Size = new System.Drawing.Size(120, 39);
            this.btn_kontostand_abfragen.TabIndex = 76;
            this.btn_kontostand_abfragen.Text = "Kontostand abfragen";
            this.btn_kontostand_abfragen.UseVisualStyleBackColor = true;
            this.btn_kontostand_abfragen.Click += new System.EventHandler(this.btn_kontostand_abfragen_Click);
            // 
            // btn_synchronisation
            // 
            this.btn_synchronisation.Location = new System.Drawing.Point(15, 273);
            this.btn_synchronisation.Name = "btn_synchronisation";
            this.btn_synchronisation.Size = new System.Drawing.Size(112, 39);
            this.btn_synchronisation.TabIndex = 75;
            this.btn_synchronisation.Text = "Synchronisation";
            this.btn_synchronisation.UseVisualStyleBackColor = true;
            this.btn_synchronisation.Click += new System.EventHandler(this.btn_synchronisation_Click);
            // 
            // pBox_tan
            // 
            this.pBox_tan.ErrorImage = global::libfintx_test.Properties.Resources.tan;
            this.pBox_tan.Image = global::libfintx_test.Properties.Resources.tan;
            this.pBox_tan.InitialImage = global::libfintx_test.Properties.Resources.tan;
            this.pBox_tan.Location = new System.Drawing.Point(921, 6);
            this.pBox_tan.Name = "pBox_tan";
            this.pBox_tan.Size = new System.Drawing.Size(250, 200);
            this.pBox_tan.TabIndex = 73;
            this.pBox_tan.TabStop = false;
            // 
            // txt_tanverfahren
            // 
            this.txt_tanverfahren.Location = new System.Drawing.Point(591, 136);
            this.txt_tanverfahren.Name = "txt_tanverfahren";
            this.txt_tanverfahren.Size = new System.Drawing.Size(297, 20);
            this.txt_tanverfahren.TabIndex = 72;
            // 
            // lbl_tanverfahren
            // 
            this.lbl_tanverfahren.AutoSize = true;
            this.lbl_tanverfahren.Location = new System.Drawing.Point(457, 139);
            this.lbl_tanverfahren.Name = "lbl_tanverfahren";
            this.lbl_tanverfahren.Size = new System.Drawing.Size(81, 13);
            this.lbl_tanverfahren.TabIndex = 71;
            this.lbl_tanverfahren.Text = "TAN-Verfahren:";
            // 
            // txt_verwendungszweck
            // 
            this.txt_verwendungszweck.Location = new System.Drawing.Point(591, 110);
            this.txt_verwendungszweck.Name = "txt_verwendungszweck";
            this.txt_verwendungszweck.Size = new System.Drawing.Size(297, 20);
            this.txt_verwendungszweck.TabIndex = 70;
            // 
            // lbl_verwendungszweck
            // 
            this.lbl_verwendungszweck.AutoSize = true;
            this.lbl_verwendungszweck.Location = new System.Drawing.Point(457, 113);
            this.lbl_verwendungszweck.Name = "lbl_verwendungszweck";
            this.lbl_verwendungszweck.Size = new System.Drawing.Size(106, 13);
            this.lbl_verwendungszweck.TabIndex = 69;
            this.lbl_verwendungszweck.Text = "Verwendungszweck:";
            // 
            // txt_betrag
            // 
            this.txt_betrag.Location = new System.Drawing.Point(591, 84);
            this.txt_betrag.Name = "txt_betrag";
            this.txt_betrag.Size = new System.Drawing.Size(297, 20);
            this.txt_betrag.TabIndex = 68;
            // 
            // lbl_betrag
            // 
            this.lbl_betrag.AutoSize = true;
            this.lbl_betrag.Location = new System.Drawing.Point(457, 87);
            this.lbl_betrag.Name = "lbl_betrag";
            this.lbl_betrag.Size = new System.Drawing.Size(41, 13);
            this.lbl_betrag.TabIndex = 67;
            this.lbl_betrag.Text = "Betrag:";
            // 
            // txt_empfängerbic
            // 
            this.txt_empfängerbic.Location = new System.Drawing.Point(591, 58);
            this.txt_empfängerbic.Name = "txt_empfängerbic";
            this.txt_empfängerbic.Size = new System.Drawing.Size(297, 20);
            this.txt_empfängerbic.TabIndex = 66;
            // 
            // lbl_empfängerbic
            // 
            this.lbl_empfängerbic.AutoSize = true;
            this.lbl_empfängerbic.Location = new System.Drawing.Point(457, 61);
            this.lbl_empfängerbic.Name = "lbl_empfängerbic";
            this.lbl_empfängerbic.Size = new System.Drawing.Size(81, 13);
            this.lbl_empfängerbic.TabIndex = 65;
            this.lbl_empfängerbic.Text = "Empfänger-BIC:";
            // 
            // txt_empfängeriban
            // 
            this.txt_empfängeriban.Location = new System.Drawing.Point(591, 32);
            this.txt_empfängeriban.Name = "txt_empfängeriban";
            this.txt_empfängeriban.Size = new System.Drawing.Size(297, 20);
            this.txt_empfängeriban.TabIndex = 64;
            // 
            // lbl_empfängeriban
            // 
            this.lbl_empfängeriban.AutoSize = true;
            this.lbl_empfängeriban.Location = new System.Drawing.Point(457, 35);
            this.lbl_empfängeriban.Name = "lbl_empfängeriban";
            this.lbl_empfängeriban.Size = new System.Drawing.Size(89, 13);
            this.lbl_empfängeriban.TabIndex = 63;
            this.lbl_empfängeriban.Text = "Empfänger-IBAN:";
            // 
            // txt_empfängername
            // 
            this.txt_empfängername.Location = new System.Drawing.Point(591, 6);
            this.txt_empfängername.Name = "txt_empfängername";
            this.txt_empfängername.Size = new System.Drawing.Size(297, 20);
            this.txt_empfängername.TabIndex = 62;
            // 
            // lbl_empfängername
            // 
            this.lbl_empfängername.AutoSize = true;
            this.lbl_empfängername.Location = new System.Drawing.Point(457, 9);
            this.lbl_empfängername.Name = "lbl_empfängername";
            this.lbl_empfängername.Size = new System.Drawing.Size(92, 13);
            this.lbl_empfängername.TabIndex = 61;
            this.lbl_empfängername.Text = "Empfänger-Name:";
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(111, 188);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(332, 20);
            this.txt_pin.TabIndex = 58;
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(12, 191);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(28, 13);
            this.lbl_pin.TabIndex = 57;
            this.lbl_pin.Text = "PIN:";
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(111, 162);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(332, 20);
            this.txt_userid.TabIndex = 56;
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(12, 165);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(46, 13);
            this.lbl_userid.TabIndex = 55;
            this.lbl_userid.Text = "User-ID:";
            // 
            // txt_hbci_version
            // 
            this.txt_hbci_version.Location = new System.Drawing.Point(111, 136);
            this.txt_hbci_version.Name = "txt_hbci_version";
            this.txt_hbci_version.Size = new System.Drawing.Size(332, 20);
            this.txt_hbci_version.TabIndex = 54;
            // 
            // lbl_hbci_version
            // 
            this.lbl_hbci_version.AutoSize = true;
            this.lbl_hbci_version.Location = new System.Drawing.Point(12, 139);
            this.lbl_hbci_version.Name = "lbl_hbci_version";
            this.lbl_hbci_version.Size = new System.Drawing.Size(73, 13);
            this.lbl_hbci_version.TabIndex = 53;
            this.lbl_hbci_version.Text = "HBCI-Version:";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(111, 110);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(332, 20);
            this.txt_url.TabIndex = 52;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(12, 113);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(32, 13);
            this.lbl_url.TabIndex = 51;
            this.lbl_url.Text = "URL:";
            // 
            // txt_iban
            // 
            this.txt_iban.Location = new System.Drawing.Point(111, 84);
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.Size = new System.Drawing.Size(332, 20);
            this.txt_iban.TabIndex = 50;
            // 
            // lbl_iban
            // 
            this.lbl_iban.AutoSize = true;
            this.lbl_iban.Location = new System.Drawing.Point(12, 87);
            this.lbl_iban.Name = "lbl_iban";
            this.lbl_iban.Size = new System.Drawing.Size(35, 13);
            this.lbl_iban.TabIndex = 49;
            this.lbl_iban.Text = "IBAN:";
            // 
            // txt_bic
            // 
            this.txt_bic.Location = new System.Drawing.Point(111, 58);
            this.txt_bic.Name = "txt_bic";
            this.txt_bic.Size = new System.Drawing.Size(332, 20);
            this.txt_bic.TabIndex = 48;
            // 
            // lbl_bic
            // 
            this.lbl_bic.AutoSize = true;
            this.lbl_bic.Location = new System.Drawing.Point(12, 61);
            this.lbl_bic.Name = "lbl_bic";
            this.lbl_bic.Size = new System.Drawing.Size(27, 13);
            this.lbl_bic.TabIndex = 47;
            this.lbl_bic.Text = "BIC:";
            // 
            // txt_bankleitzahl
            // 
            this.txt_bankleitzahl.Location = new System.Drawing.Point(111, 32);
            this.txt_bankleitzahl.Name = "txt_bankleitzahl";
            this.txt_bankleitzahl.Size = new System.Drawing.Size(131, 20);
            this.txt_bankleitzahl.TabIndex = 46;
            this.txt_bankleitzahl.TextChanged += new System.EventHandler(this.Txt_bankleitzahl_TextChanged);
            // 
            // lbl_bankleitzahl
            // 
            this.lbl_bankleitzahl.AutoSize = true;
            this.lbl_bankleitzahl.Location = new System.Drawing.Point(12, 35);
            this.lbl_bankleitzahl.Name = "lbl_bankleitzahl";
            this.lbl_bankleitzahl.Size = new System.Drawing.Size(67, 13);
            this.lbl_bankleitzahl.TabIndex = 45;
            this.lbl_bankleitzahl.Text = "Bankleitzahl:";
            // 
            // txt_kontonummer
            // 
            this.txt_kontonummer.Location = new System.Drawing.Point(111, 6);
            this.txt_kontonummer.Name = "txt_kontonummer";
            this.txt_kontonummer.Size = new System.Drawing.Size(332, 20);
            this.txt_kontonummer.TabIndex = 44;
            this.txt_kontonummer.TextChanged += new System.EventHandler(this.Txt_kontonummer_TextChanged);
            // 
            // lbl_kontonummer
            // 
            this.lbl_kontonummer.AutoSize = true;
            this.lbl_kontonummer.Location = new System.Drawing.Point(12, 9);
            this.lbl_kontonummer.Name = "lbl_kontonummer";
            this.lbl_kontonummer.Size = new System.Drawing.Size(75, 13);
            this.lbl_kontonummer.TabIndex = 43;
            this.lbl_kontonummer.Text = "Kontonummer:";
            // 
            // btn_zugelassene_tanverfahren
            // 
            this.btn_zugelassene_tanverfahren.Location = new System.Drawing.Point(819, 273);
            this.btn_zugelassene_tanverfahren.Name = "btn_zugelassene_tanverfahren";
            this.btn_zugelassene_tanverfahren.Size = new System.Drawing.Size(151, 39);
            this.btn_zugelassene_tanverfahren.TabIndex = 82;
            this.btn_zugelassene_tanverfahren.Text = "Zugelassene TAN-Verfahren";
            this.btn_zugelassene_tanverfahren.UseVisualStyleBackColor = true;
            this.btn_zugelassene_tanverfahren.Click += new System.EventHandler(this.btn_zugelassene_tanverfahren_Click);
            // 
            // btn_bankdaten_laden
            // 
            this.btn_bankdaten_laden.Location = new System.Drawing.Point(976, 273);
            this.btn_bankdaten_laden.Name = "btn_bankdaten_laden";
            this.btn_bankdaten_laden.Size = new System.Drawing.Size(102, 39);
            this.btn_bankdaten_laden.TabIndex = 83;
            this.btn_bankdaten_laden.Text = "Bankdaten laden";
            this.btn_bankdaten_laden.UseVisualStyleBackColor = true;
            this.btn_bankdaten_laden.Click += new System.EventHandler(this.btn_lade_bankdaten_Click);
            // 
            // btn_überweisungsdaten_laden
            // 
            this.btn_überweisungsdaten_laden.Location = new System.Drawing.Point(1084, 273);
            this.btn_überweisungsdaten_laden.Name = "btn_überweisungsdaten_laden";
            this.btn_überweisungsdaten_laden.Size = new System.Drawing.Size(143, 39);
            this.btn_überweisungsdaten_laden.TabIndex = 84;
            this.btn_überweisungsdaten_laden.Text = "Überweisungsdaten laden";
            this.btn_überweisungsdaten_laden.UseVisualStyleBackColor = true;
            this.btn_überweisungsdaten_laden.Click += new System.EventHandler(this.btn_lade_überweisungsdaten_Click);
            // 
            // txt_tan
            // 
            this.txt_tan.Location = new System.Drawing.Point(591, 188);
            this.txt_tan.Name = "txt_tan";
            this.txt_tan.Size = new System.Drawing.Size(297, 20);
            this.txt_tan.TabIndex = 74;
            // 
            // lbl_tan
            // 
            this.lbl_tan.AutoSize = true;
            this.lbl_tan.Location = new System.Drawing.Point(457, 189);
            this.lbl_tan.Name = "lbl_tan";
            this.lbl_tan.Size = new System.Drawing.Size(32, 13);
            this.lbl_tan.TabIndex = 73;
            this.lbl_tan.Text = "TAN:";
            // 
            // btn_konten_anzeigen
            // 
            this.btn_konten_anzeigen.Location = new System.Drawing.Point(1233, 273);
            this.btn_konten_anzeigen.Name = "btn_konten_anzeigen";
            this.btn_konten_anzeigen.Size = new System.Drawing.Size(106, 39);
            this.btn_konten_anzeigen.TabIndex = 85;
            this.btn_konten_anzeigen.Text = "Konten anzeigen";
            this.btn_konten_anzeigen.UseVisualStyleBackColor = true;
            this.btn_konten_anzeigen.Click += new System.EventHandler(this.btn_konten_anzeigen_Click);
            // 
            // btn_tan_medium_name_abfragen
            // 
            this.btn_tan_medium_name_abfragen.Location = new System.Drawing.Point(1346, 273);
            this.btn_tan_medium_name_abfragen.Name = "btn_tan_medium_name_abfragen";
            this.btn_tan_medium_name_abfragen.Size = new System.Drawing.Size(156, 39);
            this.btn_tan_medium_name_abfragen.TabIndex = 86;
            this.btn_tan_medium_name_abfragen.Text = "TAN-Medium-Name abfragen";
            this.btn_tan_medium_name_abfragen.UseVisualStyleBackColor = true;
            this.btn_tan_medium_name_abfragen.Click += new System.EventHandler(this.btn_tan_medium_name_abfragen_Click);
            // 
            // chk_tracing
            // 
            this.chk_tracing.AutoSize = true;
            this.chk_tracing.Checked = true;
            this.chk_tracing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_tracing.Location = new System.Drawing.Point(591, 217);
            this.chk_tracing.Name = "chk_tracing";
            this.chk_tracing.Size = new System.Drawing.Size(173, 17);
            this.chk_tracing.TabIndex = 89;
            this.chk_tracing.Text = "HBCI-Nachrichten aufzeichnen";
            this.chk_tracing.UseVisualStyleBackColor = true;
            this.chk_tracing.CheckedChanged += new System.EventHandler(this.chk_Tracing_CheckedChanged);
            // 
            // chk_tracingFormatted
            // 
            this.chk_tracingFormatted.AutoSize = true;
            this.chk_tracingFormatted.Location = new System.Drawing.Point(816, 218);
            this.chk_tracingFormatted.Name = "chk_tracingFormatted";
            this.chk_tracingFormatted.Size = new System.Drawing.Size(72, 17);
            this.chk_tracingFormatted.TabIndex = 90;
            this.chk_tracingFormatted.Text = "Formatiert";
            this.chk_tracingFormatted.UseVisualStyleBackColor = true;
            this.chk_tracingFormatted.Visible = false;
            this.chk_tracingFormatted.CheckedChanged += new System.EventHandler(this.chk_tracingFormatted_CheckedChanged);
            // 
            // lbl_bankleitzahl_zentrale
            // 
            this.lbl_bankleitzahl_zentrale.AutoSize = true;
            this.lbl_bankleitzahl_zentrale.Location = new System.Drawing.Point(254, 35);
            this.lbl_bankleitzahl_zentrale.Name = "lbl_bankleitzahl_zentrale";
            this.lbl_bankleitzahl_zentrale.Size = new System.Drawing.Size(49, 13);
            this.lbl_bankleitzahl_zentrale.TabIndex = 91;
            this.lbl_bankleitzahl_zentrale.Text = "Zentrale:";
            // 
            // txt_bankleitzahl_zentrale
            // 
            this.txt_bankleitzahl_zentrale.Location = new System.Drawing.Point(312, 32);
            this.txt_bankleitzahl_zentrale.Name = "txt_bankleitzahl_zentrale";
            this.txt_bankleitzahl_zentrale.Size = new System.Drawing.Size(131, 20);
            this.txt_bankleitzahl_zentrale.TabIndex = 47;
            // 
            // txt_tan_medium
            // 
            this.txt_tan_medium.Location = new System.Drawing.Point(591, 162);
            this.txt_tan_medium.Name = "txt_tan_medium";
            this.txt_tan_medium.Size = new System.Drawing.Size(297, 20);
            this.txt_tan_medium.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "TAN-Medium:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Umsatzabruf ab:";
            // 
            // date_umsatzabruf_von
            // 
            this.date_umsatzabruf_von.Location = new System.Drawing.Point(132, 215);
            this.date_umsatzabruf_von.Name = "date_umsatzabruf_von";
            this.date_umsatzabruf_von.Size = new System.Drawing.Size(311, 20);
            this.date_umsatzabruf_von.TabIndex = 95;
            // 
            // chk_umsatzabruf_von
            // 
            this.chk_umsatzabruf_von.AutoSize = true;
            this.chk_umsatzabruf_von.Location = new System.Drawing.Point(111, 218);
            this.chk_umsatzabruf_von.Name = "chk_umsatzabruf_von";
            this.chk_umsatzabruf_von.Size = new System.Drawing.Size(15, 14);
            this.chk_umsatzabruf_von.TabIndex = 96;
            this.chk_umsatzabruf_von.UseVisualStyleBackColor = true;
            // 
            // chk_umsatzabruf_bis
            // 
            this.chk_umsatzabruf_bis.AutoSize = true;
            this.chk_umsatzabruf_bis.Location = new System.Drawing.Point(111, 245);
            this.chk_umsatzabruf_bis.Name = "chk_umsatzabruf_bis";
            this.chk_umsatzabruf_bis.Size = new System.Drawing.Size(15, 14);
            this.chk_umsatzabruf_bis.TabIndex = 99;
            this.chk_umsatzabruf_bis.UseVisualStyleBackColor = true;
            // 
            // date_umsatzabruf_bis
            // 
            this.date_umsatzabruf_bis.Location = new System.Drawing.Point(132, 242);
            this.date_umsatzabruf_bis.Name = "date_umsatzabruf_bis";
            this.date_umsatzabruf_bis.Size = new System.Drawing.Size(311, 20);
            this.date_umsatzabruf_bis.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Umsatzabruf bis:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 604);
            this.Controls.Add(this.chk_umsatzabruf_bis);
            this.Controls.Add(this.date_umsatzabruf_bis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_umsatzabruf_von);
            this.Controls.Add(this.date_umsatzabruf_von);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tan_medium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bankleitzahl_zentrale);
            this.Controls.Add(this.lbl_bankleitzahl_zentrale);
            this.Controls.Add(this.chk_tracingFormatted);
            this.Controls.Add(this.chk_tracing);
            this.Controls.Add(this.btn_tan_medium_name_abfragen);
            this.Controls.Add(this.btn_konten_anzeigen);
            this.Controls.Add(this.txt_tan);
            this.Controls.Add(this.lbl_tan);
            this.Controls.Add(this.btn_überweisungsdaten_laden);
            this.Controls.Add(this.btn_bankdaten_laden);
            this.Controls.Add(this.btn_zugelassene_tanverfahren);
            this.Controls.Add(this.txt_hbci_meldung);
            this.Controls.Add(this.btn_auftrag_bestätigen_tan);
            this.Controls.Add(this.btn_überweisen);
            this.Controls.Add(this.camt_053_abholen);
            this.Controls.Add(this.camt_052_abholen);
            this.Controls.Add(this.btn_umsätze_abholen);
            this.Controls.Add(this.btn_kontostand_abfragen);
            this.Controls.Add(this.btn_synchronisation);
            this.Controls.Add(this.pBox_tan);
            this.Controls.Add(this.txt_tanverfahren);
            this.Controls.Add(this.lbl_tanverfahren);
            this.Controls.Add(this.txt_verwendungszweck);
            this.Controls.Add(this.lbl_verwendungszweck);
            this.Controls.Add(this.txt_betrag);
            this.Controls.Add(this.lbl_betrag);
            this.Controls.Add(this.txt_empfängerbic);
            this.Controls.Add(this.lbl_empfängerbic);
            this.Controls.Add(this.txt_empfängeriban);
            this.Controls.Add(this.lbl_empfängeriban);
            this.Controls.Add(this.txt_empfängername);
            this.Controls.Add(this.lbl_empfängername);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.txt_hbci_version);
            this.Controls.Add(this.lbl_hbci_version);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.txt_iban);
            this.Controls.Add(this.lbl_iban);
            this.Controls.Add(this.txt_bic);
            this.Controls.Add(this.lbl_bic);
            this.Controls.Add(this.txt_bankleitzahl);
            this.Controls.Add(this.lbl_bankleitzahl);
            this.Controls.Add(this.txt_kontonummer);
            this.Controls.Add(this.lbl_kontonummer);
            this.Name = "Form1";
            this.Text = "libfintx Test Framework";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_tan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txt_hbci_meldung;
        internal System.Windows.Forms.Button btn_auftrag_bestätigen_tan;
        internal System.Windows.Forms.Button btn_überweisen;
        internal System.Windows.Forms.Button camt_053_abholen;
        internal System.Windows.Forms.Button camt_052_abholen;
        internal System.Windows.Forms.Button btn_umsätze_abholen;
        internal System.Windows.Forms.Button btn_kontostand_abfragen;
        internal System.Windows.Forms.Button btn_synchronisation;
        internal System.Windows.Forms.PictureBox pBox_tan;
        internal System.Windows.Forms.TextBox txt_tanverfahren;
        internal System.Windows.Forms.Label lbl_tanverfahren;
        internal System.Windows.Forms.TextBox txt_verwendungszweck;
        internal System.Windows.Forms.Label lbl_verwendungszweck;
        internal System.Windows.Forms.TextBox txt_betrag;
        internal System.Windows.Forms.Label lbl_betrag;
        internal System.Windows.Forms.TextBox txt_empfängerbic;
        internal System.Windows.Forms.Label lbl_empfängerbic;
        internal System.Windows.Forms.TextBox txt_empfängeriban;
        internal System.Windows.Forms.Label lbl_empfängeriban;
        internal System.Windows.Forms.TextBox txt_empfängername;
        internal System.Windows.Forms.Label lbl_empfängername;
        internal System.Windows.Forms.TextBox txt_pin;
        internal System.Windows.Forms.Label lbl_pin;
        internal System.Windows.Forms.TextBox txt_userid;
        internal System.Windows.Forms.Label lbl_userid;
        internal System.Windows.Forms.TextBox txt_hbci_version;
        internal System.Windows.Forms.Label lbl_hbci_version;
        internal System.Windows.Forms.TextBox txt_url;
        internal System.Windows.Forms.Label lbl_url;
        internal System.Windows.Forms.TextBox txt_iban;
        internal System.Windows.Forms.Label lbl_iban;
        internal System.Windows.Forms.TextBox txt_bic;
        internal System.Windows.Forms.Label lbl_bic;
        internal System.Windows.Forms.TextBox txt_bankleitzahl;
        internal System.Windows.Forms.Label lbl_bankleitzahl;
        internal System.Windows.Forms.TextBox txt_kontonummer;
        internal System.Windows.Forms.Label lbl_kontonummer;
        internal System.Windows.Forms.Button btn_zugelassene_tanverfahren;
        internal System.Windows.Forms.Button btn_bankdaten_laden;
        internal System.Windows.Forms.Button btn_überweisungsdaten_laden;
        internal System.Windows.Forms.TextBox txt_tan;
        internal System.Windows.Forms.Label lbl_tan;
        internal System.Windows.Forms.Button btn_konten_anzeigen;
        internal System.Windows.Forms.Button btn_tan_medium_name_abfragen;
        private System.Windows.Forms.CheckBox chk_tracing;
        private System.Windows.Forms.CheckBox chk_tracingFormatted;
        internal System.Windows.Forms.Label lbl_bankleitzahl_zentrale;
        internal System.Windows.Forms.TextBox txt_bankleitzahl_zentrale;
        internal System.Windows.Forms.TextBox txt_tan_medium;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_umsatzabruf_von;
        private System.Windows.Forms.CheckBox chk_umsatzabruf_von;
        private System.Windows.Forms.CheckBox chk_umsatzabruf_bis;
        private System.Windows.Forms.DateTimePicker date_umsatzabruf_bis;
        internal System.Windows.Forms.Label label3;
    }
}

