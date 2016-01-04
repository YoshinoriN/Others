#### ディレクトリオブジェクト作成
```sql
CREATE DIRECTORY [DirectoryName] AS '[FolderPath]';
```
* sample
```sql
CREATE DIRECTORY MYDIR AS 'D:\TEMP';
```


#### 作成したディレクトリオブジェクトの確認
```sql
SELECT * FROM ALL_DIRECTORIES;
SELECT * FROM DBA_DIRECTORIES;
```

#### 権限付与
```sql
GRANT READ ON DIRECTORY [DirectoryName] TO [UserName];
GRANT WRITE ON DIRECTORY [DirectoryName] TO [UserName];
```

#### 削除
```Sql
DROP DIRECTORY [DirectoryName];
```
