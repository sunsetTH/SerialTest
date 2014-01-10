namespace SERIALDUBUG
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Init = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.comBoxSerial = new System.Windows.Forms.ComboBox();
            this.comboBoxBuad = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxCheckbits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopbits = new System.Windows.Forms.ComboBox();
            this.comboBoxStreamCtrl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.数据显示 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.曲线显示 = new System.Windows.Forms.TabControl();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.d显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.曲线显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示数据类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.数据显示.SuspendLayout();
            this.曲线显示.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Init
            // 
            resources.ApplyResources(this.Init, "Init");
            this.Init.Name = "Init";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Linen;
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            // 
            // comBoxSerial
            // 
            this.comBoxSerial.FormattingEnabled = true;
            resources.ApplyResources(this.comBoxSerial, "comBoxSerial");
            this.comBoxSerial.Name = "comBoxSerial";
            this.comBoxSerial.Sorted = true;
            this.comBoxSerial.SelectedIndexChanged += new System.EventHandler(this.comBoxSerial_SelectedIndexChanged);
            // 
            // comboBoxBuad
            // 
            this.comboBoxBuad.FormattingEnabled = true;
            this.comboBoxBuad.Items.AddRange(new object[] {
            resources.GetString("comboBoxBuad.Items"),
            resources.GetString("comboBoxBuad.Items1"),
            resources.GetString("comboBoxBuad.Items2"),
            resources.GetString("comboBoxBuad.Items3"),
            resources.GetString("comboBoxBuad.Items4"),
            resources.GetString("comboBoxBuad.Items5")});
            resources.ApplyResources(this.comboBoxBuad, "comboBoxBuad");
            this.comboBoxBuad.Name = "comboBoxBuad";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            resources.GetString("comboBoxDatabits.Items"),
            resources.GetString("comboBoxDatabits.Items1"),
            resources.GetString("comboBoxDatabits.Items2"),
            resources.GetString("comboBoxDatabits.Items3")});
            resources.ApplyResources(this.comboBoxDatabits, "comboBoxDatabits");
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comBoxCheckbits
            // 
            this.comBoxCheckbits.FormattingEnabled = true;
            this.comBoxCheckbits.Items.AddRange(new object[] {
            resources.GetString("comBoxCheckbits.Items"),
            resources.GetString("comBoxCheckbits.Items1"),
            resources.GetString("comBoxCheckbits.Items2"),
            resources.GetString("comBoxCheckbits.Items3"),
            resources.GetString("comBoxCheckbits.Items4")});
            resources.ApplyResources(this.comBoxCheckbits, "comBoxCheckbits");
            this.comBoxCheckbits.Name = "comBoxCheckbits";
            // 
            // comboBoxStopbits
            // 
            this.comboBoxStopbits.FormattingEnabled = true;
            this.comboBoxStopbits.Items.AddRange(new object[] {
            resources.GetString("comboBoxStopbits.Items"),
            resources.GetString("comboBoxStopbits.Items1"),
            resources.GetString("comboBoxStopbits.Items2")});
            resources.ApplyResources(this.comboBoxStopbits, "comboBoxStopbits");
            this.comboBoxStopbits.Name = "comboBoxStopbits";
            // 
            // comboBoxStreamCtrl
            // 
            this.comboBoxStreamCtrl.AllowDrop = true;
            this.comboBoxStreamCtrl.FormattingEnabled = true;
            this.comboBoxStreamCtrl.Items.AddRange(new object[] {
            resources.GetString("comboBoxStreamCtrl.Items"),
            resources.GetString("comboBoxStreamCtrl.Items1"),
            resources.GetString("comboBoxStreamCtrl.Items2")});
            resources.ApplyResources(this.comboBoxStreamCtrl, "comboBoxStreamCtrl");
            this.comboBoxStreamCtrl.Name = "comboBoxStreamCtrl";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxStreamCtrl);
            this.groupBox1.Controls.Add(this.comboBoxStopbits);
            this.groupBox1.Controls.Add(this.comBoxCheckbits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxDatabits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBuad);
            this.groupBox1.Controls.Add(this.comBoxSerial);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2")});
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.Name = "checkedListBox1";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            resources.GetString("checkedListBox2.Items")});
            resources.ApplyResources(this.checkedListBox2, "checkedListBox2");
            this.checkedListBox2.Name = "checkedListBox2";
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Controls.Add(this.radioButton2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.Init);
            this.groupBox4.Controls.Add(this.checkedListBox1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapControl);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapControl
            // 
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.mapControl, "mapControl");
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 2;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Zoom = 0D;
            this.mapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseDown);
            // 
            // 数据显示
            // 
            this.数据显示.Controls.Add(this.checkedListBox3);
            this.数据显示.Controls.Add(this.zedGraphControl1);
            resources.ApplyResources(this.数据显示, "数据显示");
            this.数据显示.Name = "数据显示";
            this.数据显示.UseVisualStyleBackColor = true;
            this.数据显示.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // zedGraphControl1
            // 
            resources.ApplyResources(this.zedGraphControl1, "zedGraphControl1");
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            resources.ApplyResources(this.checkedListBox3, "checkedListBox3");
            this.checkedListBox3.Items.AddRange(new object[] {
            resources.GetString("checkedListBox3.Items"),
            resources.GetString("checkedListBox3.Items1"),
            resources.GetString("checkedListBox3.Items2"),
            resources.GetString("checkedListBox3.Items3"),
            resources.GetString("checkedListBox3.Items4"),
            resources.GetString("checkedListBox3.Items5"),
            resources.GetString("checkedListBox3.Items6"),
            resources.GetString("checkedListBox3.Items7"),
            resources.GetString("checkedListBox3.Items8")});
            this.checkedListBox3.MultiColumn = true;
            this.checkedListBox3.Name = "checkedListBox3";
            // 
            // 曲线显示
            // 
            this.曲线显示.Controls.Add(this.数据显示);
            this.曲线显示.Controls.Add(this.tabPage2);
            this.曲线显示.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.曲线显示, "曲线显示");
            this.曲线显示.Name = "曲线显示";
            this.曲线显示.SelectedIndex = 0;
            this.曲线显示.Click += new System.EventHandler(this.曲线显示_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存为ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            resources.ApplyResources(this.打开ToolStripMenuItem, "打开ToolStripMenuItem");
            // 
            // 保存为ToolStripMenuItem
            // 
            this.保存为ToolStripMenuItem.Name = "保存为ToolStripMenuItem";
            resources.ApplyResources(this.保存为ToolStripMenuItem, "保存为ToolStripMenuItem");
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            resources.ApplyResources(this.另存为ToolStripMenuItem, "另存为ToolStripMenuItem");
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存为ToolStripMenuItem1});
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            resources.ApplyResources(this.保存文件ToolStripMenuItem, "保存文件ToolStripMenuItem");
            // 
            // 另存为ToolStripMenuItem1
            // 
            this.另存为ToolStripMenuItem1.Name = "另存为ToolStripMenuItem1";
            resources.ApplyResources(this.另存为ToolStripMenuItem1, "另存为ToolStripMenuItem1");
            // 
            // d显示ToolStripMenuItem
            // 
            this.d显示ToolStripMenuItem.Name = "d显示ToolStripMenuItem";
            resources.ApplyResources(this.d显示ToolStripMenuItem, "d显示ToolStripMenuItem");
            // 
            // 曲线显示ToolStripMenuItem
            // 
            this.曲线显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示数据类型ToolStripMenuItem});
            this.曲线显示ToolStripMenuItem.Name = "曲线显示ToolStripMenuItem";
            resources.ApplyResources(this.曲线显示ToolStripMenuItem, "曲线显示ToolStripMenuItem");
            // 
            // 显示数据类型ToolStripMenuItem
            // 
            this.显示数据类型ToolStripMenuItem.Name = "显示数据类型ToolStripMenuItem";
            resources.ApplyResources(this.显示数据类型ToolStripMenuItem, "显示数据类型ToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存文件ToolStripMenuItem,
            this.d显示ToolStripMenuItem,
            this.曲线显示ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.曲线显示);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.数据显示.ResumeLayout(false);
            this.曲线显示.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox comBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxBuad;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comBoxCheckbits;
        private System.Windows.Forms.ComboBox comboBoxStopbits;
        private System.Windows.Forms.ComboBox comboBoxStreamCtrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage 数据显示;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.TabControl 曲线显示;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem d显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 曲线显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示数据类型ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private GMap.NET.WindowsForms.GMapControl mapControl;
    }
}

