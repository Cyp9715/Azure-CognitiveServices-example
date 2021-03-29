
namespace STT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.textBox_keyValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Init = new System.Windows.Forms.Button();
            this.textBox_regionValue = new System.Windows.Forms.TextBox();
            this.group_KeyAndRegion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Key = new System.Windows.Forms.Label();
            this.group_LanguageSelect = new System.Windows.Forms.GroupBox();
            this.radioBtn_English = new System.Windows.Forms.RadioButton();
            this.radioBtn_Korean = new System.Windows.Forms.RadioButton();
            this.group_KeySett = new System.Windows.Forms.GroupBox();
            this.textBox_KeySettingToggle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_KeySettingSpeech = new System.Windows.Forms.TextBox();
            this.group_Log = new System.Windows.Forms.GroupBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context_NotifySupport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_NotifySupport_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Off = new System.Windows.Forms.Button();
            this.btn_On = new System.Windows.Forms.Button();
            this.group_KeyAndRegion.SuspendLayout();
            this.group_LanguageSelect.SuspendLayout();
            this.group_KeySett.SuspendLayout();
            this.group_Log.SuspendLayout();
            this.context_NotifySupport.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.BackgroundImage")));
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Exit.Location = new System.Drawing.Point(332, 9);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(33, 29);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // textBox_keyValue
            // 
            this.textBox_keyValue.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Korean"});
            this.textBox_keyValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_keyValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_keyValue.Location = new System.Drawing.Point(60, 27);
            this.textBox_keyValue.Name = "textBox_keyValue";
            this.textBox_keyValue.Size = new System.Drawing.Size(206, 21);
            this.textBox_keyValue.TabIndex = 1;
            this.textBox_keyValue.Text = "02f639e582a746ba8f7c8e11aa3de35d";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Windows10 Speech To Text";
            // 
            // btn_Init
            // 
            this.btn_Init.Location = new System.Drawing.Point(272, 52);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(75, 23);
            this.btn_Init.TabIndex = 3;
            this.btn_Init.TabStop = false;
            this.btn_Init.Text = "Init";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // textBox_regionValue
            // 
            this.textBox_regionValue.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Korean"});
            this.textBox_regionValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_regionValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_regionValue.Location = new System.Drawing.Point(60, 54);
            this.textBox_regionValue.Name = "textBox_regionValue";
            this.textBox_regionValue.Size = new System.Drawing.Size(206, 21);
            this.textBox_regionValue.TabIndex = 4;
            this.textBox_regionValue.Text = "koreacentral";
            // 
            // group_KeyAndRegion
            // 
            this.group_KeyAndRegion.Controls.Add(this.label2);
            this.group_KeyAndRegion.Controls.Add(this.label_Key);
            this.group_KeyAndRegion.Controls.Add(this.textBox_keyValue);
            this.group_KeyAndRegion.Controls.Add(this.textBox_regionValue);
            this.group_KeyAndRegion.Controls.Add(this.btn_Init);
            this.group_KeyAndRegion.Location = new System.Drawing.Point(12, 54);
            this.group_KeyAndRegion.Name = "group_KeyAndRegion";
            this.group_KeyAndRegion.Size = new System.Drawing.Size(353, 92);
            this.group_KeyAndRegion.TabIndex = 7;
            this.group_KeyAndRegion.TabStop = false;
            this.group_KeyAndRegion.Text = "Azure Key,Region Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resion";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(9, 30);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(27, 12);
            this.label_Key.TabIndex = 5;
            this.label_Key.Text = "Key";
            // 
            // group_LanguageSelect
            // 
            this.group_LanguageSelect.Controls.Add(this.radioBtn_English);
            this.group_LanguageSelect.Controls.Add(this.radioBtn_Korean);
            this.group_LanguageSelect.Location = new System.Drawing.Point(12, 162);
            this.group_LanguageSelect.Name = "group_LanguageSelect";
            this.group_LanguageSelect.Size = new System.Drawing.Size(353, 92);
            this.group_LanguageSelect.TabIndex = 8;
            this.group_LanguageSelect.TabStop = false;
            this.group_LanguageSelect.Text = "Language Select";
            // 
            // radioBtn_English
            // 
            this.radioBtn_English.AutoSize = true;
            this.radioBtn_English.Location = new System.Drawing.Point(212, 44);
            this.radioBtn_English.Name = "radioBtn_English";
            this.radioBtn_English.Size = new System.Drawing.Size(65, 16);
            this.radioBtn_English.TabIndex = 2;
            this.radioBtn_English.Text = "English";
            this.radioBtn_English.UseVisualStyleBackColor = true;
            this.radioBtn_English.CheckedChanged += new System.EventHandler(this.radioBtn_English_CheckedChanged);
            // 
            // radioBtn_Korean
            // 
            this.radioBtn_Korean.AutoSize = true;
            this.radioBtn_Korean.Checked = true;
            this.radioBtn_Korean.Location = new System.Drawing.Point(79, 44);
            this.radioBtn_Korean.Name = "radioBtn_Korean";
            this.radioBtn_Korean.Size = new System.Drawing.Size(63, 16);
            this.radioBtn_Korean.TabIndex = 1;
            this.radioBtn_Korean.TabStop = true;
            this.radioBtn_Korean.Text = "Korean";
            this.radioBtn_Korean.UseVisualStyleBackColor = true;
            this.radioBtn_Korean.CheckedChanged += new System.EventHandler(this.radioBtn_Korean_CheckedChanged);
            // 
            // group_KeySett
            // 
            this.group_KeySett.Controls.Add(this.textBox_KeySettingToggle);
            this.group_KeySett.Controls.Add(this.label4);
            this.group_KeySett.Controls.Add(this.label3);
            this.group_KeySett.Controls.Add(this.textBox_KeySettingSpeech);
            this.group_KeySett.Location = new System.Drawing.Point(12, 269);
            this.group_KeySett.Name = "group_KeySett";
            this.group_KeySett.Size = new System.Drawing.Size(352, 87);
            this.group_KeySett.TabIndex = 10;
            this.group_KeySett.TabStop = false;
            this.group_KeySett.Text = "KeySetting";
            // 
            // textBox_KeySettingToggle
            // 
            this.textBox_KeySettingToggle.AllowDrop = true;
            this.textBox_KeySettingToggle.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_KeySettingToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_KeySettingToggle.Location = new System.Drawing.Point(60, 53);
            this.textBox_KeySettingToggle.Name = "textBox_KeySettingToggle";
            this.textBox_KeySettingToggle.ReadOnly = true;
            this.textBox_KeySettingToggle.Size = new System.Drawing.Size(286, 21);
            this.textBox_KeySettingToggle.TabIndex = 9;
            this.textBox_KeySettingToggle.Enter += new System.EventHandler(this.textBox_KeySettingToggle_Enter);
            this.textBox_KeySettingToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeySettingToggle_KeyDown);
            this.textBox_KeySettingToggle.Leave += new System.EventHandler(this.textBox_KeySettingToggle_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toggle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speech";
            // 
            // textBox_KeySettingSpeech
            // 
            this.textBox_KeySettingSpeech.AllowDrop = true;
            this.textBox_KeySettingSpeech.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_KeySettingSpeech.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_KeySettingSpeech.Location = new System.Drawing.Point(60, 20);
            this.textBox_KeySettingSpeech.Name = "textBox_KeySettingSpeech";
            this.textBox_KeySettingSpeech.ReadOnly = true;
            this.textBox_KeySettingSpeech.Size = new System.Drawing.Size(286, 21);
            this.textBox_KeySettingSpeech.TabIndex = 0;
            this.textBox_KeySettingSpeech.Enter += new System.EventHandler(this.textBox_KeySettingSpeech_Enter);
            this.textBox_KeySettingSpeech.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeySettingSpeech_KeyDown);
            this.textBox_KeySettingSpeech.Leave += new System.EventHandler(this.textBox_KeySettingSpeech_Leave);
            // 
            // group_Log
            // 
            this.group_Log.Controls.Add(this.textBox_Result);
            this.group_Log.Location = new System.Drawing.Point(12, 427);
            this.group_Log.Name = "group_Log";
            this.group_Log.Size = new System.Drawing.Size(353, 186);
            this.group_Log.TabIndex = 11;
            this.group_Log.TabStop = false;
            this.group_Log.Text = "Log";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(6, 20);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(340, 160);
            this.textBox_Result.TabIndex = 6;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "STT in trayIcon";
            this.notifyIcon.ContextMenuStrip = this.context_NotifySupport;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Windows 10 STT";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // context_NotifySupport
            // 
            this.context_NotifySupport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_NotifySupport_exit});
            this.context_NotifySupport.Name = "context_NotifySupport";
            this.context_NotifySupport.Size = new System.Drawing.Size(94, 26);
            // 
            // context_NotifySupport_exit
            // 
            this.context_NotifySupport_exit.Name = "context_NotifySupport_exit";
            this.context_NotifySupport_exit.Size = new System.Drawing.Size(93, 22);
            this.context_NotifySupport_exit.Text = "exit";
            this.context_NotifySupport_exit.Click += new System.EventHandler(this.context_NotifySupport_exit_Click);
            // 
            // btn_Off
            // 
            this.btn_Off.BackColor = System.Drawing.Color.Gray;
            this.btn_Off.Enabled = false;
            this.btn_Off.FlatAppearance.BorderSize = 0;
            this.btn_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Off.Location = new System.Drawing.Point(192, 362);
            this.btn_Off.Name = "btn_Off";
            this.btn_Off.Size = new System.Drawing.Size(173, 58);
            this.btn_Off.TabIndex = 13;
            this.btn_Off.Text = "OFF";
            this.btn_Off.UseVisualStyleBackColor = false;
            this.btn_Off.Click += new System.EventHandler(this.btn_Off_Click);
            // 
            // btn_On
            // 
            this.btn_On.BackColor = System.Drawing.Color.White;
            this.btn_On.FlatAppearance.BorderSize = 0;
            this.btn_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_On.Location = new System.Drawing.Point(12, 363);
            this.btn_On.Name = "btn_On";
            this.btn_On.Size = new System.Drawing.Size(173, 58);
            this.btn_On.TabIndex = 14;
            this.btn_On.Text = "ON";
            this.btn_On.UseVisualStyleBackColor = false;
            this.btn_On.Click += new System.EventHandler(this.btn_On_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(374, 625);
            this.Controls.Add(this.btn_On);
            this.Controls.Add(this.btn_Off);
            this.Controls.Add(this.group_Log);
            this.Controls.Add(this.group_KeySett);
            this.Controls.Add(this.group_LanguageSelect);
            this.Controls.Add(this.group_KeyAndRegion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_KeyAndRegion.ResumeLayout(false);
            this.group_KeyAndRegion.PerformLayout();
            this.group_LanguageSelect.ResumeLayout(false);
            this.group_LanguageSelect.PerformLayout();
            this.group_KeySett.ResumeLayout(false);
            this.group_KeySett.PerformLayout();
            this.group_Log.ResumeLayout(false);
            this.group_Log.PerformLayout();
            this.context_NotifySupport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox textBox_keyValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.TextBox textBox_regionValue;
        private System.Windows.Forms.GroupBox group_KeyAndRegion;
        private System.Windows.Forms.GroupBox group_LanguageSelect;
        private System.Windows.Forms.RadioButton radioBtn_English;
        private System.Windows.Forms.RadioButton radioBtn_Korean;
        private System.Windows.Forms.GroupBox group_KeySett;
        private System.Windows.Forms.TextBox textBox_KeySettingSpeech;
        private System.Windows.Forms.GroupBox group_Log;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btn_Off;
        private System.Windows.Forms.Button btn_On;
        private System.Windows.Forms.ContextMenuStrip context_NotifySupport;
        private System.Windows.Forms.ToolStripMenuItem context_NotifySupport_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.TextBox textBox_KeySettingToggle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

