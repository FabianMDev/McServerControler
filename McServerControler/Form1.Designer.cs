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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleOut
            // 
            this.ConsoleOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleOut.HideSelection = false;
            this.ConsoleOut.Location = new System.Drawing.Point(12, 12);
            this.ConsoleOut.Name = "ConsoleOut";
            this.ConsoleOut.ReadOnly = true;
            this.ConsoleOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ConsoleOut.Size = new System.Drawing.Size(829, 518);
            this.ConsoleOut.TabIndex = 0;
            this.ConsoleOut.Text = "";
            // 
            // ConsoleIn
            // 
            this.ConsoleIn.Location = new System.Drawing.Point(0, 548);
            this.ConsoleIn.Name = "ConsoleIn";
            this.ConsoleIn.Size = new System.Drawing.Size(841, 23);
            this.ConsoleIn.TabIndex = 1;
            this.ConsoleIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsoleIn_KeyPress);
            // 
            // buttonstart
            // 
            this.buttonstart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonstart.Location = new System.Drawing.Point(0, 0);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(89, 23);
            this.buttonstart.TabIndex = 2;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonstart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 571);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsoleIn);
            this.Controls.Add(this.ConsoleOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox ConsoleOut;
        private TextBox ConsoleIn;
        private Button buttonstart;
        private Panel panel1;
    }
}