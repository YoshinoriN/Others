# メソッド

メソッドはフィールドと異なり、全てのインスタンスで共通である。

### オーバーロード

同一メソッド名でも、引数の数や型が異なることをオーバーロードという。

たとえばMessageBox.Showメソッド。

```csharp
MessageBox.Show("Hello world");
MessageBox.Show("Hello world","Hello world dialog");
```

引数の数が同じでも引数の型が異なるメソッドをオーバーロードすることができる。

これはコンパイラが推論してくれるから。

なお、戻り値のみが異なるメソッドはオーバーロードできない。


### コンストラクタのオーバーロード

引数付のコンストラクタを定義すると、デフォルトコンストラクタの呼び出しができなくなるので、その場合は引数のないコンストラクタを定義する必要がある。

```csharp
class Person
{
    public string name;
    public DateTime birthday;

    ///引数有りのコンストラクタ
    public Person(string name)
    {
        this.name = name;
    }

    ///引数なしのコンストラクタ
    public Person()
    {
        this.name = "Yoshinori.N";
    }

｝
```
