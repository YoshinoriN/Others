using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitSample1Test
{
    [TestFixture]
    public class NunitSample1Test
    {
        [Test]
        public void IsSameTest()
        {
            int x = 1;
            int y = 2;

            bool TestResult = NunitSample1.Compare.IsSame(x, y);

            //戻り値がfalseなので期待値と同一のため、Nunitの実行結果はOKとなる
            Assert.AreEqual(false, TestResult);

            //こっちの場合は期待値と実際の値が異なるのでNunitを実行すると失敗となる
            Assert.AreEqual(true, TestResult);
        }

        /// <summary>
        /// テストケースをメソッドの頭に記述する。
        /// 引数の数は実際にテストされるメソッドの数と異なってもよいので、
        /// 第3引数に期待値を記述する。
        /// </summary>
        /// <param name="x">値2</param>
        /// <param name="y">値1</param>
        /// <param name="expect">期待値</param>
        [TestCase(1, 2, false)]
        [TestCase(1, 1, true)]
        public void IsSameTest<Type>(Type x, Type y, bool expect)
        {
            bool TestResult = NunitSample1.Compare.IsSame(x, y);
            Assert.AreEqual(expect, TestResult);
        }

        [TestCase]
        public void IsSameTest()
        {
            //正常でメッセージ指定なし。Nunitの実行結果にはなにも表示されない。
            Assert.AreEqual(true, NunitSample1.Compare.IsSame(1, 1));
            //正常でメッセージ指定しているが、Nunitの実行結果にはなにも表示されない。
            Assert.AreEqual(false, NunitSample1.Compare.IsSame(1, 2), "問題なし!!");
            //失敗だがメッセージを指定していないので、Nunitの実行結果にはなにも表示されない。
            Assert.AreEqual(true, NunitSample1.Compare.IsSame(1, 2));
            //失敗でメッセージを指定しているのでNunitの実行結果には「失敗です!!」のメッセージが表示される。
            Assert.AreEqual(true, NunitSample1.Compare.IsSame(1, 2), "失敗です!!");
        }
    }
}
