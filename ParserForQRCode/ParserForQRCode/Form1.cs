using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ParserForQRCode {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent ();
		}

		private void buttonParse_Click ( object sender , EventArgs e )
		{
			var req = WebRequest.Create(this.textBoxInputUrl.Text);
			string html = new StreamReader(req.GetResponse().GetResponseStream()).ReadToEnd();

			HtmlDocument htmlDocument;
			XmlDocument  doc = new XmlDocument();

			doc.LoadXml(html.Replace("&","").Replace("\n","").Replace("\r",""));
			var table = doc.GetElementsByTagName("table").Item(0);

			table.RemoveChild(table.FirstChild);

			var nodes =table.ChildNodes;

			string lastVersion = "-1";
			int rowCount = 0;

			XmlDocument document = new XmlDocument();

			StringBuilder str = new StringBuilder();

			foreach (XmlNode nodeTr in nodes)
			{
				str.Append( "new []{ ");
				//if (nodeTr.FirstChild.Attributes["rowspan"]!=null)
				//{
				//	lastVersion = nodeTr.FirstChild.FirstChild.Value;
				//}
				//else
				//{
				//	str.Append ( lastVersion + ", " );
				//}
				for (int i = 1; i < nodeTr.ChildNodes.Count-1; i++)
				{
					try {
						str.Append ( nodeTr.ChildNodes[i].FirstChild.Value + ", " );
					}
					catch ( NullReferenceException ) {
						
						
					}
				}

				try {
					str.Append ( nodeTr.ChildNodes[nodeTr.ChildNodes.Count - 1].FirstChild.Value + " }," );
				}
				catch ( NullReferenceException ) {
					
					str.Append ( " }," );
				}
				str.Append( System.Environment.NewLine);
			}

			this.textBoxOutput.Text = str.ToString ().Replace ( "QR Version " , "" );
			//this.textBoxOutput.Text = str.ToString();
		}
	}
}
