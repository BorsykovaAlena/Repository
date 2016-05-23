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
using Newtonsoft;
using System.IO;
using Variant7Borsukova;
using System.Numerics;


namespace Interface
{
    public partial class MainForm : Form
    {
        
        private DataTable _elementtable;
        private ElementControl _elementControl = new ElementControl();
        private List<ComplexResistance> elementList = new List<ComplexResistance>();
        public MainForm()
       
        {
            InitializeComponent();
            CreateColumns();
        }
            private void CreateColumns()
            {
                _elementtable = new DataTable();
                var column1 = new DataColumn("Элемент")
                {
                    Caption = "Element",
                    DataType = typeof(string),
                    ReadOnly = true
                };
                var column2 = new DataColumn("Значение")
                {
                    Caption = "Value",
                    DataType = typeof(Complex),
                    ReadOnly = true
                };

                _elementtable.Columns.Add(column1);
                _elementtable.Columns.Add(column2);
                dataGridView1.DataSource = _elementtable;
            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            var form3 = new HelpForm();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                var element = form3.Console;
                elementList.Add(element);
                var row = _elementtable.NewRow();
                row[0] = element.ToString();
                row[1] = element.CalculateVolume(Convert.ToDouble(textBox1.Text));
                _elementtable.Rows.Add(row);
                dataGridView1.Update();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         //Изменить
        private void Modify_Click(object sender, EventArgs e)
        {
            var form3 = new HelpForm();
            var currentIndex = dataGridView1.CurrentRow.Index;
            form3.Console = elementList[currentIndex];
            elementList.RemoveAt(currentIndex);
            _elementtable.Rows.RemoveAt(currentIndex);
            if (form3.ShowDialog() == DialogResult.OK)
            {
                var element = form3.Console;
                elementList.Add(element);
                var row = _elementtable.NewRow();
                row[0] = element.ToString();
                row[1] = element.CalculateVolume(Convert.ToDouble(textBox1.Text));
                _elementtable.Rows.Add(row);
                dataGridView1.Update();

            }
            //if (dataGridView1.CurrentRow != null)
            //{
            //    _elementControl.ElementModel = elementList[dataGridView1.CurrentRow.Index]; 
            //    _elementControl.Show(); 
            //    elementList[dataGridView1.CurrentRow.Index] = _elementControl.ElementModel;
            //    //CreateColumns();
            //    _elementControl.ElementModel = null; 
            //}
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            _elementtable.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainMenu Menu = new MainMenu();
            //MenuItem m1 = new MenuItem("Меню"); 
            //Menu.MenuItems.Add(m1);
            //MenuItem subm1 = new MenuItem("Открыть");
            //m1.MenuItems.Add(subm1);
            //MenuItem subm2 = new MenuItem("Сохранить");
            //m1.MenuItems.Add(subm2);
            //MenuItem subm3 = new MenuItem("Выйти");
            //m1.MenuItems.Add(subm3);

            //subm1.Click += new EventHandler(открытьToolStripMenuItem);
            //subm2.Click += new EventHandler(сохранитьToolStripMenuItem);
            //subm3.Click += new EventHandler(выйтиToolStripMenuItem);
            
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
           {
               TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
           };
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Element |*.myfile";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = openFileDialog.FileName;
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (Newtonsoft.Json.JsonReader jreader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    elementList = serializer.Deserialize<List<ComplexResistance>>(jreader);
                }
                _elementtable.Rows.Clear();
                for (int i = 0; i < elementList.Count; i++)
                {
                    var element = elementList[i];
                    var row = _elementtable.NewRow();
                    row[0] = element.ToString();
                    row[1] = element.CalculateVolume(Convert.ToDouble(textBox1.Text));
                    _elementtable.Rows.Add(row);
                }
                dataGridView1.Update();
            }
        }

           
    

        //Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Element |@*.myfile";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = saveFileDialog.FileName;
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (Newtonsoft.Json.JsonWriter jwriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jwriter, elementList);
                }
                MessageBox.Show("Сохранено!");
            }
        }

        //Выйти
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Остановить программу?",
            "Завершение",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _elementtable.Rows.Clear();
            for (int i = 0; i < elementList.Count; i++)
            {
                var element = elementList[i];
                var row = _elementtable.NewRow();
                row[0] = element.ToString();
                row[1] = Convert.ToString(element.CalculateVolume(Convert.ToDouble(textBox1.Text)));
                _elementtable.Rows.Add(row);
            };
            dataGridView1.Refresh();
        }
    }
}
