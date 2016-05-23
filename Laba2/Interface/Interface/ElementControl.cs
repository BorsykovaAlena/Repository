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
    public partial class ElementControl : UserControl
    {
        private ComplexResistance elementModel;
        public ComplexResistance ElementModel
        {
            get
            {
                return elementModel;
            }
            set
            {
                elementModel = value;
            }
        }
        public ElementControl()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public ComplexResistance Console
        {
            get
            {
                ComplexResistance elementModel = null;
                if (ResistorButton.Checked)
                {
                    var resistance = new Resistor();
                    resistance.Resistance = Convert.ToInt32(textBox1.Text);

                    elementModel = resistance;
                }
                else if (IndykziaButton.Checked)
                {
                    var inductance = new Inductor();
                    inductance.Inductance = Convert.ToInt32(textBox2.Text);


                    elementModel = inductance;
                }
                else if (KondensatorButton.Checked)
                {
                    var condenser = new Capacitor();
                    condenser.Condenser = Convert.ToInt32(textBox3.Text);

                    elementModel = condenser;
                }

                return elementModel;
            }
            set 
            {
                if (value is Resistor) 
                {
                    var resistor = (Resistor)value;
                    ResistorButton.Checked = true;
                    textBox1.Text = resistor.Resistance.ToString();
                }
                else if (value is Inductor) 
                {
                    var inductance = (Inductor)value;
                    IndykziaButton.Checked = true;
                    textBox2.Text = inductance.Inductance.ToString();
                }
                else if (value is Capacitor)
                {
                    var condenser = (Capacitor)value;
                    KondensatorButton.Checked = true;
                    textBox3.Text = condenser.Condenser.ToString();
                }
            }
        } 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;  //видимый
            textBox2.Visible = false; //невидимый
            textBox3.Visible = false; //невидимый
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IndykziaButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false; //невидимый
            textBox2.Visible = true;  //видимый
            textBox3.Visible = false; //невидимый
        }

        private void KondensatorButton_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;  //невидимый
            textBox2.Visible = false;  //невидимый
            textBox3.Visible = true;  //видимый
        }

        private void ElementControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
