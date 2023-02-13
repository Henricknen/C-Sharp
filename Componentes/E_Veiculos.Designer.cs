namespace Componentes
{
    partial class F_Veiculos
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
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.Location = new System.Drawing.Point(1, 33);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.Size = new System.Drawing.Size(270, 405);
            this.tb_listaVeiculos.TabIndex = 0;
            this.tb_listaVeiculos.TextChanged += new System.EventHandler(this.tb_listaVeiculos_TextChanged);
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.tb_listaVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veiculos";
            this.Load += new System.EventHandler(this.F_Veiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listaVeiculos;
    }
}