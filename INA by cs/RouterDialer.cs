using System;
using System.Net;
using System.Web;

namespace INA_by_cs
{
    public class RouterDialer
    {
        string rtIp;
        string rtAcc;
        string rtPsw;
        string pppAcc;
        string pppPsw;

        public void SetRouterInfo(string ip, string account, string password)
        {
            rtIp = ip;
            rtAcc = account;
            rtPsw = password;
        }

        public void SetPPPoEInfo(string account, string password)
        {
            pppAcc = account;
            pppPsw = password;
        }

        private string GetUrl()
        {
            string s0 = "http://" + rtIp;
            string s1 = "/userRpm/PPPoECfgRpm.htm?wantype=2&VnetPap=0&";
            string enAcc = HttpUtility.UrlEncode(pppAcc);
            string enPsw = HttpUtility.UrlEncode(pppPsw);
            string s2 = "acc=" + enAcc + "&psw=" + enPsw;
            string s3 = "&SecType=1&linktype=4&waittime2=0&Connect=%C1%AC+%BD%D3";
            string al = s0 + s1 + s2 + s3;
            return al;
        }

        private CredentialCache GetCredentialCache()
        {
            CredentialCache cache = new CredentialCache();
            Uri uri = new Uri("http://" + rtIp);
            NetworkCredential credential = new NetworkCredential(rtAcc, rtPsw);
            cache.Add(uri, "Basic", credential);
            return cache;
        }

        public void BeginRouterDial()
        {
            string url = GetUrl();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "GET";
            req.Credentials = GetCredentialCache();
            HttpWebResponse rep = (HttpWebResponse)req.GetResponse();
            rep.Close();
        }
    }
}
