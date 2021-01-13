namespace Lanches
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtQuantidadeRefri = new System.Windows.Forms.TextBox();
            this.txtQuantidadeLanches = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lanches.Properties.Resources.tumblr_o4tkltGCKT1v4dmu0o1_400;
            this.pictureBox1.Location = new System.Drawing.Point(526, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 397);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Lanches.Properties.Resources.fundo_de_aguarela_grunge_usando_cores_pastel_1048_6530;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtTroco);
            this.groupBox2.Controls.Add(this.txtDinheiro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-7, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de Troco";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(312, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calcular o Troco";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(236, 46);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(41, 29);
            this.txtTroco.TabIndex = 3;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(116, 49);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(40, 29);
            this.txtDinheiro.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dinheiro:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Lanches.Properties.Resources.fundo_de_aguarela_grunge_usando_cores_pastel_1048_6530;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotalCompra);
            this.groupBox1.Controls.Add(this.txtQuantidadeRefri);
            this.groupBox1.Controls.Add(this.txtQuantidadeLanches);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de Venda";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular Total da Compra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Preço do Refrigerante: R$2.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Preço do Lanche: R$6.00";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(199, 153);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.ReadOnly = true;
            this.txtTotalCompra.Size = new System.Drawing.Size(38, 29);
            this.txtTotalCompra.TabIndex = 14;
            // 
            // txtQuantidadeRefri
            // 
            this.txtQuantidadeRefri.Location = new System.Drawing.Point(199, 95);
            this.txtQuantidadeRefri.Name = "txtQuantidadeRefri";
            this.txtQuantidadeRefri.Size = new System.Drawing.Size(38, 29);
            this.txtQuantidadeRefri.TabIndex = 13;
            // 
            // txtQuantidadeLanches
            // 
            this.txtQuantidadeLanches.Location = new System.Drawing.Point(199, 42);
            this.txtQuantidadeLanches.Name = "txtQuantidadeLanches";
            this.txtQuantidadeLanches.Size = new System.Drawing.Size(38, 29);
            this.txtQuantidadeLanches.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total da Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantos Refrigerantes?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantos Lanches?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(908, 393);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtQuantidadeRefri;
        private System.Windows.Forms.TextBox txtQuantidadeLanches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

