### ベアリポジトリの同期を取る

* 全部ブランチの同期を取る場合は下記のように記載する。
* 「--prune」オプションをつけた場合、originでブランチが削除されていたら、ローカル側のBareリポジトリのブランチも削除される。
```git
git fetch origin --prune 'refs/heads/*:refs/heads/*'
```
* ブランチを指定する場合は「*」のところをブランチ名に変更する。下記は「master」のみ同期する場合。
```git
git fetch origin 'refs/heads/master:refs/heads/master'
```
* fast-forwardできない場合は、実行時にできなかったブランチの前に ![rejected] と表示される。
