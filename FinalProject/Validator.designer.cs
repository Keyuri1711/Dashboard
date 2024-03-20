namespace FinalProject
{
    partial class Validator
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.validateip = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter IP address: ";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(267, 133);
            this.inputbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(368, 22);
            this.inputbox.TabIndex = 2;
            // 
            // validateip
            // 
            this.validateip.Location = new System.Drawing.Point(51, 322);
            this.validateip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateip.Name = "validateip";
            this.validateip.Size = new System.Drawing.Size(187, 67);
            this.validateip.TabIndex = 3;
            this.validateip.Text = "Validate IP";
            this.validateip.UseVisualStyleBackColor = true;
            this.validateip.Click += new System.EventHandler(this.validateip_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(260, 322);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(187, 67);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(476, 322);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(187, 67);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.validateip);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Validator";
            this.Text = "keyuri dhorajiya";
            this.Load += new System.EventHandler(this.IP4_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button validateip;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label2;
    }
}