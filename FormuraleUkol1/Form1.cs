using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FormuraleUkol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListBox box;
        Form form2;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = (Size)new Point(500, 400);
            this.Text = "Stach";
            box= new ListBox();
            box.Location = new Point(20, 30);
            box.Size = new Size(150, 250);
            this.Controls.Add(box);

            Button btn = new Button();
            btn = new Button();
            btn.Text = "Zapiš";
            btn.Location = new Point(250, 20);
            btn.Size = new Size(100, 75);
            btn.Click += btn_Click;
            this.Controls.Add(btn);

            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            Button btn1 = new Button();
            Button btn2 = new Button();
            TextBox txt1 = new TextBox();

            btn1.DialogResult = DialogResult.OK;
            btn2.DialogResult = DialogResult.Cancel;

            btn1.Location = new Point(40, 189);
            btn1.Size = new Size(75, 23);
            btn1.Text = "Ulož";
            btn2.Location = new Point(148, 188);
            btn2.Size = new Size(75, 23);
            btn2.Text = "Zruš";

            txt1.Location = new Point(49, 40);
            txt1.Size = new Size(188, 22);

            form2.Controls.Add(txt1);
            form2.Controls.Add(btn1);
            form2.Controls.Add(btn2);
            form2.Activate();
            txt1.Focus();
            form2.ActiveControl = txt1;
            form2.AcceptButton = btn1;


            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (box.Items.Count >= 11)
                {
                    MessageBox.Show("Plný Listbox!");
                }
                else
                {
                    box.Items.Add(txt1.Text);
                }

            }

        }

        private class Form2 : Form
        {
            public Form2()
            {

            }
        }
    }
}
