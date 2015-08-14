# WPFのUI
### UIコントロール
* ボタン・テキストボックスといったコンポーネントのこと。
* 位置は相対的に決まるので、各コンポーネントのマージンで指定することになる。

### レイアウトコントロール
* UIコントロールの位置を決めるコンポーネントのこと。「DockPanel」や「StackPanel」がある。
* WPFでは全ての親要素が「Window」になる。この「Window」子要素を配置していく。
* 子要素が望むサイズをもとに親要素が子要素を配置する。ただし、必ずしも子要素が望むサイズで配置されるとは限らない。

例) Winodow ⇒ DockPanel ⇒ StackPanel ⇒ 各UIコントロール(テキストボックスとか)

下のサンプルはDockPanelの中に2つのStackPanelと各StackPanelの中にTextBox,TextBlockを配置したもの。

```xml
<Window x:Class="UIConpornent.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:UIConpornent"
        mc:Ignorable="d"
        Title="MainWindow" Height="350" Width="525">
    <DockPanel Margin="0,0,2,0">
        <StackPanel RenderTransformOrigin="-0.418,0.474" DockPanel.Dock="Bottom" Orientation="Horizontal" VerticalAlignment="Center" Margin="0">
            <StackPanel.RenderTransform>
                <TransformGroup>
                    <ScaleTransform/>
                    <SkewTransform AngleX="0.497"/>
                    <RotateTransform/>
                    <TranslateTransform X="0.477"/>
                </TransformGroup>
            </StackPanel.RenderTransform>
            <Button x:Name="OkButton" Content="Button" Height="21" Margin="0" VerticalAlignment="Top" Width="60" Click="OkButton_Click"/>
            <Button x:Name="cancelButton" Content="Button" Height="21" Margin="10,0,0,0" Width="60" HorizontalAlignment="Left"/>
        </StackPanel>
        <StackPanel>
            <TextBlock x:Name="textBlock" TextWrapping="Wrap" Text="メッセージを入力してください。"/>
            <TextBox x:Name="textBox" Height="23" TextWrapping="Wrap" Width="120" HorizontalAlignment="Left"/>
        </StackPanel>
    </DockPanel>
</Window>
```

### Xamlコードと

### 参考記事

> 日経ソフトウェア2015年8月号
