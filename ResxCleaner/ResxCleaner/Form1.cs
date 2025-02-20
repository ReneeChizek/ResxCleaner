using System.Net.Security;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ResxCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SortDataByName()
        {
            XDocument origDoc = workDoc;
            XDocument newDoc = new XDocument(
                new XElement(origDoc.Root.Name,
                    from comment in origDoc.Root.Nodes() where comment.NodeType == XmlNodeType.Comment select comment,
                    from schema in origDoc.Root.Elements() where schema.Name.LocalName == "schema" select schema,
                    from resheader in origDoc.Root.Elements("resheader") orderby (string)resheader.Attribute("name") select resheader,
                    from assembly in origDoc.Root.Elements("assembly") orderby (string)assembly.Attribute("name") select assembly,
                    from metadata in origDoc.Root.Elements("metadata") orderby (string)metadata.Attribute("name") select metadata,
                    from data in origDoc.Root.Elements("data") orderby (string)data.Attribute("name") select data
                )
            );

            workDoc = newDoc;
        }

        private Dictionary<string, List<XElement>> lst;
        private XDocument workDoc;
        private void LoadFile()
        {
            lst = new Dictionary<string, List<XElement>>();
            using (XmlReader inputStream = XmlReader.Create(openFileDialog1.FileName))
            {
                try
                {
                    // Create a linq XML document from the source.
                    workDoc = XDocument.Load(inputStream);


                    // Create a sorted version of the XML
                    //XDocument sortedDoc = SortDataByName(doc);
                    // Save it to the target
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        private void RemoveFullDuplicates()
        {
            XElement? prevElement = null;
            foreach(var element in workDoc.Root.Elements("data").ToList())
            {
                if (prevElement == null)
                {
                    prevElement = element;
                    continue;
                }
                else if(prevElement.Attribute("name").Value == element.Attribute("name").Value && prevElement.Value == element.Value)
                {
                    element.Remove();
                }
                else
                {
                    prevElement = element;
                }
            }
            //foreach (XElement element in workDoc.Root.Elements("data"))
            //{
            //    if (!lst.ContainsKey(element.Name.LocalName))
            //        lst.Add(element.Name.LocalName, new List<XElement>());
            //    lst[element.Name.LocalName].Add(element);
            //}
            //foreach (string key in lst.Keys)
            //{
            //    List<XElement> elements = lst[key];
            //    if (elements.Count > 1)
            //    { 
            //        var firstString = elements[0].Value;
            //        for (int i = 1; i < elements.Count; i++)
            //        {
            //            if (elements[i].Value == firstString)
            //            {
            //               // doc.Root.Elements("data").Where()
            //            }
            //        }
            //    }
            //}
        }
        private void PopulateForm()
        {

        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                lblFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                lblFilename.Text = Path.GetFileName(openFileDialog1.FileName);
                LoadFile();
                SortDataByName();
                RemoveFullDuplicates();
                PopulateForm();
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
//            XmlReader inputStream = XmlReader.Create(openFileDialog1.FileName);
                //XmlWriter xmlWriter = XmlWriter.Create(openFileDialog1.FileName);
            //xmlWriter.W
            workDoc.Save(openFileDialog1.FileName);
            btnSave.Enabled=false;

        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            var help = new HelpForm();
            help.ShowDialog();
        }
    }
}
