
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
            this.label_Title = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context_NotifySupport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_NotifySupport_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.group_KeyAndRegion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Key = new System.Windows.Forms.Label();
            this.textBox_AzurekeyValue = new System.Windows.Forms.TextBox();
            this.textBox_AzureRegionValue = new System.Windows.Forms.TextBox();
            this.btn_Init = new System.Windows.Forms.Button();
            this.group_LanguageSelect = new System.Windows.Forms.GroupBox();
            this.radioBtn_English = new System.Windows.Forms.RadioButton();
            this.radioBtn_Korean = new System.Windows.Forms.RadioButton();
            this.textBox_AzureKeySettingSpeech = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_AzureKeySettingToggle = new System.Windows.Forms.TextBox();
            this.group_KeySett = new System.Windows.Forms.GroupBox();
            this.btn_AzureOFF = new System.Windows.Forms.Button();
            this.btn_AzureON = new System.Windows.Forms.Button();
            this.group_flatform = new System.Windows.Forms.TabControl();
            this.tabPage_Azure = new System.Windows.Forms.TabPage();
            this.tabPage_Google = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_GoogleKeySettingToggle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_GoogleKeySettingSpeech = new System.Windows.Forms.TextBox();
            this.btn_GoogleOFF = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.GroupBox();
            this.textBox_json = new System.Windows.Forms.TextBox();
            this.btn_jsonFind = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_GoogleON = new System.Windows.Forms.Button();
            this.openFileDialog_jsonFind = new System.Windows.Forms.OpenFileDialog();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.group_Log = new System.Windows.Forms.GroupBox();
            this.context_NotifySupport.SuspendLayout();
            this.group_KeyAndRegion.SuspendLayout();
            this.group_LanguageSelect.SuspendLayout();
            this.group_KeySett.SuspendLayout();
            this.group_flatform.SuspendLayout();
            this.tabPage_Azure.SuspendLayout();
            this.tabPage_Google.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.d.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.group_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Exit.BackgroundImage")));
            this.Btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Exit.Location = new System.Drawing.Point(437, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(33, 30);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(197, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(103, 19);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Speech to Text";
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
            // group_KeyAndRegion
            // 
            this.group_KeyAndRegion.Controls.Add(this.label2);
            this.group_KeyAndRegion.Controls.Add(this.label_Key);
            this.group_KeyAndRegion.Controls.Add(this.textBox_AzurekeyValue);
            this.group_KeyAndRegion.Controls.Add(this.textBox_AzureRegionValue);
            this.group_KeyAndRegion.Controls.Add(this.btn_Init);
            this.group_KeyAndRegion.Location = new System.Drawing.Point(46, 56);
            this.group_KeyAndRegion.Name = "group_KeyAndRegion";
            this.group_KeyAndRegion.Size = new System.Drawing.Size(361, 92);
            this.group_KeyAndRegion.TabIndex = 7;
            this.group_KeyAndRegion.TabStop = false;
            this.group_KeyAndRegion.Text = "Azure Key,Region Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resion";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(16, 29);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(27, 12);
            this.label_Key.TabIndex = 5;
            this.label_Key.Text = "Key";
            // 
            // textBox_AzurekeyValue
            // 
            this.textBox_AzurekeyValue.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Korean"});
            this.textBox_AzurekeyValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_AzurekeyValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_AzurekeyValue.Location = new System.Drawing.Point(67, 26);
            this.textBox_AzurekeyValue.Name = "textBox_AzurekeyValue";
            this.textBox_AzurekeyValue.Size = new System.Drawing.Size(206, 21);
            this.textBox_AzurekeyValue.TabIndex = 1;
            this.textBox_AzurekeyValue.Text = "02f639e582a746ba8f7c8e11aa3de35d";
            // 
            // textBox_AzureRegionValue
            // 
            this.textBox_AzureRegionValue.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Korean"});
            this.textBox_AzureRegionValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_AzureRegionValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_AzureRegionValue.Location = new System.Drawing.Point(67, 58);
            this.textBox_AzureRegionValue.Name = "textBox_AzureRegionValue";
            this.textBox_AzureRegionValue.Size = new System.Drawing.Size(206, 21);
            this.textBox_AzureRegionValue.TabIndex = 4;
            this.textBox_AzureRegionValue.Text = "koreacentral";
            // 
            // btn_Init
            // 
            this.btn_Init.Location = new System.Drawing.Point(279, 56);
            this.btn_Init.Name = "btn_Init";
            this.btn_Init.Size = new System.Drawing.Size(75, 23);
            this.btn_Init.TabIndex = 3;
            this.btn_Init.TabStop = false;
            this.btn_Init.Text = "Init";
            this.btn_Init.UseVisualStyleBackColor = true;
            this.btn_Init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // group_LanguageSelect
            // 
            this.group_LanguageSelect.Controls.Add(this.radioBtn_English);
            this.group_LanguageSelect.Controls.Add(this.radioBtn_Korean);
            this.group_LanguageSelect.Location = new System.Drawing.Point(46, 154);
            this.group_LanguageSelect.Name = "group_LanguageSelect";
            this.group_LanguageSelect.Size = new System.Drawing.Size(361, 92);
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
            // textBox_AzureKeySettingSpeech
            // 
            this.textBox_AzureKeySettingSpeech.AllowDrop = true;
            this.textBox_AzureKeySettingSpeech.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_AzureKeySettingSpeech.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_AzureKeySettingSpeech.Location = new System.Drawing.Point(60, 20);
            this.textBox_AzureKeySettingSpeech.Name = "textBox_AzureKeySettingSpeech";
            this.textBox_AzureKeySettingSpeech.ReadOnly = true;
            this.textBox_AzureKeySettingSpeech.Size = new System.Drawing.Size(290, 21);
            this.textBox_AzureKeySettingSpeech.TabIndex = 0;
            this.textBox_AzureKeySettingSpeech.Enter += new System.EventHandler(this.textBox_AzureKeySettingSpeech_Enter);
            this.textBox_AzureKeySettingSpeech.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_AzureKeySettingSpeech_KeyDown);
            this.textBox_AzureKeySettingSpeech.Leave += new System.EventHandler(this.textBox_AzureKeySettingSpeech_Leave);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Off";
            // 
            // textBox_AzureKeySettingToggle
            // 
            this.textBox_AzureKeySettingToggle.AllowDrop = true;
            this.textBox_AzureKeySettingToggle.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_AzureKeySettingToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_AzureKeySettingToggle.Location = new System.Drawing.Point(60, 53);
            this.textBox_AzureKeySettingToggle.Name = "textBox_AzureKeySettingToggle";
            this.textBox_AzureKeySettingToggle.ReadOnly = true;
            this.textBox_AzureKeySettingToggle.Size = new System.Drawing.Size(290, 21);
            this.textBox_AzureKeySettingToggle.TabIndex = 9;
            this.textBox_AzureKeySettingToggle.Enter += new System.EventHandler(this.textBox_AzureKeySettingToggle_Enter);
            this.textBox_AzureKeySettingToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_AzureKeySettingToggle_KeyDown);
            this.textBox_AzureKeySettingToggle.Leave += new System.EventHandler(this.textBox_AzureKeySettingToggle_Leave);
            // 
            // group_KeySett
            // 
            this.group_KeySett.Controls.Add(this.textBox_AzureKeySettingToggle);
            this.group_KeySett.Controls.Add(this.label4);
            this.group_KeySett.Controls.Add(this.label3);
            this.group_KeySett.Controls.Add(this.textBox_AzureKeySettingSpeech);
            this.group_KeySett.Location = new System.Drawing.Point(46, 252);
            this.group_KeySett.Name = "group_KeySett";
            this.group_KeySett.Size = new System.Drawing.Size(361, 87);
            this.group_KeySett.TabIndex = 10;
            this.group_KeySett.TabStop = false;
            this.group_KeySett.Text = "KeySetting";
            // 
            // btn_AzureOFF
            // 
            this.btn_AzureOFF.BackColor = System.Drawing.Color.Gray;
            this.btn_AzureOFF.Enabled = false;
            this.btn_AzureOFF.FlatAppearance.BorderSize = 0;
            this.btn_AzureOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AzureOFF.Location = new System.Drawing.Point(239, 361);
            this.btn_AzureOFF.Name = "btn_AzureOFF";
            this.btn_AzureOFF.Size = new System.Drawing.Size(168, 58);
            this.btn_AzureOFF.TabIndex = 13;
            this.btn_AzureOFF.Text = "OFF";
            this.btn_AzureOFF.UseVisualStyleBackColor = false;
            this.btn_AzureOFF.Click += new System.EventHandler(this.btn_AzureOff_Click);
            // 
            // btn_AzureON
            // 
            this.btn_AzureON.BackColor = System.Drawing.Color.White;
            this.btn_AzureON.FlatAppearance.BorderSize = 0;
            this.btn_AzureON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AzureON.Location = new System.Drawing.Point(46, 361);
            this.btn_AzureON.Name = "btn_AzureON";
            this.btn_AzureON.Size = new System.Drawing.Size(173, 58);
            this.btn_AzureON.TabIndex = 14;
            this.btn_AzureON.Text = "ON";
            this.btn_AzureON.UseVisualStyleBackColor = false;
            this.btn_AzureON.Click += new System.EventHandler(this.btn_AzureON_Click);
            // 
            // group_flatform
            // 
            this.group_flatform.Controls.Add(this.tabPage_Azure);
            this.group_flatform.Controls.Add(this.tabPage_Google);
            this.group_flatform.Location = new System.Drawing.Point(12, 41);
            this.group_flatform.Multiline = true;
            this.group_flatform.Name = "group_flatform";
            this.group_flatform.SelectedIndex = 0;
            this.group_flatform.Size = new System.Drawing.Size(458, 477);
            this.group_flatform.TabIndex = 15;
            this.group_flatform.Selected += new System.Windows.Forms.TabControlEventHandler(this.group_flatform_Selected);
            // 
            // tabPage_Azure
            // 
            this.tabPage_Azure.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage_Azure.Controls.Add(this.group_KeySett);
            this.tabPage_Azure.Controls.Add(this.btn_AzureOFF);
            this.tabPage_Azure.Controls.Add(this.group_KeyAndRegion);
            this.tabPage_Azure.Controls.Add(this.group_LanguageSelect);
            this.tabPage_Azure.Controls.Add(this.btn_AzureON);
            this.tabPage_Azure.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Azure.Name = "tabPage_Azure";
            this.tabPage_Azure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Azure.Size = new System.Drawing.Size(450, 451);
            this.tabPage_Azure.TabIndex = 0;
            this.tabPage_Azure.Text = "Azure";
            // 
            // tabPage_Google
            // 
            this.tabPage_Google.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage_Google.Controls.Add(this.groupBox2);
            this.tabPage_Google.Controls.Add(this.btn_GoogleOFF);
            this.tabPage_Google.Controls.Add(this.d);
            this.tabPage_Google.Controls.Add(this.groupBox4);
            this.tabPage_Google.Controls.Add(this.btn_GoogleON);
            this.tabPage_Google.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Google.Name = "tabPage_Google";
            this.tabPage_Google.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Google.Size = new System.Drawing.Size(450, 451);
            this.tabPage_Google.TabIndex = 1;
            this.tabPage_Google.Text = "Google";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_GoogleKeySettingToggle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_GoogleKeySettingSpeech);
            this.groupBox2.Location = new System.Drawing.Point(46, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 87);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KeySetting";
            // 
            // textBox_GoogleKeySettingToggle
            // 
            this.textBox_GoogleKeySettingToggle.AllowDrop = true;
            this.textBox_GoogleKeySettingToggle.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_GoogleKeySettingToggle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_GoogleKeySettingToggle.Location = new System.Drawing.Point(60, 53);
            this.textBox_GoogleKeySettingToggle.Name = "textBox_GoogleKeySettingToggle";
            this.textBox_GoogleKeySettingToggle.ReadOnly = true;
            this.textBox_GoogleKeySettingToggle.Size = new System.Drawing.Size(290, 21);
            this.textBox_GoogleKeySettingToggle.TabIndex = 9;
            this.textBox_GoogleKeySettingToggle.Enter += new System.EventHandler(this.textBox_GoogleKeySettingToggle_Enter);
            this.textBox_GoogleKeySettingToggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_GoogleKeySettingToggle_KeyDown);
            this.textBox_GoogleKeySettingToggle.Leave += new System.EventHandler(this.textBox_GoogleKeySettingToggle_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Speech";
            // 
            // textBox_GoogleKeySettingSpeech
            // 
            this.textBox_GoogleKeySettingSpeech.AllowDrop = true;
            this.textBox_GoogleKeySettingSpeech.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox_GoogleKeySettingSpeech.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_GoogleKeySettingSpeech.Location = new System.Drawing.Point(60, 20);
            this.textBox_GoogleKeySettingSpeech.Name = "textBox_GoogleKeySettingSpeech";
            this.textBox_GoogleKeySettingSpeech.ReadOnly = true;
            this.textBox_GoogleKeySettingSpeech.Size = new System.Drawing.Size(290, 21);
            this.textBox_GoogleKeySettingSpeech.TabIndex = 0;
            this.textBox_GoogleKeySettingSpeech.Enter += new System.EventHandler(this.textBox_GoogleKeySettingSpeech_Enter);
            this.textBox_GoogleKeySettingSpeech.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_GoogleKeySettingSpeech_KeyDown);
            this.textBox_GoogleKeySettingSpeech.Leave += new System.EventHandler(this.textBox_GoogleKeySettingSpeech_Leave);
            // 
            // btn_GoogleOFF
            // 
            this.btn_GoogleOFF.BackColor = System.Drawing.Color.Gray;
            this.btn_GoogleOFF.Enabled = false;
            this.btn_GoogleOFF.FlatAppearance.BorderSize = 0;
            this.btn_GoogleOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoogleOFF.Location = new System.Drawing.Point(239, 361);
            this.btn_GoogleOFF.Name = "btn_GoogleOFF";
            this.btn_GoogleOFF.Size = new System.Drawing.Size(168, 58);
            this.btn_GoogleOFF.TabIndex = 19;
            this.btn_GoogleOFF.Text = "OFF";
            this.btn_GoogleOFF.UseVisualStyleBackColor = false;
            this.btn_GoogleOFF.Click += new System.EventHandler(this.btn_GoogleOff_Click);
            // 
            // d
            // 
            this.d.Controls.Add(this.textBox_json);
            this.d.Controls.Add(this.btn_jsonFind);
            this.d.Location = new System.Drawing.Point(46, 56);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(361, 92);
            this.d.TabIndex = 15;
            this.d.TabStop = false;
            this.d.Text = "Json File";
            // 
            // textBox_json
            // 
            this.textBox_json.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Korean"});
            this.textBox_json.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_json.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_json.Location = new System.Drawing.Point(24, 39);
            this.textBox_json.Name = "textBox_json";
            this.textBox_json.ReadOnly = true;
            this.textBox_json.Size = new System.Drawing.Size(245, 21);
            this.textBox_json.TabIndex = 4;
            // 
            // btn_jsonFind
            // 
            this.btn_jsonFind.Location = new System.Drawing.Point(275, 37);
            this.btn_jsonFind.Name = "btn_jsonFind";
            this.btn_jsonFind.Size = new System.Drawing.Size(75, 23);
            this.btn_jsonFind.TabIndex = 3;
            this.btn_jsonFind.TabStop = false;
            this.btn_jsonFind.Text = "findJson";
            this.btn_jsonFind.UseVisualStyleBackColor = true;
            this.btn_jsonFind.Click += new System.EventHandler(this.btn_jsonFind_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Location = new System.Drawing.Point(46, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 92);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Language Select";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(212, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Korean";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_GoogleON
            // 
            this.btn_GoogleON.BackColor = System.Drawing.Color.White;
            this.btn_GoogleON.FlatAppearance.BorderSize = 0;
            this.btn_GoogleON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoogleON.Location = new System.Drawing.Point(46, 361);
            this.btn_GoogleON.Name = "btn_GoogleON";
            this.btn_GoogleON.Size = new System.Drawing.Size(173, 58);
            this.btn_GoogleON.TabIndex = 20;
            this.btn_GoogleON.Text = "ON";
            this.btn_GoogleON.UseVisualStyleBackColor = false;
            this.btn_GoogleON.Click += new System.EventHandler(this.btn_GoogleON_Click);
            // 
            // openFileDialog_jsonFind
            // 
            this.openFileDialog_jsonFind.FileName = "openFileDialog_jsonFind";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(6, 20);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(349, 194);
            this.textBox_log.TabIndex = 6;
            // 
            // group_Log
            // 
            this.group_Log.Controls.Add(this.textBox_log);
            this.group_Log.Location = new System.Drawing.Point(62, 547);
            this.group_Log.Name = "group_Log";
            this.group_Log.Size = new System.Drawing.Size(361, 220);
            this.group_Log.TabIndex = 11;
            this.group_Log.TabStop = false;
            this.group_Log.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(480, 823);
            this.Controls.Add(this.group_Log);
            this.Controls.Add(this.group_flatform);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.Btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form_Azure";
            this.context_NotifySupport.ResumeLayout(false);
            this.group_KeyAndRegion.ResumeLayout(false);
            this.group_KeyAndRegion.PerformLayout();
            this.group_LanguageSelect.ResumeLayout(false);
            this.group_LanguageSelect.PerformLayout();
            this.group_KeySett.ResumeLayout(false);
            this.group_KeySett.PerformLayout();
            this.group_flatform.ResumeLayout(false);
            this.tabPage_Azure.ResumeLayout(false);
            this.tabPage_Google.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.d.ResumeLayout(false);
            this.d.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.group_Log.ResumeLayout(false);
            this.group_Log.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip context_NotifySupport;
        private System.Windows.Forms.ToolStripMenuItem context_NotifySupport_exit;
        private System.Windows.Forms.Button btn_Init;
        private System.Windows.Forms.TextBox textBox_AzureRegionValue;
        private System.Windows.Forms.TextBox textBox_AzurekeyValue;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_KeyAndRegion;
        private System.Windows.Forms.RadioButton radioBtn_Korean;
        private System.Windows.Forms.RadioButton radioBtn_English;
        private System.Windows.Forms.GroupBox group_LanguageSelect;
        private System.Windows.Forms.TextBox textBox_AzureKeySettingSpeech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_AzureKeySettingToggle;
        private System.Windows.Forms.GroupBox group_KeySett;
        private System.Windows.Forms.Button btn_AzureOFF;
        private System.Windows.Forms.Button btn_AzureON;
        private System.Windows.Forms.TabControl group_flatform;
        private System.Windows.Forms.TabPage tabPage_Azure;
        private System.Windows.Forms.TabPage tabPage_Google;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_GoogleKeySettingToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_GoogleKeySettingSpeech;
        private System.Windows.Forms.Button btn_GoogleOFF;
        private System.Windows.Forms.GroupBox d;
        private System.Windows.Forms.TextBox textBox_json;
        private System.Windows.Forms.Button btn_jsonFind;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btn_GoogleON;
        private System.Windows.Forms.OpenFileDialog openFileDialog_jsonFind;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.GroupBox group_Log;
    }
}

