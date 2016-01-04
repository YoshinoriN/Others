## Nunitの使い方

### 1.Nunitをインストール
割愛

### 2.Nunitの設定変更
Numitを起動する。

「Tools」の「Setting」から「IDE Support」で「Enable Visual Studio」を選択。

### 3.Nunit用のプロジェクトを作成

テストされる側のプロジェクト

```csharp
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
        public static bool IsSame<Type>(Type x,Type y)
        {
            if (x.Equals(y))
                return true;

            return false;
        }
    }
}

```

Privateメソッドをテストする場合はテストされる側のAssemblyInfo.csに下記を記述。

```csharp
後述するテストプロジェクト名を記述する。
[assembly: InternalsVisibleTo("NunitSample1Test")]
```

### 3.テスト用プロジェクトの作成

 1. 元のプロジェクト名の後ろに「Test」追加したプロジェクトを作成する。

    テスト用のプロジェクトを作成することで、テストコードや参照設定が実プロジェクトに入らないというメリットがある。

 2. 作成した[**Test]プロジェクトの参照に[Nunitのdll] を追加する。

     Nunitのインストール先⇒bin⇒NunitFrameWork.dll

 3. テストするプロジェクトを参照に加える。

### 4.テスト用クラスの作成
 1. テスト用クラス[**Test]を作成

 2. テスト用クラスに属性を設定する
    クラスに[TestFixture]を記述する。
    Nuitは [TestFixture]属性の記述されているクラスをテスト対象と認識する。

```csharp
[TestFixture]
public class NunitSample1Test
{

}

```

### 5-1.テストメソッドの作成（Test属性）

メソッドの上部に[Test]属性を記述する。
下記は、AreEqualメソッドを使用したサンプル。
AreEqualメソッドでは左に期待値を右にテスト値を記述する。

```csharp
Assert.AreEqual(期待値,テスト値)
```

```csharp
namespace NunitSample1Test
{
    [TestFixture]
    public class NunitSample1Test
    {

    [Test]
        public void IsSameTest()
        {
        int x =1;
        int y =2;

        bool TestResult = NunitSample1.Compare.IsSame(x,y);

        //戻り値がfalseなので期待値と同一のため、Nunitの実行結果はOKとなる
        Assert.AreEqual(false,TestResult);

        //こっちの場合は期待値と実際の値が異なるのでNunitを実行すると失敗となる
        //Assert.AreEqual(true, TestResult);
        }
    }
}
```

### 5-2.テストメソッドの作成（TestCase属性）

Test属性の場合だと、Testの数に応じてメソッドを作成する必要がでてしまうので、TestCaseでまとめてテストをするほうがよいと思われる。

以下はテストケースをメソッドの頭に記述するケース
```csharp
[TestFixture]
public class NunitSample1Test
{

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
        bool TestResult= NunitSample1.Compare.IsSame(x,y);
        Assert.AreEqual(expect, TestResult);
    }

}
```

以下はテストケースをメソッドの頭に記述しないケース
```csharp
[TestFixture]
public class NunitSample1Test
{
    [TestCase]
    public void IsDiffTest()
    {
        Assert.AreEqual(true, NunitSample1.Compare.IsSame(1,1));
        Assert.AreEqual(false, NunitSample1.Compare.IsSame(1,2));
    }

}
```


### 6.テスト失敗時にメッセージを表示する
失敗時に限り、Nunit実行時の実行結果ペインにメッセージを表示できる。
```csharp
[TestFixture]
public class NunitSample1Test
{
    [TestCase]
    public void IsSameTest()
    {
        //正常でメッセージ指定なし。Nunitの実行結果にはなにも表示されない。
        Assert.AreEqual(true, NunitSample1.Compare.IsSame(1,1));
        //正常でメッセージ指定しているが、Nunitの実行結果にはなにも表示されない。
        Assert.AreEqual(false, NunitSample1.Compare.IsSame(1,2),"問題なし!!");
        //失敗だがメッセージを指定していないので、Nunitの実行結果にはなにも表示されない。
        Assert.AreEqual(true, NunitSample1.Compare.IsSame(1, 2));
        //失敗でメッセージを指定しているのでNunitの実行結果には「失敗です!!」のメッセージが表示される。
        Assert.AreEqual(true, NunitSample1.Compare.IsSame(1, 2),"失敗です!!");
    }
}
```


### 参考リンク
下記が参考にさせて頂いたサイトです。ありがとうございます。
* http://qiita.com/rohinomiya/items/47f09523f1b9dfa015b1
* http://codezine.jp/article/detail/6518
