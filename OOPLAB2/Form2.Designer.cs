﻿namespace OOPLAB2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtj = new System.Windows.Forms.TextBox();
            this.txti = new System.Windows.Forms.TextBox();
            this.rdCstm = new System.Windows.Forms.RadioButton();
            this.rdHard = new System.Windows.Forms.RadioButton();
            this.rdMed = new System.Windows.Forms.RadioButton();
            this.rdEasy = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblShp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbxBlue = new System.Windows.Forms.CheckBox();
            this.cbxyellow = new System.Windows.Forms.CheckBox();
            this.cbxRed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(413, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtj);
            this.panel1.Controls.Add(this.txti);
            this.panel1.Controls.Add(this.rdCstm);
            this.panel1.Controls.Add(this.rdHard);
            this.panel1.Controls.Add(this.rdMed);
            this.panel1.Controls.Add(this.rdEasy);
            this.panel1.Location = new System.Drawing.Point(457, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 166);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtj
            // 
            this.txtj.Location = new System.Drawing.Point(169, 95);
            this.txtj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtj.Name = "txtj";
            this.txtj.Size = new System.Drawing.Size(29, 22);
            this.txtj.TabIndex = 20;
            this.txtj.TextChanged += new System.EventHandler(this.txtj_TextChanged);
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(115, 95);
            this.txti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(29, 22);
            this.txti.TabIndex = 19;
            this.txti.TextChanged += new System.EventHandler(this.txti_TextChanged);
            // 
            // rdCstm
            // 
            this.rdCstm.AutoSize = true;
            this.rdCstm.Location = new System.Drawing.Point(32, 96);
            this.rdCstm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCstm.Name = "rdCstm";
            this.rdCstm.Size = new System.Drawing.Size(76, 21);
            this.rdCstm.TabIndex = 18;
            this.rdCstm.TabStop = true;
            this.rdCstm.Text = "Custom";
            this.rdCstm.UseVisualStyleBackColor = true;
            // 
            // rdHard
            // 
            this.rdHard.AutoSize = true;
            this.rdHard.Location = new System.Drawing.Point(32, 69);
            this.rdHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdHard.Name = "rdHard";
            this.rdHard.Size = new System.Drawing.Size(60, 21);
            this.rdHard.TabIndex = 17;
            this.rdHard.TabStop = true;
            this.rdHard.Text = "Hard";
            this.rdHard.UseVisualStyleBackColor = true;
            // 
            // rdMed
            // 
            this.rdMed.AutoSize = true;
            this.rdMed.Location = new System.Drawing.Point(32, 42);
            this.rdMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdMed.Name = "rdMed";
            this.rdMed.Size = new System.Drawing.Size(78, 21);
            this.rdMed.TabIndex = 16;
            this.rdMed.TabStop = true;
            this.rdMed.Text = "Medium";
            this.rdMed.UseVisualStyleBackColor = true;
            // 
            // rdEasy
            // 
            this.rdEasy.AutoSize = true;
            this.rdEasy.Location = new System.Drawing.Point(32, 15);
            this.rdEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdEasy.Name = "rdEasy";
            this.rdEasy.Size = new System.Drawing.Size(60, 21);
            this.rdEasy.TabIndex = 15;
            this.rdEasy.TabStop = true;
            this.rdEasy.Text = "Easy";
            this.rdEasy.UseVisualStyleBackColor = true;
            this.rdEasy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxBlue);
            this.panel2.Controls.Add(this.cbxyellow);
            this.panel2.Controls.Add(this.cbxRed);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(460, 327);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 205);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(115, 70);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(32, 70);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(115, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(115, 43);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(32, 43);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Square";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Triangle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl.Location = new System.Drawing.Point(452, 85);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(185, 29);
            this.lblLvl.TabIndex = 17;
            this.lblLvl.Text = "Diffuculty Levels";
            // 
            // lblShp
            // 
            this.lblShp.AutoSize = true;
            this.lblShp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShp.Location = new System.Drawing.Point(359, 327);
            this.lblShp.Name = "lblShp";
            this.lblShp.Size = new System.Drawing.Size(95, 29);
            this.lblShp.TabIndex = 18;
            this.lblShp.Text = "Shapes";
            this.lblShp.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 551);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(368, 431);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 29);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Color";
            this.lblColor.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cbxBlue
            // 
            this.cbxBlue.AutoSize = true;
            this.cbxBlue.Location = new System.Drawing.Point(32, 158);
            this.cbxBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxBlue.Name = "cbxBlue";
            this.cbxBlue.Size = new System.Drawing.Size(58, 21);
            this.cbxBlue.TabIndex = 24;
            this.cbxBlue.Text = "Blue";
            this.cbxBlue.UseVisualStyleBackColor = true;
            // 
            // cbxyellow
            // 
            this.cbxyellow.AutoSize = true;
            this.cbxyellow.Location = new System.Drawing.Point(32, 133);
            this.cbxyellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxyellow.Name = "cbxyellow";
            this.cbxyellow.Size = new System.Drawing.Size(70, 21);
            this.cbxyellow.TabIndex = 23;
            this.cbxyellow.Text = "Yellow";
            this.cbxyellow.UseVisualStyleBackColor = true;
            // 
            // cbxRed
            // 
            this.cbxRed.AutoSize = true;
            this.cbxRed.Location = new System.Drawing.Point(33, 108);
            this.cbxRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRed.Name = "cbxRed";
            this.cbxRed.Size = new System.Drawing.Size(56, 21);
            this.cbxRed.TabIndex = 22;
            this.cbxRed.Text = "Red";
            this.cbxRed.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 690);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblShp);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdHard;
        private System.Windows.Forms.RadioButton rdMed;
        private System.Windows.Forms.RadioButton rdEasy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtj;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.RadioButton rdCstm;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblShp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox cbxBlue;
        private System.Windows.Forms.CheckBox cbxyellow;
        private System.Windows.Forms.CheckBox cbxRed;
    }
}