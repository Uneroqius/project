using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolkek
{
public partial class Form1 : Form
{


public Form1()
{
InitializeComponent();
}

public void _1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
{
this.Validate();
this._1BindingSource.EndEdit();
this.tableAdapterManager.UpdateAll(this.courseDataSet);

}

public void Form1_Load(object sender, EventArgs e)
{
// TODO: данная строка кода позволяет загрузить данные в таблицу "courseDataSet._1". При необходимости она может быть перемещена или удалена.
this._1TableAdapter.Fill(this.courseDataSet._1);

}

public void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
{
Close();
}

public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
{
courseDataSet._1.Clear();
try
{
if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
courseDataSet.ReadXml(openFileDialog1.FileName);
}
catch (ArgumentException)
{
MessageBox.Show("Error");
}
}

public void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
{
try
{
if (saveFileDialog1.ShowDialog() == DialogResult.OK) MessageBox.Show("Ok");
courseDataSet.WriteXml(saveFileDialog1.FileName);
}
catch (ArgumentException){
MessageBox.Show("Error");
}
}

public void поискToolStripMenuItem_Click(object sender, EventArgs e){
Form2 f = new Form2();
f.Owner = this;
f.Show();
}

public void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e){
Form3 f1 = new Form3();
f1.Owner = this;
f1.Show();
}
}
}
