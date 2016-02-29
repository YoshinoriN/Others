# ユーザー

## 作成
---
パスワードはシングルクォーテーションで囲む
```sql
create user ****@ホスト名 identified by '****';
```

## 確認
---
Userはmysqlというスキーマ(?)に格納されている
```sql
select user, host from mysql.user;
```
