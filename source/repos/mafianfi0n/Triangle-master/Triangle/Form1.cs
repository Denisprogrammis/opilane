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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            if ((txtH.Text.Equals(""))){
                if ((txtA.Text.Equals("")) || (txtB.Text.Equals("")) || (txtC.Text.Equals("")))
                    MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                {
                    listView1.Items.Clear();
                    double a, b, c;
                    a = Convert.ToDouble(txtA.Text);
                    b = Convert.ToDouble(txtB.Text);
                    c = Convert.ToDouble(txtC.Text);
                    Triangle triangle = new Triangle(a, b, c);
                    listView1.Items.Add("Сторона а");
                    listView1.Items.Add("Сторона b");
                    listView1.Items.Add("Сторона c");
                    listView1.Items.Add("Периметр");
                    listView1.Items.Add("Площадь");
                    listView1.Items.Add("Существует?");
                    listView1.Items.Add("Спецификатор");
                    listView1.Items[0].SubItems.Add(triangle.outputA());
                    listView1.Items[1].SubItems.Add(triangle.outputB());
                    listView1.Items[2].SubItems.Add(triangle.outputC());
                    listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                    listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                    if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
                    else listView1.Items[5].SubItems.Add("Не существует");
                    listView1.Items[6].SubItems.Add(Convert.ToString(triangle.TriangleType()));
                    if(triangle.Answer == "Прямоугольный")
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
            }
            if((txtA.Text != String.Empty) && (txtH.Text != String.Empty))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                listView1.Items.Clear();
                double a, h, s;
                a = Convert.ToDouble(txtA.Text);
                h = Convert.ToDouble(txtH.Text);
                s = 0.5 * a * h;
                listView1.Items.Add("Сторона а");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(txtA.Text);
                listView1.Items[1].SubItems.Add(txtH.Text);
                listView1.Items[2].SubItems.Add(Convert.ToString(s));
            }
            if ((txtB.Text != String.Empty) && (txtH.Text != String.Empty))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                listView1.Items.Clear();
                double b, h, s;
                b = Convert.ToDouble(txtB.Text);
                h = Convert.ToDouble(txtH.Text);
                s = 0.5 * b * h;
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(txtB.Text);
                listView1.Items[1].SubItems.Add(txtH.Text);
                listView1.Items[2].SubItems.Add(Convert.ToString(s));
            }
            if ((txtC.Text != String.Empty) && (txtH.Text != String.Empty))
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                listView1.Items.Clear();
                double c, h, s;
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
                s = 0.5 * c * h;
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(txtC.Text);
                listView1.Items[1].SubItems.Add(txtH.Text);
                listView1.Items[2].SubItems.Add(Convert.ToString(s));
            }
        }

        private void Run_button_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
