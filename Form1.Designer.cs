
namespace AplicacionBancaraWindowsFormsG3_2022_I
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
            this.txtbNT1 = new System.Windows.Forms.TextBox();
            this.txtbNT2 = new System.Windows.Forms.TextBox();
            this.txtbNT3 = new System.Windows.Forms.TextBox();
            this.txtbNT4 = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNT1
            // 
            this.txtbNT1.Location = new System.Drawing.Point(279, 196);
            this.txtbNT1.Name = "txtbNT1";
            this.txtbNT1.Size = new System.Drawing.Size(118, 31);
            this.txtbNT1.TabIndex = 0;
            this.txtbNT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNT1_KeyPress);
            // 
            // txtbNT2
            // 
            this.txtbNT2.Location = new System.Drawing.Point(456, 199);
            this.txtbNT2.Name = "txtbNT2";
            this.txtbNT2.Size = new System.Drawing.Size(118, 31);
            this.txtbNT2.TabIndex = 1;
            this.txtbNT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNT1_KeyPress);
            // 
            // txtbNT3
            // 
            this.txtbNT3.Location = new System.Drawing.Point(636, 193);
            this.txtbNT3.Name = "txtbNT3";
            this.txtbNT3.Size = new System.Drawing.Size(118, 31);
            this.txtbNT3.TabIndex = 3;
            this.txtbNT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNT1_KeyPress);
            // 
            // txtbNT4
            // 
            this.txtbNT4.Location = new System.Drawing.Point(814, 196);
            this.txtbNT4.Name = "txtbNT4";
            this.txtbNT4.Size = new System.Drawing.Size(118, 31);
            this.txtbNT4.TabIndex = 4;
            this.txtbNT4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNT1_KeyPress);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(674, 437);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(249, 61);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Tarjeta";
            // 
            // txtbNIP
            // 
            this.txtbNIP.Location = new System.Drawing.Point(814, 281);
            this.txtbNIP.Name = "txtbNIP";
            this.txtbNIP.Size = new System.Drawing.Size(118, 31);
            this.txtbNIP.TabIndex = 5;
            this.txtbNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNT1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtbNIP);
            this.Controls.Add(this.txtbNT4);
            this.Controls.Add(this.txtbNT3);
            this.Controls.Add(this.txtbNT2);
            this.Controls.Add(this.txtbNT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNT1;
        private System.Windows.Forms.TextBox txtbNT2;
        private System.Windows.Forms.TextBox txtbNT3;
        private System.Windows.Forms.TextBox txtbNT4;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNIP;
        private System.Windows.Forms.Label label2;
    }
}

