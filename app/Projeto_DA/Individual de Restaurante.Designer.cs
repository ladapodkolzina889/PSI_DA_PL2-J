namespace Projeto_DA
{
    partial class Individual_de_Restaurante
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
            this.lb_IndividualDeRestaurante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lb_IndividualDeRestaurante
            // 
            this.lb_IndividualDeRestaurante.AutoSize = true;
            this.lb_IndividualDeRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_IndividualDeRestaurante.Location = new System.Drawing.Point(298, 9);
            this.lb_IndividualDeRestaurante.Name = "lb_IndividualDeRestaurante";
            this.lb_IndividualDeRestaurante.Size = new System.Drawing.Size(221, 24);
            this.lb_IndividualDeRestaurante.TabIndex = 8;
            this.lb_IndividualDeRestaurante.Text = "Individual de Restaurante";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 378);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerir os trabalhadores";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(233, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 378);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu da restaurante";
            // 
            // Individual_de_Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_IndividualDeRestaurante);
            this.Name = "Individual_de_Restaurante";
            this.Text = "Individual_de_Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_IndividualDeRestaurante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}