using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
namespace INA_by_cs
{
    public class EventListen
    {
        public static string card;//accBox账号显示
        public static string message;//mBox通知
        // This member is used to wait for events.
        static AutoResetEvent signal;

        public static void main()
        {
            signal = new AutoResetEvent(false);
            EventLog NewLog = new EventLog();
            NewLog.Source = "RasClient";
            NewLog.EntryWritten += new EntryWrittenEventHandler(EntryWritten);
            NewLog.EnableRaisingEvents = true;
            signal.WaitOne();
        }

        public static void EntryWritten(object source, EntryWrittenEventArgs e)
        {

            //判断是否是想要的事件ID，其他地区可以选择相应的ID
            if (e.Entry.InstanceId == 20221)
            {
                //保存到本地作为备用
                String fileName = "log.txt";
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("已截获的信息:Id={0},Message={1}", e.Entry.InstanceId, e.Entry.Message);
                sw.WriteLine(DateTime.Now);
                sw.Close();

                //只截取需要的账号部分
                string str = e.Entry.Message;
                int start = str.IndexOf("User = ");
                int length = str.IndexOf("VpnStrategy");
                card = str.Substring(start + 8, length - start - 9);
            }
            signal.Set();
        }
    }
}
