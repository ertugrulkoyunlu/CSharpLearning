using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
namespace Xml
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings ayarlar = new XmlWriterSettings();
            ayarlar.Indent = true;
            ayarlar.IndentChars = "   ";
            XmlWriter yazici = XmlWriter.Create(Server.MapPath("xmlYeniDosya.xml"), ayarlar);
            yazici.WriteStartDocument();
            yazici.WriteComment("xml kitaplar listesi");
            yazici.WriteStartElement("kitaplar");

            yazici.WriteStartElement("kitap");
            yazici.WriteElementString("numara", "1");
            yazici.WriteElementString("ad", "nutuk");
            yazici.WriteElementString("yazar", "M. Kemal ataturk");
            yazici.WriteElementString("yayinevi", "Kanarya");
            yazici.WriteEndElement();

            yazici.WriteStartElement("kitap");
            yazici.WriteElementString("numara", "2");
            yazici.WriteElementString("ad", "Mesnevi'den secmeler");
            yazici.WriteElementString("yazar", "Mevlana Celalettin Rumi");
            yazici.WriteElementString("yayinevi", "Keklik");
            yazici.WriteEndElement();
            yazici.WriteEndElement();
            yazici.Close();
            Response.Write("xml dosyasi yazdirldi");

        }
    }
}