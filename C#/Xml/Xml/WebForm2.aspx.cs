using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;


namespace Xml
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(MapPath("~/XMLFile1.xml"));
            
            XmlNodeList dugumler=xmlDoc.SelectNodes("kitaplar/kitap/yazarlar[yazar='M. Akif Ersoy']");
            XmlNode parentdugum;
            Label1.Text= "M. Akif Ersoyun Kitaplari <br/>";
            foreach(XmlNode dugum in dugumler)
            {
                parentdugum=dugum.ParentNode;
                Label1.Text+=parentdugum.InnerText+"<br/>";
            }
        }
    }
}