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
public partial class Form3 : Form
{

public Form3()
{
InitializeComponent();


}

private void button3_Click(object sender, EventArgs e)
{
Close();
}

private void button2_Click(object sender, EventArgs e)
{
Form1 main = this.Owner as Form1;
main._1BindingSource.RemoveFilter();
}

private void button1_Click(object sender, EventArgs e)
{

Form1 main = this.Owner as Form1;
try
{
string s = comboBox1.Text;
if (s == main.courseDataSet._1.НазваниеColumn.ColumnName)
s += " = '" + textBox1.Text + "'";
if (s == main.courseDataSet._1.РайонColumn.ColumnName)
s = "[Район] = '" + textBox1.Text + "'";
if (s == main.courseDataSet._1.АдресColumn.ColumnName)
s = "[Адрес] = '" + textBox1.Text + "'";
if (s == main.courseDataSet._1.МетроColumn.ColumnName)
s = "[Метро] = '" + textBox1.Text + "'";
if (s == main.courseDataSet._1.Тип_магазинаColumn.ColumnName)
s = "[Тип магазина] = '" + textBox1.Text + "'";

main._1BindingSource.Filter = s;
}
catch { MessageBox.Show("Error"); }

}
}
}

