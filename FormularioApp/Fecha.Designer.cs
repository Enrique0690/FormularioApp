namespace FormularioApp
{
    partial class Fecha
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
            this.txtEdadAn = new System.Windows.Forms.TextBox();
            this.txtEdadDias = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Fecha de nacimiento";
            // 
            // txtEdadAn
            // 
            this.txtEdadAn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadAn.Location = new System.Drawing.Point(54, 162);
            this.txtEdadAn.Name = "txtEdadAn";
            this.txtEdadAn.Size = new System.Drawing.Size(227, 32);
            this.txtEdadAn.TabIndex = 1;
            // 
            // txtEdadDias
            // 
            this.txtEdadDias.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdadDias.Location = new System.Drawing.Point(54, 209);
            this.txtEdadDias.Name = "txtEdadDias";
            this.txtEdadDias.Size = new System.Drawing.Size(227, 32);
            this.txtEdadDias.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Presioname";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(92, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormularioApp.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(377, 265);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEdadDias);
            this.Controls.Add(this.txtEdadAn);
            this.Controls.Add(this.label1);
            this.Name = "Fecha";
            this.Text = "Fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdadAn;
        private System.Windows.Forms.TextBox txtEdadDias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}