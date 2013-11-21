namespace ui.attrappe
{
    partial class UI
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
            this.txtZiffer = new System.Windows.Forms.TextBox();
            this.btnZiffer = new System.Windows.Forms.Button();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.btnOp = new System.Windows.Forms.Button();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZiffer
            // 
            this.txtZiffer.Location = new System.Drawing.Point(22, 19);
            this.txtZiffer.Name = "txtZiffer";
            this.txtZiffer.Size = new System.Drawing.Size(100, 20);
            this.txtZiffer.TabIndex = 0;
            this.txtZiffer.Text = "9";
            // 
            // btnZiffer
            // 
            this.btnZiffer.Location = new System.Drawing.Point(147, 12);
            this.btnZiffer.Name = "btnZiffer";
            this.btnZiffer.Size = new System.Drawing.Size(62, 32);
            this.btnZiffer.TabIndex = 1;
            this.btnZiffer.Text = "bei Zi";
            this.btnZiffer.UseVisualStyleBackColor = true;
            this.btnZiffer.Click += new System.EventHandler(this.btnZiffer_Click);
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(24, 56);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(97, 20);
            this.txtOp.TabIndex = 2;
            this.txtOp.Text = "+";
            // 
            // btnOp
            // 
            this.btnOp.Location = new System.Drawing.Point(147, 50);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(62, 32);
            this.btnOp.TabIndex = 3;
            this.btnOp.Text = "bei Op";
            this.btnOp.UseVisualStyleBackColor = true;
            this.btnOp.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(24, 115);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(48, 13);
            this.lblErgebnis.TabIndex = 4;
            this.lblErgebnis.Text = "Ergebnis";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 167);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.btnZiffer);
            this.Controls.Add(this.txtZiffer);
            this.Name = "UI";
            this.Text = "UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZiffer;
        private System.Windows.Forms.Button btnZiffer;
        private System.Windows.Forms.TextBox txtOp;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Label lblErgebnis;
    }
}