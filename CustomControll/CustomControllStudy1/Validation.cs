using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControllStudy1
{
    class Validation
    {
        /// <summary>
        /// 数値かどうか検証するメソッド
        /// </summary>
        public static bool IsNurmeric(object x)
        {
            double o;
            return double.TryParse(x.ToString(), out o);
        }
    }
}
