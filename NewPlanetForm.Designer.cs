namespace NeverSpace
{
    partial class NewPlanetForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.textBoxSpeedX = new System.Windows.Forms.TextBox();
            this.textBoxSpeedY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxFixed = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIenergy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(66, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(147, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(96, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Text = "10";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(96, 38);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 2;
            this.textBoxY.Text = "10";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(96, 64);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(100, 20);
            this.textBoxMass.TabIndex = 3;
            this.textBoxMass.Text = "10";
            // 
            // textBoxSpeedX
            // 
            this.textBoxSpeedX.Location = new System.Drawing.Point(96, 116);
            this.textBoxSpeedX.Name = "textBoxSpeedX";
            this.textBoxSpeedX.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedX.TabIndex = 5;
            this.textBoxSpeedX.Text = "10";
            // 
            // textBoxSpeedY
            // 
            this.textBoxSpeedY.Location = new System.Drawing.Point(96, 142);
            this.textBoxSpeedY.Name = "textBoxSpeedY";
            this.textBoxSpeedY.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedY.TabIndex = 6;
            this.textBoxSpeedY.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "x speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "y speed";
            // 
            // checkBoxFixed
            // 
            this.checkBoxFixed.AutoSize = true;
            this.checkBoxFixed.Location = new System.Drawing.Point(98, 203);
            this.checkBoxFixed.Name = "checkBoxFixed";
            this.checkBoxFixed.Size = new System.Drawing.Size(48, 17);
            this.checkBoxFixed.TabIndex = 7;
            this.checkBoxFixed.Text = "fixed";
            this.checkBoxFixed.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Internal energy";
            // 
            // textBoxIenergy
            // 
            this.textBoxIenergy.Location = new System.Drawing.Point(96, 167);
            this.textBoxIenergy.Name = "textBoxIenergy";
            this.textBoxIenergy.Size = new System.Drawing.Size(100, 20);
            this.textBoxIenergy.TabIndex = 14;
            this.textBoxIenergy.Text = "10";
            // 
            // NewPlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxIenergy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxFixed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpeedY);
            this.Controls.Add(this.textBoxSpeedX);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "NewPlanetForm";
            this.Text = "NewPlanetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.TextBox textBoxSpeedX;
        private System.Windows.Forms.TextBox textBoxSpeedY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxFixed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIenergy;
    }
}