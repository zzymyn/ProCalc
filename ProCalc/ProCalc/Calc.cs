﻿using System;
using System.Windows.Forms;
using ProCalc.Lib.Syntax;
using ProCalc.Lib.GMP;

namespace ProCalc.UI
{
    public partial class Calc : Form
    {
        public Calc()
        {
            MPFR.DefaultPrecision = 256;
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {
        }

        private void Evaluate()
        {
            try
            {
                var result = Parser.Evaluate(m_Eq.Text);
                m_Result.Text = result.ToString();
            }
            catch (ParsingException e)
            {
                m_Result.Text = e.Message;
            }
        }

        private void m_EvaluateButton_Click(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}
