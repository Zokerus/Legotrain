namespace LTC
{
    partial class FrmMainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.TbcController = new System.Windows.Forms.TabControl();
            this.TabController = new System.Windows.Forms.TabPage();
            this.BtnPower = new System.Windows.Forms.Button();
            this.BtnControllerConnect = new System.Windows.Forms.Button();
            this.CbbController = new System.Windows.Forms.ComboBox();
            this.LblController = new System.Windows.Forms.Label();
            this.TabFeedback = new System.Windows.Forms.TabPage();
            this.BtnMelderConnect = new System.Windows.Forms.Button();
            this.CbbMelder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabSchalter = new System.Windows.Forms.TabPage();
            this.BtnSchalterConnect = new System.Windows.Forms.Button();
            this.CbbSchalter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbbTrains = new System.Windows.Forms.ComboBox();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TrbSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChbAbschnitt4 = new System.Windows.Forms.CheckBox();
            this.ChbAbschnitt2 = new System.Windows.Forms.CheckBox();
            this.ChbAbschnitt1 = new System.Windows.Forms.CheckBox();
            this.ChbAbschnitt3 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.streckeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zügeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTotalStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TbcController.SuspendLayout();
            this.TabController.SuspendLayout();
            this.TabFeedback.SuspendLayout();
            this.TabSchalter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcController
            // 
            this.TbcController.Controls.Add(this.TabController);
            this.TbcController.Controls.Add(this.TabFeedback);
            this.TbcController.Controls.Add(this.TabSchalter);
            this.TbcController.Location = new System.Drawing.Point(18, 42);
            this.TbcController.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbcController.Name = "TbcController";
            this.TbcController.SelectedIndex = 0;
            this.TbcController.Size = new System.Drawing.Size(363, 232);
            this.TbcController.TabIndex = 0;
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.BtnPower);
            this.TabController.Controls.Add(this.BtnControllerConnect);
            this.TabController.Controls.Add(this.CbbController);
            this.TabController.Controls.Add(this.LblController);
            this.TabController.Location = new System.Drawing.Point(4, 29);
            this.TabController.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabController.Name = "TabController";
            this.TabController.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabController.Size = new System.Drawing.Size(355, 199);
            this.TabController.TabIndex = 0;
            this.TabController.Text = "Controller";
            this.TabController.UseVisualStyleBackColor = true;
            // 
            // BtnPower
            // 
            this.BtnPower.BackColor = System.Drawing.Color.Red;
            this.BtnPower.Location = new System.Drawing.Point(117, 135);
            this.BtnPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(112, 35);
            this.BtnPower.TabIndex = 3;
            this.BtnPower.Text = "Power OFF";
            this.BtnPower.UseVisualStyleBackColor = false;
            this.BtnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // BtnControllerConnect
            // 
            this.BtnControllerConnect.Location = new System.Drawing.Point(117, 91);
            this.BtnControllerConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnControllerConnect.Name = "BtnControllerConnect";
            this.BtnControllerConnect.Size = new System.Drawing.Size(112, 35);
            this.BtnControllerConnect.TabIndex = 2;
            this.BtnControllerConnect.Text = "Connect";
            this.BtnControllerConnect.UseVisualStyleBackColor = true;
            this.BtnControllerConnect.Click += new System.EventHandler(this.BtnControllerConnect_Click);
            // 
            // CbbController
            // 
            this.CbbController.FormattingEnabled = true;
            this.CbbController.Location = new System.Drawing.Point(14, 49);
            this.CbbController.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbController.Name = "CbbController";
            this.CbbController.Size = new System.Drawing.Size(326, 28);
            this.CbbController.TabIndex = 1;
            // 
            // LblController
            // 
            this.LblController.AutoSize = true;
            this.LblController.Location = new System.Drawing.Point(9, 25);
            this.LblController.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblController.Name = "LblController";
            this.LblController.Size = new System.Drawing.Size(81, 20);
            this.LblController.TabIndex = 0;
            this.LblController.Text = "Controller:";
            // 
            // TabFeedback
            // 
            this.TabFeedback.Controls.Add(this.BtnMelderConnect);
            this.TabFeedback.Controls.Add(this.CbbMelder);
            this.TabFeedback.Controls.Add(this.label1);
            this.TabFeedback.Location = new System.Drawing.Point(4, 29);
            this.TabFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabFeedback.Name = "TabFeedback";
            this.TabFeedback.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabFeedback.Size = new System.Drawing.Size(355, 199);
            this.TabFeedback.TabIndex = 1;
            this.TabFeedback.Text = "Rückmeldung";
            this.TabFeedback.UseVisualStyleBackColor = true;
            // 
            // BtnMelderConnect
            // 
            this.BtnMelderConnect.Location = new System.Drawing.Point(117, 91);
            this.BtnMelderConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMelderConnect.Name = "BtnMelderConnect";
            this.BtnMelderConnect.Size = new System.Drawing.Size(112, 35);
            this.BtnMelderConnect.TabIndex = 5;
            this.BtnMelderConnect.Text = "Connect";
            this.BtnMelderConnect.UseVisualStyleBackColor = true;
            this.BtnMelderConnect.Click += new System.EventHandler(this.BtnMelderConnect_Click);
            // 
            // CbbMelder
            // 
            this.CbbMelder.FormattingEnabled = true;
            this.CbbMelder.Location = new System.Drawing.Point(14, 49);
            this.CbbMelder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbMelder.Name = "CbbMelder";
            this.CbbMelder.Size = new System.Drawing.Size(326, 28);
            this.CbbMelder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rückmelder:";
            // 
            // TabSchalter
            // 
            this.TabSchalter.Controls.Add(this.BtnSchalterConnect);
            this.TabSchalter.Controls.Add(this.CbbSchalter);
            this.TabSchalter.Controls.Add(this.label2);
            this.TabSchalter.Location = new System.Drawing.Point(4, 29);
            this.TabSchalter.Name = "TabSchalter";
            this.TabSchalter.Size = new System.Drawing.Size(355, 199);
            this.TabSchalter.TabIndex = 2;
            this.TabSchalter.Text = "Schalter";
            this.TabSchalter.UseVisualStyleBackColor = true;
            // 
            // BtnSchalterConnect
            // 
            this.BtnSchalterConnect.Location = new System.Drawing.Point(117, 91);
            this.BtnSchalterConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSchalterConnect.Name = "BtnSchalterConnect";
            this.BtnSchalterConnect.Size = new System.Drawing.Size(112, 35);
            this.BtnSchalterConnect.TabIndex = 8;
            this.BtnSchalterConnect.Text = "Connect";
            this.BtnSchalterConnect.UseVisualStyleBackColor = true;
            this.BtnSchalterConnect.Click += new System.EventHandler(this.BtnSchalterConnect_Click);
            // 
            // CbbSchalter
            // 
            this.CbbSchalter.FormattingEnabled = true;
            this.CbbSchalter.Location = new System.Drawing.Point(14, 49);
            this.CbbSchalter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbSchalter.Name = "CbbSchalter";
            this.CbbSchalter.Size = new System.Drawing.Size(326, 28);
            this.CbbSchalter.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Schalter:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbbTrains);
            this.groupBox1.Controls.Add(this.LblSpeed);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnGo);
            this.groupBox1.Controls.Add(this.TrbSpeed);
            this.groupBox1.Location = new System.Drawing.Point(18, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(357, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Züge";
            // 
            // CbbTrains
            // 
            this.CbbTrains.FormattingEnabled = true;
            this.CbbTrains.Location = new System.Drawing.Point(45, 29);
            this.CbbTrains.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbbTrains.Name = "CbbTrains";
            this.CbbTrains.Size = new System.Drawing.Size(270, 28);
            this.CbbTrains.TabIndex = 4;
            this.CbbTrains.SelectedIndexChanged += new System.EventHandler(this.CbbTrains_SelectedIndexChanged);
            // 
            // LblSpeed
            // 
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(172, 295);
            this.LblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(18, 20);
            this.LblSpeed.TabIndex = 3;
            this.LblSpeed.Text = "0";
            this.LblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(204, 320);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(112, 35);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "STOP";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(45, 320);
            this.BtnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(112, 35);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "GO";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TrbSpeed
            // 
            this.TrbSpeed.Location = new System.Drawing.Point(154, 63);
            this.TrbSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrbSpeed.Maximum = 100;
            this.TrbSpeed.Minimum = -100;
            this.TrbSpeed.Name = "TrbSpeed";
            this.TrbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrbSpeed.Size = new System.Drawing.Size(45, 228);
            this.TrbSpeed.TabIndex = 0;
            this.TrbSpeed.Scroll += new System.EventHandler(this.TrbSpeed_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.ChbAbschnitt4);
            this.groupBox2.Controls.Add(this.ChbAbschnitt2);
            this.groupBox2.Controls.Add(this.ChbAbschnitt1);
            this.groupBox2.Controls.Add(this.ChbAbschnitt3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(390, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(792, 523);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan";
            // 
            // ChbAbschnitt4
            // 
            this.ChbAbschnitt4.AutoSize = true;
            this.ChbAbschnitt4.Location = new System.Drawing.Point(552, 242);
            this.ChbAbschnitt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChbAbschnitt4.Name = "ChbAbschnitt4";
            this.ChbAbschnitt4.Size = new System.Drawing.Size(108, 24);
            this.ChbAbschnitt4.TabIndex = 5;
            this.ChbAbschnitt4.Text = "Abschnitt 4";
            this.ChbAbschnitt4.UseVisualStyleBackColor = true;
            // 
            // ChbAbschnitt2
            // 
            this.ChbAbschnitt2.AutoSize = true;
            this.ChbAbschnitt2.Location = new System.Drawing.Point(51, 242);
            this.ChbAbschnitt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChbAbschnitt2.Name = "ChbAbschnitt2";
            this.ChbAbschnitt2.Size = new System.Drawing.Size(108, 24);
            this.ChbAbschnitt2.TabIndex = 4;
            this.ChbAbschnitt2.Text = "Abschnitt 2";
            this.ChbAbschnitt2.UseVisualStyleBackColor = true;
            // 
            // ChbAbschnitt1
            // 
            this.ChbAbschnitt1.AutoSize = true;
            this.ChbAbschnitt1.Location = new System.Drawing.Point(334, 423);
            this.ChbAbschnitt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChbAbschnitt1.Name = "ChbAbschnitt1";
            this.ChbAbschnitt1.Size = new System.Drawing.Size(108, 24);
            this.ChbAbschnitt1.TabIndex = 3;
            this.ChbAbschnitt1.Text = "Abschnitt 1";
            this.ChbAbschnitt1.UseVisualStyleBackColor = true;
            // 
            // ChbAbschnitt3
            // 
            this.ChbAbschnitt3.AutoSize = true;
            this.ChbAbschnitt3.Location = new System.Drawing.Point(334, 52);
            this.ChbAbschnitt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChbAbschnitt3.Name = "ChbAbschnitt3";
            this.ChbAbschnitt3.Size = new System.Drawing.Size(108, 24);
            this.ChbAbschnitt3.TabIndex = 2;
            this.ChbAbschnitt3.Text = "Abschnitt 3";
            this.ChbAbschnitt3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streckeToolStripMenuItem,
            this.zügeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1688, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // streckeToolStripMenuItem
            // 
            this.streckeToolStripMenuItem.Name = "streckeToolStripMenuItem";
            this.streckeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.streckeToolStripMenuItem.Text = "Strecke";
            // 
            // zügeToolStripMenuItem
            // 
            this.zügeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem});
            this.zügeToolStripMenuItem.Name = "zügeToolStripMenuItem";
            this.zügeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.zügeToolStripMenuItem.Text = "Züge";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            this.erstellenToolStripMenuItem.Click += new System.EventHandler(this.erstellenToolStripMenuItem_Click);
            // 
            // BtnTotalStop
            // 
            this.BtnTotalStop.BackColor = System.Drawing.Color.Red;
            this.BtnTotalStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTotalStop.Location = new System.Drawing.Point(390, 603);
            this.BtnTotalStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTotalStop.Name = "BtnTotalStop";
            this.BtnTotalStop.Size = new System.Drawing.Size(170, 71);
            this.BtnTotalStop.TabIndex = 4;
            this.BtnTotalStop.Text = "STOP";
            this.BtnTotalStop.UseVisualStyleBackColor = false;
            this.BtnTotalStop.Click += new System.EventHandler(this.BtnTotalStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 578);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sensor 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 578);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sensor 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 578);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sensor 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 683);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1162, 193);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 204);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(141, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 920);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnTotalStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbcController);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lego Train Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainWindow_FormClosing);
            this.TbcController.ResumeLayout(false);
            this.TabController.ResumeLayout(false);
            this.TabController.PerformLayout();
            this.TabFeedback.ResumeLayout(false);
            this.TabFeedback.PerformLayout();
            this.TabSchalter.ResumeLayout(false);
            this.TabSchalter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TbcController;
        private System.Windows.Forms.TabPage TabController;
        private System.Windows.Forms.Button BtnControllerConnect;
        private System.Windows.Forms.ComboBox CbbController;
        private System.Windows.Forms.Label LblController;
        private System.Windows.Forms.TabPage TabFeedback;
        private System.Windows.Forms.Button BtnPower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TrackBar TrbSpeed;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMelderConnect;
        private System.Windows.Forms.ComboBox CbbMelder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChbAbschnitt3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ChbAbschnitt1;
        private System.Windows.Forms.CheckBox ChbAbschnitt2;
        private System.Windows.Forms.ComboBox CbbTrains;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem streckeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zügeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.Button BtnTotalStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox ChbAbschnitt4;
        private System.Windows.Forms.TabPage TabSchalter;
        private System.Windows.Forms.Button BtnSchalterConnect;
        private System.Windows.Forms.ComboBox CbbSchalter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

