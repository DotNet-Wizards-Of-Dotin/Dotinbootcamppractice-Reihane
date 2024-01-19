using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class UnitCalculator : Form
    {
        RUels convertor_object;
        public UnitCalculator()
            //this is constractor
        {
            InitializeComponent();
            convertor_object = new Convertor_class();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sout_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                //meghdar  ro az user bgire

                float Input = convertor_object.Sout((float)input.Value);
                MessageBox.Show(Input+"سوت");
            }
        }

        private void mesghal_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                float Input = convertor_object.Mesghal((float)input.Value);
                MessageBox.Show(Input + "مثقال");

            }
        }
        private void ghirat_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                float Input = convertor_object.Ghirat((float)input.Value);
                MessageBox.Show(Input + "قیراط");
            }
        }
        public bool validation()
        {
            if (input.Value == 0)
            {
                MessageBox.Show("لطفا یک عدد وارد کنید");
                return false;
            }
            return true;
        }


        private void input_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
