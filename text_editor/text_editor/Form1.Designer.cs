namespace text_editor
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
            this.rtb_main_text = new System.Windows.Forms.RichTextBox();
            this.b_save_text = new System.Windows.Forms.Button();
            this.b_open_text = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_main_text
            // 
            this.rtb_main_text.Location = new System.Drawing.Point(12, 24);
            this.rtb_main_text.Name = "rtb_main_text";
            this.rtb_main_text.Size = new System.Drawing.Size(784, 421);
            this.rtb_main_text.TabIndex = 0;
            this.rtb_main_text.Text = "";
            // 
            // b_save_text
            // 
            this.b_save_text.Location = new System.Drawing.Point(12, 2);
            this.b_save_text.Name = "b_save_text";
            this.b_save_text.Size = new System.Drawing.Size(75, 23);
            this.b_save_text.TabIndex = 1;
            this.b_save_text.Text = "button1";
            this.b_save_text.UseVisualStyleBackColor = true;
            this.b_save_text.Click += new System.EventHandler(this.b_save_text_Click);
            // 
            // b_open_text
            // 
            this.b_open_text.Location = new System.Drawing.Point(93, 2);
            this.b_open_text.Name = "b_open_text";
            this.b_open_text.Size = new System.Drawing.Size(75, 23);
            this.b_open_text.TabIndex = 2;
            this.b_open_text.Text = "button2";
            this.b_open_text.UseVisualStyleBackColor = true;
            this.b_open_text.Click += new System.EventHandler(this.b_open_text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_open_text);
            this.Controls.Add(this.b_save_text);
            this.Controls.Add(this.rtb_main_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_main_text;
        private System.Windows.Forms.Button b_save_text;
        private System.Windows.Forms.Button b_open_text;
    }
}

