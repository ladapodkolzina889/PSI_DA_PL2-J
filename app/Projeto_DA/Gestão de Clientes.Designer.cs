namespace Projeto_DA
{
    partial class Gestão_de_Clientes
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bt_criarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.tb_NIFCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_removerCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.lb_GestãoDeClientes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 368);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(251, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(539, 303);
            this.listBox2.TabIndex = 5;
            // 
            // bt_criarCliente
            // 
            this.bt_criarCliente.Location = new System.Drawing.Point(52, 92);
            this.bt_criarCliente.Name = "bt_criarCliente";
            this.bt_criarCliente.Size = new System.Drawing.Size(156, 20);
            this.bt_criarCliente.TabIndex = 6;
            this.bt_criarCliente.Text = "Criar";
            this.bt_criarCliente.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "NIF:";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Location = new System.Drawing.Point(52, 22);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(156, 20);
            this.tb_nomeCliente.TabIndex = 9;
            // 
            // tb_NIFCliente
            // 
            this.tb_NIFCliente.Location = new System.Drawing.Point(52, 52);
            this.tb_NIFCliente.Name = "tb_NIFCliente";
            this.tb_NIFCliente.Size = new System.Drawing.Size(156, 20);
            this.tb_NIFCliente.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nomeCliente);
            this.groupBox1.Controls.Add(this.tb_NIFCliente);
            this.groupBox1.Controls.Add(this.bt_criarCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Novo Cliente";
            // 
            // bt_removerCliente
            // 
            this.bt_removerCliente.Location = new System.Drawing.Point(6, 22);
            this.bt_removerCliente.Name = "bt_removerCliente";
            this.bt_removerCliente.Size = new System.Drawing.Size(211, 20);
            this.bt_removerCliente.TabIndex = 12;
            this.bt_removerCliente.Text = "Remover Cliente";
            this.bt_removerCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.bt_removerCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 422);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Clientes";
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(454, 60);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(114, 50);
            this.bt_guardar.TabIndex = 14;
            this.bt_guardar.Text = "Guardar Alterações";
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "NIF:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(292, 60);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(156, 20);
            this.tb_nome.TabIndex = 17;
            // 
            // tb_nif
            // 
            this.tb_nif.Location = new System.Drawing.Point(292, 90);
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(156, 20);
            this.tb_nif.TabIndex = 18;
            // 
            // bt_consultar
            // 
            this.bt_consultar.Location = new System.Drawing.Point(649, 440);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(141, 20);
            this.bt_consultar.TabIndex = 19;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.UseVisualStyleBackColor = true;
            // 
            // lb_GestãoDeClientes
            // 
            this.lb_GestãoDeClientes.AutoSize = true;
            this.lb_GestãoDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_GestãoDeClientes.Location = new System.Drawing.Point(411, 9);
            this.lb_GestãoDeClientes.Name = "lb_GestãoDeClientes";
            this.lb_GestãoDeClientes.Size = new System.Drawing.Size(168, 24);
            this.lb_GestãoDeClientes.TabIndex = 20;
            this.lb_GestãoDeClientes.Text = "Gestão de Clientes";
            // 
            // Gestão_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 570);
            this.Controls.Add(this.lb_GestãoDeClientes);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_nif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Name = "Gestão_de_Clientes";
            this.Text = "Gestão_de_Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button bt_criarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.TextBox tb_NIFCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_removerCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_nif;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.Label lb_GestãoDeClientes;
    }
}