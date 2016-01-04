#  ジェネリック
### ジェネリック
------------------
* 「ArrayList」のような「object型」を要素として保持するものと異なり、コンパイル時にエラーを検出できる。
* 型のキャストが不要になる。
* ボックス化(値型(スタック)から参照型(ヒープ)への変換)とアンボックス化(その逆)が行われないため、パフォーマンスが良い。

#### ジェネリッククラス
* ジェネリックの場合、インスタンス生成時に具体的な型に置き換えられる。
* 一つのクラスで異なる型に対応するインスタンスを作成できる。
* 「T」は型パラメータという。慣習的に「T」を使用する。

```csharp
//「T」は仮の型でインスタンス生成時に具体的な型に置き換えられる。
public class MyFIFO<T>
{
    private int size = 0;
    private T[] items;

    public MyFIFO()
    {
        items = new T[10];
    }

    public void Push(T x)
    {
        items[size++] = x;
    }

    public T Pop()
    {
        T y = items[0];
        //LINQで配列を作り直す。
        items = items.Skip(1).ToArray();
        return y;
    }
}

static void Main(string[] args)
{
    //ジェネリックの場合、インスタンス生成時に具体的な型に置き換えられる。
    //一つのクラスで異なる型に対応するインスタンスを作成できる。
    //下記の場合、インスタンス生成時に「MyFIFO」内の「T」が「int」と「string」に置き換えられる。
    MyFIFO<int> intStack = new MyFIFO<int>();
    MyFIFO<string> strStack = new MyFIFO<string>();

    intStack.Push(1);
    intStack.Push(2);
    intStack.Push(3);
    intStack.Push(4);

    Console.WriteLine(intStack.Pop());
    Console.WriteLine(intStack.Pop());
    Console.ReadLine();

    strStack.Push("a");
    strStack.Push("b");
    strStack.Push("c");
    strStack.Push("d");

    Console.WriteLine(strStack.Pop());
    Console.WriteLine(strStack.Pop());
    Console.ReadLine();
}
```
