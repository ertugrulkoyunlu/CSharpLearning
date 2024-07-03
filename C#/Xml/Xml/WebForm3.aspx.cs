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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument doc = new XPathDocument(MapPath("~/XMLFile1.xml"));
            XPathNavigator gezgin = doc.CreateNavigator();
            XPathNodeIterator dugumkitapadi = gezgin.Select("kitaplar/kitap/ad");
            while (dugumkitapadi.MoveNext())
            {
                Label1.Text += dugumkitapadi.Current.ToString();
            }
            XPathNodeIterator dugumler = gezgin.Select("kitaplar/kitap[fiyat>40 and fiyat<=85]");
            while (dugumler.MoveNext())
            {
                XPathNodeIterator cocukdugumler = dugumler.Current.SelectChildren(XPathNodeType.Element);
                if (cocukdugumler.Current.Name == "yazarlar")
                {
                    XPathNodeIterator yazardugum = cocukdugumler.Current.SelectChildren(XPathNodeType.Element);
                    while (yazardugum.MoveNext())
                    {
                        Label2.Text += "<br/>" + yazardugum.Current.Value + ",";
                    }
                }
                else
                {
                    Label2.Text+="<br/>"+cocukdugumler.Current.Value +" ";
                }
            }
        }
    }
}