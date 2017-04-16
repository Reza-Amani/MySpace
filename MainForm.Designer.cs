namespace NeverSpace
{
    partial class MainForm
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
            this.pictureBoxSpace = new System.Windows.Forms.PictureBox();
            this.button_simple_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSpace
            // 
            this.pictureBoxSpace.BackColor = System.Drawing.Color.Black;
            this.pictureBoxSpace.Location = new System.Drawing.Point(108, 0);
            this.pictureBoxSpace.Name = "pictureBoxSpace";
            this.pictureBoxSpace.Size = new System.Drawing.Size(525, 418);
            this.pictureBoxSpace.TabIndex = 0;
            this.pictureBoxSpace.TabStop = false;
            // 
            // button_simple_start
            // 
            this.button_simple_start.BackColor = System.Drawing.Color.White;
            this.button_simple_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_simple_start.ForeColor = System.Drawing.Color.Black;
            this.button_simple_start.Location = new System.Drawing.Point(12, 12);
            this.button_simple_start.Name = "button_simple_start";
            this.button_simple_start.Size = new System.Drawing.Size(75, 30);
            this.button_simple_start.TabIndex = 1;
            this.button_simple_start.Text = "simple start";
            this.button_simple_start.UseVisualStyleBackColor = false;
            this.button_simple_start.Click += new System.EventHandler(this.button_simple_start_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(633, 418);
            this.Controls.Add(this.button_simple_start);
            this.Controls.Add(this.pictureBoxSpace);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "MainForm";
            this.Text = "Space";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSpace;
        private System.Windows.Forms.Button button_simple_start;
    }
}

