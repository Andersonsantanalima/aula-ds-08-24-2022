namespace ds
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l = new System.Windows.Forms.Label();
            this.btndepos = new System.Windows.Forms.RadioButton();
            this.btnsacar = new System.Windows.Forms.RadioButton();
            this.numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnexecutar = new System.Windows.Forms.Button();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsaldo);
            this.groupBox1.Controls.Add(this.btnexecutar);
            this.groupBox1.Controls.Add(this.txtvalor);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.btnsacar);
            this.groupBox1.Controls.Add(this.btndepos);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 597);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "banco";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(27, 493);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(66, 24);
            this.l.TabIndex = 6;
            this.l.Text = "saldo ";
            // 
            // btndepos
            // 
            this.btndepos.AutoSize = true;
            this.btndepos.Location = new System.Drawing.Point(31, 262);
            this.btndepos.Name = "btndepos";
            this.btndepos.Size = new System.Drawing.Size(114, 28);
            this.btndepos.TabIndex = 7;
            this.btndepos.TabStop = true;
            this.btndepos.Text = "depositar";
            this.btndepos.UseVisualStyleBackColor = true;
           
            // 
            // btnsacar
            // 
            this.btnsacar.AutoSize = true;
            this.btnsacar.Location = new System.Drawing.Point(31, 307);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(78, 28);
            this.btnsacar.TabIndex = 8;
            this.btnsacar.TabStop = true;
            this.btnsacar.Text = "sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            this.btnsacar.CheckedChanged += new System.EventHandler(this.Btnsacar_CheckedChanged);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(27, 92);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(82, 24);
            this.numero.TabIndex = 9;
            this.numero.Text = "numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "valor";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(31, 119);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(297, 29);
            this.txtnumero.TabIndex = 11;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(31, 206);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(297, 29);
            this.txtvalor.TabIndex = 12;
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(31, 385);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(422, 74);
            this.btnexecutar.TabIndex = 13;
            this.btnexecutar.Text = "executar";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.Btnexecutar_Click);
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(111, 493);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(80, 24);
            this.lblsaldo.TabIndex = 14;
            this.lblsaldo.Text = "R$ 0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 646);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.RadioButton btnsacar;
        private System.Windows.Forms.RadioButton btndepos;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Button btnexecutar;
    }
}

