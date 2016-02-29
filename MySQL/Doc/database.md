# スキーマ

## スキーマ作成
---
MySQLではデータベース=スキーマと考えて問題ない。
```sql
create database testdb;
```

## キャラクタセット確認
```sql
show variables like 'character_set%';
```
