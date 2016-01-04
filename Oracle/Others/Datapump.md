#### DATAPUMPコマンド

##### EXPORT
----------------
```sql
EXPDP [****]/[****]@[*****] DUMPFILE=[DirectoryName]:[FileName].DMP LOGFILE=[DirectoryName]:[LogName].LOG
```

##### IMPORT
----------------
```sql
IMPDP [****]/[****]@[*****] DUMPFILE=[DirectoryName]:[FileName].DMP LOGFILE=[DirectoryName]:[LogName].LOG
```

[DirectoryName]⇒CREATE DIRECTORY で作った DirectoryName

[FileName]⇒EXPORTするファイル名

[LogName]⇒ログ出力するパス


##### 個人的によくつかうオプション
----------------------------------
* COMMENT=*****
* DATA_ONLY		⇒データのみ
* METADATA_ONLY	⇒メタデータのみ
* ALL				⇒全て
```sql
CONTENT=DATAONLY
```
* REMAP_SCHEMA(スキーマ名指定してデータのロード)
```sql
REMAP_SCHEMA=アンロードスキーマ:ロードスキーマ
```
* INCLUDE(対象オブジェクトを指定)
```sql
INCLUDE=TABLE:\"IN (\'TEST\')\"
TESTテーブルをロード、アンロード
```

ちなみに・・・

パッケージを上書きするようなオプションは存在しない。

##### DBLINKで直接流し込むとき
------------------------------
```sql
EXPDP   [EXP基]/[EXP基] DIRECTORY=[EXP基のDirectoryName] NETWORK_LINK=[DatBaseLinkName]
```

##### 途中で中断した場合
------------------------------
```sql
[Kill_Job] と入力した後に [yes]
```
これを入力しないとマスター表にゴミが残って以降のDATAPUMPが失敗する可能性がある。
