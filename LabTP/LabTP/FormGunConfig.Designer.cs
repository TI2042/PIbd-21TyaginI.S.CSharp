namespace LabTP
{
    partial class FormGunConfig
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
            this.labelGun = new System.Windows.Forms.Label();
            this.labelBTR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelGun = new System.Windows.Forms.Panel();
            this.pictureBoxGun = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelGun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGun
            // 
            this.labelGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGun.Location = new System.Drawing.Point(6, 18);
            this.labelGun.Name = "labelGun";
            this.labelGun.Size = new System.Drawing.Size(161, 73);
            this.labelGun.TabIndex = 0;
            this.labelGun.Text = "Зенитка";
            this.labelGun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableGun_MouseDown);
            // 
            // labelBTR
            // 
            this.labelBTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBTR.Location = new System.Drawing.Point(6, 100);
            this.labelBTR.Name = "labelBTR";
            this.labelBTR.Size = new System.Drawing.Size(161, 76);
            this.labelBTR.TabIndex = 1;
            this.labelBTR.Text = "БТР";
            this.labelBTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBTR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableBTR_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGun);
            this.groupBox1.Controls.Add(this.labelBTR);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // panelGun
            // 
            this.panelGun.AllowDrop = true;
            this.panelGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGun.Controls.Add(this.pictureBoxGun);
            this.panelGun.Controls.Add(this.label2);
            this.panelGun.Controls.Add(this.label1);
            this.panelGun.Location = new System.Drawing.Point(202, 12);
            this.panelGun.Name = "panelGun";
            this.panelGun.Size = new System.Drawing.Size(333, 340);
            this.panelGun.TabIndex = 4;
            this.panelGun.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelGun_DragDrop);
            this.panelGun.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelGun_DragEnter);
            // 
            // pictureBoxGun
            // 
            this.pictureBoxGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGun.Location = new System.Drawing.Point(14, 17);
            this.pictureBoxGun.Name = "pictureBoxGun";
            this.pictureBoxGun.Size = new System.Drawing.Size(301, 172);
            this.pictureBoxGun.TabIndex = 5;
            this.pictureBoxGun.TabStop = false;
            this.pictureBoxGun.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelGun_DragDrop);
            this.pictureBoxGun.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelGun_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(34, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Доп. цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(34, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Основной цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(553, 30);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(51, 52);
            this.panelWhite.TabIndex = 5;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(610, 30);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(51, 52);
            this.panelBlack.TabIndex = 6;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(553, 88);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(51, 52);
            this.panelRed.TabIndex = 7;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(610, 88);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(51, 52);
            this.panelYellow.TabIndex = 8;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(553, 146);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(51, 52);
            this.panelBlue.TabIndex = 9;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(610, 146);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(51, 52);
            this.panelPink.TabIndex = 10;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(553, 204);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(51, 52);
            this.panelAqua.TabIndex = 11;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(610, 204);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(51, 52);
            this.panelGreen.TabIndex = 12;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 47);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormGunConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelAqua);
            this.Controls.Add(this.panelPink);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panelBlack);
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelGun);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGunConfig";
            this.Text = "FormGunConfig";
           
            this.groupBox1.ResumeLayout(false);
            this.panelGun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGun;
        private System.Windows.Forms.Label labelBTR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelGun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxGun;
    }
}