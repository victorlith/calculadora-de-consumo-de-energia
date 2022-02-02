
namespace Calculadora
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtResultado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtValor1 = new System.Windows.Forms.TextBox();
			this.txtValor2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.resultado1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtResultado2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxValor3 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtResultado
			// 
			this.txtResultado.CausesValidation = false;
			this.txtResultado.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResultado.Location = new System.Drawing.Point(160, 285);
			this.txtResultado.Multiline = true;
			this.txtResultado.Name = "txtResultado";
			this.txtResultado.Size = new System.Drawing.Size(163, 29);
			this.txtResultado.TabIndex = 5;
			this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(145, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Consumo de Energia";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Potência (W):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Horas de Uso:";
			// 
			// txtValor1
			// 
			this.txtValor1.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor1.Location = new System.Drawing.Point(113, 85);
			this.txtValor1.Name = "txtValor1";
			this.txtValor1.Size = new System.Drawing.Size(163, 23);
			this.txtValor1.TabIndex = 3;
			this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtValor2
			// 
			this.txtValor2.Font = new System.Drawing.Font("Futura Bk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor2.Location = new System.Drawing.Point(113, 128);
			this.txtValor2.Name = "txtValor2";
			this.txtValor2.Size = new System.Drawing.Size(163, 23);
			this.txtValor2.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Calculadora.Properties.Resources.imgpi_5;
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(312, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 162);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// resultado1
			// 
			this.resultado1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.resultado1.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultado1.Location = new System.Drawing.Point(189, 228);
			this.resultado1.Name = "resultado1";
			this.resultado1.Size = new System.Drawing.Size(105, 46);
			this.resultado1.TabIndex = 8;
			this.resultado1.Text = "Calcular";
			this.resultado1.UseVisualStyleBackColor = true;
			this.resultado1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new System.Drawing.Point(380, 335);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 26);
			this.button2.TabIndex = 9;
			this.button2.Text = "Sair";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Dias de Uso:";
			// 
			// btnLimpar
			// 
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.Location = new System.Drawing.Point(380, 304);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(82, 25);
			this.btnLimpar.TabIndex = 12;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtResultado2
			// 
			this.txtResultado2.CausesValidation = false;
			this.txtResultado2.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResultado2.Location = new System.Drawing.Point(160, 323);
			this.txtResultado2.Multiline = true;
			this.txtResultado2.Name = "txtResultado2";
			this.txtResultado2.Size = new System.Drawing.Size(163, 29);
			this.txtResultado2.TabIndex = 13;
			this.txtResultado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(86, 290);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Valor:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(86, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "Consumo:";
			// 
			// cbxValor3
			// 
			this.cbxValor3.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxValor3.FormattingEnabled = true;
			this.cbxValor3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
			this.cbxValor3.Location = new System.Drawing.Point(113, 170);
			this.cbxValor3.Name = "cbxValor3";
			this.cbxValor3.Size = new System.Drawing.Size(163, 24);
			this.cbxValor3.TabIndex = 16;
			this.cbxValor3.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 374);
			this.Controls.Add(this.cbxValor3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtResultado2);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.resultado1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtResultado);
			this.Controls.Add(this.txtValor2);
			this.Controls.Add(this.txtValor1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Consumo de Energia";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtValor1;
		private System.Windows.Forms.TextBox txtValor2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button resultado1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxValor3;
    }
}

