using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Libriary
{
    public partial class Form4 : Form
    {
        private BindingSource booksBindingSource;

        public BindingSource BooksBindingSource
        {
            get { return booksBindingSource; }
            set { booksBindingSource = value; }
        }
        public Form4(BindingSource bindingSource)
        {
            InitializeComponent();
            booksBindingSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (!string.IsNullOrEmpty(textBox1.Text))
                filter = $"Наименование = '{textBox1.Text}'";
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += " AND ";
                filter += $"Автор = '{textBox2.Text}'";
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += " AND ";
                filter += $"Издательство = '{textBox3.Text}'";
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                if (Regex.IsMatch(textBox4.Text, "^\\d+$"))
                {
                    if (!string.IsNullOrEmpty(filter))
                        filter += " AND ";
                    filter += $"Год = '{textBox4.Text}'";
                }
                else
                {
                    MessageBox.Show("Введите корректный год.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            booksBindingSource.Filter = filter;
        }
    }
}
