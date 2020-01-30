using System;
using System.ComponentModel;
using System.Drawing;
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

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Form1 form = (Form1)base.Owner;
			label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
			label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
			label7.Text = Math.Round(form.x2) + " — " + Math.Round(form.z2);
			label9.Text = Math.Round(form.x3) + " — " + Math.Round(form.z3);
			if (form.radioButton3.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Visible = false;
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1–2";
				label6.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton4.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Visible = false;
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "2–3";
				label6.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton5.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1-2";
				label6.Text = "3-5";
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton6.Checked && !form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1–7";
				label6.Text = "8–21";
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton6.Checked && form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Text = Math.Round(form.x2) + " — " + Math.Round(form.z2);
				label9.Visible = false;
				label4.Text = "1–3";
				label6.Text = "4–7";
				label8.Text = "8–14";
				label10.Visible = false;
			}
			else if (form.radioButton7.Checked && !form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1–7";
				label6.Text = "8–14";
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton7.Checked && form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1–3";
				label6.Text = "4–7";
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton8.Checked && !form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "7–14";
				label6.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton8.Checked && form.checkBox1.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "1–3";
				label6.Text = "4–7";
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton9.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Visible = false;
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "3-5";
				label6.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton10.Checked)
			{
				label13.Visible = false;
				label14.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Visible = false;
				label7.Visible = false;
				label9.Visible = false;
				label4.Text = "5-7";
				label6.Visible = false;
				label8.Visible = false;
				label10.Visible = false;
			}
			else if (form.radioButton11.Checked)
			{
				label11.Visible = false;
				label12.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Text = Math.Round(form.x2) + " — " + Math.Round(form.z2);
				label9.Text = Math.Round(form.x3) + " — " + Math.Round(form.z3);
				label4.Visible = false;
				label6.Text = "1-3";
				label8.Text = "4-6";
				label10.Text = "7-14";
			}
			else if (form.radioButton12.Checked)
			{
				label11.Visible = false;
				label12.Visible = false;
				label3.Text = Math.Round(form.x) + " — " + Math.Round(form.z);
				label5.Text = Math.Round(form.x1) + " — " + Math.Round(form.z1);
				label7.Visible = false;
				label9.Visible = false;
				label4.Visible = false;
				label6.Text = "1-5";
				label8.Visible = false;
				label10.Visible = false;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hemophilia.Form2));
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label1.Location = new System.Drawing.Point(138, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(301, 40);
			label1.TabIndex = 0;
			label1.Text = "Доза фактора свертывания крови\r\nдля однократного введения (МЕ)";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label2.Location = new System.Drawing.Point(454, 20);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(246, 20);
			label2.TabIndex = 1;
			label2.Text = "Продолжительность (дней)";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label3.Location = new System.Drawing.Point(245, 59);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(76, 25);
			label3.TabIndex = 2;
			label3.Text = "label3";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label4.Location = new System.Drawing.Point(536, 59);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(76, 25);
			label4.TabIndex = 3;
			label4.Text = "label4";
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label5.Location = new System.Drawing.Point(245, 93);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(76, 25);
			label5.TabIndex = 4;
			label5.Text = "label5";
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label6.Location = new System.Drawing.Point(536, 93);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(76, 25);
			label6.TabIndex = 5;
			label6.Text = "label6";
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label7.Location = new System.Drawing.Point(245, 127);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(76, 25);
			label7.TabIndex = 6;
			label7.Text = "label7";
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label8.Location = new System.Drawing.Point(536, 127);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(76, 25);
			label8.TabIndex = 7;
			label8.Text = "label8";
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label9.Location = new System.Drawing.Point(245, 161);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(76, 25);
			label9.TabIndex = 8;
			label9.Text = "label9";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label10.Location = new System.Drawing.Point(536, 161);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(89, 25);
			label10.TabIndex = 9;
			label10.Text = "label10";
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label11.Location = new System.Drawing.Point(12, 59);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(103, 20);
			label11.TabIndex = 10;
			label11.Text = "Начальная";
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label12.Location = new System.Drawing.Point(12, 93);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(128, 20);
			label12.TabIndex = 11;
			label12.Text = "Поддержание";
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label13.Location = new System.Drawing.Point(12, 59);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(117, 20);
			label13.TabIndex = 12;
			label13.Text = "До операции";
			label14.AutoSize = true;
			label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			label14.Location = new System.Drawing.Point(12, 93);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(147, 20);
			label14.TabIndex = 13;
			label14.Text = "После операции";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(702, 195);
			base.Controls.Add(label14);
			base.Controls.Add(label13);
			base.Controls.Add(label12);
			base.Controls.Add(label11);
			base.Controls.Add(label10);
			base.Controls.Add(label9);
			base.Controls.Add(label8);
			base.Controls.Add(label7);
			base.Controls.Add(label6);
			base.Controls.Add(label5);
			base.Controls.Add(label4);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form2";
			Text = "Результат";
			base.Load += new System.EventHandler(Form2_Load);
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
