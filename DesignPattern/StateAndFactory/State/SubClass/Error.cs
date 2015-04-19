using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace StateAndFactory.State
{
    /// <summary>
    /// TextBoxStateクラスのサブクラス。
    /// 実際にテキストボックスに表示する値を実装する。
    /// </summary>
    internal class Error : TextBoxState
    {
        protected override string Text
        {
            get 
            {
                return "Error";
            }
        }

        protected override Color BackColor
        {
            get
            {
                return Color.Red;
            }
        }

        protected override Color ForeColor
        {
            get
            {
                return Color.White;
            }
        }
    }
}
