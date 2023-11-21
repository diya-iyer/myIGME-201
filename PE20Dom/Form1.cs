using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            // Objective 8: Change the .InnerText of the first <h1> to "My UFO Page"
            HtmlElement h1Element = webBrowser1.Document.GetElementsByTagName("h1")[0];
            h1Element.InnerText = "My UFO Page";

            // Objective 9: Change the .InnerText of the first <h2> to "My UFO Info"
            HtmlElement h2Element1 = webBrowser1.Document.GetElementsByTagName("h2")[0];
            h2Element1.InnerText = "My UFO Info";

            // Objective 10: Change the .InnerText of the 2nd <h2> to "My UFO Pictures"
            HtmlElement h2Element2 = webBrowser1.Document.GetElementsByTagName("h2")[1];
            h2Element2.InnerText = "My UFO Pictures";

            // Objective 11: Change the .InnerText of the 3rd <h2> to an empty string - ""
            HtmlElement h2Element3 = webBrowser1.Document.GetElementsByTagName("h2")[2];
            h2Element3.InnerText = "";

            // Objective 12: Select the <body> element and make 2 style changes
            HtmlElement bodyElement = webBrowser1.Document.Body;
            bodyElement.Style = "font-family: sans-serif; color: #FF5555"; // "reddish" color in hexadecimal

            // Objective 13: Select the first paragraph and make changes
            HtmlElement pElement = webBrowser1.Document.GetElementsByTagName("p")[0];
            pElement.InnerHtml = "Report your UFO sightings here: <a href=\"http://www.nuforc.org\">http://www.nuforc.org</a>";
            pElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

            // Objective 14: Change the .InnerText of the 2nd paragraph to an empty string - ""
            HtmlElement pElement2 = webBrowser1.Document.GetElementsByTagName("p")[1];
            pElement2.InnerText = "";

            // Objective 15: Insert an <img> element in the beginning of the 3rd paragraph
            HtmlElement imgElement = webBrowser1.Document.CreateElement("img");
            imgElement.SetAttribute("src", "https://www.seti.org/sites/default/files/styles/original/public/2023-07/antique-UAP-envato-1200px.jpg?itok=ZpMp2_V4"); 
            webBrowser1.Document.GetElementsByTagName("p")[2].InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, imgElement);

            // Objective 16: Add a footer element to the end of the page
            HtmlElement footerElement = webBrowser1.Document.CreateElement("footer");
            footerElement.InnerText = $"&copy; 2023 Diya Iyer"; 
            webBrowser1.Document.Body.AppendChild(footerElement);
        }

    }
}
