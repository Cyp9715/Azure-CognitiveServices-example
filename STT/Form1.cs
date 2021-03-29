using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Indieteur.GlobalHooks;
using STT.Code;

namespace STT
{
    public delegate void DelPrintLog(string message);

    public enum e_language
    {
        Korean,
        English
    }

    public enum e_currentToogleState
    {
        OFF,
        ON
    }



    public partial class Form1 : Form
    {
        static GlobalKeyHook globalKeyHook;
        public Azure azure = new Azure();

        // form change variables
        private bool On;
        private Point Pos;

        // get set Func
        private e_currentToogleState toogleState { get; set; }
        public static e_language selectLan { get; private set; }
        public VirtualKeycodes tempKey { get; private set; }

        // error manage        
        bool initCom = false;


        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            notifyActive("Stt in tray", "right click and click the exit button to finish");
            this.Hide();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_keyValue.Text) || String.IsNullOrEmpty(textBox_regionValue.Text))
            {
                printLog(E_Azure.initIsNull);
            }
            else
            {
                initCom = true;
                azure.sttInit(textBox_keyValue.Text, textBox_regionValue.Text);
                printLog(E_Azure.initCaution);
            }
        }

        private void radioBtn_Korean_CheckedChanged(object sender, EventArgs e)
        {
            selectLan = e_language.Korean;
        }

        private void radioBtn_English_CheckedChanged(object sender, EventArgs e)
        {
            selectLan = e_language.English;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.Show();
        }

        private void context_NotifySupport_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_On_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToogleState.ON;

            if(initCom == false)
            {
                printLog(E_Azure.initBtnNotClicked);
            }

            if (String.IsNullOrEmpty(textBox_KeySettingSpeech.Text) || String.IsNullOrEmpty(textBox_KeySettingToggle.Text))
            {
                printLog(E_Azure.keyIsNotSetting);
            }
            else
            {
                btnOn_Active();
                globalKeyHookActive();
                notifyActive("Stt ON", "Stt is hooking the keyboard");
            }
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToogleState.OFF;

            btnOff_Active();
            globalKeyHookDispose();
            notifyActive("Stt OFF", "Stt is hooking Stop");
        }



        private void textBox_KeySettingSpeech_Enter(object sender, EventArgs e)
        {
            globalKeyHookActive();
            textBox_KeySettingSpeech.BackColor = Color.White;
        }

        private void textBox_KeySettingSpeech_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_KeySettingSpeech.Text = tempKey.ToString();
        }

        private void textBox_KeySettingSpeech_Leave(object sender, EventArgs e)
        {
            textBox_KeySettingSpeech.BackColor = Color.Gray;
            globalKeyHookDispose();
        }



        private void textBox_KeySettingToggle_Enter(object sender, EventArgs e)
        {
            globalKeyHookActive();
            textBox_KeySettingToggle.BackColor = Color.White;
        }

        private void textBox_KeySettingToggle_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_KeySettingToggle.Text = tempKey.ToString();
        }

        private void textBox_KeySettingToggle_Leave(object sender, EventArgs e)
        {
            textBox_KeySettingToggle.BackColor = Color.Gray;
            globalKeyHookDispose();
        }
        




        // bottom is not form event.

        private void InitializeForm()
        {
            // add Click & Move Windows
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void notifyActive(string titleMsg_, string tipMsg_)
        {
            notifyIcon.BalloonTipTitle = titleMsg_;
            notifyIcon.BalloonTipText = tipMsg_;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }

        private async void GlobalKeyHook_OnKeyDown(object sender, GlobalKeyEventArgs e)
        {
            tempKey = e.KeyCode;

            if (e.KeyCode.ToString() == textBox_KeySettingSpeech.Text)
            {
                try
                {
                    SendKeys.Send(await azure.MicrophoneInput(Form1.selectLan));
                }
                catch (System.ApplicationException)
                {
                    printLog(E_Azure.micNotRecognize);
                }
            }
            
            else if (e.KeyCode.ToString() == textBox_KeySettingToggle.Text)
            {
                switch(toogleState)
                {
                    case e_currentToogleState.ON:
                        toogleState = e_currentToogleState.OFF;
                        btn_Off_Click(this, null);
                        break;

                    case e_currentToogleState.OFF:
                        toogleState = e_currentToogleState.ON;
                        btn_On_Click(this, null);
                        break;
                }
            }
        }

        public void printLog(string message)
        {
            textBox_Result.AppendText(message);
            textBox_Result.AppendText(Environment.NewLine);
        }

        private void globalKeyHookDispose()
        {
            if(globalKeyHook != null)
            {
                globalKeyHook.Dispose();
                globalKeyHook = null;
            }
        }

        private void globalKeyHookActive()
        {
            if(globalKeyHook == null)
            {
                globalKeyHook = new GlobalKeyHook();
                globalKeyHook.OnKeyDown += GlobalKeyHook_OnKeyDown;
            }
        }

        private void btnOn_Active()
        {
            btn_On.BackColor = Color.White;
            btn_Off.BackColor = Color.Gray;
            btn_On.Enabled = false;
            btn_Off.Enabled = true;
        }

        private void btnOff_Active()
        {
            btn_On.BackColor = Color.Gray;
            btn_Off.BackColor = Color.White;
            btn_Off.Enabled = false;
            btn_On.Enabled = true;
        }

    }
}
