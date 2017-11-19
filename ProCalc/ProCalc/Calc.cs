using System;
using System.Windows.Forms;
using ProCalc.Lib.Syntax;

namespace ProCalc.UI
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            var r = Parser.Evaluate("10/-1*-2");
            ;
        }
    }
}
