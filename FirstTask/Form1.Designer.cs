using System.IO.Ports;

namespace FirstTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Get = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_CH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_flags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_DLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_period = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_ASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Set = new System.Windows.Forms.TabPage();
            this.DLC = new System.Windows.Forms.MaskedTextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trigger_com = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.set_bt = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RTR = new System.Windows.Forms.CheckBox();
            this.bit29 = new System.Windows.Forms.CheckBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Data1 = new System.Windows.Forms.TextBox();
            this.Data2 = new System.Windows.Forms.TextBox();
            this.Data3 = new System.Windows.Forms.TextBox();
            this.Data4 = new System.Windows.Forms.TextBox();
            this.Data5 = new System.Windows.Forms.TextBox();
            this.Data6 = new System.Windows.Forms.TextBox();
            this.Data7 = new System.Windows.Forms.TextBox();
            this.Data8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COMs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Get.SuspendLayout();
            this.tabPage_Set.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Get);
            this.tabControl1.Controls.Add(this.tabPage_Set);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1161, 489);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_Get
            // 
            this.tabPage_Get.Controls.Add(this.listView1);
            this.tabPage_Get.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Get.Name = "tabPage_Get";
            this.tabPage_Get.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Get.Size = new System.Drawing.Size(1153, 460);
            this.tabPage_Get.TabIndex = 0;
            this.tabPage_Get.Text = "Get Message";
            this.tabPage_Get.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_CH,
            this.column_flags,
            this.column_ID,
            this.column_DLC,
            this.column_data,
            this.column_period,
            this.column_counter,
            this.column_ASCII,
            this.column_comment});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1147, 454);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // column_CH
            // 
            this.column_CH.Text = "CH";
            this.column_CH.Width = 30;
            // 
            // column_flags
            // 
            this.column_flags.Text = "Флаги";
            this.column_flags.Width = 50;
            // 
            // column_ID
            // 
            this.column_ID.Text = "ID";
            // 
            // column_DLC
            // 
            this.column_DLC.Text = "DLC";
            this.column_DLC.Width = 40;
            // 
            // column_data
            // 
            this.column_data.Text = "Данные";
            this.column_data.Width = 119;
            // 
            // column_period
            // 
            this.column_period.Text = "Период";
            this.column_period.Width = 50;
            // 
            // column_counter
            // 
            this.column_counter.Text = "Счетчик";
            this.column_counter.Width = 55;
            // 
            // column_ASCII
            // 
            this.column_ASCII.Text = "ASCII";
            this.column_ASCII.Width = 84;
            // 
            // column_comment
            // 
            this.column_comment.Text = "Комментарий";
            this.column_comment.Width = 360;
            // 
            // tabPage_Set
            // 
            this.tabPage_Set.Controls.Add(this.DLC);
            this.tabPage_Set.Controls.Add(this.textBox17);
            this.tabPage_Set.Controls.Add(this.textBox18);
            this.tabPage_Set.Controls.Add(this.textBox19);
            this.tabPage_Set.Controls.Add(this.textBox20);
            this.tabPage_Set.Controls.Add(this.textBox21);
            this.tabPage_Set.Controls.Add(this.textBox22);
            this.tabPage_Set.Controls.Add(this.textBox23);
            this.tabPage_Set.Controls.Add(this.textBox24);
            this.tabPage_Set.Controls.Add(this.label13);
            this.tabPage_Set.Controls.Add(this.textBox16);
            this.tabPage_Set.Controls.Add(this.label12);
            this.tabPage_Set.Controls.Add(this.textBox15);
            this.tabPage_Set.Controls.Add(this.label11);
            this.tabPage_Set.Controls.Add(this.trigger_com);
            this.tabPage_Set.Controls.Add(this.label10);
            this.tabPage_Set.Controls.Add(this.textBox14);
            this.tabPage_Set.Controls.Add(this.label9);
            this.tabPage_Set.Controls.Add(this.comboBox2);
            this.tabPage_Set.Controls.Add(this.label8);
            this.tabPage_Set.Controls.Add(this.set_bt);
            this.tabPage_Set.Controls.Add(this.Value);
            this.tabPage_Set.Controls.Add(this.label7);
            this.tabPage_Set.Controls.Add(this.Period);
            this.tabPage_Set.Controls.Add(this.label6);
            this.tabPage_Set.Controls.Add(this.RTR);
            this.tabPage_Set.Controls.Add(this.bit29);
            this.tabPage_Set.Controls.Add(this.Comment);
            this.tabPage_Set.Controls.Add(this.label5);
            this.tabPage_Set.Controls.Add(this.Data1);
            this.tabPage_Set.Controls.Add(this.Data2);
            this.tabPage_Set.Controls.Add(this.Data3);
            this.tabPage_Set.Controls.Add(this.Data4);
            this.tabPage_Set.Controls.Add(this.Data5);
            this.tabPage_Set.Controls.Add(this.Data6);
            this.tabPage_Set.Controls.Add(this.Data7);
            this.tabPage_Set.Controls.Add(this.Data8);
            this.tabPage_Set.Controls.Add(this.label4);
            this.tabPage_Set.Controls.Add(this.label3);
            this.tabPage_Set.Controls.Add(this.ID);
            this.tabPage_Set.Controls.Add(this.label2);
            this.tabPage_Set.Controls.Add(this.COMs);
            this.tabPage_Set.Controls.Add(this.label1);
            this.tabPage_Set.Controls.Add(this.listView2);
            this.tabPage_Set.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Set.Name = "tabPage_Set";
            this.tabPage_Set.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Set.Size = new System.Drawing.Size(1153, 460);
            this.tabPage_Set.TabIndex = 1;
            this.tabPage_Set.Text = "Set Message";
            this.tabPage_Set.UseVisualStyleBackColor = true;
            // 
            // DLC
            // 
            this.DLC.Location = new System.Drawing.Point(212, 27);
            this.DLC.Mask = "0";
            this.DLC.Name = "DLC";
            this.DLC.Size = new System.Drawing.Size(30, 22);
            this.DLC.TabIndex = 54;
            this.DLC.Text = "8";
            this.DLC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DLC.TextChanged += new System.EventHandler(this.DLC_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(1039, 123);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(25, 22);
            this.textBox17.TabIndex = 53;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1015, 123);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(25, 22);
            this.textBox18.TabIndex = 52;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(991, 123);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(25, 22);
            this.textBox19.TabIndex = 51;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(967, 123);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(25, 22);
            this.textBox20.TabIndex = 50;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(943, 123);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(25, 22);
            this.textBox21.TabIndex = 49;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(919, 123);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(25, 22);
            this.textBox22.TabIndex = 48;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(895, 123);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(25, 22);
            this.textBox23.TabIndex = 47;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(871, 123);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(25, 22);
            this.textBox24.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(809, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Данные";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(732, 123);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(48, 22);
            this.textBox16.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "DLC";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(572, 123);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(69, 22);
            this.textBox15.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "ID";
            // 
            // trigger_com
            // 
            this.trigger_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trigger_com.FormattingEnabled = true;
            this.trigger_com.Location = new System.Drawing.Point(419, 122);
            this.trigger_com.Name = "trigger_com";
            this.trigger_com.Size = new System.Drawing.Size(88, 24);
            this.trigger_com.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Триггер CH";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(259, 124);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(49, 22);
            this.textBox14.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Задержка";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 24);
            this.comboBox2.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Действие";
            // 
            // set_bt
            // 
            this.set_bt.Location = new System.Drawing.Point(496, 54);
            this.set_bt.Name = "set_bt";
            this.set_bt.Size = new System.Drawing.Size(102, 33);
            this.set_bt.TabIndex = 34;
            this.set_bt.Text = "Заполнить";
            this.set_bt.UseVisualStyleBackColor = true;
            this.set_bt.Click += new System.EventHandler(this.SetMessageButton_click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(411, 57);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(33, 22);
            this.Value.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Значение";
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(259, 56);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(49, 22);
            this.Period.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Период (мс)";
            // 
            // RTR
            // 
            this.RTR.AutoSize = true;
            this.RTR.Location = new System.Drawing.Point(89, 57);
            this.RTR.Name = "RTR";
            this.RTR.Size = new System.Drawing.Size(58, 20);
            this.RTR.TabIndex = 29;
            this.RTR.Text = "RTR";
            this.RTR.UseVisualStyleBackColor = true;
            // 
            // bit29
            // 
            this.bit29.AutoSize = true;
            this.bit29.Location = new System.Drawing.Point(10, 57);
            this.bit29.Name = "bit29";
            this.bit29.Size = new System.Drawing.Size(60, 20);
            this.bit29.TabIndex = 28;
            this.bit29.Text = "29 bit";
            this.bit29.UseVisualStyleBackColor = true;
            this.bit29.CheckedChanged += new System.EventHandler(this.bit29_CheckedChanged);
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(463, 27);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(680, 22);
            this.Comment.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Комментарий";
            // 
            // Data1
            // 
            this.Data1.Location = new System.Drawing.Point(426, 27);
            this.Data1.MaxLength = 2;
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(25, 22);
            this.Data1.TabIndex = 25;
            this.Data1.Text = "00";
            this.Data1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data1.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data2
            // 
            this.Data2.Location = new System.Drawing.Point(401, 27);
            this.Data2.MaxLength = 2;
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(25, 22);
            this.Data2.TabIndex = 24;
            this.Data2.Text = "00";
            this.Data2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data2.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data3
            // 
            this.Data3.Location = new System.Drawing.Point(376, 27);
            this.Data3.MaxLength = 2;
            this.Data3.Name = "Data3";
            this.Data3.Size = new System.Drawing.Size(25, 22);
            this.Data3.TabIndex = 23;
            this.Data3.Text = "00";
            this.Data3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data3.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data4
            // 
            this.Data4.Location = new System.Drawing.Point(351, 27);
            this.Data4.MaxLength = 2;
            this.Data4.Name = "Data4";
            this.Data4.Size = new System.Drawing.Size(25, 22);
            this.Data4.TabIndex = 22;
            this.Data4.Text = "00";
            this.Data4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data4.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data5
            // 
            this.Data5.Location = new System.Drawing.Point(326, 27);
            this.Data5.MaxLength = 2;
            this.Data5.Name = "Data5";
            this.Data5.Size = new System.Drawing.Size(25, 22);
            this.Data5.TabIndex = 21;
            this.Data5.Text = "00";
            this.Data5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data5.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data6
            // 
            this.Data6.Location = new System.Drawing.Point(301, 27);
            this.Data6.MaxLength = 2;
            this.Data6.Name = "Data6";
            this.Data6.Size = new System.Drawing.Size(25, 22);
            this.Data6.TabIndex = 20;
            this.Data6.Text = "00";
            this.Data6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data6.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data7
            // 
            this.Data7.Location = new System.Drawing.Point(276, 27);
            this.Data7.MaxLength = 2;
            this.Data7.Name = "Data7";
            this.Data7.Size = new System.Drawing.Size(25, 22);
            this.Data7.TabIndex = 19;
            this.Data7.Text = "00";
            this.Data7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data7.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // Data8
            // 
            this.Data8.Location = new System.Drawing.Point(251, 27);
            this.Data8.MaxLength = 2;
            this.Data8.Name = "Data8";
            this.Data8.Size = new System.Drawing.Size(25, 22);
            this.Data8.TabIndex = 18;
            this.Data8.Text = "00";
            this.Data8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data8.TextChanged += new System.EventHandler(this.Data_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "DLC";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(91, 27);
            this.ID.MaxLength = 3;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(115, 22);
            this.ID.TabIndex = 14;
            this.ID.Text = "000";
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // COMs
            // 
            this.COMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMs.FormattingEnabled = true;
            this.COMs.Location = new System.Drawing.Point(10, 26);
            this.COMs.Name = "COMs";
            this.COMs.Size = new System.Drawing.Size(75, 24);
            this.COMs.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Канал";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 168);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1147, 289);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CH";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Флаги";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DLC";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Данные";
            this.columnHeader5.Width = 119;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Период";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Счетчик";
            this.columnHeader7.Width = 55;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ASCII";
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Комментарий";
            this.columnHeader9.Width = 360;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CAN";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Get.ResumeLayout(false);
            this.tabPage_Set.ResumeLayout(false);
            this.tabPage_Set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Get;
        private System.Windows.Forms.TabPage tabPage_Set;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_CH;
        private System.Windows.Forms.ColumnHeader column_flags;
        private System.Windows.Forms.ColumnHeader column_ID;
        private System.Windows.Forms.ColumnHeader column_DLC;
        private System.Windows.Forms.ColumnHeader column_data;
        private System.Windows.Forms.ColumnHeader column_period;
        private System.Windows.Forms.ColumnHeader column_counter;
        private System.Windows.Forms.ColumnHeader column_ASCII;
        private System.Windows.Forms.ColumnHeader column_comment;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Data8;
        private System.Windows.Forms.TextBox Data7;
        private System.Windows.Forms.Button set_bt;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Period;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox RTR;
        private System.Windows.Forms.CheckBox bit29;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Data1;
        private System.Windows.Forms.TextBox Data2;
        private System.Windows.Forms.TextBox Data3;
        private System.Windows.Forms.TextBox Data4;
        private System.Windows.Forms.TextBox Data5;
        private System.Windows.Forms.TextBox Data6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label11;
        private SerialPort serialPort1;
        private System.Windows.Forms.ComboBox trigger_com;
        private System.Windows.Forms.MaskedTextBox DLC;
    }
}

