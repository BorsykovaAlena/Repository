using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console;
using Variant7Borsukova;

namespace Interface
{
    public partial class HelpForm : Form
    {
        private ElementControl ElementControl = new ElementControl();
        public HelpForm()
        {
            InitializeComponent();
            this.Controls.Add(ElementControl);
        }
        public ComplexResistance Console { get { return ElementControl.Console; } set { ElementControl.Console = value; } }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
