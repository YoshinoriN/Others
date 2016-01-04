using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControllStudy1
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            this.BackColor = SystemColors.Window;

            // エンターキー以外は処理終了
            if (e.KeyCode != System.Windows.Forms.Keys.Enter)
            {
                return;
            }

            if ((this.Text.Length == 0) || (!Validation.IsNurmeric(this.Text)))
            {
                MessageBox.Show("数値を入力してください");
                this.BackColor = Color.Red;
                return;
            }


            MessageBox.Show("OK!!");
        }
    }
}
