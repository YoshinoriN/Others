#### 全テーブルに対して監査を作成します
* スキーマのテーブル名と監査ポリシービュー内のテーブル名を比較して、存在しないテーブル一覧を取得
```sql
BEGIN
	FOR TABLES_CURSOR IN (SELECT UO.OBJECT_NAME
				FROM USER_OBJECTS UO
				WHERE NOT EXISTS (SELECT *
					  	  FROM	DBA_AUDIT_POLICIES AUD_PO
					  	  WHERE	UO.OBJECT_NAME = AUD_PO.OBJECT_NAME
				 	  	 )
				AND UO.OBJECT_TYPE = 'TABLE'
				 )
	LOOP
		BEGIN
		    --テーブル名で監査ポリシーを作成します
		    --サンプルはINSERTとUPDATEを監査対象とする
			DBMS_FGA.ADD_POLICY(OBJECT_NAME => TABLES_CURSOR.OBJECT_NAME
					    ,POLICY_NAME => TABLES_CURSOR.OBJECT_NAME
					    --,AUDIT_CONDITION => TABLES_CURSOR.OBJECT_NAME
					    ,STATEMENT_TYPES => 'INSERT,UPDATE'
					    );
		END;
	END LOOP;
END;
```
