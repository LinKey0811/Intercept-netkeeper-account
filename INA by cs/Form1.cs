using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace INA_by_cs
{
    public partial class Form1 : Form
    {
        public static string acc;
        public Form1()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            mBox.Text = "正在拦截账号";
            accBox.Text = "";
            EventListen.main();
            mBox.Text = EventListen.message;
            acc = EventListen.card;
            acc = "\r" + acc;
            accBox.Text = acc;
            if (accBox.Text == "")
                mBox.Text = "未截获到账号";
            else
                mBox.Text = "已截获到账号";
        }

        private Dialer dialer = new Dialer();
        private void rdial_Click(object sender, EventArgs e)
        {
            if (acc == "")
                mBox.Text = "没有截获到宽带账号，正在使用输入的宽带账号";
            else if (accBox.Text == "")
                mBox.Text = "没有输入宽带账号，请重试"; 
            else if (psBox.Text == "")
                mBox.Text = "没有输入宽带密码，请重试";
            else if (rtAccBox.Text=="")
                mBox.Text = "没有输入路由登录账号，请重试";
            else if(rtPsBox.Text == "")
                mBox.Text = "没有输入路由登录密码，请重试";
            else if (rtIPBox.Text == "")
                mBox.Text = "没有输入路由IP，请重试"; 
            else
            {
                mBox.Text = "正在进行路由拨号";
                dialer.BeginRouterDial(rtIPBox.Text, rtAccBox.Text, rtPsBox.Text, acc, psBox.Text);
                /*//检查账号长度
                int len = acc.Length;
                string leng= Convert.ToString(len);
                mBox.Text = leng;
                */
            }
        }
        private void ldial_Click(object sender, EventArgs e)
        {
            if (acc == "")
                mBox.Text = "没有截获到宽带账号，正在使用输入的宽带账号";
            else if (accBox.Text == "")
                mBox.Text = "没有输入宽带账号，请重试";
            else if (psBox.Text == "")
                mBox.Text = "没有输入宽带密码，请重试";
            else
            {
                mBox.Text = "正在进行宽带拨号";
                string lcCnn = "Netkeeper";//这里是已有拨号的名称，切记，已有！！！
                /*dialer.BeginLocalDial(lcCnn, acc, psBox.Text);*/
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            accBox.Text = "";
            psBox.Text = "";
            rtAccBox.Text = "";
            rtPsBox.Text = "";
            rtIPBox.Text = "";
            EventListen.card = "";
            acc = "";
            mBox.Text = "已清除数据，请重新输入";
        }
        private void save_Click(object sender, EventArgs e)
        {
            String fileName = "save.txt";
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(rtIPBox.Text);
            sw.WriteLine(rtAccBox.Text);
            sw.WriteLine(rtPsBox.Text);
            sw.WriteLine(psBox.Text);
            sw.Close();
            mBox.Text = "已保存设置";
        }
        private void INA_Load(object sender, EventArgs e)
        {
            //读取保存的配置
            if (File.Exists("save.txt"))
            {
                string[] str = File.ReadAllLines("save.txt");
                rtIPBox.Text = str[0];
                rtAccBox.Text = str[1];
                rtPsBox.Text = str[2];
                psBox.Text = str[3];
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/LinKey0811");
        }
        private void rtPsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtset_Enter(object sender, EventArgs e)
        {

        }

        private void cdset_Enter(object sender, EventArgs e)
        {

        }

        private void psBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtAccBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtIPBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkey_Click(object sender, EventArgs e)
        {

        }
        private void accBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void mBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

