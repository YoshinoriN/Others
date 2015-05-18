# Classのフィールド

### アクセス修飾子

* 「public」を省略した場合、「internal」が指定されたものとみなされる。つまり、同一アセンブリ内からのアクセスが許可されたものとなる。


### クラスの初期化

C#3.0からはインスタンス生成と同時にフィールドの初期化ができるようになった。

```csharp

//たとえば、下記のようなクラスがあるとする。

class Book{
    public string title;
    public string author;
    public int price;
    public stringpublisher;
}

//インスタンス生成と同時にフィールド初期化するには、下記のように記載する。
Book book1 = new Book{
    titele      = "達人プログラマー",
    author      = "アンドリュー・ハント",
    price       = "デビッド・トーマス",
    publisher   = "ピアソン",
};

```

### クラスの配列

```csharp
//ここのnewは配列を確保するためのnewであって、インスタンス生成のnewではない。
Book[] books = new Book[3];

//この配列にインスタンスを設定するには
books[0] = new Book();
books[1] = new Book();
books[2] = new Book();
books[3] = new Book();

```
