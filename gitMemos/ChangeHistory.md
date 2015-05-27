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

### ファイル/ディレクトリを履歴ごと消す

#### 1. ファイルを履歴ごと消す
* 特定の拡張子のファイルを消す場合、例えばtxtのファイルを消す場合は「*.txt」を指定する。
* ファイル名はスペースで区切ることで複数指定可能。例えば「*.txt *.log *.pdb」でそれぞれの拡張子のファイルを一括で削除できる。
```git
git filter-branch -f --index-filter 'git rm --cached --ignore-unmatch ファイル名' --prune-empty -- --all
```

#### 2. ディレクトリを履歴ごと消す
* ディレクトリを消す場合はルートディレクトリからのパスを指定しないといけない。
```git
git filter-branch -f --index-filter 'git rm -rf --cached --ignore-unmatch フォルダ名'  --prune-empty -- --all
```

#### 3. オプションとかその他
* 終了後にWarningが表示され、削除できなかった場合は、「git gc」を行った後に再度試すとうまくいくことがある。
* 「--prune-empty」で削除後のリビジョンが空になる場合、リビジョンごと削除する。
* 「-- --all」で全ブランチを対象とする。「--all」の前のハイフン2つは前のコマンドを終えることを意味するらしい、ハイフン2つをいれずに、「--all」だけ入力しても、全ブランチから削除されない。
