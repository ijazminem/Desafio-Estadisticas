namespace DesafioEstadisticas
{
    partial class FormLogin
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.iniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtusuario.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(302, 226);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(130, 25);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.Text = "Usuario";
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.SystemColors.Menu;
            this.txtcontra.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.Location = new System.Drawing.Point(302, 257);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(130, 25);
            this.txtcontra.TabIndex = 1;
            this.txtcontra.Text = "Contraseña";
            // 
            // iniciarsesion
            // 
            this.iniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iniciarsesion.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarsesion.ForeColor = System.Drawing.SystemColors.Window;
            this.iniciarsesion.Image = global::DesafioEstadisticas.Properties.Resources.botones;
            this.iniciarsesion.Location = new System.Drawing.Point(319, 298);
            this.iniciarsesion.Name = "iniciarsesion";
            this.iniciarsesion.Size = new System.Drawing.Size(97, 25);
            this.iniciarsesion.TabIndex = 2;
            this.iniciarsesion.Text = "Iniciar Sesión";
            this.iniciarsesion.UseVisualStyleBackColor = true;
            this.iniciarsesion.Click += new System.EventHandler(this.iniciarsesion_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesafioEstadisticas.Properties.Resources.Bienvenido__3_;
            this.ClientSize = new System.Drawing.Size(734, 436);
            this.Controls.Add(this.iniciarsesion);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button iniciarsesion;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.TextBox txtcontra;
    }
}