namespace LabTP
{
    partial class FormBase
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
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.buttonSetAntiaircraftGun = new System.Windows.Forms.Button();
            this.buttonSetGun = new System.Windows.Forms.Button();
            this.groupBoxGetGun = new System.Windows.Forms.GroupBox();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonTakeGun = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.labelnumBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.groupBoxGetGun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Location = new System.Drawing.Point(2, 1);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(1062, 641);
            this.pictureBoxBase.TabIndex = 0;
            this.pictureBoxBase.TabStop = false;
            
            // 
            // buttonSetAntiaircraftGun
            // 
            this.buttonSetAntiaircraftGun.Location = new System.Drawing.Point(1070, 12);
            this.buttonSetAntiaircraftGun.Name = "buttonSetAntiaircraftGun";
            this.buttonSetAntiaircraftGun.Size = new System.Drawing.Size(167, 38);
            this.buttonSetAntiaircraftGun.TabIndex = 1;
            this.buttonSetAntiaircraftGun.Text = "Припаковать зенитку";
            this.buttonSetAntiaircraftGun.UseVisualStyleBackColor = true;
            this.buttonSetAntiaircraftGun.Click += new System.EventHandler(this.buttonSetAntiaircraftGun_Click);
            // 
            // buttonSetGun
            // 
            this.buttonSetGun.Location = new System.Drawing.Point(1071, 57);
            this.buttonSetGun.Name = "buttonSetGun";
            this.buttonSetGun.Size = new System.Drawing.Size(166, 35);
            this.buttonSetGun.TabIndex = 2;
            this.buttonSetGun.Text = "Припарковать бтр";
            this.buttonSetGun.UseVisualStyleBackColor = true;
            this.buttonSetGun.Click += new System.EventHandler(this.buttonSetGun_Click);
            // 
            // groupBoxGetGun
            // 
            this.groupBoxGetGun.Controls.Add(this.pictureBoxTake);
            this.groupBoxGetGun.Controls.Add(this.button3);
            this.groupBoxGetGun.Controls.Add(this.maskedTextBox);
            this.groupBoxGetGun.Controls.Add(this.label1);
            this.groupBoxGetGun.Location = new System.Drawing.Point(1067, 310);
            this.groupBoxGetGun.Name = "groupBoxGetGun";
            this.groupBoxGetGun.Size = new System.Drawing.Size(181, 341);
            this.groupBoxGetGun.TabIndex = 3;
            this.groupBoxGetGun.TabStop = false;
            this.groupBoxGetGun.Text = "Забрать технику";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(7, 112);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(168, 220);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonTakeGun
            // 
            this.buttonTakeGun.Location = new System.Drawing.Point(7, 70);
            this.buttonTakeGun.Name = "buttonTakeGun";
            this.buttonTakeGun.Size = new System.Drawing.Size(168, 35);
            this.buttonTakeGun.TabIndex = 2;
            this.buttonTakeGun.Text = "Забрать";
            this.buttonTakeGun.UseVisualStyleBackColor = true;
            this.buttonTakeGun.Click += new System.EventHandler(this.buttonTakeGun_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(75, 22);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(95, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelnumBase
            // 
            this.labelnumBase.AutoSize = true;
            this.labelnumBase.Location = new System.Drawing.Point(7, 22);
            this.labelnumBase.Name = "label1";
            this.labelnumBase.Size = new System.Drawing.Size(59, 17);
            this.labelnumBase.TabIndex = 0;
            this.labelnumBase.Text = "№ базы";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 654);
            this.Controls.Add(this.groupBoxGetGun);
            this.Controls.Add(this.buttonSetGun);
            this.Controls.Add(this.buttonSetAntiaircraftGun);
            this.Controls.Add(this.pictureBoxBase);
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.groupBoxGetGun.ResumeLayout(false);
            this.groupBoxGetGun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Button buttonSetAntiaircraftGun;
        private System.Windows.Forms.Button buttonSetGun;
        private System.Windows.Forms.GroupBox groupBoxGetGun;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonTakeGun;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelnumBase;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}
