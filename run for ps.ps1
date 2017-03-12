$EventListenerDef=@"
namespace PStips.Net
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    public class EventListener
    {
        public string EventName { private set; get; }
        public string EventSource { private set; get; }
        private EventLog log;
        public EventListener(string eventName, string eventSource)
        {
            log = new EventLog(eventName);
            log.Source = eventSource;
            log.EnableRaisingEvents = true;
            log.EntryWritten += log_EntryWritten;
        }
        int cishu = 0;
        void log_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            cishu = 1 + cishu;
            Console.WriteLine("=============================第{0}次截获=============================",cishu);
            if (e.Entry.InstanceId==20221)
            {
		StreamWriter f = new StreamWriter(@"log.txt", false);  
            	f.WriteLine("已截获的信息:Id={0},Message={1},Time={2}",e.Entry.InstanceId,e.Entry.Message,e.Entry.TimeGenerated);
            	f.Close();
		Console.WriteLine("======================截获成功,请复制真实账号======================\n");
            	string str = e.Entry.Message;
		int start = str.IndexOf("Dial-in User = ");
		int length = str.IndexOf("VpnStrategy");
		string card = str.Substring(start, length-start-1);
		Console.WriteLine(card);
	    }
	    else
	    {
	        Console.WriteLine("==========================截获到无效信息===========================\r");
	    }
	    Console.WriteLine("\n**************************请开始你的表演!**************************\n");
		}
    }
}
"@
Add-Type -TypeDefinition $EventListenerDef
New-Object PStips.Net.EventListener -ArgumentList 'Application','EventCreate'
Write-Host '**************************请开始你的表演!**************************

===========================请勿关闭窗口!===========================
============请在第1秒到第3秒内点击登录开始拨号,等待截获============
===================登录后长时间未响应请尝试重启!===================

**************************请开始你的表演!**************************

' -NoNewline
$null = [Console]::ReadKey('?')