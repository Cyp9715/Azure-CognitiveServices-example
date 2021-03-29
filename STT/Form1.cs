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

    public enum e_currentToggleState
    {
        OFF,
        AzureON,
        GoogleON
    }

    public partial class Form1 : Form
    {
        static GlobalKeyHook globalKeyHook;
        public CAzure azure = new CAzure();
        public CGoogle google = new CGoogle();

        // form change variables
        private bool On;
        private Point Pos;

        // get set Func
        private e_currentToggleState toogleState { get; set; }
        public static e_language selectLan { get; private set; }
        public VirtualKeycodes tempKey { get; private set; }

        // error manage        
        bool AzureinitCom = false;
        bool GoogleJsonCom = false;


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
            if (String.IsNullOrEmpty(textBox_AzurekeyValue.Text) || String.IsNullOrEmpty(textBox_AzureRegionValue.Text))
            {
                printLog(Error_Azure.initIsNull);
            }
            else
            {
                AzureinitCom = true;
                azure.sttInit(textBox_AzurekeyValue.Text, textBox_AzureRegionValue.Text);
                printLog(Error_Azure.initCaution);
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

            switch (toogleState)
            {
                case e_currentToggleState.AzureON:
                    if (e.KeyCode.ToString() == textBox_AzureKeySettingSpeech.Text)
                    {
                        try
                        {
                            SendKeys.Send(await azure.MicrophoneInput(Form1.selectLan));
                        }
                        catch (System.ApplicationException)
                        {
                            printLog(Error_Azure.micNotRecognize);
                        }
                    }

                    else if (e.KeyCode.ToString() == textBox_AzureKeySettingToggle.Text)
                    {
                        switch (toogleState)
                        {
                            case e_currentToggleState.AzureON:
                                toogleState = e_currentToggleState.OFF;
                                btn_AzureOff_Click(this, null);
                                break;
                        }
                    }
                    break;

                case e_currentToggleState.GoogleON:
                    if (e.KeyCode.ToString() == textBox_GoogleKeySettingSpeech.Text)
                    {
                        try
                        {
                            //change Google API
                            //SendKeys.Send(await azure.MicrophoneInput(Form1.selectLan));
                        }
                        catch (System.ApplicationException)
                        {
                            //printLog(Error_Azure.micNotRecognize);
                        }
                    }

                    else if (e.KeyCode.ToString() == textBox_GoogleKeySettingToggle.Text)
                    {
                        switch (toogleState)
                        {
                            case e_currentToggleState.GoogleON:
                                toogleState = e_currentToggleState.OFF;
                                btn_AzureOff_Click(this, null);
                                break;
                        }
                    }
                    break;
            }
        }

        public void printLog(string message)
        {
            textBox_Log.AppendText(message);
            textBox_Log.AppendText(Environment.NewLine);
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


        // * Azure Section * //

        private void btn_AzureOn_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToggleState.AzureON;

            if (AzureinitCom == false)
            {
                printLog(Error_Azure.initBtnNotClicked);
            }

            if (String.IsNullOrEmpty(textBox_AzureKeySettingSpeech.Text) || String.IsNullOrEmpty(textBox_AzureKeySettingToggle.Text))
            {
                printLog(Error_Azure.keyIsNotSetting);
            }
            else
            {
                btn_AzureOnChange();
                globalKeyHookActive();
                notifyActive("Stt ON", "Stt is hooking the keyboard");
            }
        }

        private void btn_AzureOff_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToggleState.OFF;

            btn_AzureOffChange();
            globalKeyHookDispose();
            notifyActive("Stt OFF", "Stt is hooking Stop");
        }

        private void textBox_AzureKeySettingSpeech_Enter(object sender, EventArgs e)
        {
            globalKeyHookActive();
            textBox_AzureKeySettingSpeech.BackColor = Color.White;
        }

        private void textBox_AzureKeySettingSpeech_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_AzureKeySettingSpeech.Text = tempKey.ToString();
        }

        private void textBox_AzureKeySettingSpeech_Leave(object sender, EventArgs e)
        {
            textBox_AzureKeySettingSpeech.BackColor = Color.Gray;
            globalKeyHookDispose();
        }

        private void textBox_AzureKeySettingToggle_Enter(object sender, EventArgs e)
        {
            globalKeyHookActive();
            textBox_AzureKeySettingToggle.BackColor = Color.White;
        }

        private void textBox_AzureKeySettingToggle_KeyDown(object sender, KeyEventArgs e)
        {
            textBox_AzureKeySettingToggle.Text = tempKey.ToString();
        }

        private void textBox_AzureKeySettingToggle_Leave(object sender, EventArgs e)
        {
            textBox_AzureKeySettingToggle.BackColor = Color.Gray;
            globalKeyHookDispose();
        }


        private void btn_AzureOnChange()
        {
            btn_AzureOn.BackColor = Color.White;
            btn_AzureOff.BackColor = Color.Gray;
            btn_AzureOn.Enabled = false;
            btn_AzureOff.Enabled = true;
        }

        private void btn_AzureOffChange()
        {
            btn_AzureOn.BackColor = Color.Gray;
            btn_AzureOff.BackColor = Color.White;
            btn_AzureOff.Enabled = false;
            btn_AzureOn.Enabled = true;
        }







        // * Google Section * //

        private void btn_jsonFind_Click(object sender, EventArgs e)
        {
            openFileDialog_jsonFind.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog_jsonFind.ShowDialog();
            textBox_json.Text = openFileDialog_jsonFind.FileName;
        }
    }
}
