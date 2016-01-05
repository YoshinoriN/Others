### Svnからgitに移行する際にやったことまとめ

1. 不要ファイルを取り除く
--------------------------
(gitのほうでファイル削除してもいいはずだが、gitに完全移行する前に綺麗にしておきたかった。)

svndumpfilterで除外したいファイルを除いたSvn dumpファイルを出力する。

基本はexportもとを指定し、どのファイルを除外していくかつらつら記述する

#### オプション

　--drop-empty-revs:空になったリビジョンを取り除く。

　--renumber-revs:空になったリビジョンに番号を振りなおす。

　(Rev**で追加でコミットとかよくやってるので、うちのチームでは両方とも使えない)

```svn
svnadmin dump [Repository Path] | svndumpfilter exclude src/hoge.pdb document/hoo.xls > [Output dump file path]
```
#### その他

Exportもとでごちゃごちゃブランチとかきってた場合エラーがでて失敗する。

(不要なブランチだったので削除したらうまくいったはず・・・・これはだいぶ以前やったので覚えてない・・・)


2. Importする
---------------------
Import(Load)もとを指定し、どのダンプをImport(Load)するのか指定する

```svn
svnadmin load [New Repositoy path] < [Input dump file path]
```

SvndumpfilterとLoadを繰り返して除外ファイルを完全に取り除く。

3. コミットコメントをgit風に修正する
----------------------------------------
gitのGUIクライアントはコメントの1行目しか表示されないケースがおおいので、それにあわせたコミットコメントに修正する。

これもgit側で実施してもよいが、SVN側でTortoiseSVNでやったほうが楽なはずなので、gitの移行前にやっておく。

1行目にできるだけ詳細な内容をかく。書ききれないものは改行して記述する。

4. git svnする
----------------------------------------
「git svn clone」コマンドでSvnリポジトリをもとにローカルにgitリポジトリを作成する。

このときにSvnのリポジトリがある端末上でやってしまうのが早い。ネットワーク越しだと時間が掛かる。
(gitとsvnを併用するなら、gitを使用する人の端末でやらざるをえないが)  


Svnリポジトリのプロトコルがfileの場合は「git svn clone」コマンドをそのまま実行してもエラーになるのでSvnインストールフォルダの「svnserver」を実行する。
```svn
svnserve --daemon --root Svnリポジトリのパス
```
SvnServeを実行した状態で下記を実行する。
```git
git svn clone --prefix svn/ svn://locaohost
```

これでSvnリポジトリに紐づいたgitリポジトリが作成される。

git svnを使用して作成したgitリポジトリをgit cloneしても、ただのgitリポジトリにしかならないので注意。
