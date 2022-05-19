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
public partial class Form2 : Form
{
BindingSource bs = new BindingSource();

public Form2()
{
InitializeComponent();
}

private void button1_Click(object sender, EventArgs e)
{//Название
Form1 main = this.Owner as Form1;
if (main != null)
{
for(int i = 0; i < main._1DataGridView.Rows.Count; i++)
{
main._1DataGridView.Rows[i].Selected = false;
for(int j = 0; j < main._1DataGridView.Columns.Count; j++)
{
if (main._1DataGridView.Rows[i].Cells[j].Value != null) {
if (main._1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
{
main._1DataGridView.Rows[i].Selected = true;
break;
}
}
}
}
}
}

private void button2_Click(object sender, EventArgs e)
{
Form1 main = this.Owner as Form1;
if (main != null)
{
for (int i = 0; i < main._1DataGridView.Rows.Count; i++)
{
main._1DataGridView.Rows[i].Selected = false;
for (int j = 0; j < main._1DataGridView.Columns.Count; j++)
{
if (main._1DataGridView.Rows[i].Cells[j].Value != null)
{
if (main._1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
{
main._1DataGridView.Rows[i].Selected = true;
break;
}
}
}
}
}
}

private void button3_Click(object sender, EventArgs e)
{
Form1 main = this.Owner as Form1;
if (main != null)
{
for (int i = 0; i < main._1DataGridView.Rows.Count; i++)
{
main._1DataGridView.Rows[i].Selected = false;
for (int j = 0; j < main._1DataGridView.Columns.Count; j++)
{
if (main._1DataGridView.Rows[i].Cells[j].Value != null)
{
if (main._1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
{
main._1DataGridView.Rows[i].Selected = true;
break;
}
}
}
}
}
}

private void button4_Click(object sender, EventArgs e)
{
Form1 main = this.Owner as Form1;
if (main != null)
{
for (int i = 0; i < main._1DataGridView.Rows.Count; i++)
{
main._1DataGridView.Rows[i].Selected = false;
for (int j = 0; j < main._1DataGridView.Columns.Count; j++)
{
if (main._1DataGridView.Rows[i].Cells[j].Value != null)
{
if (main._1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
{
main._1DataGridView.Rows[i].Selected = true;
break;
}
}
}
}
}
}

private void button5_Click(object sender, EventArgs e)
{
Form1 main = this.Owner as Form1;
if (main != null)
{
for (int i = 0; i < main._1DataGridView.Rows.Count; i++)
{
main._1DataGridView.Rows[i].Selected = false;
for (int j = 0; j < main._1DataGridView.Columns.Count; j++)
{
if (main._1DataGridView.Rows[i].Cells[j].Value != null)
{
if (main._1DataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
{
main._1DataGridView.Rows[i].Selected = true;
break;
}
}
}
}
}
}

private void button6_Click(object sender, EventArgs e)
{
Close();
}
}}
