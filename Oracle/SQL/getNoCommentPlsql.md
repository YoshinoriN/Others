PLSQLではエラー発生行番号がコンパイル前のPLSQLとずれる。

おそらく、コンパイル時にコメント行が削除されているためと思われる。

下記スクリプトはコメント行を省いたPLSQLのコードを表示するもの。

#### ワークテーブルを作る

```sql
CREATE TABLE NO_COMMENT_PLSQL(REGIST_LINE		NUMBER
							 ,TEXT	VARCHAR2(4000))
							  ;
```

#### 下記を実行するとワークテーブルにコメントなしのPLSQLが出力される

```sql
DECLARE

OBJ_NAME	VARCHAR2(30);
OBJ_TYPE	VARCHAR2(30);
MIN_LINE	NUMBER;
MIN_LINE2	NUMBER;
CNT		NUMBER;

BEGIN
	OBJ_NAME := '*******';		--対象オブジェクト名
	OBJ_TYPE := '*******';		--対象オブジェクトの種類[PACKAGE BODY とか]

	--ワークテーブルの初期化
	DELETE FROM NO_COMMENT_PLSQL;

	--ワークテーブルに対象オブジェクトを格納（通常コメントアウト「--」を除いて格納）

	INSERT INTO NO_COMMENT_PLSQL
	SELECT	LINE
			,TEXT
	FROM	USER_SOURCE
	WHERE	NAME = OBJ_NAME
	AND		TYPE = OBJ_TYPE
	AND		NOT SUBSTR(TEXT,1,2) LIKE '--%'
	AND		LENGTHB(TRIM(REPLACE(TEXT,chr(9),''))) != 1		--タブで格納されている可能性を考慮
	ORDER BY LINE
	;

	--一括コメントアウト「/* ～ */」が存在するか確認
	SELECT	COUNT(*)
	INTO	CNT
	FROM	NO_COMMENT_PLSQL
	WHERE	(SUBSTR(TRIM(REPLACE(TEXT,chr(9),'')),1,2) = '/*'
						 OR TRIM(REPLACE(TEXT,chr(9),'')) LIKE '%*/%')
	;

	--一括コメントアウトが存在している場合は削除する
	IF CNT != 0 THEN
		LOOP
			--一括コメントアウトの開始行を取得
			SELECT	MIN(REGIST_LINE)
			INTO	MIN_LINE
			FROM	NO_COMMENT_PLSQL
			WHERE 	SUBSTR(TRIM(REPLACE(TEXT,chr(9),'')),1,2) = '/*'
			;

			--一括コメントアウトの終了行を取得
			SELECT	MIN(REGIST_LINE)
			INTO	MIN_LINE2
			FROM 	NO_COMMENT_PLSQL
			WHERE 	REGIST_LINE > (SELECT MIN(REGIST_LINE) FROM NO_COMMENT_PLSQL)
			AND		TRIM(REPLACE(TEXT,chr(9),'')) LIKE '%*/%'
			;

			--一括コメントアウトの開始～終了行を削除
			DELETE FROM NO_COMMENT_PLSQL
			WHERE REGIST_LINE BETWEEN MIN_LINE AND MIN_LINE2
			;

			--一括コメントアウトが残っているか確認する
			SELECT	COUNT(*)
			INTO	CNT
			FROM	NO_COMMENT_PLSQL
			WHERE	(SUBSTR(TRIM(REPLACE(TEXT,chr(9),'')),1,2) = '/*'
				OR TRIM(REPLACE(TEXT,chr(9),'')) LIKE '%*/%')
			;

			--一括コメントアウトがなくなるなればループ脱出
			EXIT WHEN CNT=0;
		END LOOP;
	END IF;

--	COMMIT;		--ファイル出力する時など、必要に応じて
END;
```
#### 最後に下記SQLで確認

```sql
SELECT  ROW_NUMBER() OVER (ORDER BY NCP.REGIST_LINE) ROW_ID		--コメント削除後のPLSQL行
		,NCP.REGIST_LINE					--コメント削除前のPLSQL行
		,NCP.TEXT						--対象行のコード
FROM	NO_COMMENT_PLSQL NCP
;
```
