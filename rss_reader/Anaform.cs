using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

using CodeHollow.FeedReader;

namespace rss_reader
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        private void Anaform_Load(object sender, EventArgs e)
        {
            // https://github.com/codehollow/FeedReader
            listBox1.Items.Add("https://mustafabukulmez.com/rss");
            listBox1.Items.Add("https://dinamiknetwork.com/rss/");
            listBox1.Items.Add("https://kursbil.com/feed/");
            listBox1.Items.Add("https://figurex.net/feed/");
            listBox1.Items.Add("https://www.hurriyet.com.tr/rss/anasayfa");
            listBox1.Items.Add("https://www.youtube.com/feeds/videos.xml?channel_id=UCguHtRRt-FX2CnxfMW-pW8A");
        }
        private void btn_getir_Click(object sender, EventArgs e)
        {
            Get_RSS();
        }
        async void Get_RSS()
        {
            string feedUrl = listBox1.Items[listBox1.SelectedIndex].ToString();

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            var xNamespace = xDocument.Root.GetDefaultNamespace();
            int index = 0;
            foreach (var item in feed.Items)
            {
                var baseFeedItem = item.SpecificItem;
                string thumbnail = null;
                if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                {
                    thumbnail = baseFeedItem.Element.Descendants().First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url").Value;
                }
                index++;
                RSS_TekHaber rss = new RSS_TekHaber();
                rss.lbl_index.Text = index.ToString() + ".";
                rss.lbl_baslik.Text = ClearText(item.Title);
                rss.txt_aciklama.Text = ClearText(item.Description);
                rss.link_lbl_url.Text = item.Link;
                rss.lbl_Tarih.Text = item.PublishingDateString;
                rss.pic_gorsel.ImageLocation = thumbnail;
                rss.Margin = new Padding(0, -7, 0, 0);
                flowLayoutPanel1.Controls.Add(rss);
            }
        }
        string ClearText(string text)
        {
            try
            {
                return text.Replace("&#46;", "").Replace("<p>", "").Replace("</p>", "").Replace("<a>", "").Replace("</a>", "").Replace("&#8217;", "").Replace("[&#8230;]", "")
                     .Replace("<a rel=", "").Replace("nofollow", "").Replace("href=", "").Replace(">", "").Replace('"', ' ')
                     ;
            }
            catch (NullReferenceException ex)
            {
                return "Açıklama Bulunamadı";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }

}
