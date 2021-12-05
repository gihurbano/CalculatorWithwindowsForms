
namespace Calculator
{
    partial class frm1
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
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(36, 164);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(176, 37);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "Adição";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(36, 227);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(176, 37);
            this.btnSubtrair.TabIndex = 1;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(36, 288);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(176, 37);
            this.Dividir.TabIndex = 2;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(36, 347);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(176, 37);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(48, 103);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(153, 40);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.Location = new System.Drawing.Point(73, 25);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(139, 23);
            this.txtNumeroUm.TabIndex = 5;
            this.txtNumeroUm.Leave += new System.EventHandler(this.txtNumeroUm_Leave);
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.Location = new System.Drawing.Point(73, 63);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(139, 23);
            this.txtNumeroDois.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número 1: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(82, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(265, 431);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroDois);
            this.Controls.Add(this.txtNumeroUm);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Name = "frm1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
    }
}

