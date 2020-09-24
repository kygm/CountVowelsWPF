namespace CountVowels
{
    partial class frmMain
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnShowVowels = new System.Windows.Forms.Button();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(20, 13);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(306, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a sentence to calculate number of vowels";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 54);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(294, 139);
            this.txtInput.TabIndex = 1;
            // 
            // btnShowVowels
            // 
            this.btnShowVowels.Location = new System.Drawing.Point(40, 220);
            this.btnShowVowels.Name = "btnShowVowels";
            this.btnShowVowels.Size = new System.Drawing.Size(110, 53);
            this.btnShowVowels.TabIndex = 2;
            this.btnShowVowels.Text = "Show amount of vowels";
            this.btnShowVowels.UseVisualStyleBackColor = true;
            this.btnShowVowels.Click += new System.EventHandler(this.btnShowVowels_Click);
            // 
            // txtVowels
            // 
            this.txtVowels.Location = new System.Drawing.Point(160, 230);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.ReadOnly = true;
            this.txtVowels.Size = new System.Drawing.Size(67, 22);
            this.txtVowels.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(233, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 53);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 323);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.btnShowVowels);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmMain";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnShowVowels;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Button btnClear;
    }
}

