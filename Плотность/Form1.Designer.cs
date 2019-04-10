namespace Плотность
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDisp1 = new System.Windows.Forms.TextBox();
            this.textBoxt1 = new System.Windows.Forms.TextBox();
            this.textBoxDisp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Плотность при 20 Гр.С.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущая температура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Плотность при 20 Гр.С.";
            // 
            // textBoxDisp1
            // 
            this.textBoxDisp1.Location = new System.Drawing.Point(163, 50);
            this.textBoxDisp1.Name = "textBoxDisp1";
            this.textBoxDisp1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisp1.TabIndex = 1;
            this.textBoxDisp1.Text = "0,6500";
            // 
            // textBoxt1
            // 
            this.textBoxt1.Location = new System.Drawing.Point(163, 14);
            this.textBoxt1.Name = "textBoxt1";
            this.textBoxt1.Size = new System.Drawing.Size(100, 20);
            this.textBoxt1.TabIndex = 2;
            this.textBoxt1.Text = "20";
            // 
            // textBoxDisp
            // 
            this.textBoxDisp.Location = new System.Drawing.Point(163, 149);
            this.textBoxDisp.Name = "textBoxDisp";
            this.textBoxDisp.Size = new System.Drawing.Size(100, 20);
            this.textBoxDisp.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "( От 0,6500 до 1,0 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Расчетная температура";
            // 
            // textBoxt2
            // 
            this.textBoxt2.Location = new System.Drawing.Point(163, 123);
            this.textBoxt2.Name = "textBoxt2";
            this.textBoxt2.Size = new System.Drawing.Size(100, 20);
            this.textBoxt2.TabIndex = 4;
            this.textBoxt2.Text = "20";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxt2);
            this.Controls.Add(this.textBoxDisp);
            this.Controls.Add(this.textBoxt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDisp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(330, 200);
            this.Name = "Form1";
            this.Text = "Расчет плотности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDisp1;
        private System.Windows.Forms.TextBox textBoxt1;
        private System.Windows.Forms.TextBox textBoxDisp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxt2;
    }
}

