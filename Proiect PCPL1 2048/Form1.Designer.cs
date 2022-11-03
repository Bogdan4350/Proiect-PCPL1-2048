namespace Proiect_PCPL1_2048
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.START = new System.Windows.Forms.Button();
            this.CREDITS = new System.Windows.Forms.Button();
            this.SETTINGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.START.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.START.Location = new System.Drawing.Point(349, 167);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(121, 49);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // CREDITS
            // 
            this.CREDITS.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CREDITS.ForeColor = System.Drawing.Color.Cyan;
            this.CREDITS.Location = new System.Drawing.Point(349, 362);
            this.CREDITS.Name = "CREDITS";
            this.CREDITS.Size = new System.Drawing.Size(121, 49);
            this.CREDITS.TabIndex = 1;
            this.CREDITS.Text = "CREDITS";
            this.CREDITS.UseVisualStyleBackColor = true;
            this.CREDITS.Click += new System.EventHandler(this.CREDITS_Click);
            // 
            // SETTINGS
            // 
            this.SETTINGS.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SETTINGS.ForeColor = System.Drawing.Color.Lime;
            this.SETTINGS.Location = new System.Drawing.Point(349, 265);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(121, 49);
            this.SETTINGS.TabIndex = 2;
            this.SETTINGS.Text = "SETTINGS";
            this.SETTINGS.UseVisualStyleBackColor = true;
            this.SETTINGS.Click += new System.EventHandler(this.SETTINGS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SETTINGS);
            this.Controls.Add(this.CREDITS);
            this.Controls.Add(this.START);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Aplicatie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button START;
        private Button CREDITS;
        private Button SETTINGS;
    }
}