using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hemophilia
{
	public class Form1 : Form
	{
		public double M;

		public double P;

		public double x;

		public double x1;

		public double x2;

		public double x3;

		public double z;

		public double z1;

		public double z2;

		public double z3;

		public int L;

		public int L1;

		public int L2;

		public int L3;

		public int K;

		public int K1;

		public int K2;

		public int K3;

		private IContainer components = null;

		private Label label1;

		private Label label4;

		private RadioButton radioButton1;

		private GroupBox groupBox1;

		private RadioButton radioButton2;

		private Label label5;

		private GroupBox groupBox2;

		public RadioButton radioButton12;

		public RadioButton radioButton11;

		public RadioButton radioButton10;

		public RadioButton radioButton9;

		public RadioButton radioButton8;

		public RadioButton radioButton7;

		public RadioButton radioButton6;

		public RadioButton radioButton5;

		public RadioButton radioButton4;

		public RadioButton radioButton3;

		private ToolTip toolTip1;

		private TextBox textBox1;

		private TextBox textBox2;

		public CheckBox checkBox1;

		private Button button1;

		private CheckBox checkBox2;

		public Form1()
		{
			InitializeComponent();
			radioButton1.Checked = true;
			radioButton3.Checked = true;
			checkBox1.Checked = true;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char keyChar = e.KeyChar;
			if (keyChar == ',' && textBox1.Text.IndexOf(',') != -1)
			{
				e.Handled = true;
			}
			else if (!char.IsDigit(keyChar) && keyChar != '\b' && keyChar != ',')
			{
				e.Handled = true;
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ',' || ((TextBox)sender).Text.IndexOf(",") != -1 || ((TextBox)sender).Text.Length == 8) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void RadioButtons_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				checkBox2.Visible = false;
			}
			else
			{
				checkBox2.Visible = true;
			}
			int num = groupBox2.Controls.IndexOf(groupBox2.Controls.OfType<RadioButton>().FirstOrDefault((RadioButton r) => r.Checked));
			if (checkBox1.Checked && radioButton1.Checked)
			{
				switch (num)
				{
				case 0:
					L = 40;
					K = 80;
					L1 = 20;
					K1 = 50;
					break;
				case 1:
					L = 60;
					K = 80;
					L1 = 30;
					K1 = 40;
					L2 = 20;
					K2 = 30;
					L3 = 10;
					K3 = 20;
					break;
				case 2:
					L = 20;
					K = 40;
					break;
				case 3:
					L = 20;
					K = 40;
					break;
				case 4:
					L = 30;
					K = 50;
					L1 = 10;
					K1 = 20;
					break;
				case 5:
					L = 30;
					K = 50;
					L1 = 10;
					K1 = 20;
					break;
				case 6:
					L = 50;
					K = 80;
					L1 = 30;
					K1 = 50;
					L2 = 20;
					K2 = 40;
					break;
				case 7:
					L = 20;
					K = 40;
					L1 = 10;
					K1 = 20;
					break;
				case 8:
					L = 10;
					K = 20;
					break;
				case 9:
					L = 10;
					K = 20;
					break;
				}
			}
			else if (!checkBox1.Checked && radioButton1.Checked)
			{
				switch (num)
				{
				case 0:
					L = 50;
					K = 80;
					L1 = 30;
					K1 = 80;
					break;
				case 1:
					L = 80;
					K = 100;
					L1 = 60;
					K1 = 80;
					L2 = 40;
					K2 = 60;
					L3 = 30;
					K3 = 50;
					break;
				case 2:
					L = 50;
					break;
				case 3:
					L = 50;
					break;
				case 4:
					L = 80;
					K = 100;
					L1 = 50;
					break;
				case 5:
					L = 80;
					K = 100;
					L1 = 50;
					break;
				case 6:
					L = 80;
					K = 100;
					L1 = 50;
					break;
				case 7:
					L = 80;
					K = 100;
					L1 = 30;
					K1 = 60;
					break;
				case 8:
					L = 40;
					K = 60;
					break;
				case 9:
					L = 40;
					K = 60;
					break;
				}
			}
			if (checkBox1.Checked && radioButton2.Checked)
			{
				switch (num)
				{
				case 0:
					L = 40;
					K = 80;
					L1 = 20;
					K1 = 50;
					break;
				case 1:
					L = 50;
					K = 70;
					L1 = 30;
					K1 = 40;
					L2 = 20;
					K2 = 30;
					L3 = 10;
					K3 = 20;
					break;
				case 2:
					L = 15;
					K = 30;
					break;
				case 3:
					L = 15;
					K = 30;
					break;
				case 4:
					L = 30;
					K = 50;
					L1 = 10;
					K1 = 20;
					break;
				case 5:
					L = 30;
					K = 50;
					L1 = 10;
					K1 = 20;
					break;
				case 6:
					L = 50;
					K = 80;
					L1 = 30;
					K1 = 50;
					L2 = 20;
					K2 = 40;
					break;
				case 7:
					L = 15;
					K = 30;
					L1 = 10;
					K1 = 20;
					break;
				case 8:
					L = 10;
					K = 20;
					break;
				case 9:
					L = 10;
					K = 20;
					break;
				}
			}
			else if (!checkBox1.Checked && radioButton2.Checked)
			{
				switch (num)
				{
				case 0:
					L = 50;
					K = 80;
					L1 = 30;
					K1 = 80;
					break;
				case 1:
					L = 60;
					K = 80;
					L1 = 40;
					K1 = 60;
					L2 = 30;
					K2 = 50;
					L3 = 20;
					K3 = 40;
					break;
				case 2:
					L = 40;
					break;
				case 3:
					L = 40;
					break;
				case 4:
					L = 60;
					K = 80;
					L1 = 30;
					break;
				case 5:
					L = 60;
					K = 80;
					L1 = 30;
					break;
				case 6:
					L = 60;
					K = 80;
					L1 = 30;
					break;
				case 7:
					L = 60;
					K = 80;
					L1 = 30;
					K1 = 60;
					break;
				case 8:
					L = 40;
					K = 60;
					break;
				case 9:
					L = 40;
					K = 60;
					break;
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(textBox1.Text, out P))
			{
				P = 0.0;
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(textBox2.Text, out M))
			{
				M = 0.0;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!(textBox1.Text != string.Empty) || !(textBox2.Text != string.Empty))
			{
				MessageBox.Show("Заполните данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!(textBox1.Text != "0") || !(textBox2.Text != "0"))
			{
				MessageBox.Show("Данные заполнены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (radioButton1.Checked)
			{
				x = M * ((double)L - P) * 0.5;
				z = M * ((double)K - P) * 0.5;
				x1 = M * ((double)L1 - P) * 0.5;
				z1 = M * ((double)K1 - P) * 0.5;
				x2 = M * ((double)L2 - P) * 0.5;
				z2 = M * ((double)K2 - P) * 0.5;
				x3 = M * ((double)L3 - P) * 0.5;
				z3 = M * ((double)K3 - P) * 0.5;
			}
			if (radioButton2.Checked && !checkBox2.Checked)
			{
				x = M * ((double)L - P) * 1.25;
				z = M * ((double)K - P) * 1.25;
				x1 = M * ((double)L1 - P) * 1.25;
				z1 = M * ((double)K1 - P) * 1.25;
				x2 = M * ((double)L2 - P) * 1.25;
				z2 = M * ((double)K2 - P) * 1.25;
				x3 = M * ((double)L3 - P) * 1.25;
				z3 = M * ((double)K3 - P) * 1.25;
			}
			else if (radioButton2.Checked && checkBox2.Checked)
			{
				x = M * ((double)L - P) * 1.43;
				z = M * ((double)K - P) * 1.43;
				x1 = M * ((double)L1 - P) * 1.43;
				z1 = M * ((double)K1 - P) * 1.43;
				x2 = M * ((double)L2 - P) * 1.43;
				z2 = M * ((double)K2 - P) * 1.25;
				x3 = M * ((double)L3 - P) * 1.43;
				z3 = M * ((double)K3 - P) * 1.43;
			}
			Form2 form = new Form2();
			form.Owner = this;
			Hide();
			form.ShowDialog();
			Show();
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hemophilia.Form1));
			label1 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			radioButton1 = new System.Windows.Forms.RadioButton();
			groupBox1 = new System.Windows.Forms.GroupBox();
			radioButton2 = new System.Windows.Forms.RadioButton();
			label5 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			radioButton12 = new System.Windows.Forms.RadioButton();
			radioButton11 = new System.Windows.Forms.RadioButton();
			radioButton10 = new System.Windows.Forms.RadioButton();
			radioButton9 = new System.Windows.Forms.RadioButton();
			radioButton8 = new System.Windows.Forms.RadioButton();
			radioButton7 = new System.Windows.Forms.RadioButton();
			radioButton6 = new System.Windows.Forms.RadioButton();
			radioButton5 = new System.Windows.Forms.RadioButton();
			radioButton4 = new System.Windows.Forms.RadioButton();
			radioButton3 = new System.Windows.Forms.RadioButton();
			toolTip1 = new System.Windows.Forms.ToolTip(components);
			textBox1 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			checkBox1 = new System.Windows.Forms.CheckBox();
			button1 = new System.Windows.Forms.Button();
			checkBox2 = new System.Windows.Forms.CheckBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label1.Location = new System.Drawing.Point(255, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(141, 29);
			label1.TabIndex = 1;
			label1.Text = "Расчет доз";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label4.Location = new System.Drawing.Point(260, 104);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(62, 18);
			label4.TabIndex = 4;
			label4.Text = "Вес (кг)";
			radioButton1.AutoSize = true;
			radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton1.Location = new System.Drawing.Point(7, 23);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new System.Drawing.Size(122, 22);
			radioButton1.TabIndex = 7;
			radioButton1.TabStop = true;
			radioButton1.Text = "Гемофилия A";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			groupBox1.Location = new System.Drawing.Point(7, 42);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(247, 82);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Выберите тип Гемофилии";
			radioButton2.AutoSize = true;
			radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton2.Location = new System.Drawing.Point(6, 53);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new System.Drawing.Size(123, 22);
			radioButton2.TabIndex = 8;
			radioButton2.TabStop = true;
			radioButton2.Text = "Гемофилия B";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			label5.Location = new System.Drawing.Point(260, 51);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(308, 36);
			label5.TabIndex = 9;
			label5.Text = "Исходный уровень фактора плазмы крови\r\n(до введения препарата) %";
			groupBox2.Controls.Add(radioButton12);
			groupBox2.Controls.Add(radioButton11);
			groupBox2.Controls.Add(radioButton10);
			groupBox2.Controls.Add(radioButton9);
			groupBox2.Controls.Add(radioButton8);
			groupBox2.Controls.Add(radioButton7);
			groupBox2.Controls.Add(radioButton6);
			groupBox2.Controls.Add(radioButton5);
			groupBox2.Controls.Add(radioButton4);
			groupBox2.Controls.Add(radioButton3);
			groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			groupBox2.Location = new System.Drawing.Point(7, 130);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(622, 166);
			groupBox2.TabIndex = 18;
			groupBox2.TabStop = false;
			groupBox2.Text = "Выберите тип кровотечения";
			radioButton12.AutoSize = true;
			radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton12.Location = new System.Drawing.Point(363, 137);
			radioButton12.Name = "radioButton12";
			radioButton12.Size = new System.Drawing.Size(253, 22);
			radioButton12.TabIndex = 16;
			radioButton12.TabStop = true;
			radioButton12.Text = "Мелкая хирургическая операция";
			radioButton12.UseVisualStyleBackColor = true;
			radioButton12.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton11.AutoSize = true;
			radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton11.Location = new System.Drawing.Point(363, 109);
			radioButton11.Name = "radioButton11";
			radioButton11.Size = new System.Drawing.Size(256, 22);
			radioButton11.TabIndex = 15;
			radioButton11.TabStop = true;
			radioButton11.Text = "Крупная хирургическая операция";
			radioButton11.UseVisualStyleBackColor = true;
			radioButton11.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton10.AutoSize = true;
			radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton10.Location = new System.Drawing.Point(363, 81);
			radioButton10.Name = "radioButton10";
			radioButton10.Size = new System.Drawing.Size(154, 22);
			radioButton10.TabIndex = 14;
			radioButton10.TabStop = true;
			radioButton10.Text = "Глубокая ссадина";
			radioButton10.UseVisualStyleBackColor = true;
			radioButton10.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton9.AutoSize = true;
			radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton9.Location = new System.Drawing.Point(363, 53);
			radioButton9.Name = "radioButton9";
			radioButton9.Size = new System.Drawing.Size(95, 22);
			radioButton9.TabIndex = 13;
			radioButton9.TabStop = true;
			radioButton9.Text = "Почечное";
			radioButton9.UseVisualStyleBackColor = true;
			radioButton9.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton8.AutoSize = true;
			radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton8.Location = new System.Drawing.Point(363, 25);
			radioButton8.Name = "radioButton8";
			radioButton8.Size = new System.Drawing.Size(180, 22);
			radioButton8.TabIndex = 12;
			radioButton8.TabStop = true;
			radioButton8.Text = "Желудочно-кишечное";
			radioButton8.UseVisualStyleBackColor = true;
			radioButton8.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton7.AutoSize = true;
			radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton7.Location = new System.Drawing.Point(7, 137);
			radioButton7.Name = "radioButton7";
			radioButton7.Size = new System.Drawing.Size(113, 22);
			radioButton7.TabIndex = 11;
			radioButton7.TabStop = true;
			radioButton7.Text = "Горло и шея";
			radioButton7.UseVisualStyleBackColor = true;
			radioButton7.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton6.AutoSize = true;
			radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton6.Location = new System.Drawing.Point(7, 109);
			radioButton6.Name = "radioButton6";
			radioButton6.Size = new System.Drawing.Size(112, 22);
			radioButton6.TabIndex = 10;
			radioButton6.TabStop = true;
			radioButton6.Text = "ЦНС/голова";
			radioButton6.UseVisualStyleBackColor = true;
			radioButton6.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton5.AutoSize = true;
			radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton5.Location = new System.Drawing.Point(7, 81);
			radioButton5.Name = "radioButton5";
			radioButton5.Size = new System.Drawing.Size(344, 22);
			radioButton5.TabIndex = 9;
			radioButton5.TabStop = true;
			radioButton5.Text = "Повздошно-поясничная или глубокая мышца";
			toolTip1.SetToolTip(radioButton5, "с повреждением сосудисто-нервного пучка или значительными потерями крови");
			radioButton5.UseVisualStyleBackColor = true;
			radioButton5.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton4.AutoSize = true;
			radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton4.Location = new System.Drawing.Point(7, 53);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new System.Drawing.Size(162, 22);
			radioButton4.TabIndex = 8;
			radioButton4.TabStop = true;
			radioButton4.Text = "Неглубокая мышца";
			toolTip1.SetToolTip(radioButton4, "без повреждения сосудисто-нервного пучка (за исключением повздошно-поясничных мышц)");
			radioButton4.UseVisualStyleBackColor = true;
			radioButton4.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			radioButton3.AutoSize = true;
			radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			radioButton3.Location = new System.Drawing.Point(7, 25);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new System.Drawing.Size(75, 22);
			radioButton3.TabIndex = 7;
			radioButton3.TabStop = true;
			radioButton3.Text = "Сустав";
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			toolTip1.AutoPopDelay = 5000;
			toolTip1.InitialDelay = 1;
			toolTip1.ReshowDelay = 100;
			toolTip1.ShowAlways = true;
			textBox1.Location = new System.Drawing.Point(585, 59);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(38, 20);
			textBox1.TabIndex = 19;
			textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
			textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox1_KeyPress);
			textBox2.Location = new System.Drawing.Point(585, 103);
			textBox2.Name = "textBox2";
			textBox2.Size = new System.Drawing.Size(38, 20);
			textBox2.TabIndex = 20;
			textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
			textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(textBox2_KeyPress);
			checkBox1.AutoSize = true;
			checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			checkBox1.Location = new System.Drawing.Point(7, 302);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(334, 19);
			checkBox1.TabIndex = 21;
			checkBox1.Text = "ЗНАЧИТЕЛЬНЫЕ РЕСУРСНЫЕ ОГРАНИЧЕНИЯ";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += new System.EventHandler(RadioButtons_CheckedChanged);
			button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			button1.Location = new System.Drawing.Point(403, 302);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(189, 44);
			button1.TabIndex = 23;
			button1.Text = "Рассчитать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			checkBox2.AutoSize = true;
			checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
			checkBox2.Location = new System.Drawing.Point(7, 327);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(91, 19);
			checkBox2.TabIndex = 24;
			checkBox2.Text = "РЕБЁНОК";
			checkBox2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			base.ClientSize = new System.Drawing.Size(635, 349);
			base.Controls.Add(checkBox2);
			base.Controls.Add(button1);
			base.Controls.Add(checkBox1);
			base.Controls.Add(textBox2);
			base.Controls.Add(textBox1);
			base.Controls.Add(groupBox2);
			base.Controls.Add(label5);
			base.Controls.Add(groupBox1);
			base.Controls.Add(label4);
			base.Controls.Add(label1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			Text = "Гемофилия";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
