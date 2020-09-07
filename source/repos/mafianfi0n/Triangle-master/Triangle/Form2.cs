using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form2 : Form
    {
        double a, b, c;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtH.Text = "";
            txtS.Text = "";
            txtP.Text = "";
            txtR.Text = "";
            txtT.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtH.Text != String.Empty)
            {
                if (txtA.Text != String.Empty && txtB.Text != String.Empty)
                {
                    MessageBox.Show("Вам нужно написать только одну сторону и высоту!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                if (txtA.Text != String.Empty && txtC.Text != String.Empty)
                {
                    MessageBox.Show("Вам нужно написать только одну сторону и высоту!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                if (txtB.Text != String.Empty && txtC.Text != String.Empty)
                {
                    MessageBox.Show("Вам нужно написать только одну сторону и высоту!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                if ((txtB.Text == String.Empty) && (txtC.Text == String.Empty))
                {
                    double a, h, s;
                    a = Convert.ToDouble(txtA.Text);
                    h = Convert.ToDouble(txtH.Text);
                    clear();
                    Triangle triangle = new Triangle(a, b, c);
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    s = 0.5 * a * h;
                    txtA.Text = Convert.ToString(a);
                    txtH.Text = Convert.ToString(h);
                    txtS.Text = Convert.ToString(s);
                }
                if ((txtA.Text == String.Empty) && (txtC.Text == String.Empty))
                {
                    double b, h, s;
                    b = Convert.ToDouble(txtB.Text);
                    h = Convert.ToDouble(txtH.Text);
                    clear();
                    Triangle triangle = new Triangle(a, b, c);
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    s = 0.5 * b * h;
                    txtB.Text = Convert.ToString(b);
                    txtH.Text = Convert.ToString(h);
                    txtS.Text = Convert.ToString(s);
                }
                if ((txtB.Text == String.Empty) && (txtA.Text == String.Empty))
                {
                    double c, h, s;
                    c = Convert.ToDouble(txtC.Text);
                    h = Convert.ToDouble(txtH.Text);
                    clear();
                    Triangle triangle = new Triangle(a, b, c);
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    s = 0.5 * c * h;
                    txtC.Text = Convert.ToString(c);
                    txtH.Text = Convert.ToString(h);
                    txtS.Text = Convert.ToString(s);
                }
            }
            if (txtH.Text == String.Empty)
            {
                if ((txtA.Text != String.Empty) && (txtB.Text != String.Empty) && (txtC.Text != String.Empty))
                {
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    clear();
                    Triangle triangle = new Triangle(a, b, c);
                    txtA.Text = (triangle.outputA());
                    txtB.Text = (triangle.outputB());
                    txtC.Text = (triangle.outputC());
                    txtP.Text = (Convert.ToString(triangle.Perimeter()));
                    txtS.Text = (Convert.ToString(triangle.Surface()));
                    if (triangle.ExistTriangle) { txtR.Text = "Существует"; }
                    else txtR.Text = "Не существует";
                    txtT.Text = (Convert.ToString(triangle.TriangleType()));
                    if (triangle.Answer == "Прямоугольный")
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                    }
                    if (triangle.Answer == "Остроугольный")
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                    }
                    if (triangle.Answer == "Тупоугольный")
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
