# LINQ

統合言語クエリ(Language-Integrated Query)

何らかの集合体からデータをとってくるための式をQueryという。

データベースに特化したものがSQL。

Queryを言語に統合しているので、統合言語クエリという言い方をする。


## 使い方
---

System.Linqを加える。
```csharp
using System.Linq;
```

## 遅延評価
---

LINQは遅延評価である。

下記のコードの場合、filePathsには条件式が格納される。
絞り込んだ条件式が実際に実行されるのはforeachの部分である。
```csharp
var directoryInfo = new DirectoryInfo(path);
//この段階では条件式が格納されるだけ。
var files = directoryInfo.GetFiles()
            .Where(x => x.Extension.Contains == ".jpg" )
            ;

//格納された条件式が実行されるのはここである。
foreach (var filePath in filePaths)
            Console.WriteLine(filePath);
```

## メソッドの書き方
---

「and,or」は存在しないため、「&&,||」で表す。
以下は同等の意味になる。

```csharp
//Whereを並べるパターン
var directoryInfo = new DirectoryInfo(path);
var files = directoryInfo.GetFiles()
            .Where(x => x.Extension.Contains("g"))
            .Where(x => x.Extension.Contains("p"));

//andでくっつけるパターン
var directoryInfo = new DirectoryInfo(path);
var files = directoryInfo.GetFiles()
            .Where(fileinfo => fileinfo.Extension.Contains("g")
            && fileinfo.Extension.Contains("p"));
      
//メソッド内に記述する(return)パターン
var directoryInfo = new DirectoryInfo(path);
var files = directoryInfo.GetFiles()
            .Where(x =>
            {
                return x.Extension.Contains("g") && x.Extension.Contains("p");
            });      
```

## 別の書き方
---
メソッドをつなぐ形ではなくてSQL文のような書き方も可能である。

下記の2つの式は同等の結果となる。

```csharp
//SQLライクな書き方
var directoryInfo = new DirectoryInfo(path);
//こちらの場合はselect省略不可。
var files = from data in directoryInfo.GetFiles()
            where (data.Extension == ".jpg")
            select data
            ;

//メソッドライクな書き方
var directoryInfo = new DirectoryInfo(path);
//Select省略可能。
var files = directoryInfo.GetFiles()
            .Where(x => x.Extension.Contains == ".jpg" )
            ;
```

ただし、メソッドではない形式の場合はSelectもしくはGroup句を記述しないといけない。

## メソッドにコードを書く。
---

メソッドにコードを書くことができる。

例えば書きのコードは（あまり意味のないものになるが）jpg以外の拡張子のファイル情報を取得する。
```csharp
var files = directoryInfo.GetFiles()
            .Where(x =>
            {          
                if(x.Extension.Contains(".jpg"))
                {
                    return false;
                }
                return true;
            });
```
一時変数を使用するようなケースだと重宝する。

上記のコードの場合はメソッドがWhereなので戻り値がboolに限定される。

メソッドによって戻り値が異なる。


## メソッドの記述順序
---

メソッドの記述順序は基本的に結果に影響しない。
ただし、Indexはメソッドの記述順序に影響するので注意する。

## 条件を満たす要素があるか確認する。
---
Anyメソッドで条件を満たす要素があるかどうか調べることができる。

bool型で戻ってくる。あくまでbool型で戻って来るだけなので、該当する要素が取得できるわけではない。
```csharp
var list = new List<int>{1,3,5,8,10,99,100,999,1000};
var numbers = list.Any(x => x == 999);
```




