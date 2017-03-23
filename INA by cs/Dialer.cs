using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace INA_by_cs
{
    public class Dialer
    {
        Thread dialer;

        string rtIp;//路由ip
        string rtAcc;//路由账户
        string rtPsw;//路由密码
        string nkAcc;//NK账户
        string nkPsw;//NK密码
        string dlType;//类型

        public void BeginRouterDial(string rtIp, string rtAcc, string rtPsw, string nkAcc, string nkPsw)
        {
            this.rtIp = rtIp;
            this.rtAcc = rtAcc;
            this.rtPsw = rtPsw;
            this.nkAcc = nkAcc;
            this.nkPsw = nkPsw;
            this.dlType = "Router";

            dialer = new Thread(Dial);
            dialer.IsBackground = true;
            dialer.Start();
        }

        public bool IsNetConnected(int timeout = 250)
        {
            if (timeout < 250)
                throw new Exception("Timeout >= 250.");
            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalMilliseconds <= timeout)
            {
                try
                {
                    Ping ping = new Ping();
                    PingReply rep = ping.Send("110.75.216.92", 250);
                    ping.Dispose();
                    if (rep.Status == IPStatus.Success)
                        return true;
                }
                catch { }
            }
            return false;
        }


        
        string dialInfo = "";
        
        void RouterDial()
        {
            string realAccount = Form1.acc;
            RouterDialer rtdialer = new RouterDialer();
            rtdialer.SetRouterInfo(rtIp, rtAcc, rtPsw);
            rtdialer.SetPPPoEInfo(realAccount, nkPsw);
            rtdialer.BeginRouterDial();
            if (IsNetConnected(10000))
            {
                return;
            }
            throw new Exception("Router dial failed.");
        }
        
        void Dial()
        {
            if (IsNetConnected())
            {
                dialInfo = "网络已连接，无需拨号。";
                return;
            }
            if (dlType == "Router")
            {
                try
                {
                    RouterDial();
                    dialInfo = "路由器连接成功！";
                }
                catch
                {
                    dialInfo = "路由器连接失败！请确认支持此路由器且所填信息正确。";
                }
            }
        }
        
        public string GetState()
        {
            if (dialer == null)
            {
                return "Inited";
            }
            if (dialer.IsAlive)
            {
                return "Dialing";
            }
            else
            {
                return "DialEnd";
            }
        }
        
        public string GetDialInfo()
        {
            return dialInfo;
        }
        
        public void Reset()
        {
            if (dialer != null)
            {
                dialer.Abort();
                dialer = null;
            }

            rtIp = null;
            rtAcc = null;
            rtPsw = null;
            nkAcc = null;
            nkPsw = null;
        }
    }
}