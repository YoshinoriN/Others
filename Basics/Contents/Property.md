# プロパティ

* プロパティは大文字で始めるのが推奨されている。
* プロパティは値を保持するために定義されているわけではなく、あるフィールドへのアクセス手段を定義するためにある。

```csharp
class Person{
    //フィールドは非公開にするのが望ましい
    private double _weight;

    //プロパティ名は大文字推奨
    public double Weight｛
        //getアクセサ
        get{
            return weight;
        }

        //setアクセサ
        set{
            if (value > 30)
                //valeは暗黙のパラメータ
                _weight = value;
        }
}
```

### 自動プロパティ

C#3.0以降では自動プロパティがある。

下記は前述の「Weight」プロパティと同義になる。(value > 30)は除く。

```csharp
    public Weight{get; set;}
```

フィールドの公開と何ら変わりはないように思えるが、後からget/setアクセサの変更が可能になるので、より変更に強いプログラムになる。

下記のように記述することで読み取り専用プロパティにすることも可能。

```csharp
    private double _weight;
    public readonly double Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            _weight = value;
        }
    }
```

なお、自動プロパティを使用して記述した場合は下記のようになる。

下記のコードは上記のコードと同じになる。
```csharp
public double Weight{get; private set;}
```

また、getアクセサだけをもつプロパティを定義することでも読み取り専用プロパティを作成することができる。
```csharp
    private double _weight;
    public readonly double Weight
    {
        get
        {
            return _weight;
        }
    }

    //もしくは
    public double Weight { get; }
```
