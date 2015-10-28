# デリゲート

### デリゲート
---
メソッドを参照するための型。
System.Delegateの派生クラスになる。

```csharp
//書き方
delegate 戻り値の型 型名(引数);

//例:戻り値なしで、stringの引数をもつメソッドを代入できる。
delegate void hoge(string foo);
```

デリゲートに格納したメソッドをデリゲートを介して呼び出す例。

```csharp
public class DelegateSample
{
    //hooという名前のデリゲートを定義する。
    delegate void foo(string s);

    static void Main()
    {
        //メソッドからデリゲートへの暗黙変換。
        foo hogehoge = ShowMessage;
        // デリゲートを介してShowMessageメソッドを呼び出す。
        hogehoge("デリゲート");
    }

    static void ShowMessage(string n)
    {
        Console.Write(n);
        Console.ReadLine();
    }
}
```

### マルチキャストデリゲート
---
+=演算子を使用して、複数のメソッドを代入することができる。
代入したメソッドはデリゲート呼び出し時に代入した順番に実行される。

```csharp
public class DelegateSample
{
    //hooという名前のデリゲートを定義する。
    delegate void foo();

    static void Main()
    {
        //メソッドからデリゲートへの暗黙変換。
        //複数のメソッドを格納する。格納した状態のことをマルチキャストデリゲートと呼ぶ。
        foo hogehoge = ShowMessage1;
        hogehoge += ShowMessage2;
        hogehoge += ShowMessage3;
        //ShowMessage1～3を格納して呼び出す。
        hogehoge();
    }

    static void ShowMessage1()
    {
        Console.Write("1つめ \n");
    }
    static void ShowMessage2()
    {
        Console.Write("2つめ \n");
    }
    static void ShowMessage3()
    {
        Console.Write("3つめ");
        Console.ReadLine();
    }
}
```

逆に-=でデリゲートに代入したメソッドを削除することができる。
```csharp
public class DelegateSample
{
    //hooという名前のデリゲートを定義する。
    delegate void foo();

    static void Main()
    {
        foo hogehoge = ShowMessage1;
        hogehoge += ShowMessage2;
        hogehoge += ShowMessage3;
        //ShowMessage2の削除。
        hogehoge -= ShowMessage2;
        hogehoge();
    }

    static void ShowMessage1()
    {
        Console.Write("1つめ \n");
    }
    static void ShowMessage2()
    {
        Console.Write("2つめ \n");
    }
    static void ShowMessage3()
    {
        Console.Write("3つめ");
        Console.ReadLine();
    }
}
```
