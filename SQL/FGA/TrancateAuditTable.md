#### 普通
```sql
TRUNCATE TABLE SYS.AUD$;
```

#### Oracle Data vaultをインストールしている場合は systemユーザの所有になっているので下記でTruncateする
```sql
TRUNCATE TABLE SYSTEM.AUD$;
```
