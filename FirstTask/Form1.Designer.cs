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
            this.column_comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Set = new System.Windows.Forms.TabPage();
            this.DLC = new System.Windows.Forms.MaskedTextBox();
            this.set_bt = new System.Windows.Forms.Button();
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
            this.SetColumn_CH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetColumn_flags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetColumn_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetColumn_DLC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetColumn_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetColumn_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.column_comment});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1147, 454);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.column_ID.Width = 150;
            // 
            // column_DLC
            // 
            this.column_DLC.Text = "DLC";
            this.column_DLC.Width = 38;
            // 
            // column_data
            // 
            this.column_data.Text = "Данные";
            this.column_data.Width = 167;
            // 
            // column_comment
            // 
            this.column_comment.Text = "Комментарий";
            this.column_comment.Width = 314;
            // 
            // tabPage_Set
            // 
            this.tabPage_Set.Controls.Add(this.DLC);
            this.tabPage_Set.Controls.Add(this.set_bt);
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
            this.Data1.Location = new System.Drawing.Point(251, 27);
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
            this.Data2.Location = new System.Drawing.Point(276, 27);
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
            this.Data3.Location = new System.Drawing.Point(301, 27);
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
            this.Data4.Location = new System.Drawing.Point(326, 27);
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
            this.Data5.Location = new System.Drawing.Point(351, 27);
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
            this.Data6.Location = new System.Drawing.Point(376, 27);
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
            this.Data7.Location = new System.Drawing.Point(401, 27);
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
            this.Data8.Location = new System.Drawing.Point(426, 27);
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
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
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
            this.SetColumn_CH,
            this.SetColumn_flags,
            this.SetColumn_ID,
            this.SetColumn_DLC,
            this.SetColumn_Data,
            this.SetColumn_Comment});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 168);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1147, 289);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // SetColumn_CH
            // 
            this.SetColumn_CH.Text = "CH";
            this.SetColumn_CH.Width = 30;
            // 
            // SetColumn_flags
            // 
            this.SetColumn_flags.Text = "Флаги";
            this.SetColumn_flags.Width = 50;
            // 
            // SetColumn_ID
            // 
            this.SetColumn_ID.Text = "ID";
            this.SetColumn_ID.Width = 100;
            // 
            // SetColumn_DLC
            // 
            this.SetColumn_DLC.Text = "DLC";
            this.SetColumn_DLC.Width = 40;
            // 
            // SetColumn_Data
            // 
            this.SetColumn_Data.Text = "Данные";
            this.SetColumn_Data.Width = 150;
            // 
            // SetColumn_Comment
            // 
            this.SetColumn_Comment.Text = "Комментарий";
            this.SetColumn_Comment.Width = 360;
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
        private System.Windows.Forms.ColumnHeader column_comment;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader SetColumn_CH;
        private System.Windows.Forms.ColumnHeader SetColumn_flags;
        private System.Windows.Forms.ColumnHeader SetColumn_ID;
        private System.Windows.Forms.ColumnHeader SetColumn_DLC;
        private System.Windows.Forms.ColumnHeader SetColumn_Data;
        private System.Windows.Forms.ColumnHeader SetColumn_Comment;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Data8;
        private System.Windows.Forms.TextBox Data7;
        private System.Windows.Forms.Button set_bt;
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
        private SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox DLC;
    }
}

