using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateAndFactory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeTextBox(State.TextBoxState state)
        {
           state.ChangeTextBox(this.textBox);
        }

        private void button_Normal_Click(object sender, EventArgs e)
        {
            this.ChangeTextBox(State.StateFactory.Normal);
        }

        private void button_Warning_Click(object sender, EventArgs e)
        {
            this.ChangeTextBox(State.StateFactory.Warning);
        }

        private void button_Error_Click(object sender, EventArgs e)
        {
            this.ChangeTextBox(State.StateFactory.Error);
        }
    }
}
