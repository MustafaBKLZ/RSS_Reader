using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rss_reader
{
    public partial class RSS_TekHaber : UserControl
    {
        public RSS_TekHaber()
        {
            InitializeComponent();
        }

        private void link_lbl_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link_lbl_url.Text);
        }

        private void pic_gorsel_DoubleClick(object sender, EventArgs e)
        {
            BuyukResim fr = new BuyukResim();
            fr.pictureBox1.Image = pic_gorsel.Image;
            fr.ShowDialog();
        }
    }
}
