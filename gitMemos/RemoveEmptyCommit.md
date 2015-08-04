### 空のコミットを削除する。
---
* git filter-branch で存在しないファイルを指定して --prune-empty オプションをつけて実行するとよい。

```git
git filter-branch -f --index-filter 'git rm --cached --ignore-unmatch 存在しないファイルを指定' --prune-empty -- --all
```
