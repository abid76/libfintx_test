﻿/*	
 * 	
 *  This file is part of libfintx.
 *  
 *  Copyright (c) 2016 - 2018 Torsten Klinger
 * 	E-Mail: torsten.klinger@googlemail.com
 * 	
 * 	libfintx is free software; you can redistribute it and/or
 *	modify it under the terms of the GNU Lesser General Public
 * 	License as published by the Free Software Foundation; either
 * 	version 2.1 of the License, or (at your option) any later version.
 *	
 * 	libfintx is distributed in the hope that it will be useful,
 * 	but WITHOUT ANY WARRANTY; without even the implied warranty of
 * 	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * 	Lesser General Public License for more details.
 *	
 * 	You should have received a copy of the GNU Lesser General Public
 * 	License along with libfintx; if not, write to the Free Software
 * 	Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 * 	
 */

using libfintx.Util;
using System.Collections.Generic;
using System.Linq;

namespace libfintx
{
    public class AccountInformations
    {
        public string Accountiban { get; set; }
        public string Accountnumber { get; set; }
        public string Accountbankcode { get; set; }
        public string Accountuserid { get; set; }
        public string Accountowner { get; set; }
        public string Accounttype { get; set; }
        public string Accountcurrency { get; set; }
        public string Accountbic { get; set; }

        public List<AccountPermissions> Accountpermissions { get; set; }

        public bool IsSegmentPermitted(string segment)
        {
            return Accountpermissions.Any(a => a.Segment == segment);
        }

        public override string ToString()
        {
            return ReflectionUtil.ToString(this);
        }
    }

    public class AccountPermissions
    {
        public string Segment { get; set; }
        public string Description { get; set; }

