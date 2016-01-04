### オブジェクトの依存関係を確認する。
-----------------------------------

* DBA_DEPENDENCIESを確認すればよい。

|項目名					|説明											|備考						|
|-----------------------|-----------------------------------------------|---------------------------|
|OWNER					|参照側のオブジェクトの所有者					|							|
|NAME					|参照側のオブジェクト名							|							|
|TYPE					|参照側のオブジェクトの種類						|							|
|REFERENCED_OWNER		|参照される側のオブジェクトの所有者				|							|
|REFERENCED_NAME		|参照される側のオブジェクトの名前				|							|
|REFERENCED_TYPE		|参照される側のオブジェクトの種類				|							|
|REFERENCED_LINK_NAME	|親オブジェクトへのリンク名(リモートの場合)		|ALL_DEPENDENCIESの場合のみ	|


* 「USER_DEPENDENCIES」の場合、現行スキーマが対象。
* 「DBA_DEPENDENCIES」の場合、現行DBが対象。
* 「ALL_DEPENDENCIES」の場合、全DB対象。

以下サンプル
```sql
SELECT *
FROM	DBA_DEPENDENCIES
WHERE	OWNER = 'scott'				--参照するオブジェクトの所有者
AND		REFERENCED_OWNER = 'scott'	--参照されるオブジェクトの所有者
AND		REFERENCED_TYPE = 'TABLE'	--参照されるオブジェクトの種類
AND		NAME = 'EMP'				--参照するオブジェクトの名前
ORDER BY TYPE,NAME,REFERENCED_TYPE,REFERENCED_NAME
```

* どこからも参照されていないオブジェクトを確認する。

```sql
DECLARE
	CNT NUMBER(4);

	CURSOR C1 IS
			 SELECT OBJECT_NAME
					,OBJECT_TYPE
			 FROM	USER_OBJECTS
			 WHERE  OBJECT_TYPE NOT IN ('INDEX','VIEW','TRIGGER','DATABASE LINK','SEQUENCE')
			 ORDER BY OBJECT_TYPE,OBJECT_NAME;
BEGIN
	FOR C2 IN C1 LOOP
			
 			SELECT  COUNT(*)
			INTO	CNT
 			FROM    USER_DEPENDENCIES
 			WHERE     REFERENCED_NAME = C2.OBJECT_NAME
 			ORDER BY NAME,REFERENCED_TYPE,REFERENCED_NAME;
	
			IF CNT = 0 THEN
				DBMS_OUTPUT.PUT_LINE(C2.OBJECT_TYPE || ' : ' || C2.OBJECT_NAME);	
			END IF;

	END LOOP;
END;
```
