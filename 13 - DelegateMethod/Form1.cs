using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13___DelegateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Expressão completa

            //btn_click.Click += delegate (object sender, EventArgs e)
            //{
            //    MessageBox.Show("Fui clicado!");
            //};

            //Expressão simplificada

            btn_click.Click += delegate
            {
                MessageBox.Show("Fui clicado!");
            };
        }
    }
}
