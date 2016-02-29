# テーブル

## テーブル作成
```sql
create table sample	(id int not null primary key, name varchar(10));
```

## テーブル削除
```sql
drop table sample
```

## テーブルに関する情報の取得
```sql
show table status like 'テーブル名';
```

## Auto Increment
* 1テーブルで1カラムにのみ設定できる。
* Auto Incrementが設定されているカラムは自動で連番が格納される。
* 最大値の次の値が表示される。(次に自動で設定される値が表示される。)
* レコードを削除しても、Auto Incrementは減らない。
* Auto Incrementが設定されたカラムに任意の数値を指定したレコードを追加した場合、「本来の次回の値」と「今回追加したレコードの値」を比較して、大きい方を基にして、次回の値が決まる。
