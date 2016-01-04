#  コレクションクラス

### Dictionary
--------------------------
* キーと値のペアで構成されるデータを管理する。
* 「.NET1.1」までは「Hashtableクラス」だった。
* ハッシュテーブルとして実装されているのでキーを使用した値の取得は早い。

#### インスタンスを生成する。

* Dictionary<int,string>のように「キー」「値」の順に指定する

```csharp
static void Main(string[] args)
{
    //インスタンス生成「キー」「値」の順に指定する
    //格納するのは独自のクラスでも可能である。
    Dictionary<int, string> dict = new Dictionary<int, string>();

    //Dictionaryに登録
    dict.Add(1, "One");
    dict.Add(2, "Two");
    dict.Add(3, "Three");

    //Addメソッドで追加し「キー」を指定する。
    Console.WriteLine(dict[1]);
    Console.WriteLine(dict[2]);
    Console.WriteLine(dict[3]);

    Console.ReadLine();

    //全ての要素を取り出す。
    foreach (KeyValuePair<int,string> keyV in dict)
    {
        Console.WriteLine(keyV.Value);
    }
    Console.ReadLine();
}
```
