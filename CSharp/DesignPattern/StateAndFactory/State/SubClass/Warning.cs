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
    internal class Warning : TextBoxState
    {
        protected override string Text
        {
            get 
            {
                return "Warning";
            }
        }

        protected override Color BackColor
        {
            get
            {
                return Color.Yellow;
            }
        }

        protected override Color ForeColor
        {
            get
            {
                return SystemColors.WindowText;
            }
        }
    }
}
