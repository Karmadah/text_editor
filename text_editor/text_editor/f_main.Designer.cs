namespace text_editor
{
    partial class f_main
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
            this.b_update_font = new System.Windows.Forms.Button();
            this.cb_font_size = new System.Windows.Forms.ComboBox();
            this.t_small_text = new System.Windows.Forms.Label();
            this.t_medium_text = new System.Windows.Forms.Label();
            this.t_large_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_main_text
            // 
            this.rtb_main_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_main_text.Location = new System.Drawing.Point(6, 38);
            this.rtb_main_text.Name = "rtb_main_text";
            this.rtb_main_text.Size = new System.Drawing.Size(791, 388);
            this.rtb_main_text.TabIndex = 0;
            this.rtb_main_text.Text = "";
            // 
            // b_save_text
            // 
            this.b_save_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save_text.Location = new System.Drawing.Point(2, 2);
            this.b_save_text.Name = "b_save_text";
            this.b_save_text.Size = new System.Drawing.Size(93, 30);
            this.b_save_text.TabIndex = 1;
            this.b_save_text.Text = "SAVE";
            this.b_save_text.UseVisualStyleBackColor = true;
            this.b_save_text.Click += new System.EventHandler(this.b_save_text_Click);
            // 
            // b_open_text
            // 
            this.b_open_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_open_text.Location = new System.Drawing.Point(97, 2);
            this.b_open_text.Name = "b_open_text";
            this.b_open_text.Size = new System.Drawing.Size(700, 30);
            this.b_open_text.TabIndex = 2;
            this.b_open_text.Text = "OPEN";
            this.b_open_text.UseVisualStyleBackColor = true;
            this.b_open_text.Click += new System.EventHandler(this.b_open_text_Click);
            // 
            // b_update_font
            // 
            this.b_update_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_update_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_update_font.Location = new System.Drawing.Point(722, 425);
            this.b_update_font.Name = "b_update_font";
            this.b_update_font.Size = new System.Drawing.Size(75, 21);
            this.b_update_font.TabIndex = 3;
            this.b_update_font.Text = "button1";
            this.b_update_font.UseVisualStyleBackColor = true;
            this.b_update_font.Click += new System.EventHandler(this.b_update_font_Click);
            // 
            // cb_font_size
            // 
            this.cb_font_size.FormattingEnabled = true;
            this.cb_font_size.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cb_font_size.Location = new System.Drawing.Point(595, 425);
            this.cb_font_size.Name = "cb_font_size";
            this.cb_font_size.Size = new System.Drawing.Size(121, 21);
            this.cb_font_size.TabIndex = 4;
            // 
            // t_small_text
            // 
            this.t_small_text.AutoSize = true;
            this.t_small_text.Location = new System.Drawing.Point(53, 433);
            this.t_small_text.Name = "t_small_text";
            this.t_small_text.Size = new System.Drawing.Size(42, 13);
            this.t_small_text.TabIndex = 5;
            this.t_small_text.Text = "SMALL";
            // 
            // t_medium_text
            // 
            this.t_medium_text.AutoSize = true;
            this.t_medium_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_medium_text.Location = new System.Drawing.Point(240, 429);
            this.t_medium_text.Name = "t_medium_text";
            this.t_medium_text.Size = new System.Drawing.Size(69, 18);
            this.t_medium_text.TabIndex = 6;
            this.t_medium_text.Text = "MEDIUM";
            // 
            // t_large_text
            // 
            this.t_large_text.AutoSize = true;
            this.t_large_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_large_text.Location = new System.Drawing.Point(413, 425);
            this.t_large_text.Name = "t_large_text";
            this.t_large_text.Size = new System.Drawing.Size(73, 24);
            this.t_large_text.TabIndex = 7;
            this.t_large_text.Text = "LARGE";
            // 
            // f_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t_large_text);
            this.Controls.Add(this.t_medium_text);
            this.Controls.Add(this.t_small_text);
            this.Controls.Add(this.cb_font_size);
            this.Controls.Add(this.b_update_font);
            this.Controls.Add(this.b_open_text);
            this.Controls.Add(this.b_save_text);
            this.Controls.Add(this.rtb_main_text);
            this.Name = "f_main";
            this.Text = "SIMPLE TEXT EDITOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_main_text;
        private System.Windows.Forms.Button b_save_text;
        private System.Windows.Forms.Button b_open_text;
        private System.Windows.Forms.Button b_update_font;
        private System.Windows.Forms.ComboBox cb_font_size;
        private System.Windows.Forms.Label t_small_text;
        private System.Windows.Forms.Label t_medium_text;
        private System.Windows.Forms.Label t_large_text;
    }
}

