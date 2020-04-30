namespace Sharp_API_Client
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
            this.GoBtn = new System.Windows.Forms.Button();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(397, 323);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(146, 52);
            this.GoBtn.TabIndex = 0;
            this.GoBtn.Text = "Получить данные";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(52, 45);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(18, 13);
            this.Idlabel.TabIndex = 1;
            this.Idlabel.Text = "ID";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Location = new System.Drawing.Point(55, 75);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(27, 13);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "Title";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(58, 118);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(485, 179);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 413);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.GoBtn);
            this.Name = "Form1";
            this.Text = "Sharp Api";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.TextBox textBox;
    }
}

