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
            this.textBox_MsgGet = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Get = new System.Windows.Forms.TabPage();
            this.label_Msg = new System.Windows.Forms.Label();
            this.tabPage_Set = new System.Windows.Forms.TabPage();
            this.button_setMsg = new System.Windows.Forms.Button();
            this.textBox_MsgSet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_COM = new System.Windows.Forms.Label();
            this.comboBox_COMs = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Get.SuspendLayout();
            this.tabPage_Set.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_MsgGet
            // 
            this.textBox_MsgGet.Location = new System.Drawing.Point(8, 31);
            this.textBox_MsgGet.Multiline = true;
            this.textBox_MsgGet.Name = "textBox_MsgGet";
            this.textBox_MsgGet.ReadOnly = true;
            this.textBox_MsgGet.Size = new System.Drawing.Size(450, 131);
            this.textBox_MsgGet.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Get);
            this.tabControl1.Controls.Add(this.tabPage_Set);
            this.tabControl1.Location = new System.Drawing.Point(0, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 260);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_Get
            // 
            this.tabPage_Get.Controls.Add(this.label_Msg);
            this.tabPage_Get.Controls.Add(this.textBox_MsgGet);
            this.tabPage_Get.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Get.Name = "tabPage_Get";
            this.tabPage_Get.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Get.Size = new System.Drawing.Size(628, 231);
            this.tabPage_Get.TabIndex = 0;
            this.tabPage_Get.Text = "Get Message";
            this.tabPage_Get.UseVisualStyleBackColor = true;
            // 
            // label_Msg
            // 
            this.label_Msg.AutoSize = true;
            this.label_Msg.Location = new System.Drawing.Point(5, 11);
            this.label_Msg.Name = "label_Msg";
            this.label_Msg.Size = new System.Drawing.Size(67, 16);
            this.label_Msg.TabIndex = 3;
            this.label_Msg.Text = "Message:";
            // 
            // tabPage_Set
            // 
            this.tabPage_Set.Controls.Add(this.button_setMsg);
            this.tabPage_Set.Controls.Add(this.textBox_MsgSet);
            this.tabPage_Set.Controls.Add(this.label2);
            this.tabPage_Set.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Set.Name = "tabPage_Set";
            this.tabPage_Set.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Set.Size = new System.Drawing.Size(628, 231);
            this.tabPage_Set.TabIndex = 1;
            this.tabPage_Set.Text = "Set Message";
            this.tabPage_Set.UseVisualStyleBackColor = true;
            // 
            // button_setMsg
            // 
            this.button_setMsg.Location = new System.Drawing.Point(464, 133);
            this.button_setMsg.Name = "button_setMsg";
            this.button_setMsg.Size = new System.Drawing.Size(75, 23);
            this.button_setMsg.TabIndex = 7;
            this.button_setMsg.Text = "Set MSG";
            this.button_setMsg.UseVisualStyleBackColor = true;
            this.button_setMsg.Click += new System.EventHandler(this.button_setMsg_Click);
            // 
            // textBox_MsgSet
            // 
            this.textBox_MsgSet.Location = new System.Drawing.Point(7, 26);
            this.textBox_MsgSet.Multiline = true;
            this.textBox_MsgSet.Name = "textBox_MsgSet";
            this.textBox_MsgSet.Size = new System.Drawing.Size(450, 131);
            this.textBox_MsgSet.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Location = new System.Drawing.Point(14, 17);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(40, 16);
            this.label_COM.TabIndex = 2;
            this.label_COM.Text = "COM:";
            // 
            // comboBox_COMs
            // 
            this.comboBox_COMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMs.FormattingEnabled = true;
            this.comboBox_COMs.Location = new System.Drawing.Point(60, 14);
            this.comboBox_COMs.Name = "comboBox_COMs";
            this.comboBox_COMs.Size = new System.Drawing.Size(84, 24);
            this.comboBox_COMs.TabIndex = 1;
            this.comboBox_COMs.SelectedIndexChanged += new System.EventHandler(this.comboBox_COMs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 340);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_COMs);
            this.Controls.Add(this.label_COM);
            this.MaximumSize = new System.Drawing.Size(652, 387);
            this.MinimumSize = new System.Drawing.Size(652, 387);
            this.Name = "Form1";
            this.Text = "CAN";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Get.ResumeLayout(false);
            this.tabPage_Get.PerformLayout();
            this.tabPage_Set.ResumeLayout(false);
            this.tabPage_Set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MsgGet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Get;
        private System.Windows.Forms.TabPage tabPage_Set;
        private System.Windows.Forms.ComboBox comboBox_COMs;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.Label label_Msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MsgSet;
        private System.Windows.Forms.Button button_setMsg;
    }
}

