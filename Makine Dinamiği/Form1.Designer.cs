namespace Makine_Dinamiği
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnMekanizmayi_Calistir = new Button();
            btnMekanizmayi_Durdur = new Button();
            btnMekanizmayi_Belli_Bir_Acida_Calistir = new Button();
            label1 = new Label();
            txtTahrikAcisi = new TextBox();
            groupBox1 = new GroupBox();
            txtR4_θ = new TextBox();
            txtR3_θ = new TextBox();
            txtR2_θ = new TextBox();
            txtR1_θ = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtR4_L = new TextBox();
            label5 = new Label();
            txtR3_L = new TextBox();
            label4 = new Label();
            txtR2_L = new TextBox();
            label3 = new Label();
            txtR1_L = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtDy = new TextBox();
            txtCy = new TextBox();
            txtBy = new TextBox();
            txtAy = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtDx = new TextBox();
            label10 = new Label();
            txtCx = new TextBox();
            label11 = new Label();
            txtBx = new TextBox();
            label12 = new Label();
            txtAx = new TextBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Desktop;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1089, 758);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // btnMekanizmayi_Calistir
            // 
            btnMekanizmayi_Calistir.BackColor = Color.Aqua;
            btnMekanizmayi_Calistir.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMekanizmayi_Calistir.Location = new Point(1107, 12);
            btnMekanizmayi_Calistir.Name = "btnMekanizmayi_Calistir";
            btnMekanizmayi_Calistir.Size = new Size(256, 75);
            btnMekanizmayi_Calistir.TabIndex = 1;
            btnMekanizmayi_Calistir.Text = "Mekanizmayı Çalıştır";
            btnMekanizmayi_Calistir.UseVisualStyleBackColor = false;
            btnMekanizmayi_Calistir.Click += btnMekanizmayi_Calistir_Click;
            // 
            // btnMekanizmayi_Durdur
            // 
            btnMekanizmayi_Durdur.BackColor = Color.Olive;
            btnMekanizmayi_Durdur.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMekanizmayi_Durdur.Location = new Point(1369, 12);
            btnMekanizmayi_Durdur.Name = "btnMekanizmayi_Durdur";
            btnMekanizmayi_Durdur.Size = new Size(256, 75);
            btnMekanizmayi_Durdur.TabIndex = 2;
            btnMekanizmayi_Durdur.Text = "Mekanizmayı Durdur\r\n";
            btnMekanizmayi_Durdur.UseVisualStyleBackColor = false;
            btnMekanizmayi_Durdur.Click += btnMekanizmayi_Durdur_Click;
            // 
            // btnMekanizmayi_Belli_Bir_Acida_Calistir
            // 
            btnMekanizmayi_Belli_Bir_Acida_Calistir.BackColor = Color.PaleTurquoise;
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Location = new Point(1107, 93);
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Name = "btnMekanizmayi_Belli_Bir_Acida_Calistir";
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Size = new Size(256, 75);
            btnMekanizmayi_Belli_Bir_Acida_Calistir.TabIndex = 3;
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Text = "Mekanizmayı Ayarla";
            btnMekanizmayi_Belli_Bir_Acida_Calistir.UseVisualStyleBackColor = false;
            btnMekanizmayi_Belli_Bir_Acida_Calistir.Click += btnMekanizmayi_Belli_Bir_Acida_Calistir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(156, 33);
            label1.TabIndex = 4;
            label1.Text = "Motor Açısı:";
            // 
            // txtTahrikAcisi
            // 
            txtTahrikAcisi.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTahrikAcisi.Location = new Point(168, 26);
            txtTahrikAcisi.Name = "txtTahrikAcisi";
            txtTahrikAcisi.Size = new Size(94, 34);
            txtTahrikAcisi.TabIndex = 5;
            txtTahrikAcisi.Text = "90";
            txtTahrikAcisi.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtR4_θ);
            groupBox1.Controls.Add(txtR3_θ);
            groupBox1.Controls.Add(txtR2_θ);
            groupBox1.Controls.Add(txtR1_θ);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtR4_L);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtR3_L);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtR2_L);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtR1_L);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(1111, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 243);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vektörel Konum Tablosu";
            // 
            // txtR4_θ
            // 
            txtR4_θ.Location = new Point(372, 169);
            txtR4_θ.Name = "txtR4_θ";
            txtR4_θ.Size = new Size(200, 34);
            txtR4_θ.TabIndex = 13;
            // 
            // txtR3_θ
            // 
            txtR3_θ.Location = new Point(372, 133);
            txtR3_θ.Name = "txtR3_θ";
            txtR3_θ.Size = new Size(200, 34);
            txtR3_θ.TabIndex = 12;
            // 
            // txtR2_θ
            // 
            txtR2_θ.Location = new Point(372, 97);
            txtR2_θ.Name = "txtR2_θ";
            txtR2_θ.Size = new Size(200, 34);
            txtR2_θ.TabIndex = 11;
            // 
            // txtR1_θ
            // 
            txtR1_θ.Location = new Point(372, 61);
            txtR1_θ.Name = "txtR1_θ";
            txtR1_θ.Size = new Size(200, 34);
            txtR1_θ.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(391, 26);
            label7.Name = "label7";
            label7.Size = new Size(29, 32);
            label7.TabIndex = 9;
            label7.Text = "θ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(4, 169);
            label6.Name = "label6";
            label6.Size = new Size(48, 32);
            label6.TabIndex = 8;
            label6.Text = "R4";
            // 
            // txtR4_L
            // 
            txtR4_L.Location = new Point(58, 169);
            txtR4_L.Name = "txtR4_L";
            txtR4_L.Size = new Size(200, 34);
            txtR4_L.TabIndex = 7;
            txtR4_L.Text = "250";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(4, 133);
            label5.Name = "label5";
            label5.Size = new Size(48, 32);
            label5.TabIndex = 6;
            label5.Text = "R3";
            // 
            // txtR3_L
            // 
            txtR3_L.Location = new Point(58, 135);
            txtR3_L.Name = "txtR3_L";
            txtR3_L.Size = new Size(200, 34);
            txtR3_L.TabIndex = 5;
            txtR3_L.Text = "300";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(4, 97);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 4;
            label4.Text = "R2";
            // 
            // txtR2_L
            // 
            txtR2_L.Location = new Point(58, 97);
            txtR2_L.Name = "txtR2_L";
            txtR2_L.Size = new Size(200, 34);
            txtR2_L.TabIndex = 3;
            txtR2_L.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(4, 61);
            label3.Name = "label3";
            label3.Size = new Size(48, 32);
            label3.TabIndex = 2;
            label3.Text = "R1";
            // 
            // txtR1_L
            // 
            txtR1_L.Location = new Point(58, 61);
            txtR1_L.Name = "txtR1_L";
            txtR1_L.Size = new Size(200, 34);
            txtR1_L.TabIndex = 1;
            txtR1_L.Text = "400";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(62, 26);
            label2.Name = "label2";
            label2.Size = new Size(33, 32);
            label2.TabIndex = 0;
            label2.Text = "L";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDy);
            groupBox2.Controls.Add(txtCy);
            groupBox2.Controls.Add(txtBy);
            groupBox2.Controls.Add(txtAy);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDx);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCx);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtBx);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtAx);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(1111, 473);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(617, 297);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mafsal Konum Tablosu";
            // 
            // txtDy
            // 
            txtDy.Location = new Point(372, 169);
            txtDy.Name = "txtDy";
            txtDy.Size = new Size(200, 34);
            txtDy.TabIndex = 13;
            // 
            // txtCy
            // 
            txtCy.Location = new Point(372, 133);
            txtCy.Name = "txtCy";
            txtCy.Size = new Size(200, 34);
            txtCy.TabIndex = 12;
            // 
            // txtBy
            // 
            txtBy.Location = new Point(372, 97);
            txtBy.Name = "txtBy";
            txtBy.Size = new Size(200, 34);
            txtBy.TabIndex = 11;
            // 
            // txtAy
            // 
            txtAy.Location = new Point(372, 61);
            txtAy.Name = "txtAy";
            txtAy.Size = new Size(200, 34);
            txtAy.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(385, 26);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 9;
            label8.Text = "Y";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(4, 169);
            label9.Name = "label9";
            label9.Size = new Size(34, 32);
            label9.TabIndex = 8;
            label9.Text = "D";
            // 
            // txtDx
            // 
            txtDx.Location = new Point(43, 169);
            txtDx.Name = "txtDx";
            txtDx.Size = new Size(200, 34);
            txtDx.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(4, 133);
            label10.Name = "label10";
            label10.Size = new Size(34, 32);
            label10.TabIndex = 6;
            label10.Text = "C";
            // 
            // txtCx
            // 
            txtCx.Location = new Point(43, 133);
            txtCx.Name = "txtCx";
            txtCx.Size = new Size(200, 34);
            txtCx.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(4, 97);
            label11.Name = "label11";
            label11.Size = new Size(34, 32);
            label11.TabIndex = 4;
            label11.Text = "B";
            // 
            // txtBx
            // 
            txtBx.Location = new Point(43, 97);
            txtBx.Name = "txtBx";
            txtBx.Size = new Size(200, 34);
            txtBx.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(4, 61);
            label12.Name = "label12";
            label12.Size = new Size(34, 32);
            label12.TabIndex = 2;
            label12.Text = "A";
            // 
            // txtAx
            // 
            txtAx.Location = new Point(43, 61);
            txtAx.Name = "txtAx";
            txtAx.Size = new Size(200, 34);
            txtAx.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(62, 26);
            label13.Name = "label13";
            label13.Size = new Size(34, 32);
            label13.TabIndex = 0;
            label13.Text = "X";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtTahrikAcisi);
            groupBox3.Location = new Point(1369, 93);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 75);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 782);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMekanizmayi_Belli_Bir_Acida_Calistir);
            Controls.Add(btnMekanizmayi_Durdur);
            Controls.Add(btnMekanizmayi_Calistir);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Makine Dinamiği";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnMekanizmayi_Calistir;
        private Button btnMekanizmayi_Durdur;
        private Button btnMekanizmayi_Belli_Bir_Acida_Calistir;
        private Label label1;
        private TextBox txtTahrikAcisi;
        private GroupBox groupBox1;
        private Label label2;
        private Label label6;
        private TextBox txtR4_L;
        private Label label5;
        private TextBox txtR3_L;
        private Label label4;
        private TextBox txtR2_L;
        private Label label3;
        private TextBox txtR1_L;
        private TextBox txtR4_θ;
        private TextBox txtR3_θ;
        private TextBox txtR2_θ;
        private TextBox txtR1_θ;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox txtDy;
        private TextBox txtCy;
        private TextBox txtBy;
        private TextBox txtAy;
        private Label label8;
        private Label label9;
        private TextBox txtDx;
        private Label label10;
        private TextBox txtCx;
        private Label label11;
        private TextBox txtBx;
        private Label label12;
        private TextBox txtAx;
        private Label label13;
        private GroupBox groupBox3;
    }
}
