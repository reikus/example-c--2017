using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;


namespace VCS10StandardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DllTest1_Click(object sender, EventArgs e)
        {

            //string url="http://localhost:8091";
            string url = "http://www.gebhardt.de:8091";

            int len;

            // too small
            //int nMax = 50;
            int nMax = 50000;

            LogTextBox.AppendText("\r\nURL: " + url + "\r\n\r\n");

            StringBuilder result = new StringBuilder(nMax + 1);

            len = CallProselectaDll.SetWebserviceUrl(url);

            len = CallProselectaDll.SetWebserviceSaveDiagram(0);

            len = CallProselectaDll.GetWebserviceStatus(
                result,
                nMax);
           
            string ANTRIEBSART ="RIEMEN";
            string BAUREIHE = "RZR 10";
//            string BAUREIHE = "RER 10|RLM 50-EFF1";
            string AUSFUEHRUNG = ""; 
            string ATEX = "ID_KEIN";
            string ENTRAUCHER = "ID_KEIN"; 
            string T = "20"; 
            string T_EINHEIT = "C"; 
            string V = "10000"; 
            string V_EINHEIT = "m3/h"; 
            string DPT = ""; 
            string DPFA = "1000"; 
            string P_EINHEIT = "PA"; 
            string EINBAUART = "A"; 
            string RHO1 = "1,2"; 
            string RHO_EINHEIT = "kg/m^3"; 
            string BAUGROESSE_MIN = "400"; 
            string BAUGROESSE_MAX = "400"; 
            string SUCH_MIN = "0,9"; 
            string SUCH_MAX = "1,4"; 
            string DREHZAHLRESERVE = "0";
            string VERLUSTBEIWERT = "0";
            string ETA_FILTER = "0";
            string C2_FILTER = "0";
            string BREITE_FILTER = "1400";
            string BREITE_EINHEIT = "MM";
            string HOEHE_FILTER = "0"; 
            string HOEHE_EINHEIT = "MM"; 
            string FREQU_SP_STROM = "3-400-50";  
            string ZUBEHOER = "NEIN";  
            string ZUBEHOER_ALLES = "NEIN";  
            string VERSION = "";
            string SPRACHE = "DE";

            len = CallProselectaDll.SetWebserviceRltCalculation(
                1,
                "JA",
                "3SEITIG GESCHLOSSEN",
                "KAMMER UND PRALLPLATTE",
                "0",
                "MM"
               );

            len = CallProselectaDll.Blackbox(
                result,
                nMax,
                ANTRIEBSART, BAUREIHE, AUSFUEHRUNG, ATEX, ENTRAUCHER, T, T_EINHEIT, V, V_EINHEIT, DPT, DPFA, P_EINHEIT, EINBAUART, RHO1,
                RHO_EINHEIT, BAUGROESSE_MIN, BAUGROESSE_MAX, SUCH_MIN, SUCH_MAX, DREHZAHLRESERVE, VERLUSTBEIWERT, ETA_FILTER, C2_FILTER,
                BREITE_FILTER, BREITE_EINHEIT, HOEHE_FILTER,
                HOEHE_EINHEIT, FREQU_SP_STROM,
                ZUBEHOER, ZUBEHOER_ALLES, VERSION, SPRACHE);

            if (len > nMax) {
                LogTextBox.AppendText("SMALL RESULT:\r\n\r\n" + result + "\r\n---------------------------------\r\n");

                nMax = len;
                result = new StringBuilder(nMax + 1);
                CallProselectaDll.Blackbox(
                                result,
                                nMax,
                                ANTRIEBSART, BAUREIHE, AUSFUEHRUNG, ATEX, ENTRAUCHER, T, T_EINHEIT, V, V_EINHEIT, DPT, DPFA, P_EINHEIT, EINBAUART, RHO1,
                                RHO_EINHEIT, BAUGROESSE_MIN, BAUGROESSE_MAX, SUCH_MIN, SUCH_MAX, DREHZAHLRESERVE, VERLUSTBEIWERT, ETA_FILTER, C2_FILTER, BREITE_FILTER, BREITE_EINHEIT, HOEHE_FILTER,
                                HOEHE_EINHEIT, FREQU_SP_STROM, ZUBEHOER, ZUBEHOER_ALLES, VERSION, SPRACHE);
            }

            byte[] buffer = Encoding.Convert(Encoding.ASCII, Encoding.Unicode, Encoding.ASCII.GetBytes(result.ToString()));
            string rs = Encoding.Unicode.GetString(buffer, 0, buffer.Length);

            LogTextBox.AppendText("\r\nRESULT:\r\n\r\n" + result + "\r\n");

            result = new StringBuilder(nMax + 1);
            len = CallProselectaDll.GetWebserviceStatus(
                result,
                nMax);

            LogTextBox.AppendText("\r\nSTATUS:\r\n\r\n" + result + "\r\n");

            result = new StringBuilder(nMax + 1);
            len = CallProselectaDll.GetWebserviceGraphFile(
                result,
                nMax,
                1);

            LogTextBox.AppendText("\r\nGRAFIC FILE:\r\n\r\n" + result + "\r\n");
        }
    }

}
