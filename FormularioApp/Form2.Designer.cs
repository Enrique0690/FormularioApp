namespace FormularioApp
{
    partial class NumerosN
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
            this.lbrespuesta = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = " Enter a number";
            // 
            // lbrespuesta
            // 
            this.lbrespuesta.AutoSize = true;
            this.lbrespuesta.BackColor = System.Drawing.Color.Transparent;
            this.lbrespuesta.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrespuesta.ForeColor = System.Drawing.SystemColors.Control;
            this.lbrespuesta.Location = new System.Drawing.Point(182, 214);
            this.lbrespuesta.Name = "lbrespuesta";
            this.lbrespuesta.Size = new System.Drawing.Size(71, 27);
            this.lbrespuesta.TabIndex = 1;
            this.lbrespuesta.Text = "label2";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(227, 46);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(140, 34);
            this.txtnumero.TabIndex = 2;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumerosN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormularioApp.Properties.Resources.pink_floyd_el_lado_oscuro_de_la_luna_4033x2521_xtrafondos_com;
            this.ClientSize = new System.Drawing.Size(401, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbrespuesta);
            this.Controls.Add(this.label1);
            this.Name = "NumerosN";
            this.Text = "NumerosPrimos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrespuesta;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button button1;
    }
}