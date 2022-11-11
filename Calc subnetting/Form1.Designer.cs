
namespace Calc_subnetting
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_inip = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_nredes = new System.Windows.Forms.Label();
            this.lbl_hosts = new System.Windows.Forms.Label();
            this.txtbox_nredes = new System.Windows.Forms.TextBox();
            this.txtbox_nhosts = new System.Windows.Forms.TextBox();
            this.lbl_red = new System.Windows.Forms.Label();
            this.txtbox_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_inip
            // 
            this.txtbox_inip.Location = new System.Drawing.Point(74, 12);
            this.txtbox_inip.Name = "txtbox_inip";
            this.txtbox_inip.Size = new System.Drawing.Size(100, 20);
            this.txtbox_inip.TabIndex = 0;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(262, 10);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 1;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_nredes
            // 
            this.lbl_nredes.AutoSize = true;
            this.lbl_nredes.Location = new System.Drawing.Point(13, 63);
            this.lbl_nredes.Name = "lbl_nredes";
            this.lbl_nredes.Size = new System.Drawing.Size(55, 13);
            this.lbl_nredes.TabIndex = 2;
            this.lbl_nredes.Text = "Subredes:";
            // 
            // lbl_hosts
            // 
            this.lbl_hosts.AutoSize = true;
            this.lbl_hosts.Location = new System.Drawing.Point(13, 87);
            this.lbl_hosts.Name = "lbl_hosts";
            this.lbl_hosts.Size = new System.Drawing.Size(37, 13);
            this.lbl_hosts.TabIndex = 3;
            this.lbl_hosts.Text = "Hosts:";
            // 
            // txtbox_nredes
            // 
            this.txtbox_nredes.Location = new System.Drawing.Point(74, 60);
            this.txtbox_nredes.Name = "txtbox_nredes";
            this.txtbox_nredes.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nredes.TabIndex = 4;
            // 
            // txtbox_nhosts
            // 
            this.txtbox_nhosts.Location = new System.Drawing.Point(74, 84);
            this.txtbox_nhosts.Name = "txtbox_nhosts";
            this.txtbox_nhosts.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nhosts.TabIndex = 5;
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(12, 15);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(30, 13);
            this.lbl_red.TabIndex = 6;
            this.lbl_red.Text = "Red:";
            // 
            // txtbox_out
            // 
            this.txtbox_out.Location = new System.Drawing.Point(16, 135);
            this.txtbox_out.Multiline = true;
            this.txtbox_out.Name = "txtbox_out";
            this.txtbox_out.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbox_out.Size = new System.Drawing.Size(443, 303);
            this.txtbox_out.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.txtbox_out);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.txtbox_nhosts);
            this.Controls.Add(this.txtbox_nredes);
            this.Controls.Add(this.lbl_hosts);
            this.Controls.Add(this.lbl_nredes);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txtbox_inip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_inip;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_nredes;
        private System.Windows.Forms.Label lbl_hosts;
        private System.Windows.Forms.TextBox txtbox_nredes;
        private System.Windows.Forms.TextBox txtbox_nhosts;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.TextBox txtbox_out;
    }
}

