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
    /// オブジェクトを生成する専用のクラス。
    /// </summary>
    internal static class StateFactory
    {
        private static readonly Normal normal = new Normal();
        private static readonly Warning warning = new Warning();
        private static readonly Error error = new Error();

        internal static TextBoxState Normal
        {
            get
            {
                return normal;
            }
        }

        internal static TextBoxState Warning
        {
            get
            {
                return warning;
            }
        }

        internal static TextBoxState Error
        {
            get
            {
                return error;
            }
        }
    }
}
