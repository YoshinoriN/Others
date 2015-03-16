#### 署名


```git

git config --global user.name "*******"
git config --global user.email "*******"

```


#### Push方式をSimpleに変更


```git

git config --global push.default simple

```



#### 日本語ファイル名のエスケープを回避する


```git
git config --global core.quotepath false

```



#### 設定の確認


```git
git config --list
```

#### コマンドプロンプトの設定
[右クリック] -> [プロパティ] -> [フォント] を一旦開いて閉じる。
これでコンソールで日本語が表示されるようになる。
