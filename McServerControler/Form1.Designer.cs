namespace McServerControler
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
            this.ConsoleOut = new System.Windows.Forms.RichTextBox();
            this.ConsoleIn = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsoleOut
            // 
            this.ConsoleOut.Location = new System.Drawing.Point(12, 12);
            this.ConsoleOut.Name = "ConsoleOut";
            this.ConsoleOut.Size = new System.Drawing.Size(627, 495);
            this.ConsoleOut.TabIndex = 0;
            this.ConsoleOut.Text = "";
            // 
            // ConsoleIn
            // 
            this.ConsoleIn.Location = new System.Drawing.Point(12, 513);
            this.ConsoleIn.Name = "ConsoleIn";
            this.ConsoleIn.Size = new System.Drawing.Size(627, 23);
            this.ConsoleIn.TabIndex = 1;
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(849, 11);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 2;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.ConsoleIn);
            this.Controls.Add(this.ConsoleOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox ConsoleOut;
        private TextBox ConsoleIn;
        private Button buttonstart;
    }
}