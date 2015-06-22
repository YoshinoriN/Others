#  コレクションクラス

### コレクション
--------------------------
* 複数のオブジェクト(同じ型のデータを集めた)を管理する構造・クラスのこと。


### List<T>
--------------------------
必要に応じて動的にサイズが増加する配列のようなもの。

#### インスタンスを生成する。

List<T>の<>の中に格納する型を指定する。
```csharp
List<string> strs = new List<string>();
List<int> ints = new List<int>();
```

#### 要素を追加する

```csharp
List<Person> list = new List<Person>();

//Addメソッドを使用して要素を追加する。
list.Add(new Person("山田"));
list.Add(new Person("田中"));

public class Person
{
    private string _name;
    public readonly string Name { get { return _name; } }
    public Person(string name)
    {
        _name = name;
    }
}
```

#### 要素を取り出す
```csharp
list.Add(new Person("山田"));
list.Add(new Person("田中"));

//0番目の要素を取り出して表示する。
Person person = list[0];
Console.WriteLine(person.Name);
Console.ReadLine();

//foreachで全て表示する場合
foreach (Person person in list)
{
    Console.WriteLine(person.Name);
}
Console.ReadLine();
```
