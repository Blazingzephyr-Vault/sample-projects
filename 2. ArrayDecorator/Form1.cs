using System;
using System.Windows.Forms;

namespace ArrayDecorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteAction(object sender, EventArgs e)
        {
            Array array = new CommonArray(8, -19, 64, -3, 9);
            //array = new Randomizer(array);
            //array = new Positive(array);
            //array = new Mirror(array);
            //array = new Sort(array);
            array.DoAction();

            string arrayResult = array.Write();
            MessageBox.Show(arrayResult);
        }
    }
}