#### 作成した監査ポリシーの確認
* [ENABLE]が[YES]か[NO]かでポリシーが有効か無効化判断する
```sql
SELECT * FROM DBA_AUDIT_POLICIES;
```

#### 監査結果の確認
```sql
SELECT * FROM DBA_FGA_AUDIT_TRAIL;
```
