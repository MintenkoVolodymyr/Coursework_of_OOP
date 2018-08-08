namespace EditorSongs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAllSong = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMShowLast = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchAll = new System.Windows.Forms.TextBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchVerse = new System.Windows.Forms.TextBox();
            this.nudSearch = new System.Windows.Forms.NumericUpDown();
            this.btnSearchVerse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudChange1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudChange2 = new System.Windows.Forms.NumericUpDown();
            this.btnChange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStringForSubstitute = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSubstitute1 = new System.Windows.Forms.NumericUpDown();
            this.nudSubstitute2 = new System.Windows.Forms.NumericUpDown();
            this.btnSubstitute = new System.Windows.Forms.Button();
            this.rtbLastString = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvFind = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnViewLastString = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstitute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstitute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbAllSong
            // 
            this.rtbAllSong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbAllSong.Location = new System.Drawing.Point(526, 123);
            this.rtbAllSong.Name = "rtbAllSong";
            this.rtbAllSong.ReadOnly = true;
            this.rtbAllSong.Size = new System.Drawing.Size(447, 321);
            this.rtbAllSong.TabIndex = 0;
            this.rtbAllSong.Text = "";
            this.rtbAllSong.Click += new System.EventHandler(this.rtbAllSong_Click);
            this.rtbAllSong.TextChanged += new System.EventHandler(this.rtbAllSong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(716, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст пісні";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvInformation
            // 
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvInformation.Location = new System.Drawing.Point(4, 123);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.ReadOnly = true;
            this.dgvInformation.RowHeadersVisible = false;
            this.dgvInformation.Size = new System.Drawing.Size(503, 58);
            this.dgvInformation.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Назва";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Кількість куплетів";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Чи є сонет?";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Тип сонету";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(192, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Інформація про пісню";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMOpen,
            this.TSMSave,
            this.toolStripMenuItem1,
            this.TSMExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // TSMOpen
            // 
            this.TSMOpen.Name = "TSMOpen";
            this.TSMOpen.Size = new System.Drawing.Size(124, 22);
            this.TSMOpen.Text = "Відкрити";
            this.TSMOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // TSMSave
            // 
            this.TSMSave.Name = "TSMSave";
            this.TSMSave.Size = new System.Drawing.Size(124, 22);
            this.TSMSave.Text = "Зберегти";
            this.TSMSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // TSMExit
            // 
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.Size = new System.Drawing.Size(124, 22);
            this.TSMExit.Text = "Вихід";
            this.TSMExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAdd,
            this.TSMShowLast});
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // TSMAdd
            // 
            this.TSMAdd.Name = "TSMAdd";
            this.TSMAdd.Size = new System.Drawing.Size(262, 22);
            this.TSMAdd.Text = "Додати пісню";
            this.TSMAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TSMShowLast
            // 
            this.TSMShowLast.Name = "TSMShowLast";
            this.TSMShowLast.Size = new System.Drawing.Size(262, 22);
            this.TSMShowLast.Text = "Показати останні стрічки куплетів";
            this.TSMShowLast.Click += new System.EventHandler(this.btnViewLastString_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMHelp,
            this.toolStripMenuItem2,
            this.TSMAbout});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // TSMHelp
            // 
            this.TSMHelp.Name = "TSMHelp";
            this.TSMHelp.Size = new System.Drawing.Size(183, 22);
            this.TSMHelp.Text = "Подивитися довідку";
            this.TSMHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // TSMAbout
            // 
            this.TSMAbout.Name = "TSMAbout";
            this.TSMAbout.Size = new System.Drawing.Size(183, 22);
            this.TSMAbout.Text = "Про програму";
            this.TSMAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пошук в пісні";
            // 
            // tbSearchAll
            // 
            this.tbSearchAll.Location = new System.Drawing.Point(298, 39);
            this.tbSearchAll.Name = "tbSearchAll";
            this.tbSearchAll.Size = new System.Drawing.Size(121, 20);
            this.tbSearchAll.TabIndex = 10;
            this.tbSearchAll.TextChanged += new System.EventHandler(this.tbSearchAll_TextChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(298, 60);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(121, 29);
            this.btnSearchAll.TabIndex = 11;
            this.btnSearchAll.Text = "Шукати";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Пошук в куплеті";
            // 
            // tbSearchVerse
            // 
            this.tbSearchVerse.Location = new System.Drawing.Point(425, 40);
            this.tbSearchVerse.Name = "tbSearchVerse";
            this.tbSearchVerse.Size = new System.Drawing.Size(100, 20);
            this.tbSearchVerse.TabIndex = 13;
            this.tbSearchVerse.TextChanged += new System.EventHandler(this.tbSearchVerse_TextChanged);
            // 
            // nudSearch
            // 
            this.nudSearch.Location = new System.Drawing.Point(526, 40);
            this.nudSearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSearch.Name = "nudSearch";
            this.nudSearch.Size = new System.Drawing.Size(51, 20);
            this.nudSearch.TabIndex = 14;
            this.nudSearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSearchVerse
            // 
            this.btnSearchVerse.Location = new System.Drawing.Point(425, 61);
            this.btnSearchVerse.Name = "btnSearchVerse";
            this.btnSearchVerse.Size = new System.Drawing.Size(152, 28);
            this.btnSearchVerse.TabIndex = 15;
            this.btnSearchVerse.Text = "Шукати";
            this.btnSearchVerse.UseVisualStyleBackColor = true;
            this.btnSearchVerse.Click += new System.EventHandler(this.btnSearchVerse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(293, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Поміняти куплети місцями";
            // 
            // nudChange1
            // 
            this.nudChange1.Location = new System.Drawing.Point(296, 211);
            this.nudChange1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChange1.Name = "nudChange1";
            this.nudChange1.Size = new System.Drawing.Size(76, 20);
            this.nudChange1.TabIndex = 17;
            this.nudChange1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(383, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "з";
            // 
            // nudChange2
            // 
            this.nudChange2.Location = new System.Drawing.Point(413, 210);
            this.nudChange2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChange2.Name = "nudChange2";
            this.nudChange2.Size = new System.Drawing.Size(76, 20);
            this.nudChange2.TabIndex = 19;
            this.nudChange2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(296, 242);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(193, 23);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "Переставити";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Замінення стрічки в куплеті";
            // 
            // tbStringForSubstitute
            // 
            this.tbStringForSubstitute.Location = new System.Drawing.Point(27, 355);
            this.tbStringForSubstitute.Name = "tbStringForSubstitute";
            this.tbStringForSubstitute.Size = new System.Drawing.Size(193, 20);
            this.tbStringForSubstitute.TabIndex = 22;
            this.tbStringForSubstitute.TextChanged += new System.EventHandler(this.tbStringForSubstitute_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Введіть стрічку";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Номер куплету";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Номер стрічки";
            // 
            // nudSubstitute1
            // 
            this.nudSubstitute1.Location = new System.Drawing.Point(27, 395);
            this.nudSubstitute1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSubstitute1.Name = "nudSubstitute1";
            this.nudSubstitute1.Size = new System.Drawing.Size(76, 20);
            this.nudSubstitute1.TabIndex = 26;
            this.nudSubstitute1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSubstitute1.ValueChanged += new System.EventHandler(this.nudSubstitute1_ValueChanged);
            // 
            // nudSubstitute2
            // 
            this.nudSubstitute2.Location = new System.Drawing.Point(144, 395);
            this.nudSubstitute2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSubstitute2.Name = "nudSubstitute2";
            this.nudSubstitute2.Size = new System.Drawing.Size(77, 20);
            this.nudSubstitute2.TabIndex = 27;
            this.nudSubstitute2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubstitute
            // 
            this.btnSubstitute.Location = new System.Drawing.Point(27, 421);
            this.btnSubstitute.Name = "btnSubstitute";
            this.btnSubstitute.Size = new System.Drawing.Size(194, 23);
            this.btnSubstitute.TabIndex = 30;
            this.btnSubstitute.Text = "Замінити";
            this.btnSubstitute.UseVisualStyleBackColor = true;
            this.btnSubstitute.Click += new System.EventHandler(this.btnSubstitute_Click);
            // 
            // rtbLastString
            // 
            this.rtbLastString.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbLastString.Location = new System.Drawing.Point(296, 314);
            this.rtbLastString.Name = "rtbLastString";
            this.rtbLastString.ReadOnly = true;
            this.rtbLastString.Size = new System.Drawing.Size(200, 130);
            this.rtbLastString.TabIndex = 31;
            this.rtbLastString.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(302, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Останні стрічки куплетів";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(56, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Результати пошуку";
            // 
            // dgvFind
            // 
            this.dgvFind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvFind.Location = new System.Drawing.Point(4, 210);
            this.dgvFind.Name = "dgvFind";
            this.dgvFind.RowHeadersVisible = false;
            this.dgvFind.Size = new System.Drawing.Size(251, 99);
            this.dgvFind.TabIndex = 39;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Куплет";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Рядок";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Слово";
            this.Column8.Name = "Column8";
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::EditorSongs.Properties.Resources.Dos_black_red;
            this.btnAbout.Location = new System.Drawing.Point(681, 23);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(97, 67);
            this.btnAbout.TabIndex = 35;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnViewLastString
            // 
            this.btnViewLastString.Image = global::EditorSongs.Properties.Resources.Startmenu_black_red;
            this.btnViewLastString.Location = new System.Drawing.Point(584, 23);
            this.btnViewLastString.Name = "btnViewLastString";
            this.btnViewLastString.Size = new System.Drawing.Size(97, 67);
            this.btnViewLastString.TabIndex = 33;
            this.btnViewLastString.UseVisualStyleBackColor = true;
            this.btnViewLastString.Click += new System.EventHandler(this.btnViewLastString_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::EditorSongs.Properties.Resources.File_Config_black_red1;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(778, 23);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(97, 67);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::EditorSongs.Properties.Resources.Cp_black_red;
            this.btnExit.Location = new System.Drawing.Point(876, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 67);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EditorSongs.Properties.Resources.File_Text_black_red;
            this.btnAdd.Location = new System.Drawing.Point(195, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 66);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::EditorSongs.Properties.Resources.Cd_black_red;
            this.btnSave.Location = new System.Drawing.Point(97, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 66);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::EditorSongs.Properties.Resources.Folder_black_red;
            this.btnOpen.Location = new System.Drawing.Point(0, 24);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 66);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.dgvFind);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnViewLastString);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbLastString);
            this.Controls.Add(this.btnSubstitute);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.nudSubstitute2);
            this.Controls.Add(this.nudSubstitute1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbStringForSubstitute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.nudChange2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudChange1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearchVerse);
            this.Controls.Add(this.nudSearch);
            this.Controls.Add(this.tbSearchVerse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.tbSearchAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbAllSong);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " Редактор пісень";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChange2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstitute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubstitute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchVerse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStringForSubstitute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSubstitute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnViewLastString;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMAdd;
        private System.Windows.Forms.ToolStripMenuItem TSMShowLast;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMAbout;
        public System.Windows.Forms.RichTextBox rtbAllSong;
        public System.Windows.Forms.DataGridView dgvInformation;
        public System.Windows.Forms.RichTextBox rtbLastString;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DataGridView dgvFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.NumericUpDown nudSearch;
        public System.Windows.Forms.NumericUpDown nudChange1;
        public System.Windows.Forms.NumericUpDown nudChange2;
        public System.Windows.Forms.TextBox tbSearchAll;
        public System.Windows.Forms.TextBox tbSearchVerse;
        public System.Windows.Forms.NumericUpDown nudSubstitute1;
        public System.Windows.Forms.NumericUpDown nudSubstitute2;
    }
}

