using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

// using System.Threading.Tasks;

namespace VCS10StandardApp
{
    public class CallProselectaDll
    {
        [DllImport("proselecta2_ws.dll", CharSet = CharSet.Ansi, ExactSpelling=true, EntryPoint = "Blackbox",
            CallingConvention = CallingConvention.StdCall)]
            public static extern  int BlackboxExplicit(
                [MarshalAs(UnmanagedType.LPStr)] StringBuilder result, 
                int nMax, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ANTRIEBSART, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string BAUREIHE, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string AUSFUEHRUNG, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ATEX, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ENTRAUCHER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string T, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string T_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string V, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string V_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string DPT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string DPFA, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string P_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string EINBAUART, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string RHO1, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string RHO_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string BAUGROESSE_MIN, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string BAUGROESSE_MAX, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string SUCH_MIN, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string SUCH_MAX, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string DREHZAHLRESERVE, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string VERLUSTBEIWERT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ETA_FILTER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string C2_FILTER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string BREITE_FILTER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string BREITE_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string HOEHE_FILTER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string HOEHE_EINHEIT, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string FREQU_SP_STROM, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ZUBEHOER, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string ZUBEHOER_ALLES, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string VERSION, 
                [In] [MarshalAs(UnmanagedType.LPStr)] string SPRACHE) ;
        
        [DllImport("proselecta2_ws.dll",  EntryPoint = "Blackbox")]
            public static extern int Blackbox(
                StringBuilder result,
                int nMax,
                string ANTRIEBSART,
                string BAUREIHE,
                string AUSFUEHRUNG,
                string ATEX,
                string ENTRAUCHER,
                string T,
                string T_EINHEIT,
                string V,
                string V_EINHEIT,
                string DPT,
                string DPFA,
                string P_EINHEIT,
                string EINBAUART,
                string RHO1,
                string RHO_EINHEIT,
                string BAUGROESSE_MIN,
                string BAUGROESSE_MAX,
                string SUCH_MIN,
                string SUCH_MAX,
                string DREHZAHLRESERVE,
                string VERLUSTBEIWERT,
                string ETA_FILTER,
                string C2_FILTER,
                string BREITE_FILTER,
                string BREITE_EINHEIT,
                string HOEHE_FILTER,
                string HOEHE_EINHEIT,
                string FREQU_SP_STROM,
                string ZUBEHOER,
                string ZUBEHOER_ALLES,
                string VERSION,
                string SPRACHE);

        [DllImport("proselecta2_ws.dll",ExactSpelling=true ,CharSet = CharSet.Ansi, EntryPoint = "SetWebserviceUrl",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int SetWebserviceUrlByte(
                [In] [MarshalAs(UnmanagedType.LPArray)]byte[] url);
        
        [DllImport("proselecta2_ws.dll", ExactSpelling = true, CharSet = CharSet.Ansi, EntryPoint = "SetWebserviceUrl",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int SetWebserviceUrl(
                [In] string url);

        [DllImport("proselecta2_ws.dll", ExactSpelling=true ,CharSet= CharSet.Ansi, EntryPoint = "GetWebserviceStatus",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int GetWebserviceStatus(
                StringBuilder result, int nMax);
        
        [DllImport("proselecta2_ws.dll", EntryPoint = "IsWebserviceRunning",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int IsWebserviceRunning();
        
        [DllImport("proselecta2_ws.dll",CharSet = CharSet.Auto, EntryPoint = "GetWebserviceVersion",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int GetWebserviceVersion(
                [MarshalAs(UnmanagedType.LPTStr)] StringBuilder result, int nMax);
        
        [DllImportAttribute("proselecta2_ws.dll", EntryPoint = "GetWebserviceFanAloneW",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int GetWebserviceFanAlone(
                [MarshalAsAttribute(UnmanagedType.LPStr)] StringBuilder result, int nMax, [In()] [MarshalAs(UnmanagedType.LPStr)] string BAUREIHE, [In()] [MarshalAs(UnmanagedType.LPTStr)] string AUSFUEHRUNG, [System.Runtime.InteropServices.InAttribute()] [MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)] string BAUGROESSE_MIN, [System.Runtime.InteropServices.InAttribute()] [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPTStr)] string VERSION);

        [DllImport("proselecta2_ws.dll", ExactSpelling = true, CharSet = CharSet.Ansi, EntryPoint = "SetWebserviceSaveDiagram",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int SetWebserviceSaveDiagram(
                int onoff);

        [DllImport("proselecta2_ws.dll", CharSet = CharSet.Ansi, ExactSpelling = true, EntryPoint = "GetWebserviceGraphFile",
            CallingConvention = CallingConvention.StdCall)]
            public static extern int GetWebserviceGraphFile(
                [MarshalAs(UnmanagedType.LPStr)] StringBuilder result, int nMax, int nIndex);

        [DllImportAttribute("proselecta2_ws.dll", EntryPoint = "SetWebserviceRltCalculation",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWebserviceRltCalculation(
            [In] int nActivate,
            [In] string RLT_ANSAUG_SCHUTZGITTER,
            [In] string RLT_RIEMEN_SCHUTZGITTER,
            [In] string RLT_AUSBLAS_SITUATION,
            [In] string LAENGE,
            [In] string LAENGE_EINHEIT);
    } 
}