# データバインディングとビューモデル

### ビューモデル
---
UI要素同市よりもモデルとバインディングさせたいケースのほうが多い。

その場合、バインディングソースになるオブジェクトをバインディングをバインディングターゲットのDateContextプロパティに指定する。

この時に、モデルを直接DataContextに設定せずに、モデルをラップしたオブジェクト（ビューモデル）を使用する。

### ビューとビューモデル
---
「MainWindow」というビューがあった場合に、それに対応する「MainWindowViewModel」を作成するような形になる。

```csharp
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainWindowViewModel();
    }
}

public class MainWindowViewModel
{
    //プロパティの初期値指定はC#6.0以降から
    public string TestData { get; set; } = "hogehoge";
}

//この時のMainWindowのxamlは以下の通り。
<Grid>
    <TextBlock Text="{Binding Path=TestData}" />
</Grid>
```

また、ビューモデルはビューからの入力値といったビューの状態を保持する役目も持つ。

### INotifyPropertyChangedインターフェース
---
* 名前空間「System.ComponentModel」
* INotifyPropertyChangedはPropertyChangedイベントのみをメンバーに持つ。値が変更されたプロパティの「名前」を「文字列」で知らせる。
* ビューは自信をバインディングターゲットとするときにINotifyPropertyChangedを実装したオブジェクトをバインディングソースとすることで、ソースプロパティの変更を検知できる。

### ICommandインターフェース
---
* 名前空間「System.Windows.Input」
* ビューはICommandをボタンやその他のアクションとバインドすることでアクションが実行可能かどうか判断しつつロジックを呼び出すことができる。

|メソッド名          |処理                                 |
|-----------------|------------------------------------|
|Execute          |操作を実行する。                       |
|CanExecute       |操作が実行可能か返す。                 |
|CanExecuteChange |CanExecuteの結果が変化したことを通知する。|





### 参考記事

> 日経ソフトウェア2015年9月号
