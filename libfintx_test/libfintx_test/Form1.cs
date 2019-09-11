﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using libfintx;
using libfintx.Data;

namespace libfintx_test
{
    public partial class Form1 : Form
    {
        private List<Bank> _bankList;

        private TANDialog _tanDialog;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Synchronisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_synchronisation_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            HBCIDialogResult<string> result = Main.Synchronization(connectionDetails);

            HBCIOutput(result.Messages);
        }

        /// <summary>
        /// HBCI-Nachricht ausgeben
        /// </summary>
        /// <param name="hbcimsg"></param>
        public void HBCIOutput(IEnumerable<HBCIBankMessage> hbcimsg)
        {
            foreach (var msg in hbcimsg)
            {
                txt_hbci_meldung.Invoke(new MethodInvoker
                (delegate ()
                {
                    txt_hbci_meldung.Text += "Code: " + msg.Code + " | " + "Typ: " + msg.Type + " | " + "Nachricht: " + msg.Message + Environment.NewLine;
                    txt_hbci_meldung.SelectionStart = txt_hbci_meldung.TextLength;
                    txt_hbci_meldung.ScrollToCaret();
                }));
            }
        }

        /// <summary>
        /// Einfache Nachricht ausgeben
        /// </summary>
        /// <param name="msg"></param>
        public void SimpleOutput(string msg)
        {
            txt_hbci_meldung.Invoke(new MethodInvoker
                (delegate ()
                {
                    txt_hbci_meldung.Text += msg + Environment.NewLine;
                    txt_hbci_meldung.SelectionStart = txt_hbci_meldung.TextLength;
                    txt_hbci_meldung.ScrollToCaret();
                }));
        }

        /// <summary>
        /// Bankdaten laden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lade_bankdaten_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV|*.csv";
            openFileDialog1.Title = "Datei mit Bankdaten laden";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Lade Bankdaten falls vorhanden

                // Damit keine Zugangsdaten direkt im Code hinterlegt sind, kann optional eine Datei verwendet werden.
                // Datei liegt in C:/Users/<username>/libfintx_test_connection.csv

                var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var connFile = Path.Combine(userDir, openFileDialog1.FileName);

