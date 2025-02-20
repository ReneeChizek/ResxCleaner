using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResxCleaner
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Tool is in early stages. Hoping to have it process files and send to WinMerge (or even a configurable merge tool) so the whole process can be done in one app. For now it just sorts, removes dups and allows saving back to original file. Then merge tool can be used.\r\n\r\nWhat I do now is grab the 2 files as they currently exist in both branches (before merge). This can be done during the merge process since you can copy all from both sides of the merge. Save these files to a temp directory with one name devint.resx and the other something like branch.resx. \r\n\r\nUse tool one both files, one at a time. Select File then Save. File will be updated with sorted and cleaned resx. The 2 files can then be compared in the prefered merge tool and conflicts resolved here. Then take the resulting file and replace contents of conflicting file with cleaned data.";
        }
    }
}
