# インターフェース
-----------------

### インターフェースとは
* メソッドのシグネチャだけを抜き出したもの。どういった処理を実装するかは含まれない。
* インターフェースにはアクセス修飾子は記述できない。

```csharp
//インターフェースの名前は一般的に大文字の「I」で始める。
public interface IReadOnlyPerson
{
    //アクセス修飾子をつけることはできない。
    string Name { get;}
    int Age { get; }
    DateTime BirthDay { get;}
    void GetAge(DateTime today);
}
```

#### 読み取り専用
* インターフェースを介する（利用する）ことで読み取り専用にすることができる。

```csharp

//インターフェース
public interface IReadOnlyPerson
{
    string Name {get;}
    int Age { get; }
    DateTime BirthDay { get ;}

    void GetAge(DateTime today);
}

//インターフェースを実装したクラス
public class Person : IReadOnlyPerson
{
    //インターフェースでは「get」しか記述されていないが、実装側のクラスで「set」を書くことは可能。
    //この場合、インターフェースを介してプロパティを使用すると読み取り専用になる。
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }

    public void GetAge(DateTime today)
    {
        Age = today.Year - BirthDay.Year;
    }
}

static void Main()
{
    //インターフェースを介する場合。
    //この場合、「Person型」ではなく「IReadOnlyPerson型」を生成していることになる。
    IReadOnlyPerson ps = new Person
    {
        Name = "Hanako",
        BirthDay = DateTime.Parse("1995/04/07")
    };
    ps.GetAge(DateTime.Today);
    //インターフェースを介した場合、読み取り専用になるので、ここでは代入できない。(コンパイルエラーになる)
    ps.Age = 19;

    //インターフェース介さない場合。
    Person ps2 = new Person
    {
        Name = "Katsuo",
        BirthDay = DateTime.Parse("1985/01/19")
    };
    ps2.GetAge(DateTime.Today);
    //インターフェースを介していないので、この代入は可能である。
    ps2.Age = 29;
}
```

### 抽象クラスとの違い
* 継承関係と関係なく使用できる。
* クラスは多重継承できないが、インターフェースは複数実装できる。
