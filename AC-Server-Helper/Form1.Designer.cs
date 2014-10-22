namespace AC_Server_Helper {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.AvailableBox = new System.Windows.Forms.ListBox();
            this.SelectedBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPathBox = new System.Windows.Forms.TextBox();
            this.serverPathBox = new System.Windows.Forms.TextBox();
            this.SelectMainPathButton = new System.Windows.Forms.Button();
            this.selectServerPathButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numClientsBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.udpBox = new System.Windows.Forms.TextBox();
            this.tcpBox = new System.Windows.Forms.TextBox();
            this.httpBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.practiceCheck = new System.Windows.Forms.CheckBox();
            this.qualifyingCheck = new System.Windows.Forms.CheckBox();
            this.raceCheck = new System.Windows.Forms.CheckBox();
            this.practiceTimeBox = new System.Windows.Forms.NumericUpDown();
            this.qualifyingTimeBox = new System.Windows.Forms.NumericUpDown();
            this.raceLapsBox = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.createFileButton = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TyreWearLabel = new System.Windows.Forms.Label();
            this.TyreWearMultBox = new System.Windows.Forms.NumericUpDown();
            this.FuelMultBox = new System.Windows.Forms.NumericUpDown();
            this.DamageMultBox = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SCBox = new System.Windows.Forms.CheckBox();
            this.ACBox = new System.Windows.Forms.CheckBox();
            this.ABSBox = new System.Windows.Forms.CheckBox();
            this.TCBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numClientsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifyingTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceLapsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TyreWearMultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelMultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageMultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBox
            // 
            this.trackBox.FormattingEnabled = true;
            this.trackBox.Location = new System.Drawing.Point(137, 175);
            this.trackBox.Name = "trackBox";
            this.trackBox.Size = new System.Drawing.Size(121, 21);
            this.trackBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Track";
            // 
            // inButton
            // 
            this.inButton.Location = new System.Drawing.Point(229, 311);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(75, 23);
            this.inButton.TabIndex = 5;
            this.inButton.Text = ">>";
            this.inButton.UseVisualStyleBackColor = true;
            this.inButton.Click += new System.EventHandler(this.inButton_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(229, 341);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(75, 23);
            this.outButton.TabIndex = 6;
            this.outButton.Text = "<<";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // AvailableBox
            // 
            this.AvailableBox.FormattingEnabled = true;
            this.AvailableBox.Items.AddRange(new object[] {
            "{No Cars Yet}"});
            this.AvailableBox.Location = new System.Drawing.Point(32, 311);
            this.AvailableBox.Name = "AvailableBox";
            this.AvailableBox.Size = new System.Drawing.Size(170, 342);
            this.AvailableBox.TabIndex = 8;
            // 
            // SelectedBox
            // 
            this.SelectedBox.FormattingEnabled = true;
            this.SelectedBox.Location = new System.Drawing.Point(334, 311);
            this.SelectedBox.Name = "SelectedBox";
            this.SelectedBox.Size = new System.Drawing.Size(170, 342);
            this.SelectedBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Assetto Corsa Path:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "AC Server Path:";
            // 
            // mainPathBox
            // 
            this.mainPathBox.Location = new System.Drawing.Point(137, 11);
            this.mainPathBox.Name = "mainPathBox";
            this.mainPathBox.Size = new System.Drawing.Size(286, 20);
            this.mainPathBox.TabIndex = 12;
            this.mainPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\assettocorsa";
            this.mainPathBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainPathBox_KeyPress);
            // 
            // serverPathBox
            // 
            this.serverPathBox.Location = new System.Drawing.Point(137, 38);
            this.serverPathBox.Name = "serverPathBox";
            this.serverPathBox.Size = new System.Drawing.Size(286, 20);
            this.serverPathBox.TabIndex = 13;
            this.serverPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assetto Corsa Dedicated Server";
            this.serverPathBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serverPathBox_KeyPress);
            // 
            // SelectMainPathButton
            // 
            this.SelectMainPathButton.Location = new System.Drawing.Point(429, 8);
            this.SelectMainPathButton.Name = "SelectMainPathButton";
            this.SelectMainPathButton.Size = new System.Drawing.Size(75, 23);
            this.SelectMainPathButton.TabIndex = 14;
            this.SelectMainPathButton.Text = "...";
            this.SelectMainPathButton.UseVisualStyleBackColor = true;
            this.SelectMainPathButton.Click += new System.EventHandler(this.selectMainPathButton_Click);
            // 
            // selectServerPathButton
            // 
            this.selectServerPathButton.Location = new System.Drawing.Point(429, 35);
            this.selectServerPathButton.Name = "selectServerPathButton";
            this.selectServerPathButton.Size = new System.Drawing.Size(75, 23);
            this.selectServerPathButton.TabIndex = 15;
            this.selectServerPathButton.Text = "...";
            this.selectServerPathButton.UseVisualStyleBackColor = true;
            this.selectServerPathButton.Click += new System.EventHandler(this.selectServerPathButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Server Name: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(137, 65);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(286, 20);
            this.nameBox.TabIndex = 17;
            this.nameBox.Text = "ACServer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Number of Clients:";
            // 
            // numClientsBox
            // 
            this.numClientsBox.Location = new System.Drawing.Point(137, 93);
            this.numClientsBox.Name = "numClientsBox";
            this.numClientsBox.Size = new System.Drawing.Size(60, 20);
            this.numClientsBox.TabIndex = 19;
            this.numClientsBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numClientsBox.ValueChanged += new System.EventHandler(this.numClientsBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "UDP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "TCP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "HTTP:";
            // 
            // udpBox
            // 
            this.udpBox.Location = new System.Drawing.Point(170, 119);
            this.udpBox.Name = "udpBox";
            this.udpBox.Size = new System.Drawing.Size(50, 20);
            this.udpBox.TabIndex = 23;
            this.udpBox.Text = "9456";
            // 
            // tcpBox
            // 
            this.tcpBox.Location = new System.Drawing.Point(266, 119);
            this.tcpBox.Name = "tcpBox";
            this.tcpBox.Size = new System.Drawing.Size(50, 20);
            this.tcpBox.TabIndex = 24;
            this.tcpBox.Text = "9457";
            // 
            // httpBox
            // 
            this.httpBox.Location = new System.Drawing.Point(367, 119);
            this.httpBox.Name = "httpBox";
            this.httpBox.Size = new System.Drawing.Size(50, 20);
            this.httpBox.TabIndex = 25;
            this.httpBox.Text = "8098";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(137, 148);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(121, 20);
            this.passwordBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Practice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Qualifying";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Race";
            // 
            // practiceCheck
            // 
            this.practiceCheck.AutoSize = true;
            this.practiceCheck.Location = new System.Drawing.Point(137, 205);
            this.practiceCheck.Name = "practiceCheck";
            this.practiceCheck.Size = new System.Drawing.Size(77, 17);
            this.practiceCheck.TabIndex = 31;
            this.practiceCheck.Text = "Time (min):";
            this.practiceCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.practiceCheck.UseVisualStyleBackColor = true;
            // 
            // qualifyingCheck
            // 
            this.qualifyingCheck.AutoSize = true;
            this.qualifyingCheck.Checked = true;
            this.qualifyingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qualifyingCheck.Location = new System.Drawing.Point(137, 231);
            this.qualifyingCheck.Name = "qualifyingCheck";
            this.qualifyingCheck.Size = new System.Drawing.Size(77, 17);
            this.qualifyingCheck.TabIndex = 32;
            this.qualifyingCheck.Text = "Time (min):";
            this.qualifyingCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.qualifyingCheck.UseVisualStyleBackColor = true;
            // 
            // raceCheck
            // 
            this.raceCheck.AutoSize = true;
            this.raceCheck.Checked = true;
            this.raceCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.raceCheck.Location = new System.Drawing.Point(137, 255);
            this.raceCheck.Name = "raceCheck";
            this.raceCheck.Size = new System.Drawing.Size(52, 17);
            this.raceCheck.TabIndex = 33;
            this.raceCheck.Text = "Laps:";
            this.raceCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raceCheck.UseVisualStyleBackColor = true;
            // 
            // practiceTimeBox
            // 
            this.practiceTimeBox.Location = new System.Drawing.Point(223, 204);
            this.practiceTimeBox.Name = "practiceTimeBox";
            this.practiceTimeBox.Size = new System.Drawing.Size(35, 20);
            this.practiceTimeBox.TabIndex = 34;
            this.practiceTimeBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // qualifyingTimeBox
            // 
            this.qualifyingTimeBox.Location = new System.Drawing.Point(223, 228);
            this.qualifyingTimeBox.Name = "qualifyingTimeBox";
            this.qualifyingTimeBox.Size = new System.Drawing.Size(35, 20);
            this.qualifyingTimeBox.TabIndex = 35;
            this.qualifyingTimeBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // raceLapsBox
            // 
            this.raceLapsBox.Location = new System.Drawing.Point(223, 254);
            this.raceLapsBox.Name = "raceLapsBox";
            this.raceLapsBox.Size = new System.Drawing.Size(35, 20);
            this.raceLapsBox.TabIndex = 36;
            this.raceLapsBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Cars:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Available:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Selected";
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(429, 659);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(75, 23);
            this.createFileButton.TabIndex = 40;
            this.createFileButton.Text = "Create Files";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(474, 293);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(30, 13);
            this.selectedLabel.TabIndex = 41;
            this.selectedLabel.Text = "0/10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Ports:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(291, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Allowed Driver Aids:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(400, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Damage";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(400, 151);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Multipliers:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(400, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Fuel Use";
            // 
            // TyreWearLabel
            // 
            this.TyreWearLabel.AutoSize = true;
            this.TyreWearLabel.Location = new System.Drawing.Point(400, 230);
            this.TyreWearLabel.Name = "TyreWearLabel";
            this.TyreWearLabel.Size = new System.Drawing.Size(57, 13);
            this.TyreWearLabel.TabIndex = 53;
            this.TyreWearLabel.Text = "Tyre Wear";
            // 
            // TyreWearMultBox
            // 
            this.TyreWearMultBox.Location = new System.Drawing.Point(462, 228);
            this.TyreWearMultBox.Name = "TyreWearMultBox";
            this.TyreWearMultBox.Size = new System.Drawing.Size(42, 20);
            this.TyreWearMultBox.TabIndex = 56;
            this.TyreWearMultBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // FuelMultBox
            // 
            this.FuelMultBox.Location = new System.Drawing.Point(462, 202);
            this.FuelMultBox.Name = "FuelMultBox";
            this.FuelMultBox.Size = new System.Drawing.Size(42, 20);
            this.FuelMultBox.TabIndex = 57;
            this.FuelMultBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // DamageMultBox
            // 
            this.DamageMultBox.Location = new System.Drawing.Point(462, 177);
            this.DamageMultBox.Name = "DamageMultBox";
            this.DamageMultBox.Size = new System.Drawing.Size(42, 20);
            this.DamageMultBox.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(291, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "TC:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "ABS:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(291, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 13);
            this.label20.TabIndex = 46;
            this.label20.Text = "Stability Control:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(291, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Auto Clutch";
            // 
            // SCBox
            // 
            this.SCBox.AutoSize = true;
            this.SCBox.Checked = true;
            this.SCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SCBox.Location = new System.Drawing.Point(379, 232);
            this.SCBox.Name = "SCBox";
            this.SCBox.Size = new System.Drawing.Size(15, 14);
            this.SCBox.TabIndex = 59;
            this.SCBox.UseVisualStyleBackColor = true;
            // 
            // ACBox
            // 
            this.ACBox.AutoSize = true;
            this.ACBox.Checked = true;
            this.ACBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ACBox.Location = new System.Drawing.Point(379, 256);
            this.ACBox.Name = "ACBox";
            this.ACBox.Size = new System.Drawing.Size(15, 14);
            this.ACBox.TabIndex = 60;
            this.ACBox.UseVisualStyleBackColor = true;
            // 
            // ABSBox
            // 
            this.ABSBox.AutoSize = true;
            this.ABSBox.Checked = true;
            this.ABSBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ABSBox.Location = new System.Drawing.Point(379, 205);
            this.ABSBox.Name = "ABSBox";
            this.ABSBox.Size = new System.Drawing.Size(15, 14);
            this.ABSBox.TabIndex = 61;
            this.ABSBox.UseVisualStyleBackColor = true;
            // 
            // TCBox
            // 
            this.TCBox.AutoSize = true;
            this.TCBox.Checked = true;
            this.TCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TCBox.Location = new System.Drawing.Point(379, 178);
            this.TCBox.Name = "TCBox";
            this.TCBox.Size = new System.Drawing.Size(15, 14);
            this.TCBox.TabIndex = 62;
            this.TCBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.createFileButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(534, 691);
            this.Controls.Add(this.TCBox);
            this.Controls.Add(this.ABSBox);
            this.Controls.Add(this.ACBox);
            this.Controls.Add(this.SCBox);
            this.Controls.Add(this.DamageMultBox);
            this.Controls.Add(this.FuelMultBox);
            this.Controls.Add(this.TyreWearMultBox);
            this.Controls.Add(this.TyreWearLabel);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.raceLapsBox);
            this.Controls.Add(this.qualifyingTimeBox);
            this.Controls.Add(this.practiceTimeBox);
            this.Controls.Add(this.raceCheck);
            this.Controls.Add(this.qualifyingCheck);
            this.Controls.Add(this.practiceCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.httpBox);
            this.Controls.Add(this.tcpBox);
            this.Controls.Add(this.udpBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numClientsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectServerPathButton);
            this.Controls.Add(this.SelectMainPathButton);
            this.Controls.Add(this.serverPathBox);
            this.Controls.Add(this.mainPathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedBox);
            this.Controls.Add(this.AvailableBox);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.inButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AC Server File Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numClientsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifyingTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceLapsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TyreWearMultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelMultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DamageMultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trackBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.ListBox AvailableBox;
        private System.Windows.Forms.ListBox SelectedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mainPathBox;
        private System.Windows.Forms.TextBox serverPathBox;
        private System.Windows.Forms.Button SelectMainPathButton;
        private System.Windows.Forms.Button selectServerPathButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numClientsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox udpBox;
        private System.Windows.Forms.TextBox tcpBox;
        private System.Windows.Forms.TextBox httpBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox practiceCheck;
        private System.Windows.Forms.CheckBox qualifyingCheck;
        private System.Windows.Forms.CheckBox raceCheck;
        private System.Windows.Forms.NumericUpDown practiceTimeBox;
        private System.Windows.Forms.NumericUpDown qualifyingTimeBox;
        private System.Windows.Forms.NumericUpDown raceLapsBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label TyreWearLabel;
        private System.Windows.Forms.NumericUpDown TyreWearMultBox;
        private System.Windows.Forms.NumericUpDown FuelMultBox;
        private System.Windows.Forms.NumericUpDown DamageMultBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox SCBox;
        private System.Windows.Forms.CheckBox ACBox;
        private System.Windows.Forms.CheckBox ABSBox;
        private System.Windows.Forms.CheckBox TCBox;
    }
}

