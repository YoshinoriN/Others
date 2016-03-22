# robocopy

## 指定した拡張子を除いて上書きする

```cmd
robocopy "元ディレクトリ" "コピー先" /S /NP /is /R:0 /E /NFL /NDL /NS /xf 除外したい拡張子をスペースで区切る (例)*.pdb *.log *.bak *.xml
```
