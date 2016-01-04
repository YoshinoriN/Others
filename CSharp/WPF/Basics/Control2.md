# 主なコントロール

### TextBlock
* 文字列のみを表示することができる。

### Label
* TextBlockと異なり、アクセスキーが使える。
* アクセスキーを使用すると、Bindingプロパティで指定したコントロールにフォーカスをあてることができる。例えば、下記の場合では「S」を押した場合に、「onRadioButton」にフォーカスが当たる。
* アクセスキーはアンダースコアを記述する。そのため、Labelの名前に「アンダースコア」を記述することはできない。

```xml
<Label Grid.Row="1" Content="スイッチ(_S)"
       Target="{Binding ElementName=onRadioButton, Mode=OneWay}" />
<StackPanel Grid.Row="1" Grid.Column="1">
    <RadioButton x:Name="onRadioButton" GroupName="Color"
                 Content="On" Checked="onRadioButton_Checked"/>
    <RadioButton x:Name="offRadioButton" GroupName="Color"
                 Content="Off" Checked="offRadioButton_Checked"/>
</StackPanel>
```

### RadioButton
* ラジオボタンをグループ化するにはレイアウトコントロールで階層を分けるか、「GroupName」を指定する。
* 下記の例では「difficulty」というグループ分けを行って、それぞれに「Checked」イベントを設定してる。

```xml
<StackPanel Grid.Row="1" Grid.Column="1">
    <RadioButton x:Name="hardRadioButton" GroupName="difficulty"
                 Content="難" Checked="hardRadioButton_Checked"/>
    <RadioButton x:Name="middleRadioButton" GroupName="difficulty"
                 Content="普" Checked="middleRadioButton_Checked"/>
    <RadioButton x:Name="easyRadioButton" GroupName="difficulty"
                 Content="易" Checked="easyRadioButton_Checked"/>
</StackPanel>
```
### ComboBox
* ComboBoxの選択肢をXamlで指定するには「ComboBoxItem」を記述する。

```xml
<ComboBox x:Name="sakeComboBox" Grid.Row="1" Grid.Column="1" SelectionChanged="sakeComboBox_SelectionChanged">
    <ComboBoxItem Content="陸奥八仙"/>
    <ComboBoxItem Content="東洋美人"/>
    <ComboBoxItem Content="紀土"/>
    <ComboBoxItem Content="忠臣蔵"/>
</ComboBox>
```

### 参考記事

> 日経ソフトウェア2015年8月号
