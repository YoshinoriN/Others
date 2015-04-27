using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSample1
{
    public class Compare
    {
        /// <summary>
        /// 2つの引数の値が同一かどうか確認します
        /// </summary>
        /// <param name="x">比較値1</param>
        /// <param name="y">比較値2</param>
        /// <returns>
        /// [一致:True]
        /// [不一致:False]
        /// </returns>
        public static bool IsDiff<Type>(Type x,Type y)
        {
            if(!CompareType(x, y))
            {
                return false;
            }

            if (x.Equals(y))
                return true;

            return false;
        } 

        /// <summary>
        /// 2つの引数の型が同じかどうか確認します
        /// </summary>
        /// <param name="x">比較値1</param>
        /// <param name="y">比較値2</param>
        /// <returns>
        /// [一致:True]
        /// [不一致:False]
        /// </returns>
        private static bool CompareType<Type>(Type x,Type y)
        {
            if (x.GetType() == y.GetType())
            {
                return true;
            }
            return false;
        }
    }
}
