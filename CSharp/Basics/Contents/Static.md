# StaticクラスとStaticメンバー

### Staticメソッド
* 個々のインスタンスに依存しないような機能(下記のような月初かどうか調べるようなメソッド等)はStaticメソッドで作成する。
* 個々のインスタンスからも同様のメソッドを使用したい場合は、Staticメソッドに加えて同名の通常のメソッドも定義する。
* Staticのつかないメソッドを区別するために「インスタンスメソッド」と呼ぶこともある。

```csharp
class Date
{
    public Date(int month, int day)
    {
        Month = month;
        Day = day;
    }
    public int Month { get; set; }
    public int Day { get; set; }

    /// <summary>
    /// 月初かどうか調べる。
    /// </summary>
    /// <param name="day">日</param>
    /// <returns>[True:月初][False:月初でない]</returns>
    public static bool IsStartOfMonth(int day)
    {
        return (day == 1);
    }

    /// <summary>
    /// 個々のインスタンスから使用する場合はStaticでない通常のメソッドを実装し、こちらを使用する。
    /// </summary>
    public bool IsStartOfMonth()
    {
        // StaticメソッドのIsStartOfMonthを使用する。
        return Date.IsStartOfMonth(this.Day);
    }

}
```

### インスタンスメソッドとStaticメソッド

* Staticメソッドからインスタンスメソッドの呼び出しはできない。
* Staticメソッドからインスタンスのメンバーにアクセスはできない。
* インスタンスを生成しなくても、Staticメソッドは呼び出し可能。
