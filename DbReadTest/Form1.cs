using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DbReadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказчики' table. You can move, or remove it, as needed.
            this.заказчикиTableAdapter.Fill(this.заказыDataSet.Заказчики);
            // TODO: This line of code loads data into the 'заказыDataSet.Предметы' table. You can move, or remove it, as needed.
            this.предметыTableAdapter.Fill(this.заказыDataSet.Предметы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            //заказыBindingSource.Filter = "КодЗаказа < 10";

            // TODO: This line of code loads data into the 'заказыDataSet.Работы' table. You can move, or remove it, as needed.
            this.работыTableAdapter.Fill(this.заказыDataSet.Работы);
            // TODO: This line of code loads data into the 'заказыDataSet.Заказы' table. You can move, or remove it, as needed.
            this.заказыTableAdapter.Fill(this.заказыDataSet.Заказы);
            // TODO: This line of code loads data into the 'заказыDataSet.Вузы' table. You can move, or remove it, as needed.
            this.вузыTableAdapter.Fill(this.заказыDataSet.Вузы);
            // TODO: This line of code loads data into the 'заказыDataSet.ВидИсполнения' table. You can move, or remove it, as needed.
            this.видИсполненияTableAdapter.Fill(this.заказыDataSet.ВидИсполнения);                           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.заказыTableAdapter.FillBy(this.заказыDataSet.Заказы);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                object Param1 = new object();
                this.заказыTableAdapter.FillBy1(this.заказыDataSet.Заказы, Param1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.заказыTableAdapter.FillBy2(this.заказыDataSet.Заказы, ((int)(System.Convert.ChangeType(кодЗаказаToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}