using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

			//html = Regex.Match(html, @"/^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$/").Value;
			doc.LoadXml(html.Replace("\n","").Replace("\r",""));
			var table = doc.GetElementsByTagName("table").Item(0);


			var nodes =table.FirstChild.ChildNodes;

			string lastVersion = "-1";
			int rowCount = 0;

			XmlDocument document = new XmlDocument();

			StringBuilder str = new StringBuilder();

			foreach (XmlNode nodeTr in nodes)
			{
				str.Append( "{ ");
				str.Append ( System.Environment.NewLine );
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
						str.Append ( "MaskPatterns.Pattern"+nodeTr.ChildNodes[i].FirstChild.Value + ", " );
					}
					catch ( NullReferenceException ) {
						
						
					}
				}


				str.Append ( System.Environment.NewLine );
				try {
					str.Append ("new bool[] {"+ nodeTr.ChildNodes[nodeTr.ChildNodes.Count - 1].FirstChild.Value.Replace("0","false, ").Replace("1","true,")+"}" + System.Environment.NewLine+ " },");
				}
				catch ( NullReferenceException ) {

					str.Append ( System.Environment.NewLine );
					str.Append ( " }," );
				}
				str.Append( System.Environment.NewLine);
			}

			this.textBoxOutput.Text = str.ToString ().Replace ( "QR Version " , "" );
			//this.textBoxOutput.Text = str.ToString();
		}
	}
}
