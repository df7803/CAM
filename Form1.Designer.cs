namespace CAM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LST = new System.Windows.Forms.CheckBox();
            this.GEO = new System.Windows.Forms.CheckBox();
            this.GMT = new System.Windows.Forms.CheckBox();
            this.DXF = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Manual = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CBTL1030 = new System.Windows.Forms.CheckBox();
            this.CBTC1000 = new System.Windows.Forms.CheckBox();
            this.CBTC2020 = new System.Windows.Forms.CheckBox();
            this.LblESCOLHA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(278, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 317);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROJETISTA";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(316, 59);
            this.button6.TabIndex = 8;
            this.button6.Text = "GERAR RELATORIO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(7, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 76);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deseja copiar arquivo para pasta local?";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Escolha o Local";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_SaveToFile_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 23);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(6, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Onde estão os arquivos DXF/GEO/GMT/LST?";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 23);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "ESCOLHA O LOCAL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LST);
            this.groupBox1.Controls.Add(this.GEO);
            this.groupBox1.Controls.Add(this.GMT);
            this.groupBox1.Controls.Add(this.DXF);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marque o(s)tipo(s) de arquivo que deseja verifica";
            // 
            // LST
            // 
            this.LST.AutoSize = true;
            this.LST.Location = new System.Drawing.Point(220, 19);
            this.LST.Name = "LST";
            this.LST.Size = new System.Drawing.Size(49, 17);
            this.LST.TabIndex = 3;
            this.LST.Text = ".LST";
            this.LST.UseVisualStyleBackColor = true;
            this.LST.CheckedChanged += new System.EventHandler(this.LST_CheckedChanged);
            // 
            // GEO
            // 
            this.GEO.AutoSize = true;
            this.GEO.Location = new System.Drawing.Point(73, 19);
            this.GEO.Name = "GEO";
            this.GEO.Size = new System.Drawing.Size(52, 17);
            this.GEO.TabIndex = 1;
            this.GEO.Text = ".GEO";
            this.GEO.UseVisualStyleBackColor = true;
            this.GEO.CheckedChanged += new System.EventHandler(this.GEO_CheckedChanged);
            // 
            // GMT
            // 
            this.GMT.AutoSize = true;
            this.GMT.Location = new System.Drawing.Point(147, 19);
            this.GMT.Name = "GMT";
            this.GMT.Size = new System.Drawing.Size(53, 17);
            this.GMT.TabIndex = 2;
            this.GMT.Text = ".GMT";
            this.GMT.UseVisualStyleBackColor = true;
            this.GMT.CheckedChanged += new System.EventHandler(this.GMT_CheckedChanged);
            // 
            // DXF
            // 
            this.DXF.AutoSize = true;
            this.DXF.Location = new System.Drawing.Point(6, 19);
            this.DXF.Name = "DXF";
            this.DXF.Size = new System.Drawing.Size(50, 17);
            this.DXF.TabIndex = 0;
            this.DXF.Text = ".DXF";
            this.DXF.UseVisualStyleBackColor = true;
            this.DXF.CheckedChanged += new System.EventHandler(this.DXF_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.Manual);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.CBTL1030);
            this.tabPage2.Controls.Add(this.CBTC1000);
            this.tabPage2.Controls.Add(this.CBTC2020);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VAL CAM";
            // 
            // Manual
            // 
            this.Manual.Location = new System.Drawing.Point(6, 105);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(120, 60);
            this.Manual.TabIndex = 10;
            this.Manual.Text = "MANUAL";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 60);
            this.button3.TabIndex = 9;
            this.button3.Text = "GERAR RELATORIO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CBTL1030
            // 
            this.CBTL1030.AutoSize = true;
            this.CBTL1030.Location = new System.Drawing.Point(6, 17);
            this.CBTL1030.Name = "CBTL1030";
            this.CBTL1030.Size = new System.Drawing.Size(63, 17);
            this.CBTL1030.TabIndex = 6;
            this.CBTL1030.Text = "TL1030";
            this.CBTL1030.UseVisualStyleBackColor = true;
            this.CBTL1030.CheckedChanged += new System.EventHandler(this.CBTL1030_CheckedChanged);
            // 
            // CBTC1000
            // 
            this.CBTC1000.AutoSize = true;
            this.CBTC1000.Location = new System.Drawing.Point(6, 63);
            this.CBTC1000.Name = "CBTC1000";
            this.CBTC1000.Size = new System.Drawing.Size(64, 17);
            this.CBTC1000.TabIndex = 8;
            this.CBTC1000.Text = "TP1000";
            this.CBTC1000.UseVisualStyleBackColor = true;
            this.CBTC1000.CheckedChanged += new System.EventHandler(this.CBTC1000_CheckedChanged);
            // 
            // CBTC2020
            // 
            this.CBTC2020.AutoSize = true;
            this.CBTC2020.Location = new System.Drawing.Point(6, 40);
            this.CBTC2020.Name = "CBTC2020";
            this.CBTC2020.Size = new System.Drawing.Size(64, 17);
            this.CBTC2020.TabIndex = 7;
            this.CBTC2020.Text = "TC2020";
            this.CBTC2020.UseVisualStyleBackColor = true;
            this.CBTC2020.CheckedChanged += new System.EventHandler(this.CBTC2020_CheckedChanged);
            // 
            // LblESCOLHA
            // 
            this.LblESCOLHA.Location = new System.Drawing.Point(3, 3);
            this.LblESCOLHA.Name = "LblESCOLHA";
            this.LblESCOLHA.Size = new System.Drawing.Size(78, 39);
            this.LblESCOLHA.TabIndex = 1;
            this.LblESCOLHA.Text = "ESCOLHA O(s) OSFA(s)";
            this.LblESCOLHA.UseVisualStyleBackColor = true;
            this.LblESCOLHA.Click += new System.EventHandler(this.LblESCOLHA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "HELP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblESCOLHA);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(90, 108);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "FECHAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(108, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 71);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_load);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 171);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 133);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total de programas deste OSFA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total de programas CAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de arquivos";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(109, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 12;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(629, 311);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button LblESCOLHA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox CBTL1030;
        private System.Windows.Forms.CheckBox CBTC2020;
        private System.Windows.Forms.CheckBox CBTC1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Manual;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LST;
        private System.Windows.Forms.CheckBox GEO;
        private System.Windows.Forms.CheckBox GMT;
        private System.Windows.Forms.CheckBox DXF;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}