                if (File.Exists(connFile))
                {
                    var lines = File.ReadAllLines(connFile).Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
                    if (lines.Length != 2)
                    {
                        SimpleOutput($"Die Datei {connFile} existiert, hat aber das falsche Format.");
                        return;
                    }

                    var values = lines[1].Split(';');
                    if (values.Length < 8)
                    {
                        SimpleOutput($"Die Datei {connFile} existiert, hat aber das falsche Format.");
                        return;
                    }

                    txt_kontonummer.Text = values[0];
                    txt_bankleitzahl.Text = values[1];
                    txt_bic.Text = values[2];
                    txt_iban.Text = values[3];
                    txt_url.Text = values[4];
                    txt_hbci_version.Text = values[5];
                    txt_userid.Text = values[6];
                    txt_pin.Text = values[7];
                }
            }
        }

        /// <summary>
        /// Überweisungsdaten laden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_lade_überweisungsdaten_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV|*.csv";
            openFileDialog1.Title = "Datei mit Überweisungsdaten laden";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Lade Überweisungsdaten falls vorhanden

                var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var connFile = Path.Combine(userDir, openFileDialog1.FileName);

                if (File.Exists(connFile))
                {
                    var lines = File.ReadAllLines(connFile).Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();
                    if (lines.Length != 2)
                    {
                        SimpleOutput($"Die Datei {connFile} existiert, hat aber das falsche Format.");
                        return;
                    }

                    var values = lines[1].Split(';');
                    if (values.Length < 5)
                    {
                        SimpleOutput($"Die Datei {connFile} existiert, hat aber das falsche Format.");
                        return;
                    }

                    txt_empfängername.Text = values[0];
                    txt_empfängeriban.Text = values[1].Replace(" ", "");
                    txt_empfängerbic.Text = values[2];
                    txt_betrag.Text = values[3];
                    txt_verwendungszweck.Text = values[4];
                    if (values.Length >= 6)
                        txt_tanverfahren.Text = values[5];
                }
            }
        }

        /// <summary>
        /// Kontostand abfragen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_kontostand_abfragen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                // TAN-Verfahren
                Segment.HIRMS = txt_tanverfahren.Text;

                // TAN-Medium-Name
                var accounts = Main.Accounts(connectionDetails, _tanDialog, false);
                if (!accounts.IsSuccess)
                {
                    HBCIOutput(accounts.Messages);
                    return;
                }

                AccountInformations accountInfo = UPD.HIUPD?.GetAccountInformations(connectionDetails.Account, connectionDetails.Blz.ToString());
                if (accountInfo == null || accountInfo.IsSegmentPermitted("HKTAB"))
                {
                    var requestTanResult = Main.RequestTANMediumName(connectionDetails, _tanDialog);
                    if (!requestTanResult.IsSuccess)
                    {
                        HBCIOutput(requestTanResult.Messages);
                        return;
                    }
                    Segment.HITAB = requestTanResult.Data.FirstOrDefault();
                }

                var balance = Main.Balance(connectionDetails, _tanDialog, false);

                HBCIOutput(balance.Messages);

                if (balance.IsSuccess)
                    SimpleOutput("Kontostand: " + Convert.ToString(balance.Data.Balance));
            }
        }

        /// <summary>
        /// Konten anzeigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_konten_anzeigen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                // TAN-Verfahren
                Segment.HIRMS = txt_tanverfahren.Text;

                var accounts = Main.Accounts(connectionDetails, _tanDialog, false);

                HBCIOutput(accounts.Messages);

                if (accounts.IsSuccess)
                {
                    foreach (var acc in accounts.Data)
                    {
                        SimpleOutput("Inhaber: " + acc.Accountowner + " | " + "IBAN: " + acc.Accountiban + " | " + "Typ: " + acc.Accounttype);

                        foreach (var p in acc.Accountpermissions)
                        {
                            SimpleOutput("Segment: " + p.Segment + " | " + "Beschreibung: " + p.Description);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Zugelassene TAN-Verfahren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zugelassene_tanverfahren_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                foreach (var process in TANProcesses.items)
                {
                    SimpleOutput("Name: " + process.ProcessName + " | " + "Nummer: " + process.ProcessNumber);
                }
            }
        }

        /// <summary>
        /// Umsätze abholen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_umsätze_abholen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                // TAN-Verfahren
                Segment.HIRMS = txt_tanverfahren.Text;

                var transactions = Main.Transactions(connectionDetails, _tanDialog, false);

                HBCIOutput(transactions.Messages);

                if (transactions.IsSuccess)
                {
                    foreach (var item in transactions.Data)
                    {
                        foreach (var i in item.SWIFTTransactions)
                        {
                            SimpleOutput("Datum: " + i.inputDate + " | " +
                                "Empfänger / Auftraggeber: " + i.partnerName + " | " +
                                "Verwendungszweck: " + i.text + " | "
                                + "Betrag: " + i.amount);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Umsätze im Format camt052 abholen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void camt_052_abholen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                var transactions = Main.Transactions_camt(connectionDetails, _tanDialog, false, camtVersion.camt052);

                HBCIOutput(transactions.Messages);

                if (transactions.IsSuccess)
                {
                    foreach (var item in transactions.Data)
                    {
                        foreach (var i in item.transactions)
                        {
                            SimpleOutput("Datum: " + i.inputDate + " | " +
                                "Empfänger / Auftraggeber: " + i.partnerName + " | " +
                                "Verwendungszweck: " + i.description + " | "
                                + "Betrag: " + String.Format("{0:0.00}", i.amount));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Umsätze im Format camt053 abholen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void camt_053_abholen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                var transactions = Main.Transactions_camt(connectionDetails, _tanDialog, false, camtVersion.camt053);

                HBCIOutput(transactions.Messages);

                if (transactions.IsSuccess)
                {
                    foreach (var item in transactions.Data)
                    {
                        foreach (var i in item.transactions)
                        {
                            SimpleOutput("Datum: " + i.inputDate + " | " +
                                "Empfänger / Auftraggeber: " + i.partnerName + " | " +
                                "Verwendungszweck: " + i.text + " | "
                                + "Betrag: " + i.amount);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Überweisen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_überweisen_Click(object sender, EventArgs e)
        {
            Main.Logging(true);

            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);

            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                // TAN-Verfahren
                Segment.HIRMS = txt_tanverfahren.Text;

                var tanDialog = new TANDialog(WaitForTAN, pBox_tan);

                // TAN-Medium-Name
                AccountInformations accountInfo = UPD.HIUPD?.GetAccountInformations(connectionDetails.Account, connectionDetails.Blz.ToString());
                if (accountInfo != null && accountInfo.IsSegmentPermitted("HKTAB"))
                {
                    var requestTanResult = Main.RequestTANMediumName(connectionDetails, _tanDialog);
                    if (!requestTanResult.IsSuccess)
                    {
                        HBCIOutput(requestTanResult.Messages);
                        return;
                    }
                    Segment.HITAB = requestTanResult.Data.FirstOrDefault();
                }

                var transfer = Main.Transfer(connectionDetails, tanDialog, txt_empfängername.Text, Regex.Replace(txt_empfängeriban.Text, @"\s+", ""), txt_empfängerbic.Text,
                    decimal.Parse(txt_betrag.Text), txt_verwendungszweck.Text, Segment.HIRMS, false);

                // Out image is needed e. g. for photoTAN
                //var transfer = Main.Transfer(connectionDetails, txt_empfängername.Text, txt_empfängeriban.Text, txt_empfängerbic.Text,
                //    decimal.Parse(txt_betrag.Text), txt_verwendungszweck.Text, Segment.HIRMS, pBox_tan, false);

                HBCIOutput(transfer.Messages);
            }
        }

        /// <summary>
        /// TAN-Medium-Name abfragen -> Notwendig bsp. für pushTAN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tan_medium_name_abfragen_Click(object sender, EventArgs e)
        {
            Segment.Reset();

            ConnectionDetails connectionDetails = GetConnectionDetails();

            var sync = Main.Synchronization(connectionDetails);
            connectionDetails.CustomerSystemId = Segment.HISYN;

            HBCIOutput(sync.Messages);

            if (sync.IsSuccess)
            {
                Segment.HIRMS = txt_tanverfahren.Text;
                var result = Main.RequestTANMediumName(connectionDetails, _tanDialog);

                HBCIOutput(result.Messages);

                if (result.IsSuccess)
                    SimpleOutput(string.Join(", ", result.Data));
            }
        }

        private bool _tanReady;

        /// <summary>
        /// Auftrag mit TAN bestätigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_auftrag_bestätigen_tan_Click(object sender, EventArgs e)
        {
            _tanReady = true;
            // Wird eigentlich nicht mehr benötigt -> UserTANDialog

            //ConnectionDetails connectionDetails = GetConnectionDetails();

            //var tan = Main.TAN(connectionDetails, txt_tan.Text);

            //HBCIOutput(tan.Messages);
        }

        private void chk_Tracing_CheckedChanged(object sender, EventArgs e)
        {
            Main.Tracing(chk_tracing.Checked, false);
            if (chk_tracing.Checked)
            {
                MessageBox.Show("Achtung: Die Nachrichten werden im Klartext (inkl. PIN, Benutzerkennung, TAN) in eine Textdatei geschrieben!");
            }
            chk_tracingFormatted.Visible = chk_tracing.Checked;
        }

        private void chk_tracingFormatted_CheckedChanged(object sender, EventArgs e)
        {
            Main.Tracing(chk_tracing.Checked, chk_tracingFormatted.Checked);
        }

        private ConnectionDetails GetConnectionDetails()
        {
            var result = new ConnectionDetails()
            {
                AccountHolder = txt_empfängername.Text,
                Account = txt_kontonummer.Text,
                Blz = Convert.ToInt32(txt_bankleitzahl.Text),
                BlzHeadquarter = string.IsNullOrWhiteSpace(txt_bankleitzahl_zentrale.Text) ? (int?)null : Convert.ToInt32(txt_bankleitzahl_zentrale.Text),
                BIC = txt_bic.Text,
                IBAN = Regex.Replace(txt_iban.Text, @"\s+", ""),
                Url = txt_url.Text,
                HBCIVersion = Convert.ToInt32(txt_hbci_version.Text),
                UserId = txt_userid.Text,
                Pin = txt_pin.Text
            };

            return result;
        }

        private void Txt_bankleitzahl_TextChanged(object sender, EventArgs e)
        {
            var bank = _bankList.FirstOrDefault(b => b.Blz == txt_bankleitzahl.Text);
            if (bank != null)
            {
                txt_bankleitzahl_zentrale.Text = bank.BlzZentrale;
                txt_bic.Text = bank.Bic;
                txt_url.Text = bank.Url;
                txt_hbci_version.Text = "300";
            }

            UpdateIban();
        }

        private void UpdateIban()
        {
            if (!string.IsNullOrEmpty(txt_bankleitzahl.Text) && !string.IsNullOrWhiteSpace(txt_kontonummer.Text))
            {
                txt_iban.Text = CreateIban(txt_bankleitzahl.Text, txt_kontonummer.Text);
            }
        }

        public static string CreateIban(string blz, string kntnr, bool groupedReturn = true)
        {
            string lkz = "DE";

            string bban = blz.PadLeft(8, '0') + kntnr.PadLeft(10, '0');

            string sum = bban + lkz.Aggregate("", (current, c) => current + (c - 55).ToString()) + "00";

            try
            {
                var d = decimal.Parse(sum);
                var checksum = 98 - (d % 97);
                string iban = lkz + checksum.ToString().PadLeft(2, '0') + bban;
                return groupedReturn ? FormatIBAN(iban) : iban;
            }
            catch (Exception)
            {
            }
            return null;
        }

        public static string FormatIBAN(string iban)
        {
            iban = iban?.ToUpper()?.Trim();
            if (iban == null)
                return string.Empty;

            iban = Regex.Replace(iban, @"\s+", "");

            return iban.Select((c, i) => (i % 4 == 3) ? c + " " : c + "").Aggregate("", (current, c) => current + c);
        }

        private void Txt_kontonummer_TextChanged(object sender, EventArgs e)
        {
            UpdateIban();
        }

        public string WaitForTAN(TANDialog tanDialog)
        {
            HBCIOutput(tanDialog.DialogResult.Messages);

            txt_tan.BackColor = Color.LightYellow;
            txt_tan.Focus();

            while (!_tanReady)
            {
                Application.DoEvents();
            }
            var tan = txt_tan.Text;

            txt_tan.BackColor = Color.White;
            txt_tan.Text = string.Empty;

            _tanReady = false;

            return tan;
        }

        static string _accountFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "account.csv");

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string account = $"{txt_kontonummer.Text};{txt_bankleitzahl.Text};{txt_bankleitzahl_zentrale.Text};{txt_bic.Text};{txt_iban.Text};{txt_url.Text};{txt_hbci_version.Text};{txt_userid.Text};{txt_tanverfahren.Text}";

            File.WriteAllText(_accountFile, account);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tanDialog = new TANDialog(WaitForTAN);
            _bankList = Bank.GetBankList();

            if (chk_tracing.Checked)
                Main.Tracing(true);

            if (File.Exists(_accountFile))
            {
                var content = File.ReadAllText(_accountFile);
                var fields = content.Split(';');
                if (fields.Length == 9)
                {
                    txt_kontonummer.Text = fields[0];
                    txt_bankleitzahl.Text = fields[1];
                    txt_bankleitzahl_zentrale.Text = fields[2];
                    txt_bic.Text = fields[3];
                    txt_iban.Text = fields[4];
                    txt_url.Text = fields[5];
                    txt_hbci_version.Text = fields[6];
                    txt_userid.Text = fields[7];
                    txt_tanverfahren.Text = fields[8];
                    txt_pin.Focus();
                }
            }

            var homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var productIdFile = Path.Combine(homeDir, ".libfintx", "Product_Id.txt");

            if (File.Exists(productIdFile))
                libfintx.Program.Buildname = File.ReadAllText(productIdFile);
        }
    }
}
