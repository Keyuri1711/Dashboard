namespace Final_Project
{
    partial class tempconv
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
            this.fromctof = new System.Windows.Forms.RadioButton();
            this.fromftoc = new System.Windows.Forms.RadioButton();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.readfile = new System.Windows.Forms.Button();
            this.convetbtn = new System.Windows.Forms.Button();
            this.messagebox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fromctof
            // 
            this.fromctof.AutoSize = true;
            this.fromctof.Location = new System.Drawing.Point(172, 30);
            this.fromctof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromctof.Name = "fromctof";
            this.fromctof.Size = new System.Drawing.Size(96, 20);
            this.fromctof.TabIndex = 0;
            this.fromctof.TabStop = true;
            this.fromctof.Text = "From C to F";
            this.fromctof.UseVisualStyleBackColor = true;
            this.fromctof.CheckedChanged += new System.EventHandler(this.fromctof_CheckedChanged);
            // 
            // fromftoc
            // 
            this.fromftoc.AutoSize = true;
            this.fromftoc.Location = new System.Drawing.Point(172, 54);
            this.fromftoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromftoc.Name = "fromftoc";
            this.fromftoc.Size = new System.Drawing.Size(96, 20);
            this.fromftoc.TabIndex = 1;
            this.fromftoc.TabStop = true;
            this.fromftoc.Text = "From F to C";
            this.fromftoc.UseVisualStyleBackColor = true;
            this.fromftoc.CheckedChanged += new System.EventHandler(this.fromftoc_CheckedChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(64, 112);
            this.input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(129, 22);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(261, 112);
            this.output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(129, 22);
            this.output.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(442, 361);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(114, 41);
            this.exitbtn.TabIndex = 14;
            this.exitbtn.Text = "&Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // readfile
            // 
            this.readfile.Location = new System.Drawing.Point(235, 361);
            this.readfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readfile.Name = "readfile";
            this.readfile.Size = new System.Drawing.Size(132, 41);
            this.readfile.TabIndex = 13;
            this.readfile.Text = "&Read File";
            this.readfile.UseVisualStyleBackColor = true;
            this.readfile.Click += new System.EventHandler(this.readfile_Click);
            // 
            // convetbtn
            // 
            this.convetbtn.Location = new System.Drawing.Point(37, 361);
            this.convetbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.convetbtn.Name = "convetbtn";
            this.convetbtn.Size = new System.Drawing.Size(124, 41);
            this.convetbtn.TabIndex = 12;
            this.convetbtn.Text = "&Convert";
            this.convetbtn.UseVisualStyleBackColor = true;
            this.convetbtn.Click += new System.EventHandler(this.convetbtn_Click);
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(14, 192);
            this.messagebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messagebox.Name = "messagebox";
            this.messagebox.ReadOnly = true;
            this.messagebox.Size = new System.Drawing.Size(557, 132);
            this.messagebox.TabIndex = 15;
            this.messagebox.Text = "";
            this.messagebox.TextChanged += new System.EventHandler(this.messagebox_TextChanged);
            // 
            // tempconv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 433);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.readfile);
            this.Controls.Add(this.convetbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.fromftoc);
            this.Controls.Add(this.fromctof);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tempconv";
            this.Text = "keyuri dhorajiya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fromctof;
        private System.Windows.Forms.RadioButton fromftoc;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button readfile;
        private System.Windows.Forms.Button convetbtn;
        private System.Windows.Forms.RichTextBox messagebox;
    }
}