        public static string Permission(string Segment)
        {
            switch (Segment)
            {
                case "BKAMA": return "Mindestalteranfrage mit Autorisierung";
                case "BIAMA": return "Mindestalteranfrage rückmelden";
                case "BIAMAS": return "Mindestalteranfrage Parameter";
                case "BKAMN": return "Mindestalteranfrage ohne Autorisierung";
                case "BIAMN": return "Mindestalteranfrage rückmelden";
                case "BIAMNS": return "Mindestalteranfrage Parameter";
                case "BKAGA": return "Geburtsdatumanfrage mit Autorisierung";
                case "BIAGA": return "Geburtsdatum rückmelden";
                case "BIAGAS": return "Geburtsdatumanfrage Parameter";
                case "BKAGN": return "Geburtsdatumanfrage ohne Autorisierung";
                case "BIAGN": return "Geburtsdatum rückmelden";
                case "BIAGNS": return "Geburtsdatumanfrage Parameter";
                case "DKTLA": return "TAN-Liste anfordern";
                case "DITLAS": return "TAN-Liste anfordern Parameter";
                case "DKTAZ": return "TAN-Liste anzeigen";
                case "DITAZ": return "TAN-Liste anzeigen Rückmeldung";
                case "DITAZS": return "TAN-Liste anzeigen Parameter";
                case "DKTLF": return "TAN-Liste freischalten";
                case "DITLFS": return "TAN-Liste freischalten Parameter";
                case "DKTSP": return "TAN-Liste sperren";
                case "DITSPS": return "TAN-Liste sperren Parameter";
                case "DKPAE": return "PIN ändern";
                case "DIPAES": return "PIN ändern Parameter";
                case "DKPSP": return "PIN sperren";
                case "DIPSPS": return "PIN sperren Parameter";
                case "DKPSA": return "PIN-Sperre aufheben";
                case "DIPSAS": return "PIN-Sperre aufheben Parameter";
                case "DIPINS": return "BPD-Erweiterung für PIN-TAN-Verfahren";
                case "DKANA": return "Anmeldename anlegen/ändern";
                case "DKANL": return "Anmeldename löschen";
                case "DIANL": return "Anmeldename löschen bestätigen";
                case "DKFPO": return "Festpreisorder";
                case "DKBAZ": return "Zahlungsverkehrsdateien abfragen";
                case "DKBRK": return "Bestand Referenzkonten";
                case "DKURK": return "Komfortüberweisung";
                case "DKKAU": return "Kreditkartenabrechnungsübersicht anfordern";
                case "DKKKA": return "Kreditkartenabrechnungen anfordern";
                case "DKKKU": return "Kreditkartenumsätze anfordern";
                case "DKZDF": return "Zahlungsverkehrsdateien freigeben";
                case "DKZDL": return "Zahlungsverkehrsdateien löschen";
                case "HIADRS": return "Adressänderung Parameter";
                case "HIAOMS": return "Auslandsüberweisung ohne Meldeteil Parameter";
                case "HIAUBS": return "Auslandsüberweisung Parameter";
                case "HIAUE": return "Ausgeführte Überweisungen rückmelden";
                case "HIAUES": return "Ausgeführte Überweisungen Parameter";
                case "HIAZK": return "Kartenanzeige";
                case "HIAZKS": return "Kartenanzeige Parameter";
                case "HIAZS": return "Alternative ZKA Sicherheitsverfahren Rückmeldung";
                case "HIAZSS": return "Alternative ZKA Sicherheitsverfahren, Parameter";
                case "HIBBS": return "Bestand terminierter SEPA-Firmeneinzellastschriften rückmelden";
                case "HIBBSS": return "Bestand terminierter SEPA-Firmeneinzellastschriften Parameter";
                case "HIBDDS": return "SEPA-Firmensammellastschrift Parameter";
                case "HIBDS": return "SEPA-Firmeneinzellastschrift Parameter";
                case "HIBMB": return "Bestand terminierter SEPA-Firmensammellastschriften rückmelden";
                case "HIBMBS": return "Bestand terminierter SEPA-Firmensammellastschriften, Parameter";
                case "HIBME": return "Einreichung terminierter SEPA-Firmensammellastschrift bestätigen";
                case "HIBMES": return "Terminierte SEPA-Firmensammellastschrift einreichen Parameter";
                case "HIBMLS": return "Terminierte SEPA-Firmensammellastschrift löschen Parameter";
                case "HIBPA": return "Bankparameter allgemein";
                case "HIBSA": return "Änderung terminierter SEPA-Firmeneinzellastschrift bestätigen";
                case "HIBSAS": return "Terminierte SEPA-Firmeneinzellastschrift ﾊndern Parameter";
                case "HIBSE": return "Einreichung terminierter SEPA-Firmeneinzellastschrift bestätigen";
                case "HIBSES": return "Terminierte SEPA-Firmeneinzellastschrift einreichen Parameter";
                case "HIBSLS": return "Terminierte SEPA-Firmeneinzellastschrift löschen Parameter";
                case "HICAN": return "Kontoumsätze rückmelden/neue Umsätze camt";
                case "HICANS": return "Kontoumsätze/neu camt Parameter";
                case "HICAZ": return "Kontoumsätze rückmelden/Zeitraum camt";
                case "HICAZS": return "Kontoumsätze/Zeitraum camt Parameter";
                case "HICCMS": return "SEPA-Sammelüberweisung Parameter";
                case "HICCSS": return "SEPA Einzelüberweisung Parameter";
                case "HICDA": return "SEPA-Dauerauftragsänderungsvormerkungen rückmelden";
                case "HICDAS": return "SEPA-Dauerauftragsänderungsvormerkungen Parameter";
                case "HICDB": return "SEPA-Dauerauftragsbestand rückmelden";
                case "HICDBS": return "SEPA-Dauerauftragsbestand Parameter";
                case "HICDDS": return "SEPA-Sammellastschrift Parameter";
                case "HICDE": return "SEPA-Dauerauftragseinrichtung bestätigen";
                case "HICDES": return "SEPA-Dauerauftrag einrichten Parameter";
                case "HICDLS": return "SEPA-Dauerauftrag löschen Parameter";
                case "HICDN": return "SEPA-Dauerauftragsänderung bestätigen";
                case "HICDNS": return "SEPA-Dauerauftrag ändern Parameter";
                case "HICDSS": return "Lastschrift Parameter";
                case "HICDU": return "SEPA-Dauerauftragsaussetzung bestätigen";
                case "HICDUS": return "SEPA-Dauerauftrag aussetzen Parameter";
                case "HICMB": return "Bestand terminierter SEPA-Sammelüberweisungen rückmelden";
                case "HICMBS": return "Bestand terminierter SEPA-Sammelüberweisungen Parameter";
                case "HICME": return "Einreichung terminierter SEPA-Sammelüberweisung bestätigen";
                case "HICMES": return "Terminierte SEPA-Sammelüberweisung einreichen Parameter";
                case "HICMLS": return "Terminierte SEPA-Sammelüberweisung löschen Parameter";
                case "HICSA": return "Änderung terminierter SEPA-Überweisung bestätigen";
                case "HICSAS": return "Terminierte SEPA-Überweisung ändern Parameter";
                case "HICSB": return "Bestand terminierter SEPA-Überweisungen rückmelden";
                case "HICSBS": return "Bestand terminierter SEPA-Überweisungen Parameter";
                case "HICSE": return "Einreichung terminierter SEPA-Überweisung bestätigen";
                case "HICSES": return "Terminierte SEPA-Überweisung einreichen Parameter";
                case "HICSLS": return "Terminierte SEPA-Überweisung löschen Parameter";
                case "HICVAS": return "Vorbereitete SEPA-Überweisung ändern Parameter";
                case "HICVB": return "Bestand vorbereiteter SEPA-Überweisungen";
                case "HICVBS": return "Bestand vorbereiteter SEPA-Überweisungen Parameter";
                case "HICVE": return "Anlage vorbereiteter SEPA-Überweisung bestätigen";
                case "HICVES": return "Vorbereitete SEPA-Überweisung anlegen Parameter";
                case "HICVLS": return "Vorbereitete SEPA-Überweisung löschen Parameter";
                case "HIDAA": return "Dauerauftragsänderungsvormerkungen rückmelden";
                case "HIDAAS": return "Dauerauftragsänderungsvormerkungen Parameter";
                case "HIDAB": return "Dauerauftragsbestand rückmelden";
                case "HIDABS": return "Dauerauftragsbestand Parameter";
                case "HIDAE": return "Dauerauftragseinrichtung bestätigen";
                case "HIDAES": return "Dauerauftrag einrichten Parameter";
                case "HIDALS": return "Dauerauftrag löschen Parameter";
                case "HIDAN": return "Dauerauftragsänderung bestätigen";
                case "HIDANS": return "Dauerauftrag ändern Parameter";
                case "HIDAS": return "Dauerauftragsaussetzung bestätigen";
                case "HIDASS": return "Dauerauftrag aussetzen Parameter";
                case "HIDBS": return "Bestand terminierter SEPA-Einzellastschriften rückmelden";
                case "HIDBSS": return "Bestand terminierter SEPA-Einzellastschriften Parameter";
                case "HIDEA": return "Dauereinzellastschriftänderung bestätigen";
                case "HIDEAS": return "Dauereinzellastschrift ändern Parameter";
                case "HIDEB": return "Dauereinzellastschriftbestand rückmelden";
                case "HIDEBS": return "Dauereinzellastschriftbestand Parameter";
                case "HIDEE": return "Dauereinzellastschrifteinrichtung bestätigen";
                case "HIDEES": return "Dauereinzellastschrift einrichten Parameter";
                case "HIDELS": return "Dauereinzellastschrift löschen Parameter";
                case "HIDEU": return "Dauereinzellastschriftaussetzung bestätigen";
                case "HIDEUS": return "Dauereinzellastschrift aussetzen Parameter";
                case "HIDEV": return "Dauereinzellastschriftänderungsvormerkungen rückmelden";
                case "HIDEVS": return "Dauereinzellastschriftänderungsvormerkungen anfordern, Parameter";
                case "HIDMB": return "Bestand terminierter SEPA-Sammellastschriften rückmelden";
                case "HIDMBS": return "Bestand terminierter SEPA-Sammellastschriften Parameter";
                case "HIDME": return "Einreichung terminierter SEPA-Sammellastschrift bestätigen";
                case "HIDMES": return "Terminierte SEPA-Sammellastschrift einreichen Parameter";
                case "HIDMLS": return "Terminierte SEPA-Sammellastschrift löschen Parameter";
                case "HIDSA": return "Änderung terminierter SEPA-Einzellastschriften bestätigen";
                case "HIDSAS": return "Terminierte SEPA-Einzellastschrift ändern Parameter";
                case "HIDSB": return "Bestand SEPA-Lastschriftwiderspruch rückmelden";
                case "HIDSBS": return "Bestand Lastschriftwiderspruch Parameter";
                case "HIDSE": return "Einreichung terminierter SEPA-Einzellastschrift bestätigen";
                case "HIDSES": return "Terminierte SEPA-Einzellastschrift einreichen Parameter";
                case "HIDSLS": return "Terminierte SEPA-Einzellastschrift löschen Parameter";
                case "HIDSWS": return "SEPA-Lastschriftwiderspruch Parameter";
                case "HIDTES": return "Eilüberweisung (Sammel) Parameter";
                case "HIDVK": return "Devisenkurse rückmelden";
                case "HIDVKS": return "Devisenkurse Parameter";
                case "HIECA": return "Kontoauszug camt";
                case "HIECAS": return "Kontoauszug camt Parameter";
                case "HIEILS": return "Eilüberweisung (Einzel) Parameter";
                case "HIEKA": return "Kontoauszug";
                case "HIEKAS": return "Kontoauszug Parameter";
                case "HIEKP": return "Kontoauszug PDF";
                case "HIEKPS": return "Kontoauszug PDF Parameter";
                case "HIESUS": return "EU-Standardüberweisung Parameter";
                case "HIEUES": return "Euro-Eilüberweisung Parameter";
                case "HIFDA": return "Finanzdatenformat rückmelden";
                case "HIFDAS": return "Finanzdatenformat anfordern Parameter";
                case "HIFDB": return "Bearbeitungsstatus Finanzdatenformat rückmelden";
                case "HIFDBS": return "Bearbeitungsstatus Finanzdatenformat Parameter";
                case "HIFDL": return "Finanzdatenformatliste rückmelden";
                case "HIFDLS": return "Finanzdatenformatliste anfordern Parameter";
                case "HIFDS": return "Bearbeitungsstatus Dokument rückmelden";
                case "HIFDSS": return "Finanzdatenformat senden Parameter";
                case "HIFGA": return "Festgeldänderung bestätigen";
                case "HIFGAS": return "Festgeld ﾊndern Parameter";
                case "HIFGB": return "Festgeldbestand rückmelden";
                case "HIFGBS": return "Festgeldbestand Parameter";
                case "HIFGK": return "Festgeldkonditionen rückmelden";
                case "HIFGKS": return "Festgeldkonditionen Parameter";
                case "HIFGN": return "Festgeldneuanlage bestätigen";
                case "HIFGNS": return "Festgeldneuanlage Parameter";
                case "HIFGP": return "Festgeldprolongation bestätigen";
                case "HIFGPS": return "Festgeldprolongation Parameter";
                case "HIFGWS": return "Festgeldneuanlage widerrufen Parameter";
                case "HIFPO": return "Festpreisordereinreichung bestätigen";
                case "HIFPOS": return "Festpreisorder Parameter";
                case "HIFPWS": return "Festgeldprolongation widerrufen Parameter";
                case "HIFRA": return "Einreichung Freistellungsauftrag bestätigen";
                case "HIFRAS": return "Freistellungsauftrag anlegen Parameter";
                case "HIFRD": return "Freistellungsdaten rückmelden";
                case "HIFRDS": return "Freistellungsdaten Parameter";
                case "HIFRLS": return "Freistellungsdaten löschen Parameter";
                case "HIFRNS": return "Freistellungsdaten ändern Parameter";
                case "HIGAMS": return "Gastmeldung Parameter";
                case "HIGUB": return "Bestätigung Einreichung garantierte Überweisung";
                case "HIGUBS": return "Garantierte Überweisung Parameter";
                case "HIHSI": return "HHD/Secoder Informationen rückmelden";
                case "HIHSIS": return "HHD/Secoder Informationen Parameter";
                case "HIINF": return "Informationen rückmelden";
                case "HIINFS": return "Informationsanforderung Parameter";
                case "HIISA": return "Übermittlung eines öffentlichen Schlüssels";
                case "HIKAN": return "Kontoumsätze rückmelden/neue Umsätze";
                case "HIKANS": return "Kontoumsätze/neu Parameter";
                case "HIKASS": return "Kartensperre beantragen Parameter";
                case "HIKAU": return "Übersicht Kontoauszüge";
                case "HIKAUS": return "Übersicht Kontoauszüge Parameter";
                case "HIKAZ": return "Kontoumsätze rückmelden/Zeitraum";
                case "HIKAZS": return "Kontoumsätze/Zeitraum Parameter";
                case "HIKDD": return "Kundendaten rückmelden";
                case "HIKDDS": return "Kundendaten Parameter";
                case "HIKDMS": return "Kundenmeldung Parameter";
                case "HIKIA": return "Kreditinstitutsangebote rückmelden";
                case "HIKIAS": return "Kreditinstitutsangebote Parameter";
                case "HIKIF": return "Kontoinformationen rückmelden";
                case "HIKIFS": return "Kontoinformationen Parameter";
                case "HIKIM": return "Kreditinstitutsmeldung";
                case "HIKOM": return "Kommunikationszugang rückmelden";
                case "HIKOMS": return "Kommunikationszugang Parameter";
                case "HIKPV": return "Komprimierungsverfahren";
                case "HILASS": return "Lastschrift Parameter";
                case "HILGAS": return "Laden GeldKarte abmelden Parameter";
                case "HILGB": return "Laden GeldKarte bestätigen Antwort";
                case "HILGBS": return "Laden GeldKarte bestätigen Parameter";
                case "HILGD": return "Laden GeldKarte durchführen Antwort";
                case "HILGDS": return "Laden GeldKarte durchführen Parameter";
                case "HILGE": return "Laden GeldKarte einleiten Antwort";
                case "HILGES": return "Laden GeldKarte einleiten Parameter";
                case "HILGO": return "Laden GeldKarte Storno vorbereiten Antwort";
                case "HILGOS": return "Laden GeldKarte Storno vorbereiten Parameter";
                case "HILGRS": return "Laden Geldkarte registrieren Parameter";
                case "HILGS": return "Laden GeldKarte Status";
                case "HILGSS": return "Laden GeldKarte Statusanfrage Parameter";
                case "HILGT": return "Laden GeldKarte Storno durchführen Antwort";
                case "HILGTS": return "Laden GeldKarte Storno durchführen Parameter";
                case "HILGV": return "Laden GeldKarte vorbereiten Antwort";
                case "HILGVS": return "Laden GeldKarte vorbereiten Parameter";
                case "HILGX": return "Laden GeldKarte Storno Bestätigung";
                case "HILGXS": return "Laden GeldKarte Storno bestätigen Parameter";
                case "HILSWS": return "Lastschriftwiderspruch Parameter";
                case "HILWB": return "Bestand Lastschriftwiderspruch";
                case "HILWBS": return "Bestand Lastschriftwiderspruch Parameter";
                case "HIMTAS": return "Mobilfunkverbindung ändern Parameter";
                case "HIMTFS": return "Mobilfunkverbindung freischalten Parameter";
                case "HIMTRS": return "Mobilfunkverbindung registrieren Parameter";
                case "HINEA": return "Liste Neuemissionen";
                case "HINEAS": return "Liste Neuemissionen Parameter";
                case "HINEZ": return "Einreichung Zeichnung bestätigen";
                case "HINEZS": return "Neuemission zeichnen Parameter";
                case "HIOAN": return "Orderanzeige";
                case "HIOANS": return "Orderanzeige Parameter";
                case "HIPAES": return "PIN ändern Parameter";
                case "HIPINS": return "PIN-TAN-spezifische Informationen";
                case "HIPPDS": return "Prepaidkarte laden Parameter";
                case "HIPRO": return "Statusprotokoll rückmelden";
                case "HIPROS": return "Statusprotokoll Parameter";
                case "HIPSAS": return "PIN-Sperre aufheben Parameter";
                case "HIPSPS": return "PIN sperren Parameter";
                case "HIQTGS": return "Empfangsquittung Parameter";
                case "HIRMG": return "Rückmeldungen zur Gesamtnachricht";
                case "HIRMS": return "Rückmeldungen zu Segmenten";
                case "HISAL": return "Saldenrückmeldung";
                case "HISALS": return "Saldenabfrage Parameter";
                case "HISHV": return "Sicherheitsverfahren";
                case "HISLAS": return "Sammellastschrift Parameter";
                case "HISLB": return "Bestand terminierter Sammellastschriften rückmelden";
                case "HISLBS": return "Bestand terminierter Sammellastschriften Parameter";
                case "HISLE": return "Einreichung terminierter Sammellastschrift bestätigen";
                case "HISLES": return "Terminierte Sammellastschrift einreichen Parameter";
                case "HISLLS": return "Terminierte Sammellastschrift löschen Parameter";
                case "HISPA": return "SEPA-Kontoverbindung rückmelden";
                case "HISPAS": return "SEPA-Kontoverbindung anfordern, Parameter";
                case "HISRBS": return "Sorten- und Reisescheckbestellung Parameter";
                case "HISRK": return "Sorten- und Reisescheckkonditionen rückmelden";
                case "HISRKS": return "Sorten- und Reisescheckkonditionen Parameter";
                case "HISSP": return "Bestätigung der Schlüsselsperrung";
                case "HISTPS": return "Euro-STP-Zahlung Parameter";
                case "HISUBS": return "Sammelüberweisung Parameter";
                case "HISYN": return "Synchronisierungsantwort";
                case "HISZT": return "Serverzeit";
                case "HISZTS": return "Serverzeit Parameter";
                case "HITAB": return "TAN-Generator/Liste anzeigen Bestand Rückmeldung";
                case "HITABS": return "TAN-Generator/Liste anzeigen Bestand Parameter";
                case "HITAN": return "Zwei-Schritt TAN Einreichung Rückmeldung";
                case "HITANS": return "Zwei-Schritt TAN Einreichung Parameter";
                case "HITAUS": return "TAN-Generator an- bzw. ummelden Parameter";
                case "HITAZ": return "TAN-Verbrauchsinformationen rückmelden";
                case "HITAZS": return "TAN-Verbrauchsinformationen Parameter";
                case "HITEA": return "Änderung terminierter Einzellastschrift bestätigen";
                case "HITEAS": return "Terminierte Einzellastschrift ändern Parameter";
                case "HITEB": return "Bestand terminierter Einzellastschriften rückmelden";
                case "HITEBS": return "Bestand terminierter Einzellastschriften Parameter";
                case "HITEE": return "Einreichung terminierter Einzellastschrift bestätigen";
                case "HITEES": return "Terminierte Einzellastschrift einreichen Parameter";
                case "HITELS": return "Terminierte Einzellastschrift löschen Parameter";
                case "HITLAS": return "TAN-Liste anfordern Parameter";
                case "HITLFS": return "TAN-Liste freischalten Parameter";
                case "HITMLS": return "TAN-Medium deaktivieren oder löschen Parameter";
                case "HITMVS": return "Terminvereinbarung Parameter";
                case "HITSB": return "Bestand terminierter Sammelüberweisungen rückmelden";
                case "HITSBS": return "Bestand terminierter Sammelüberweisungen Parameter";
                case "HITSE": return "Einreichung terminierter Sammelüberweisung bestätigen";
                case "HITSES": return "Terminierte Sammelüberweisung einreichen Parameter";
                case "HITSLS": return "Terminierte Sammelüberweisung löschen Parameter";
                case "HITSPS": return "TAN-Liste löschen Parameter";
                case "HITSYS": return "TAN-Generator Synchronisierung Parameter";
                case "HITUA": return "Änderung terminierter Überweisung bestätigen";
                case "HITUAS": return "Terminierte Überweisung ändern Parameter ";
                case "HITUB": return "Bestand terminierter Überweisungen rückmelden";
                case "HITUBS": return "Bestand terminierter Überweisungen Parameter";
                case "HITUE": return "Einreichung terminierter Überweisung bestﾊtigen";
                case "HITUES": return "Terminierte Überweisung einreichen Parameter";
                case "HITULS": return "Terminierte Überweisung löschen Parameter";
                case "HIUEBS": return "Einzelüberweisung Parameter";
                case "HIUMBS": return "Umbuchung Parameter";
                case "HIUPA": return "Userparameter allgemein";
                case "HIUPD": return "Kontoinformation";
                case "HIVDBS": return "Vordruckbestellung Parameter";
                case "HIVISS": return "Secoder-spezifische Visualisierungsinformationen";
                case "HIVMK": return "Vormerkposten anfordern";
                case "HIVMKS": return "Vormerkposten anfordern Parameter";
                case "HIVUAS": return "Vorbereitete Überweisung ändern Parameter";
                case "HIVUB": return "Bestand vorbereiteter Überweisungen";
                case "HIVUBS": return "Bestand vorbereiteter Überweisungen Parameter";
                case "HIVUE": return "Anlage vorbereiteter Überweisung bestätigen";
                case "HIVUES": return "Vorbereitete Überweisung anlegen Parameter";
                case "HIVULS": return "Vorbereitete Überweisung löschen Parameter";
                case "HIWDU": return "Depotumsätze rückmelden";
                case "HIWDUS": return "Depotumsätze Parameter";
                case "HIWFO": return "Fondsordereinreichung bestätigen";
                case "HIWFOS": return "Fondsorder Parameter";
                case "HIWFP": return "Festpreisangebote rückmelden";
                case "HIWFPS": return "Festpreisangebote Parameter";
                case "HIWOA": return "Wertpapierorderänderung bestätigen";
                case "HIWOAS": return "Wertpapierorderänderung Parameter";
                case "HIWOH": return "Wertpapierorderhistorie rückmelden";
                case "HIWOHS": return "Wertpapierorderhistorie Parameter";
                case "HIWPD": return "Depotaufstellung rückmelden";
                case "HIWPDS": return "Depotaufstellung Parameter";
                case "HIWPH": return "Wichtige Informationen rückmelden";
                case "HIWPHS": return "Wichtige Informationen Parameter";
                case "HIWPI": return "Wertpapierinformationen rückmelden";
                case "HIWPIS": return "Wertpapierinformationen Parameter";
                case "HIWPK": return "Wertpapierkurse rückmelden";
                case "HIWPKS": return "Wertpapierkurse Parameter";
                case "HIWPO": return "Wertpapierordereinreichung bestätigen";
                case "HIWPOS": return "Wertpapierorder Parameter";
                case "HIWPR": return "Wertpapierreferenznummern rückmelden";
                case "HIWPRS": return "Wertpapierreferenznummern Parameter";
                case "HIWPS": return "Wertpapierorderstreichung bestätigen";
                case "HIWPSS": return "Wertpapierorderstreichung Parameter";
                case "HIWSD": return "Wertpapierstammdaten rückmelden";
                case "HIWSDS": return "Wertpapierstammdaten Parameter";
                case "HIWSO": return "Orderstatus";
                case "HIWSOS": return "Orderstatus Parameter";
                case "HKADR": return "Adressänderung";
                case "HKAOM": return "Auslandsüberweisung ohne Meldeteil";
                case "HKAUB": return "Auslandsüberweisung";
                case "HKAUE": return "Ausgeführte Überweisungen anfordern";
                case "HKAZK": return "Kartenanzeige anfordern";
                case "HKAZS": return "Alternative ZKA Sicherheitsverfahren";
                case "HKBBS": return "Bestand terminierter SEPA-Firmeneinzellastschriften anfordern";
                case "HKBDD": return "SEPA-Firmensammellastschrift";
                case "HKBDS": return "SEPA-Firmeneinzellastschrift";
                case "HKBMB": return "Bestand terminierter SEPA-Firmensammellastschriften anfordern";
                case "HKBME": return "Terminierte SEPA-Firmensammellastschrift einreichen";
                case "HKBML": return "Terminierte SEPA-Firmensammellastschrift löschen";
                case "HKBSA": return "Terminierte SEPA-Firmeneinzellastschrift ﾊndern";
                case "HKBSE": return "Terminierte SEPA-Firmeneinzellastschrift einreichen";
                case "HKBSL": return "Terminierte SEPA-Firmeneinzellastschrift löschen";
                case "HKCAN": return "Kontoumsätze anfordern/neue Umsätze camt";
                case "HKCAZ": return "Kontoumsätze anfordern/Zeitraum camt";
                case "HKCCM": return "SEPA-Sammelüberweisung";
                case "HKCCS": return "SEPA Einzelüberweisung";
                case "HKCDA": return "SEPA-Dauerauftragsänderungsvormerkungen anfordern";
                case "HKCDB": return "SEPA-Dauerauftragsbestand anfordern";
                case "HKCDD": return "SEPA-Sammellastschrift";
                case "HKCDE": return "SEPA-Dauerauftrag einrichten";
                case "HKCDL": return "SEPA-Dauerauftrag löschen";
                case "HKCDN": return "SEPA-Dauerauftrag ändern";
                case "HKCDS": return "SEPA-Einzellastschrift";
                case "HKCDU": return "SEPA-Dauerauftrag aussetzen";
                case "HKCMB": return "Bestand terminierter SEPA-Sammelüberweisungen anfordern";
                case "HKCME": return "Terminierte SEPA-Sammelüberweisung einreichen";
                case "HKCML": return "Terminierte SEPA-Sammelüberweisung löschen";
                case "HKCSA": return "Terminierte SEPA-Überweisung ändern";
                case "HKCSB": return "Bestand terminierter SEPA-Überweisungen anfordern";
                case "HKCSE": return "Terminierte SEPA-Überweisung einreichen";
                case "HKCSL": return "Terminierte SEPA-Überweisung löschen";
                case "HKCVA": return "Vorbereitete SEPA-Überweisung ändern";
                case "HKCVB": return "Bestand vorbereiteter SEPA-Überweisungen abfragen";
                case "HKCVE": return "Vorbereitete SEPA-Überweisung anlegen";
                case "HKCVL": return "Vorbereitete SEPA-Überweisung löschen";
                case "HKDAA": return "Dauerauftragsänderungsvormerkungen anfordern";
                case "HKDAB": return "Dauerauftragsbestand anfordern";
                case "HKDAE": return "Dauerauftrag einrichten";
                case "HKDAL": return "Dauerauftrag löschen";
                case "HKDAN": return "Dauerauftrag ändern";
                case "HKDAS": return "Dauerauftrag aussetzen";
                case "HKDBS": return "Bestand terminierter SEPA-Einzellastschriften anfordern";
                case "HKDEA": return "Dauereinzellastschrift ändern";
                case "HKDEB": return "Dauereinzellastschriftbestand anfordern";
                case "HKDEE": return "Dauereinzellastschrift einrichten";
                case "HKDEL": return "Dauereinzellastschrift löschen";
                case "HKDEU": return "Dauereinzellastschrift aussetzen";
                case "HKDEV": return "Dauereinzellastschriftänderungsvormerkungen anfordern";
                case "HKDMB": return "Bestand terminierter SEPA-Sammellastschriften anfordern";
                case "HKDME": return "Terminierte SEPA-Sammellastschrift einreichen";
                case "HKDML": return "Terminierte SEPA-Sammellastschrift löschen";
                case "HKDSA": return "Terminierte SEPA-Einzellastschrift ändern";
                case "HKDSB": return "Bestand SEPA-Lastschriftwiderspruch anfordern";
                case "HKDSE": return "Terminierte SEPA-Einzellastschrift einreichen";
                case "HKDSL": return "Terminierte SEPA-Einzellastschrift löschen";
                case "HKDSW": return "SEPA-Lastschriftwiderspruch einreichen";
                case "HKDTE": return "Eilüberweisung (Sammel)";
                case "HKDVK": return "Devisenkurse anfordern";
                case "HKECA": return "Kontoauszug camt anfordern";
                case "HKEIL": return "Eilüberweisung (Einzel)";
                case "HKEKA": return "Kontoauszug anfordern";
                case "HKEKP": return "Kontoauszug PDF anfordern";
                case "HKEND": return "Dialogende";
                case "HKESU": return "EU-Standardüberweisung";
                case "HKEUE": return "Euro-Eilüberweisung";
                case "HKFDA": return "Finanzdatenformat anfordern";
                case "HKFDB": return "Bearbeitungsstatus Finanzdatenformat anfordern";
                case "HKFDL": return "Finanzdatenformatliste anfordern";
                case "HKFDS": return "Finanzdatenformat senden";
                case "HKFGA": return "Festgeldanlage ändern";
                case "HKFGB": return "Festgeldbestand anfordern";
                case "HKFGK": return "Festgeldkonditionen anfordern";
                case "HKFGn": return "Festgeldneuanlage";
                case "HKFGP": return "Festgeldanlage prolongieren";
                case "HKFGW": return "Festgeldneuanlage widerrufen";
                case "HKFPO": return "Festpreisorder";
                case "HKFPW": return "Festgeldprolongation widerrufen";
                case "HKFRA": return "Freistellungsauftrag anlegen";
                case "HKFRD": return "Freistellungsdaten abfragen";
                case "HKFRL": return "Freistellungsdaten löschen";
                case "HKFRn": return "Freistellungsdaten ändern";
                case "HKGAM": return "Gastmeldung";
                case "HKGUB": return "Garantierte Überweisung";
                case "HKHSI": return "HHD/Secoder Informationen übermitteln";
                case "HKIDn": return "Identifikation";
                case "HKINF": return "Informationen anfordern";
                case "HKISA": return "Anforderung eines öffentlichen Schlüssels";
                case "HKKAn": return "Kontoumsätze anfordern/neue Umsätze";
                case "HKKAS": return "Kartensperre beantragen";
                case "HKKAU": return "Übersicht Kontoauszüge";
                case "HKKAZ": return "Kontoumsätze anfordern/Zeitraum";
                case "HKKDD": return "Kundendaten anfordern";
                case "HKKDM": return "Kundenmeldung";
                case "HKKIA": return "Kreditinstitutsangebote anfordern";
                case "HKKIF": return "Kontoinformationen anfordern";
                case "HKKOM": return "Kommunikationszugang anfordern";
                case "HKLAS": return "Einzellastschrift";
                case "HKLGA": return "Laden GeldKarte abmelden";
                case "HKLGB": return "Laden GeldKarte bestätigen";
                case "HKLGD": return "Laden GeldKarte durchführen";
                case "HKLGE": return "Laden GeldKarte einleiten";
                case "HKLGO": return "Laden GeldKarte Storno vorbereiten";
                case "HKLGR": return "Laden GeldKarte registrieren";
                case "HKLGS": return "Laden GeldKarte Statusanfrage";
                case "HKLGT": return "Laden GeldKarte Storno durchführen";
                case "HKLGV": return "Laden GeldKarte vorbereiten";
                case "HKLGX": return "Laden GeldKarte Storno bestätigen";
                case "HKLSW": return "Lastschriftwiderspruch beantragen";
                case "HKLWB": return "Bestand Lastschriftwiderspruch";
                case "HKMTA": return "Mobilfunkverbindung ändern";
                case "HKMTF": return "Mobilfunkverbindung freischalten";
                case "HKMTR": return "Mobilfunkverbindung registrieren";
                case "HKNEA": return "Liste Neuemissionen anfordern";
                case "HKNEZ": return "Neuemission zeichnen";
                case "HKOAN": return "Orderanzeige anfordern";
                case "HKPAE": return "PIN ändern";
                case "HKPPD": return "Prepaidkarte laden";
                case "HKPRO": return "Statusprotokoll anfordern";
                case "HKPSA": return "PIN-Sperre aufheben";
                case "HKPSP": return "PIN sperren";
                case "HKQTG": return "Empfangsquittung";
                case "HKSAK": return "Schlüsseländerung";
                case "HKSAL": return "Saldenabfrage";
                case "HKSLA": return "Sammellastschrift";
                case "HKSLB": return "Bestand terminierter Sammellastschriften anfordern";
                case "HKSLE": return "Terminierte Sammellastschrift einreichen";
                case "HKSLL": return "Terminierte Sammellastschrift löschen";
                case "HKSPA": return "SEPA-Kontoverbindung anfordern";
                case "HKSRB": return "Sorten- und Reisescheckbestellung";
                case "HKSRK": return "Sorten- und Reisescheckkonditionen anfordern";
                case "HKSSP": return "Schlüsselsperrung";
                case "HKSTP": return "Euro-STP-Zahlung";
                case "HKSUB": return "Sammelüberweisung";
                case "HKSYN": return "Synchronisierung";
                case "HKSZT": return "Serverzeitabfrage";
                case "HKTAB": return "TAN-Generator/Liste anzeigen Bestand";
                case "HKTAN": return "Zwei-Schritt TAN Einreichung";
                case "HKTAU": return "TAN-Generator an- bzw. ummelden";
                case "HKTAZ": return "TAN-Verbrauchsinformationen anzeigen";
                case "HKTEA": return "Terminierte Einzellastschrift ändern";
                case "HKTEB": return "Bestand terminierter Einzellastschriften anfordern";
                case "HKTEE": return "Terminierte Einzellastschrift einreichen";
                case "HKTEL": return "Terminierte Einzellastschrift löschen";
                case "HKTLA": return "TAN-Liste anfordern";
                case "HKTLF": return "TAN-Liste freischalten";
                case "HKTML": return "TAN-Medium deaktivieren oder löschen";
                case "HKTMV": return "Terminvereinbarung";
                case "HKTSB": return "Bestand terminierter Sammelüberweisungen anfordern";
                case "HKTSE": return "Terminierte Sammelüberweisung einreichen";
                case "HKTSL": return "Terminierte Sammelüberweisung löschen";
                case "HKTSP": return "TAN-Liste löschen";
                case "HKTSY": return "TAN-Generator Synchronisierung";
                case "HKTUA": return "Terminierte Überweisung ändern";
                case "HKTUB": return "Bestand terminierter Überweisungen anfordern";
                case "HKTUE": return "Terminierte Überweisung einreichen";
                case "HKTUL": return "Terminierte Überweisung löschen";
                case "HKUEB": return "Einzelüberweisung";
                case "HKUMB": return "Umbuchung";
                case "HKVDB": return "Vordruckbestellung";
                case "HKVIS": return "Secoder-spezifische Visualisierungsinformationen";
                case "HKVMK": return "Vormerkposten anfordern";
                case "HKVUA": return "Vorbereitete Überweisung ändern";
                case "HKVUB": return "Bestand vorbereiteter Überweisungen abfragen";
                case "HKVUE": return "Vorbereitete Überweisung anlegen";
                case "HKVUL": return "Vorbereitete Überweisung löschen";
                case "HKVVB": return "Verarbeitungsvorbereitung";
                case "HKWDU": return "Depotumsätze anfordern";
                case "HKWFO": return "Fondsorder einreichen";
                case "HKWFP": return "Festpreisangebote anfordern";
                case "HKWOA": return "Wertpapierorderänderung";
                case "HKWOH": return "Wertpapierorderhistorie anfordern";
                case "HKWPD": return "Depotaufstellung anfordern";
                case "HKWPH": return "Wichtige Informationen anfordern";
                case "HKWPI": return "Wertpapierinformationen anfordern";
                case "HKWPK": return "Wertpapierkurse anfordern";
                case "HKWPO": return "Wertpapierorder einreichen";
                case "HKWPR": return "Wertpapierreferenznummern anfordern ";
                case "HKWPS": return "Wertpapierorderstreichung";
                case "HKWSD": return "Wertpapierstammdaten anfordern";
                case "HKWSO": return "Orderstatus anfordern";
                case "HNHBK": return "Nachrichtenkopf";
                case "HNHBS": return "Nachrichtenabschluss";
                case "HNSHA": return "Signaturabschluss";
                case "HNSHK": return "Signaturkopf";
                case "HNVSD": return "Verschlüsselte Daten";
                case "HNVSK": return "Verschlüsselungskopf";
                case "IKSEP": return "Auslandsüberweisung";
                case "IISEPS": return "Auslandsüberweisung Parameter";
                default: return string.Empty;
            }
        }

        public override string ToString()
        {
            return $"{Segment}: {Description}";
        }
    }
}
