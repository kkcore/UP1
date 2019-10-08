namespace UP1
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
            this.playSound_button = new System.Windows.Forms.Button();
            this.directSound_Button = new System.Windows.Forms.Button();
            this.readbytes_button = new System.Windows.Forms.Button();
            this.wavHeader_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playSound_button
            // 
            this.playSound_button.Location = new System.Drawing.Point(675, 12);
            this.playSound_button.Name = "playSound_button";
            this.playSound_button.Size = new System.Drawing.Size(113, 59);
            this.playSound_button.TabIndex = 0;
            this.playSound_button.Text = "PlaySound func";
            this.playSound_button.UseVisualStyleBackColor = true;
            this.playSound_button.Click += new System.EventHandler(this.PlaySound_button_Click);
            // 
            // directSound_Button
            // 
            this.directSound_Button.Location = new System.Drawing.Point(537, 12);
            this.directSound_Button.Name = "directSound_Button";
            this.directSound_Button.Size = new System.Drawing.Size(101, 59);
            this.directSound_Button.TabIndex = 1;
            this.directSound_Button.Text = "DirectSound";
            this.directSound_Button.UseVisualStyleBackColor = true;
            this.directSound_Button.Click += new System.EventHandler(this.DirectSound_Button_Click);
            // 
            // readbytes_button
            // 
            this.readbytes_button.Location = new System.Drawing.Point(414, 12);
            this.readbytes_button.Name = "readbytes_button";
            this.readbytes_button.Size = new System.Drawing.Size(101, 59);
            this.readbytes_button.TabIndex = 2;
            this.readbytes_button.Text = "Read wav Bytes";
            this.readbytes_button.UseVisualStyleBackColor = true;
            this.readbytes_button.Click += new System.EventHandler(this.Readbytes_button_Click);
            // 
            // wavHeader_textBox
            // 
            this.wavHeader_textBox.Location = new System.Drawing.Point(42, 28);
            this.wavHeader_textBox.Multiline = true;
            this.wavHeader_textBox.Name = "wavHeader_textBox";
            this.wavHeader_textBox.Size = new System.Drawing.Size(199, 74);
            this.wavHeader_textBox.TabIndex = 3;
            this.wavHeader_textBox.Text = "There should be wav header values.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wavHeader_textBox);
            this.Controls.Add(this.readbytes_button);
            this.Controls.Add(this.directSound_Button);
            this.Controls.Add(this.playSound_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playSound_button;
        private System.Windows.Forms.Button directSound_Button;
        private System.Windows.Forms.Button readbytes_button;
        private System.Windows.Forms.TextBox wavHeader_textBox;
    }
}

