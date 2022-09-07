using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace RSSileinternettenHaberBaşlıklarıÇekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void habergetir(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            habergetir(" http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            habergetir("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            habergetir("http://www.fotomac.com.tr/rss/anasayfa.xml");
        }
    }
}
