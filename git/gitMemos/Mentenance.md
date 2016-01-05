## リポジトリのメンテナンス
---

### git gc
---

##### Out of Memoryが出る場合 
「git gc --aggressive」を行った際に、処理するオブジェクトの数が多かったりすると、エラーが発生してしまう。

対処法として圧縮処理を行うスレッド数を減らすというものがある。
.gitconfigにOut of Memory発生時のスレッド数とCPUを加味して、pack時のスレッド数を減らすように指定する。

```git
[pack]
  threads = 2
```
* 参考にさせて頂いたサイト

> http://devadjust.exblog.jp/19298790/
