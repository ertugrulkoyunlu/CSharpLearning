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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XPathDocument doc= new XPathDocument(MapPath("~/XMLFile1.xml"));
            Console.WriteLine("adsad");
            XPathNavigator gezgin= doc.CreateNavigator();
            XPathNodeIterator dugumkitapadi=gezgin.Select("/kitaplar/kitap/ad");
            while(dugumkitapadi.MoveNext())
            {   
                Label1.Text+="<br>"+dugumkitapadi.Current.ToString();
            }
            XPathNodeIterator dugumler=gezgin.Select("kitaplar/kitap[fiyat>=50 and fiyat<=80]");
            while(dugumler.MoveNext())
            {
                Label2.Text+=dugumler.Current.ToString()+"<br/>";
            }
            Label3.Text+=gezgin.Evaluate("count(kitaplar/kitap[fiyat>60])").ToString();
        }
    }
}