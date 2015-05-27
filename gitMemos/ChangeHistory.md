### 過去のコミットコメントを書き換える
```git
git rebase -i 書き換え前のコミット番号
```

エディタが立ち上がるので、[pick]を[reword]に書き換える。
Git Bashにもどるので、下記のコマンドを打つ。

```git
git commit --amend
```
エディタが立ち上がるのでコミットコメントを書き直す。
再度Git Bashにもどるので、下記のコマンドを打つ。

```git
git rebase --continue
```

### ファイルを履歴ごと消す(全ブランチ)
* 特定の拡張子のファイルを消す場合、例えばtxtのファイルを消す場合は「*.txt」を指定する。
* 終了後にWarningが表示され、削除できなかった場合は、「git gc」を行った後に再度試すとうまくいくことがある。
```git
git filter-branch -f --index-filter 'git rm --cached --ignore-unmatch ファイル名' 
```

### フォルダを履歴ごと消す(全ブランチ)
* フォルダを消す場合はフォルダのルートディレクトリからのパスを指定しないといけない。
* 終了後にWarningが表示され、削除できなかった場合は、「git gc」を行った後に再度試すとうまくいくことがある。
```git
git filter-branch -f --index-filter 'git rm -rf --cached --ignore-unmatch フォルダ名' 
```

