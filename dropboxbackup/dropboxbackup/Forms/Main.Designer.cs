namespace dropboxbackup.Forms
{
    partial class Main
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.BackUp = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseWaitCursor = true;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(365, 34);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.UseWaitCursor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // BackUp
            // 
            this.BackUp.Location = new System.Drawing.Point(12, 128);
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(75, 23);
            this.BackUp.TabIndex = 3;
            this.BackUp.Text = "Back Up!";
            this.BackUp.UseVisualStyleBackColor = true;
            this.BackUp.UseWaitCursor = true;
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(365, 128);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(75, 23);
            this.Options.TabIndex = 4;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.UseWaitCursor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 163);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.BackUp);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textBox1);
            this.Name = "Main";
            this.Text = "Dropbox Backup";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button BackUp;
        private System.Windows.Forms.Button Options;
    }
}

