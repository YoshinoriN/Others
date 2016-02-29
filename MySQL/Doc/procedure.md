# プロシージャ

### 注意点
※ MySQLにはストアドパッケージは存在しない。

### デリミタを記述する
通常SQL文の最後はセミコロン「;」で終わる。

しかし、ストアドの途中に「;」が出てくればそこで終了していると判断されるため「;」の変わりに別の記号でSQLの終わりを宣言する。
```sql
delimiter //
```
この場合、SQLの終わりは「;」でなく、「//」となる。

### 変数宣言
```sql
declare x int;
declare y varchar(10);

# デフォルト値を設定する場合
declare i int default 1;

# sampleテーブルの結果を保存するカーソルの宣言
# declare [カーソル名] cursor for [SQL文];
declare cur cursor for select id, name from sample;
```

### 実行と確認
```sql
# 下記のプロシージャが存在するとする。
delimiter //
create procedure getMaxId(out x int)
begin
	select Max(id) into x from test;
	set x = x + 1;
end
//

# 実行
call getMaxId( @x );

# 確認
select  @x;
```
