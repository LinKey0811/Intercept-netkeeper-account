// Intercept-netkeeper-account.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <iostream>
#using <System.dll>

using namespace std;
using namespace System;
using namespace System::Diagnostics;
using namespace System::Threading;
using namespace System::IO;

ref class Listener
{
private:

	// 事件发生信号
	static AutoResetEvent^ signal;

public:

	static void main()
	{
		signal = gcnew AutoResetEvent(false);
		EventLog^ NewLog = gcnew EventLog;
		NewLog->Source = "RasClient";
		NewLog->EntryWritten += gcnew EntryWrittenEventHandler(EntryWritten);
		NewLog->EnableRaisingEvents = true;
		signal->WaitOne();
	}

	static void EntryWritten(Object^ source, EntryWrittenEventArgs^ e)
	{

		Console::WriteLine("拦截到一个事件，ID={0}", e->Entry->InstanceId);
		//判断是否是想要的事件ID，其他地区可以选择相应的ID
		if (e->Entry->InstanceId == 20221)
		{
			//保存到本地作为备用
			String^ fileName = "log.txt";
			StreamWriter^ sw = gcnew StreamWriter(fileName);
			sw->WriteLine("已截获的信息:Id={0},Message={1}", e->Entry->InstanceId, e->Entry->Message);
			sw->WriteLine(DateTime::Now);
			sw->Close();

			//只截取需要的账号部分
			String^ str = e->Entry->Message;
			int start = str->IndexOf("Dial-in User = ");
			int length = str->IndexOf("VpnStrategy");
			String^ card = str->Substring(start, length - start - 1);

			//输出需要的账号到控制台
			Console::WriteLine("此事件有效，请复制以下账号\n{0}", card);
			Console::WriteLine("**************************\n");
		}
		else
		{
			Console::WriteLine("此事件无效，请重新拨号");
			Console::WriteLine("**************************\n");
		}
		signal->Set();
	}
};

int main()
{
	cout << "Made By LinKey0811\nhttps://github.com/LinKey0811 \n***************" << endl;
	//输入拦截控制
	int contral;
	cout << "请输入 1 开始拦截，输入 0 关闭\n";
	do
	{
		cin >> contral;
		if (contral == 1)
		{
			cout << "拦截开始，请拨号\n=====================\n" << endl;
			Listener::main();
		}
	} while (contral == 1);
	return 0;
}

