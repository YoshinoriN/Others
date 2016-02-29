# 条件分岐

### if~elsif
「elseif」ではなくて「elsif」
```ruby
x = 1
y = 2

if x > y
    puts "x is bigger than y"
elsif x < y
    puts "y is bigger than x"
else
    puts "equals"
end
```

### unless
条件分が偽の時に使用する。下記の場合だと「まだ大丈夫」になる。
```ruby
sleepy = false

unless sleepy
  puts "まだ大丈夫"
else
  puts "眠たいです"
end
```
