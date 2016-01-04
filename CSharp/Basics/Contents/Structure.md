# 構造体

### クラスと構造体
クラスと構造体には下記のような違いがある。

* 引数なしのコンストラクタを定義できない。
* 継承できない。
* インスタンスフィールドの初期化が行えない。
* クラスはメモリの状態が「参照型」構造体は「値型」
* 文法はほぼ同じ。

```csharp
//VBと違って「struct」
public struct Date
{
    /* インスタンスフィールドの初期化はできない。
    public Date(int month, int day)
    {
        Month = month;
        Day = day;
    }
    */

    public int Month { get; set; }
    public int Day { get; set; }

    public static bool IsStartOfMonth(int day)
    {
        return (day == 1);
    }

    public bool IsStartOfMonth()
    {
        // StaticメソッドのIsStartOfMonthを使用する。
        return Date.IsStartOfMonth(this.Day);
    }

}
```
