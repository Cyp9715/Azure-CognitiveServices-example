using System;
using System.Drawing;
using System.Windows.Forms;
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
    }

    public partial class Form1 : Form
    {
        static GlobalKeyHook globalKeyHook;
        public CAzure azure = new CAzure();

        // form change variables
        private bool On;
        private Point Pos;

        // get set Func
        private e_currentToggleState toogleState { get; set; }
        public static e_language e_selectionLanguage { get; private set; }
        public VirtualKeycodes tempKey { get; private set; }

        // error manage        
        bool azureInitCom = false;

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
                printLog(CAzureError.initIsNull);
            }
            else
            {
                azureInitCom = true;
                azure.sttInit(textBox_AzurekeyValue.Text, textBox_AzureRegionValue.Text);
                printLog(CAzureError.initCaution);
            }
        }

        private void radioBtn_Korean_CheckedChanged(object sender, EventArgs e)
        {
            e_selectionLanguage = e_language.Korean;
        }

        private void radioBtn_English_CheckedChanged(object sender, EventArgs e)
        {
            e_selectionLanguage = e_language.English;
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



        // * Azure Section * //
        private void btn_AzureON_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToggleState.AzureON;

            if (azureInitCom == false)
            {
                printLog(CAzureError.initBtnNotClicked);
            }

            if (String.IsNullOrEmpty(textBox_AzureKeySettingSpeech.Text) || String.IsNullOrEmpty(textBox_AzureKeySettingToggle.Text))
            {
                printLog(CAzureError.keyIsNotSetting);
            }
            else
            {
                btn_visualOn(btn_AzureON, btn_AzureOFF);
                globalKeyHookActive();
                notifyActive("Stt ON", "Stt is hooking the keyboard");
            }
        }

        private void btn_AzureOff_Click(object sender, EventArgs e)
        {
            toogleState = e_currentToggleState.OFF;

            btn_visualOff(btn_AzureON, btn_AzureOFF);
            globalKeyHookDispose();
            notifyActive("Stt OFF", "Stt hooking is stop");
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

            if (e.KeyCode.ToString() == textBox_AzureKeySettingSpeech.Text)
            {
                try
                {
                    SendKeys.Send(await azure.MicrophoneInput(Form1.e_selectionLanguage));
                }
                catch (System.ApplicationException)
                {
                    printLog(CAzureError.micNotRecognize);
                }
            }

            else if (e.KeyCode.ToString() == textBox_AzureKeySettingToggle.Text)
            {
                toogleState = e_currentToggleState.OFF;
                btn_AzureOff_Click(this, null);
            }
        }

        public void printLog(string message)
        {
            textBox_log.AppendText(message);
            textBox_log.AppendText(Environment.NewLine);
        }

        private void globalKeyHookDispose()
        {
            if (globalKeyHook != null)
            {
                globalKeyHook.Dispose();
                globalKeyHook = null;
            }
        }

        private void globalKeyHookActive()
        {
            if (globalKeyHook == null)
            {
                globalKeyHook = new GlobalKeyHook();
                globalKeyHook.OnKeyDown += GlobalKeyHook_OnKeyDown;
            }
        }

        private void btn_visualOn(Button btn_ON, Button btn_OFF)
        {
            btn_ON.BackColor = Color.White;
            btn_OFF.BackColor = Color.Gray;
            btn_ON.Enabled = false;
            btn_OFF.Enabled = true;
        }

        private void btn_visualOff(Button btn_ON, Button btn_OFF)
        {
            btn_ON.BackColor = Color.Gray;
            btn_OFF.BackColor = Color.White;
            btn_OFF.Enabled = false;
            btn_ON.Enabled = true;
        }
    }


}
