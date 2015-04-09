### 過去のコミットコメントを書き換える
```git
git rebase -i 書き換え前のコミット番号
```

エディタが立ち上がるので、[pick]を[edit]に書き換える。
Git Bashにもどるので、下記のコマンドを打つ。

```git
git commit --amend
```
エディタが立ち上がるのでコミットコメントを書き直す。
再度Git Bashにもどるので、下記のコマンドを打つ。

```git
git rebase --continue
```

### ファイルを履歴ごと消す(全部ブランチ)
```git
git filter-branch -f --index-filter 'git rm --cached --ignore-unmatch フォルダ名' 
```

### フォルダを履歴ごと消す(全部ブランチ)
```git
git filter-branch -f --index-filter 'git rm -rf --cached --ignore-unmatch フォルダ名' 
```

