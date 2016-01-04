using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StateAndFactory.State
{
    /// <summary>
    /// テキストボックスの状態の抽象クラス。
    /// 実際の状態はサブクラスに実装する。
    /// </summary>
    internal abstract class TextBoxState
    {
        /// <summary>
        /// テキストの抽象プロパティ
        /// </summary>
        protected abstract String Text
        {
            get;
        }

        /// <summary>
        /// 背景色の抽象プロパティ
        /// </summary>
        protected abstract Color BackColor
        {
            get;
        }

        /// <summary>
        /// 前景色の抽象プロパティ
        /// </summary>
        protected abstract Color ForeColor
        {
            get;
        }

        internal void ChangeTextBox(TextBox textbox)
        {
            //各値はサブクラスから受け取る
            textbox.Text = this.Text;
            textbox.BackColor = this.BackColor;
            textbox.ForeColor = this.ForeColor;
        }
    }
}
