# 変数

JavaScriptでは変数の宣言は不要だが、TypeScriptでは変数の宣言が必須。

TypeScriptで型を指定しても、コンパイル後のJavaScriptのコードでは削除された状態となる。

型は変数名の後に指定する。

```js
var name:string;

//宣言と同時に代入
var age:number = 20;

//複数の変数を同時に宣言
var i,n:number

//異なる型の同時も可能
var name:string, age:number;
```

## データ型

|型|備考|
|---|---|
|boolean||
|string||
|number|整数・浮動小数点を区別しない|
|Array||
|enum||
|any|初期値代入しない、もしくは型を指定しない場合、デフォルトで使用される|
|void||

