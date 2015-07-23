namespace HextToText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hexInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hexOutput = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexInput
            // 
            this.hexInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexInput.Location = new System.Drawing.Point(0, 0);
            this.hexInput.Multiline = true;
            this.hexInput.Name = "hexInput";
            this.hexInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hexInput.Size = new System.Drawing.Size(802, 115);
            this.hexInput.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hexInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 115);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hexOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 382);
            this.panel2.TabIndex = 3;
            // 
            // hexOutput
            // 
            this.hexOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexOutput.Location = new System.Drawing.Point(0, 0);
            this.hexOutput.Multiline = true;
            this.hexOutput.Name = "hexOutput";
            this.hexOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hexOutput.Size = new System.Drawing.Size(802, 382);
            this.hexOutput.TabIndex = 4;
            // 
            // convertBtn
            // 
            this.convertBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convertBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(0, 115);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(802, 43);
            this.convertBtn.TabIndex = 4;
            this.convertBtn.Text = "Convert Above Hex\r\nOutput Is Displayed Below\r\n";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 540);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hex To Text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox hexInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox hexOutput;
        private System.Windows.Forms.Button convertBtn;
    }
}

