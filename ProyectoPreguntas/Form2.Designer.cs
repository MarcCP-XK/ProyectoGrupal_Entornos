
namespace ProyectoPreguntas
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtb_usuario = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.b_start = new System.Windows.Forms.Button();
            this.timerForm2 = new System.Windows.Forms.Timer(this.components);
            this.comodin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_comodin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.comodin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Siemens Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_usuario.ForeColor = System.Drawing.Color.Blue;
            this.lbl_usuario.Location = new System.Drawing.Point(153, 364);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(99, 22);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "USUARIO:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Siemens Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.Color.Blue;
            this.lbl_password.Location = new System.Drawing.Point(111, 402);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(141, 22);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "CONTRASEÑA:";
            // 
            // txtb_usuario
            // 
            this.txtb_usuario.Location = new System.Drawing.Point(268, 367);
            this.txtb_usuario.Name = "txtb_usuario";
            this.txtb_usuario.Size = new System.Drawing.Size(155, 20);
            this.txtb_usuario.TabIndex = 3;
            // 
            // txtb_password
            // 
            this.txtb_password.Location = new System.Drawing.Point(268, 406);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(155, 20);
            this.txtb_password.TabIndex = 4;
            this.txtb_password.UseSystemPasswordChar = true;
            // 
            // b_start
            // 
            this.b_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_start.BackgroundImage")));
            this.b_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_start.FlatAppearance.BorderSize = 0;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Location = new System.Drawing.Point(196, 442);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(227, 84);
            this.b_start.TabIndex = 5;
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // timerForm2
            // 
            this.timerForm2.Interval = 3000;
            // 
            // comodin
            // 
            this.comodin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comodin.Controls.Add(this.label2);
            this.comodin.Controls.Add(this.label1);
            this.comodin.Controls.Add(this.lbl_comodin);
            this.comodin.Location = new System.Drawing.Point(456, 249);
            this.comodin.Name = "comodin";
            this.comodin.Size = new System.Drawing.Size(130, 149);
            this.comodin.TabIndex = 6;
            this.comodin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pass: 1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usu: Admin";
            // 
            // lbl_comodin
            // 
            this.lbl_comodin.AutoSize = true;
            this.lbl_comodin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comodin.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_comodin.Location = new System.Drawing.Point(31, 13);
            this.lbl_comodin.Name = "lbl_comodin";
            this.lbl_comodin.Size = new System.Drawing.Size(69, 16);
            this.lbl_comodin.TabIndex = 0;
            this.lbl_comodin.Text = "Comodin";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 592);
            this.Controls.Add(this.comodin);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.txtb_password);
            this.Controls.Add(this.txtb_usuario);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.comodin.ResumeLayout(false);
            this.comodin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_usuario;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timerForm2;
        private System.Windows.Forms.Panel comodin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_comodin;
    }
}