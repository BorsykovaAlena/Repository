namespace Interface
{
    partial class ElementControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResistorButton = new System.Windows.Forms.RadioButton();
            this.IndykziaButton = new System.Windows.Forms.RadioButton();
            this.KondensatorButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResistorButton
            // 
            this.ResistorButton.AutoSize = true;
            this.ResistorButton.Location = new System.Drawing.Point(24, 40);
            this.ResistorButton.Name = "ResistorButton";
            this.ResistorButton.Size = new System.Drawing.Size(73, 17);
            this.ResistorButton.TabIndex = 0;
            this.ResistorButton.TabStop = true;
            this.ResistorButton.Text = "Резистор";
            this.ResistorButton.UseVisualStyleBackColor = true;
            this.ResistorButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // IndykziaButton
            // 
            this.IndykziaButton.AutoSize = true;
            this.IndykziaButton.Location = new System.Drawing.Point(24, 63);
            this.IndykziaButton.Name = "IndykziaButton";
            this.IndykziaButton.Size = new System.Drawing.Size(74, 17);
            this.IndykziaButton.TabIndex = 1;
            this.IndykziaButton.TabStop = true;
            this.IndykziaButton.Text = "Индукция";
            this.IndykziaButton.UseVisualStyleBackColor = true;
            this.IndykziaButton.CheckedChanged += new System.EventHandler(this.IndykziaButton_CheckedChanged);
            // 
            // KondensatorButton
            // 
            this.KondensatorButton.AutoSize = true;
            this.KondensatorButton.Location = new System.Drawing.Point(24, 86);
            this.KondensatorButton.Name = "KondensatorButton";
            this.KondensatorButton.Size = new System.Drawing.Size(91, 17);
            this.KondensatorButton.TabIndex = 2;
            this.KondensatorButton.TabStop = true;
            this.KondensatorButton.Text = "Конденсатор";
            this.KondensatorButton.UseVisualStyleBackColor = true;
            this.KondensatorButton.CheckedChanged += new System.EventHandler(this.KondensatorButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 321);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Резистор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сопротивление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Индукция";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Индуктивность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Конденсатор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Электроёмкость";
            // 
            // ElementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KondensatorButton);
            this.Controls.Add(this.IndykziaButton);
            this.Controls.Add(this.ResistorButton);
            this.Name = "ElementControl";
            this.Size = new System.Drawing.Size(594, 590);
            this.Load += new System.EventHandler(this.ElementControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ResistorButton;
        private System.Windows.Forms.RadioButton IndykziaButton;
        private System.Windows.Forms.RadioButton KondensatorButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
