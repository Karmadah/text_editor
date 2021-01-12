using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace text_editor
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void b_save_text_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, rtb_main_text.Text);
            }
        }

        private void b_open_text_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtb_main_text.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void b_update_font_Click(object sender, EventArgs e)
        {
            switch(cb_font_size.SelectedIndex)
            {
                case 0:
                    rtb_main_text.Font = t_small_text.Font;
                    break;

                case 1:
                    rtb_main_text.Font = t_medium_text.Font;
                    break;

                case 2:
                    rtb_main_text.Font = t_large_text.Font;
                    break;
            }
        }
    }
}
