namespace Projeto_DA
{
    partial class Pedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_trabalhador = new System.Windows.Forms.TextBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.tb_restaurante = new System.Windows.Forms.TextBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.tb_ValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabalhador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restaurante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Total:";
            // 
            // tb_trabalhador
            // 
            this.tb_trabalhador.Location = new System.Drawing.Point(85, 56);
            this.tb_trabalhador.Multiline = true;
            this.tb_trabalhador.Name = "tb_trabalhador";
            this.tb_trabalhador.Size = new System.Drawing.Size(100, 20);
            this.tb_trabalhador.TabIndex = 5;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(85, 82);
            this.tb_cliente.Multiline = true;
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_cliente.TabIndex = 6;
            // 
            // tb_restaurante
            // 
            this.tb_restaurante.Location = new System.Drawing.Point(85, 108);
            this.tb_restaurante.Multiline = true;
            this.tb_restaurante.Name = "tb_restaurante";
            this.tb_restaurante.Size = new System.Drawing.Size(100, 20);
            this.tb_restaurante.TabIndex = 7;
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(85, 134);
            this.tb_estado.Multiline = true;
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 8;
            // 
            // tb_ValorTotal
            // 
            this.tb_ValorTotal.Location = new System.Drawing.Point(85, 160);
            this.tb_ValorTotal.Multiline = true;
            this.tb_ValorTotal.Name = "tb_ValorTotal";
            this.tb_ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorTotal.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(353, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "PEDIDOS:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_ValorTotal);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.tb_restaurante);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.tb_trabalhador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_trabalhador;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.TextBox tb_restaurante;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.TextBox tb_ValorTotal;
        private System.Windows.Forms.Label label6;
    }
}