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

