namespace EkpaideutikoLogismiko2024
{
    partial class OOP
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
            this.labelOOP = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOOP
            // 
            this.labelOOP.AutoSize = true;
            this.labelOOP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOOP.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOOP.Location = new System.Drawing.Point(367, 9);
            this.labelOOP.Name = "labelOOP";
            this.labelOOP.Size = new System.Drawing.Size(444, 36);
            this.labelOOP.TabIndex = 15;
            this.labelOOP.Text = "Object-Oriented Programming";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Location = new System.Drawing.Point(1060, 634);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(87, 41);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // OOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1159, 687);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelOOP);
            this.Name = "OOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object-Oriented Programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOOP;
        private System.Windows.Forms.Button buttonBack;
    }
}