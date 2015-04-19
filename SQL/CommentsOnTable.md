#### テーブルにコメントを入れる
```sql
COMMENT ON TABLE テーブル名 IS '入れたいコメント';
```
#### カラムにコメントを入れる
```sql
COMMENT ON COLUMN テーブル名.COL1 IS '入れたいコメント';
COMMENT ON COLUMN テーブル名.COL2 IS '入れたいコメント';
```

* UPDATEしたい場合は COMMENT ON で新しい値を指定する。
* 削除したい場合は COMMTNE ON で NULL('')を指定する。

#### テーブルにつけたコメントを参照する
```sql
SELECT * FROM USER_TAB_COMMENTS;
```

#### カラムにつけたコメントを参照する
```sql
SELECT * FROM USER_COL_COMMENTS
WHERE TABLE_NAME = 'テーブル名'
```

#### テーブルと列のコメントを一括で参照する
```sql
SELECT	TBL.TABLE_NAME
		,TBL.COMMENTS
		,COL.COLUMN_NAME
		,COL.COMMENTS
FROM	 USER_COL_COMMENTS COL
		,USER_TAB_COMMENTS TBL
WHERE 	TBL.TABLE_NAME = COL.TABLE_NAME
AND		TBL.COMMENTS IS NOT NULL
ORDER BY TBL.TABLE_NAME
		,COL.COLUMN_NAME
```
