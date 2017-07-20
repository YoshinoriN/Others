#### コマンドプロンプトの設定
はじめはWindows環境ではコマンドプロンプトで日本語が文字化けする。
[右クリック] -> [プロパティ] -> [フォント] を一旦開いて閉じる。
これでコマンドプロンプトで日本語が表示されるようになる。

#### git実行パスを確認する
```git
 git --exec-path
```

#### 署名

```git

git config --global user.name "*******"
git config --global user.email "*******"

```


#### Push方式をSimpleに変更


```git

git config --global push.default simple

```

#### 大文字小文字を区別

```git
git config --global core.ignorecase false
git config core.ignorecase false
```

#### 日本語ファイル名のエスケープを回避する


```git
git config --global core.quotepath false

```

#### 設定の確認

```git
git config --list
```

#### 設定の削除
```git
git config --unset 設定
```
```git
[サンプル]
git config --global --unset core.quotepath
```
