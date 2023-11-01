using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hemophilia
{
    public class Form2 : Form
    {
        private IContainer components = null;

        private Label label1;

        private Label label2;

        private Label label3;

        private Label label4;

        private Label label5;

        private Label label6;

        private Label label7;

        private Label label8;

        private Label label9;

        private Label label10;

        private Label label11;

        private Label label12;

        private Label label13;

        private Label label14;

        private double Me1;

        private double Me2;

        private double Me3;

        private double Me4;

        private double Me5;

        private double Me6;

        private double Me7;

        private double Me8;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Form1 form = (Form1)base.Owner;
            if (form.checkBox1.Checked)                     // Если есть ресурсные ограничения
            {
                if (form.radioButton3.Checked)
                {
                    Me1 = 10;
                    Me2 = 20;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "1–2";
                }
                else if (form.radioButton4.Checked)
                {
                    Me1 = 10;
                    Me2 = 20;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "2–3";
                }
                else if (form.radioButton5.Checked && form.radioButton1.Checked)
                {
                    Me1 = 20;
                    Me2 = 40;
                    Me3 = 10;
                    Me4 = 20;
                    label4.Text = "1-2";
                    label6.Text = "3-5";
                }
                else if (form.radioButton5.Checked && form.radioButton2.Checked)
                {
                    Me1 = 15;
                    Me2 = 30;
                    Me3 = 10;
                    Me4 = 20;
                    label4.Text = "1-2";
                    label6.Text = "3-5";                //Глубокие мышцы
                }
                else if (form.radioButton6.Checked)
                {
                    Me1 = 50;
                    Me2 = 80;
                    Me3 = 20;
                    Me4 = 40;
                    Me5 = 30;
                    Me6 = 50;
                    label7.Visible = true;
                    label8.Visible = true;
                    label4.Text = "1–3";
                    label6.Text = "8–14";
                    label8.Text = "4–7";
                }
                else if (form.radioButton7.Checked)
                {
                    Me1 = 30;
                    Me2 = 50;
                    Me3 = 10;
                    Me4 = 20;
                    label4.Text = "1–3";
                    label6.Text = "4–7";
                }
                else if (form.radioButton8.Checked)
                {
                    Me1 = 30;
                    Me2 = 50;
                    Me3 = 10;
                    Me4 = 20;
                    label4.Text = "1–3";
                    label6.Text = "4–7";
                }
                else if (form.radioButton9.Checked && form.radioButton1.Checked)
                {
                    Me1 = 20;
                    Me2 = 40;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "3–5";
                }
                else if (form.radioButton9.Checked && form.radioButton2.Checked)
                {
                    Me1 = 15;
                    Me2 = 30;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "3–5";
                }
                else if (form.radioButton10.Checked && form.radioButton1.Checked)
                {
                    Me1 = 20;
                    Me2 = 40;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "5–7";
                }
                else if (form.radioButton10.Checked && form.radioButton2.Checked)
                {
                    Me1 = 15;
                    Me2 = 30;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "5–7";
                }
                else if (form.radioButton11.Checked && form.radioButton1.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 40;
                    Me5 = 20;
                    Me6 = 30;
                    Me7 = 10;
                    Me8 = 20;
                    label4.Visible = false;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-3";
                    label8.Text = "4-6";
                    label10.Text = "7-14";
                }
                else if (form.radioButton11.Checked && form.radioButton2.Checked)
                {
                    Me1 = 50;
                    Me2 = 70;
                    Me3 = 30;
                    Me4 = 40;
                    Me5 = 20;
                    Me6 = 30;
                    Me7 = 10;
                    Me8 = 20;
                    label4.Visible = false;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-3";
                    label8.Text = "4-6";
                    label10.Text = "7-14";
                }
                else if (form.radioButton12.Checked)
                {
                    Me1 = 40;
                    Me2 = 80;
                    Me3 = 20;
                    Me4 = 50;
                    label4.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-5";
                }
            }
            else                                    //Если нет ресурсных органичений
            {
                if (form.radioButton3.Checked)
                {
                    Me1 = 40;
                    Me2 = 60;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "1–2";
                }
                else if (form.radioButton4.Checked)
                {
                    Me1 = 40;
                    Me2 = 60;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "2–3";
                }
                else if (form.radioButton5.Checked && form.radioButton1.Checked)
                {
                    Me1 = 80;
                    Me2 = 100;
                    Me3 = 30;
                    Me4 = 60;
                    label4.Text = "1-2";
                    label6.Text = "3-5";
                }
                else if (form.radioButton5.Checked && form.radioButton2.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 60;
                    label4.Text = "1-2";
                    label6.Text = "3-5";                //Глубокие мышцы
                }
                else if (form.radioButton6.Checked && form.radioButton1.Checked)
                {
                    Me1 = 80;
                    Me2 = 100;
                    Me3 = 50;
                    Me4 = 50;
                    label4.Text = "1–7";
                    label6.Text = "8–21";
                }
                else if (form.radioButton6.Checked && form.radioButton2.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 30;
                    label4.Text = "1–7";
                    label6.Text = "8–21";
                }
                else if (form.radioButton7.Checked && form.radioButton1.Checked)
                {
                    Me1 = 80;
                    Me2 = 100;
                    Me3 = 50;
                    Me4 = 50;
                    label4.Text = "1–7";
                    label6.Text = "8–14";
                }
                else if (form.radioButton7.Checked && form.radioButton2.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 30;
                    label4.Text = "1–7";
                    label6.Text = "8–14";
                }
                else if (form.radioButton8.Checked && form.radioButton1.Checked)
                {
                    Me1 = 80;
                    Me2 = 100;
                    Me3 = 50;
                    Me4 = 50;
                    label6.Visible = false;
                    label4.Text = "7–14";
                }
                else if (form.radioButton8.Checked && form.radioButton2.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 30;
                    label6.Visible = false;
                    label4.Text = "7–14";
                }
                else if (form.radioButton9.Checked && form.radioButton1.Checked)
                {
                    Me1 = 50;
                    Me2 = 50;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "3–5";
                }
                else if (form.radioButton9.Checked && form.radioButton2.Checked)
                {
                    Me1 = 40;
                    Me2 = 40;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "3–5";
                }
                else if (form.radioButton10.Checked && form.radioButton1.Checked)
                {
                    Me1 = 50;
                    Me2 = 50;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "5–7";
                }
                else if (form.radioButton10.Checked && form.radioButton2.Checked)
                {
                    Me1 = 40;
                    Me2 = 40;
                    label5.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label4.Text = "5–7";
                }
                else if (form.radioButton11.Checked && form.radioButton1.Checked)
                {
                    Me1 = 80;
                    Me2 = 100;
                    Me3 = 60;
                    Me4 = 80;
                    Me5 = 40;
                    Me6 = 60;
                    Me7 = 30;
                    Me8 = 50;
                    label4.Visible = false;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-3";
                    label8.Text = "4-6";
                    label10.Text = "7-14";
                }
                else if (form.radioButton11.Checked && form.radioButton2.Checked)
                {
                    Me1 = 60;
                    Me2 = 80;
                    Me3 = 40;
                    Me4 = 60;
                    Me5 = 30;
                    Me6 = 50;
                    Me7 = 20;
                    Me8 = 40;
                    label4.Visible = false;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-3";
                    label8.Text = "4-6";
                    label10.Text = "7-14";
                }
                else if (form.radioButton12.Checked)
                {
                    Me1 = 50;
                    Me2 = 80;
                    Me3 = 30;
                    Me4 = 80;
                    label4.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = true;
                    label6.Text = "1-5";
                }
            }
            if (form.radioButton1.Checked)
            {
                label3.Text = Math.Round(form.M * (Me1 - form.P) * 0.5) + " — " + Math.Round(form.M * (Me2 - form.P) * 0.5);
                label5.Text = Math.Round(form.M * (Me3 - form.P) * 0.5) + " — " + Math.Round(form.M * (Me4 - form.P) * 0.5);
                label7.Text = Math.Round(form.M * (Me5 - form.P) * 0.5) + " — " + Math.Round(form.M * (Me6 - form.P) * 0.5);
                label9.Text = Math.Round(form.M * (Me7 - form.P) * 0.5) + " — " + Math.Round(form.M * (Me8 - form.P) * 0.5);
            }
            else if (form.radioButton2.Checked && !form.checkBox2.Checked)
            {
                label3.Text = Math.Round(form.M * (Me1 - form.P) / 0.8) + " — " + Math.Round(form.M * (Me2 - form.P) / 0.8);
                label5.Text = Math.Round(form.M * (Me3 - form.P) / 0.8) + " — " + Math.Round(form.M * (Me4 - form.P) / 0.8);
                label7.Text = Math.Round(form.M * (Me5 - form.P) / 0.8) + " — " + Math.Round(form.M * (Me6 - form.P) / 0.8);
                label9.Text = Math.Round(form.M * (Me7 - form.P) / 0.8) + " — " + Math.Round(form.M * (Me8 - form.P) / 0.8);
            }
            else if (form.radioButton2.Checked && form.checkBox2.Checked)
            {
                label3.Text = Math.Round(form.M * (Me1 - form.P) / 0.7) + " — " + Math.Round(form.M * (Me2 - form.P) / 0.7);
                label5.Text = Math.Round(form.M * (Me3 - form.P) / 0.7) + " — " + Math.Round(form.M * (Me4 - form.P) / 0.7);
                label7.Text = Math.Round(form.M * (Me5 - form.P) / 0.7) + " — " + Math.Round(form.M * (Me6 - form.P) / 0.7);
                label9.Text = Math.Round(form.M * (Me7 - form.P) / 0.7) + " — " + Math.Round(form.M * (Me8 - form.P) / 0.7);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доза фактора свертывания крови\r\nдля однократного введения (МЕ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Продолжительность (дней)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(245, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(536, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(245, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(536, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(245, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(536, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(245, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(536, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Начальная";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Поддержание";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "До операции";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "После операции";
            this.label14.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 195);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}