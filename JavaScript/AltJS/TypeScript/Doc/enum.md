# 列挙型

TypeScriptでは列挙型が使用できる。

```js
enum DaysOfWeek{
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
	Sunday = 7
}
```
上記のTypeScriptをJavaScriptにコンパイルしたものは下記になる。

```js
var DaysOfWeek;
(function (DaysOfWeek) {
    DaysOfWeek[DaysOfWeek["Monday"] = 1] = "Monday";
    DaysOfWeek[DaysOfWeek["Tuesday"] = 2] = "Tuesday";
    DaysOfWeek[DaysOfWeek["Wednesday"] = 3] = "Wednesday";
    DaysOfWeek[DaysOfWeek["Thursday"] = 4] = "Thursday";
    DaysOfWeek[DaysOfWeek["Friday"] = 5] = "Friday";
    DaysOfWeek[DaysOfWeek["Saturday"] = 6] = "Saturday";
    DaysOfWeek[DaysOfWeek["Sunday"] = 7] = "Sunday";
})(DaysOfWeek || (DaysOfWeek = {}));
```

整数値を省略することもできるが、JavaScriptコンパイル時に「0」から自動的に連番が割り当てられる。

## 列挙型を使ったサンプル

```js
enum DaysOfWeek{
	Monday = 1,
	Tuesday = 2,
	Wednesday = 3,
	Thursday = 4,
	Friday = 5,
	Saturday = 6,
	Sunday = 7
}

var daysOfWeek:DaysOfWeek;
daysOfWeek = DaysOfWeek.Monday;

if(daysOfWeek = DaysOfWeek.Monday){
	alert("月曜日.....")
}
else{
	alert("月曜日ではない")	
}
```
