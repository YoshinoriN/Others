
### git grep ~検索します~
```git
git grep '検索対象'
```

* 拡張子を指定する場合

```git
git grep '検索対象' -- "*.拡張子"
```

* 大文字小文字を区別しない -i

```git
git grep -i '検索対象' 
```

* バイナリを除外 -I

```git
git grep -I '検索対象' 
```

### 行数を表示する

```sh
git config --global grep.lineNumber true
```
