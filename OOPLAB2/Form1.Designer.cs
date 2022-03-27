namespace OOPLAB2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MFDESIGN = new System.Windows.Forms.PictureBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.emptyUser = new System.Windows.Forms.Label();
            this.emptyPass = new System.Windows.Forms.Label();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.passLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MFDESIGN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MFDESIGN
            // 
            this.MFDESIGN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MFDESIGN.BackColor = System.Drawing.Color.Transparent;
            this.MFDESIGN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MFDESIGN.BackgroundImage")));
            this.MFDESIGN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MFDESIGN.Location = new System.Drawing.Point(319, 12);
            this.MFDESIGN.Name = "MFDESIGN";
            this.MFDESIGN.Size = new System.Drawing.Size(200, 173);
            this.MFDESIGN.TabIndex = 0;
            this.MFDESIGN.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(355, 233);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(150, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(355, 309);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(150, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emptyUser
            // 
            this.emptyUser.AutoSize = true;
            this.emptyUser.BackColor = System.Drawing.Color.Transparent;
            this.emptyUser.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyUser.Location = new System.Drawing.Point(355, 209);
            this.emptyUser.Name = "emptyUser";
            this.emptyUser.Size = new System.Drawing.Size(95, 21);
            this.emptyUser.TabIndex = 3;
            this.emptyUser.Text = "USERNAME";
            this.emptyUser.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // emptyPass
            // 
            this.emptyPass.AutoSize = true;
            this.emptyPass.BackColor = System.Drawing.Color.Transparent;
            this.emptyPass.Font = new System.Drawing.Font("Bauhaus 93", 14.25F);
            this.emptyPass.Location = new System.Drawing.Point(355, 285);
            this.emptyPass.Name = "emptyPass";
            this.emptyPass.Size = new System.Drawing.Size(102, 21);
            this.emptyPass.TabIndex = 4;
            this.emptyPass.Text = "PASSWORD";
            this.emptyPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // userLogo
            // 
            this.userLogo.BackColor = System.Drawing.Color.Transparent;
            this.userLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userLogo.BackgroundImage")));
            this.userLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userLogo.Location = new System.Drawing.Point(319, 223);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(30, 30);
            this.userLogo.TabIndex = 5;
            this.userLogo.TabStop = false;
            this.userLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // passLogo
            // 
            this.passLogo.BackColor = System.Drawing.Color.Transparent;
            this.passLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passLogo.BackgroundImage")));
            this.passLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passLogo.Location = new System.Drawing.Point(319, 299);
            this.passLogo.Name = "passLogo";
            this.passLogo.Size = new System.Drawing.Size(30, 30);
            this.passLogo.TabIndex = 6;
            this.passLogo.TabStop = false;
            this.passLogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOG IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "V1.0.0 Beta";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passLogo);
            this.Controls.Add(this.userLogo);
            this.Controls.Add(this.emptyPass);
            this.Controls.Add(this.emptyUser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.MFDESIGN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MFDESIGN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MFDESIGN;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label emptyUser;
        private System.Windows.Forms.Label emptyPass;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.PictureBox passLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

