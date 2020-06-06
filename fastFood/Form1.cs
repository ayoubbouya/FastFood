using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace fastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseClick += mouseClick;
            pictureBox2.MouseClick += mouseClick;
            pictureBox3.MouseClick += mouseClick;
            pictureBox4.MouseClick += mouseClick;
            pictureBox5.MouseClick += mouseClick;
            pictureBox6.MouseClick += mouseClick;
            pictureBox7.MouseClick += mouseClick;
            pictureBox8.MouseClick += mouseClick;
            pictureBox9.MouseClick += mouseClick;
            pictureBox10.MouseClick += mouseClick;
            pictureBox11.MouseClick += mouseClick;
            pictureBox12.MouseClick += mouseClick;
            pictureBox13.MouseClick += mouseClick;
            pictureBox14.MouseClick += mouseClick;
            pictureBox15.MouseClick += mouseClick;
            pictureBox16.MouseClick += mouseClick;
            pictureBox17.MouseClick += mouseClick;
            pictureBox18.MouseClick += mouseClick;
            pictureBox19.MouseClick += mouseClick;
            pictureBox20.MouseClick += mouseClick;
            pictureBox21.MouseClick += mouseClick;
            pictureBox22.MouseClick += mouseClick;
            pictureBox23.MouseClick += mouseClick;
            pictureBox24.MouseClick += mouseClick;
            pictureBox25.MouseClick += mouseClick;
            pictureBox26.MouseClick += mouseClick;
            
        }

        int price;
        string name;
        int qty;
        private int total;

        private void mouseClick(object sender, MouseEventArgs e)
        {
            

            var clickpic = (PictureBox)sender;
            if (clickpic == pictureBox1)
            {
                name = "Breakfast 1";
                price = 22;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }

            else if (clickpic == pictureBox2)
            {
                name = "Breakfast 2";
                price = 14;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }

            else if (clickpic == pictureBox3)
            {
                name = "main 1";
                price = 24;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox4)
            {
                name = "main 2";
                price = 23;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox5)
            {
                name = "main 3";
                price = 12;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox6)
            {
                name = "main 4";
                price = 23;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox7)
            {
                name = "main 5";
                price = 43;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox8)
            {
                name = "main 6";
                price = 32;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox9)
            {
                name = "salad 1";
                price = 34;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox10)
            {
                name = "salad 2";
                price = 45;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox11)
            {
                name = "salad 3";
                price = 26;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox12)
            {
                name = "salad 4";
                price = 20;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox13)
            {
                name = "salad 5";
                price = 19;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox14)
            {
                name = "salad 6";
                price = 29;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox15)
            {
                name = "salad 7";
                price = 28;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox16)
            {
                name = "salad 8";
                price = 17;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox17)
            {
                name = "drink 1";
                price = 26;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox18)
            {
                name = "drink 2";
                price = 22;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox19)
            {
                name = "drink 3";
                price = 21;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox20)
            {
                name = "drink 4";
                price = 12;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox21)
            {
                name = "drink 5";
                price = 18;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox22)
            {
                name = "drink 6";
                price = 32;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox23)
            {
                name = "dessert 1";
                price = 25;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox24)
            {
                name = "dessert 2";
                price = 22;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox25)
            {
                name = "dessert 3";
                price = 42;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }
            else if (clickpic == pictureBox26)
            {
                name = "dessert 4";
                price = 18;
                qty = int.Parse(Interaction.InputBox("enter the qty ?", "qty", ""));
            }

            total = price * qty;
            this.dataGridView1.Rows.Add(name, price, qty, total.ToString());


            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            txtsum.Text = sum.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
