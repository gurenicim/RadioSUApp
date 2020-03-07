using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Radio_App
{
    public partial class mainForm : Form
    {
        string UserName;
        string Global_URL = "";
        bool isClicked = true;
        Form parent;
        WebClient Client = new WebClient();
        WebClient Lclient = new WebClient();
        public static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //Create the reference for our browser
        public ChromeDriver driver;



        public static void PlayMusicFromURL(string URL)
        {
            player.URL = URL; //"http://radyoyayin.sabanciuniv.edu:8002/stream";

            player.settings.volume = 100;

            player.controls.play();
        }

        public static void PlayerStop()
        {
            player.controls.stop();
        }

        public static void SetPlayerVolume(int volume)
        {
            player.settings.volume = volume;
        }


        //************************************
        //[DllImport("winmm.dll")]
        //private static extern long mciSend(string command, StringBuilder retstring, int returnlength, IntPtr callback);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int MYACTION_HOTKEY_ID = 1;

        //*****************************************************************************



        public mainForm(Form Parent, string username)
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 6, (int)System.Windows.Forms.Keys.F12);
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;// to hide chrome driver

            UserName = username;
            var options = new ChromeOptions();
            options.AddArgument("headless");
            options.AddArgument("--no-proxy-server");
            driver = new ChromeDriver(service,options);
            parent = Parent;
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
                {
                    // My hotkey has been typed

                    // Do what you want here
                    // ...
                    AutoClosingMessageBox.Show(player.status, "Status", 2000);
                }
                base.WndProc(ref m);
            }
            catch
            { }
        }
        private void Play_Btn_Click(object sender, EventArgs e)
        {

            //PlayMusicFromURL(Global_URL);
            if (isClicked)
            {
                Play_Btn.Image = Properties.Resources.iconfinder_pause_circle_outline_326570;
                isClicked = false;
                PlayMusicFromURL(Global_URL);
            }
            else
            {
                Play_Btn.Image = Properties.Resources.iconfinder_ic_play_circle_outline_48px_352074;
                isClicked = true;
                PlayerStop();
            }

        }

        private string listenerFinder()
        {
            string listener = "";
            try
            {
                int index = 0, index2 = 0;
                
                string listenerstr = Lclient.DownloadString("http://radyoyayin.sabanciuniv.edu:8002/");
                index = listenerstr.IndexOf("(current):</td><td class=\"streamstats\">");
                index2 = listenerstr.IndexOf("</td>", index + "(current):</td><td class=\"streamstats\">".Length);
                listener = listenerstr.Substring(index + "(current):</td><td class=\"streamstats\">".Length, index2 - (index + "(current):</td><td class=\"streamstats\">".Length));

               
            }
            catch { }
            return "Current Listener Count is " + listener;
        }
        private void ChatterFinder() // to pull data from website chatbox
        {
            try
            {
                //dataGridView1.Columns.Add("UserName", "User");
                //dataGridView1.Columns.Add("Message", "Message");
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 90;
                int index1 = 0, index2 = 0, mindex1 = 0, mindex2 = 0;
                String ChatterID = "", ChatMessage = "";

                String ChatStr = Client.DownloadString("http://radyosu.sabanciuniv.edu/");
                while (ChatStr.IndexOf("<span class=\"wcMessageUser\"", index2 + 1) != -1) //we collect every message into gridview
                {

                    index1 = ChatStr.IndexOf("<span class=\"wcMessageUser\"", index2 + 1);

                    index2 = ChatStr.IndexOf("</span>", index1 + 1);


                    mindex1 = ChatStr.IndexOf("<span class=\"wcMessageContent\" >", index2);
                    mindex2 = ChatStr.IndexOf("<a href=\"#\" class=\"wcAdminAction wcSpamReportButton\"", mindex1 + 1);
                    int lngth1 = "< span class=\"wcMessageUser\" >".Length;
                    int lngth2 = "<span class=\"wcMessageContent\" >".Length;
                    ChatMessage = ChatStr.Substring(mindex1 + lngth2, (mindex2 - mindex1) - lngth2);
                    ChatterID = ChatStr.Substring(index1 + lngth1 + 2, (index2 - index1) - lngth1);

                    //***********************************************************
                    if (ChatterID.IndexOf("</") != -1)
                    {
                        ChatterID = ChatterID.Substring(0, ChatterID.IndexOf("</"));
                    }
                    if (ChatterID.IndexOf("e=") != -1)
                    {
                        ChatterID = ChatterID.Substring("e = \"color:#000000\"".Length, ChatterID.Length - "e = \"color:#000000\"".Length);
                    }
                    //************************************************************
                    //To make usernames proper;
                    index2++;

                    dataGridView1.Rows.Add(ChatterID, ChatMessage);
                }
            }
            catch { }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            string AllUserNames = "Guren, denizmina, admin";
            if (AllUserNames.IndexOf(UserName)==-1)
            {
                Listeners.Visible = false;
            }
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Height = 700;
            this.Width = 1400;
            Play_Btn.Image = Properties.Resources.iconfinder_ic_play_circle_outline_48px_352074;
            ChatterFinder();
            backgroundWorker1.RunWorkerAsync();
            try
            {
                driver.Navigate().GoToUrl("http://radyosu.sabanciuniv.edu/");
            }
            catch
            {
                AutoClosingMessageBox.Show("Timeout", "Sorry Bruh", 2000);
                    driver.Navigate().GoToUrl("http://radyosu.sabanciuniv.edu/");
            }

            try
            {
                IWebElement mustclick = driver.FindElement(By.ClassName("wcCustomizeButton"));
                IWebElement nameelement = driver.FindElement(By.ClassName("wcUserName"));
                IWebElement nameelementsbmt = driver.FindElement(By.ClassName("wcUserNameApprove"));

                mustclick.Click();
                nameelement.SendKeys(UserName);
                nameelementsbmt.Click();
            }
            catch
            {
                AutoClosingMessageBox.Show("Unexpected Error\nPlease make sure that you are connected to internet.", "ERROR", 4000);
            }

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e) //to update chat
        {
            dataGridView1.Rows.Clear();
            ChatterFinder();
            Listeners.Text = listenerFinder();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Navigate to google page

            Message m = new Message();
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) // control shift f12
            {
                // My hotkey has been typed

                // Do what you want here
                // ...
                MessageBox.Show(player.status);
            }
            base.WndProc(ref m);
        }

        private void RadyoSUToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //PlayerStop();
            //Global_URL = "http://radyoyayin.sabanciuniv.edu:8002/stream";
            Global_URL = "http://radyoyayin.sabanciuniv.edu:8002/stream";
            PlayMusicFromURL(Global_URL);
        }

        private void BBCRadio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global_URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p";
            PlayMusicFromURL(Global_URL);
        }

        private void BBCRadio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global_URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio2_mf_p";
            PlayMusicFromURL(Global_URL);
        }

        private void DaveKozRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global_URL = "http://us4.internet-radio.com:8266/stream";
            PlayMusicFromURL(Global_URL);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
            driver.Dispose();
            driver.Close();
            //Close the browser
            try
            {
                //driver.Close();
            }
            catch
            {


            }

        }

        private void WebBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            try
            {//Find the Search text box UI Element

                IWebElement element = driver.FindElement(By.ClassName("wcSubmitButton"));
                IWebElement element2 = driver.FindElement(By.ClassName("wcInput"));
                IWebElement element3 = driver.FindElement(By.ClassName("wcUserName"));
                IWebElement element4 = driver.FindElement(By.ClassName("wcUserNameApprove"));
                IWebElement element5 = driver.FindElement(By.ClassName("wcCustomizeButton"));
                
                //Perform Ops
                string chatname = chatbox_name.Text;
                element5.Click();
                element3.Clear();
                element3.SendKeys(chatname);
                element4.Click();
                
                element2.SendKeys(textBox1.Text);
                element.Click();
                textBox1.Text = "";
            }
            catch { }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Send_btn.PerformClick();
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was written by Guren İçim in order to help RadyoSU.\nThere will be crashes and errors naturally.\nIn such cases please Contact\ngurenicim@sabanciuniv.edu");
        }

        private void RockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
