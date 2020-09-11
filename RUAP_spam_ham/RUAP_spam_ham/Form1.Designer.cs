namespace RUAP_spam_ham
{
    partial class Form1
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetection = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(296, 103);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(171, 226);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detection:";
            // 
            // lblDetection
            // 
            this.lblDetection.AutoSize = true;
            this.lblDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetection.Location = new System.Drawing.Point(88, 155);
            this.lblDetection.Name = "lblDetection";
            this.lblDetection.Size = new System.Drawing.Size(176, 29);
            this.lblDetection.TabIndex = 3;
            this.lblDetection.Text = "spam or ham?";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(72, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDetection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.rtbText);
            this.Name = "Form1";
            this.Text = "RUAP-spam-ham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetection;
        private System.Windows.Forms.Button btnReset;
    }
}

