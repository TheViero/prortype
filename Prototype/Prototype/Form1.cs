using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype;
using static Prototype.Prototype;

namespace Prototype
{
    public partial class Form1 : Form
    {
        private Prototype.Pizza _pizza;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prototype.PizzaBuilder pizzaBuilder = new Prototype.PizzaBuilder(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            _pizza = new Prototype.Pizza(pizzaBuilder);

            MessageBox.Show("Успішне створення піци");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_pizza == null)
            {
                MessageBox.Show("Будь ласка, створіть піцу перед клонуванням");
            }
            else
            {
                Prototype.Pizza clonedBread = _pizza.Clone();

                textBox1.Text = clonedBread.Flour;
                textBox2.Text = clonedBread.Water;
                textBox3.Text = clonedBread.Yeast;
                textBox4.Text = clonedBread.Salt;
                textBox5.Text = clonedBread.Sugar;

                MessageBox.Show("Піца успішно клоновано");
            }

        }
    }
}
