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
            this.Titlu = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Cursor = System.Windows.Forms.Cursors.Hand;
            this.START.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.START.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.START.Location = new System.Drawing.Point(349, 167);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(121, 59);
            this.START.TabIndex = 0;
            this.START.Text = "START GAME";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // CREDITS
            // 
            this.CREDITS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CREDITS.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.SETTINGS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SETTINGS.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SETTINGS.ForeColor = System.Drawing.Color.Lime;
            this.SETTINGS.Location = new System.Drawing.Point(349, 265);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(121, 59);
            this.SETTINGS.TabIndex = 2;
            this.SETTINGS.Text = "SETTINGS";
            this.SETTINGS.UseVisualStyleBackColor = true;
            this.SETTINGS.Click += new System.EventHandler(this.SETTINGS_Click);
            // 
            // Titlu
            // 
            this.Titlu.BackColor = System.Drawing.Color.DarkGray;
            this.Titlu.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titlu.ForeColor = System.Drawing.Color.Blue;
            this.Titlu.Location = new System.Drawing.Point(45, 63);
            this.Titlu.Name = "Titlu";
            this.Titlu.Size = new System.Drawing.Size(710, 58);
            this.Titlu.TabIndex = 4;
            this.Titlu.Text = "2048 Aplicatie Proiect";
            this.Titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // EXIT
            // 
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EXIT.ForeColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(349, 440);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(121, 49);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Titlu);
            this.Controls.Add(this.SETTINGS);
            this.Controls.Add(this.CREDITS);
            this.Controls.Add(this.START);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048 Aplicatie";
            this.Load += new System.EventHandler(this.Aplicatie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button START;
        private Button CREDITS;
        private Button SETTINGS;
        private Label Titlu;
        private Button EXIT;
    }
}