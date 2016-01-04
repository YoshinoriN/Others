# WPFのUI
### UIコントロール
* ボタン・テキストボックスといったコンポーネントのこと。
* 位置は相対的に決まるので、各コンポーネントのマージンで指定することになる。

### レイアウトコントロール
* UIコントロールの位置を決めるコンポーネントのこと。「Grid」「DockPanel」や「StackPanel」がある。
* WPFでは全ての親要素が「Window」になる。この「Window」子要素を配置していく。
* 子要素が望むサイズをもとに親要素が子要素を配置する。ただし、必ずしも子要素が望むサイズで配置されるとは限らない。

配置例) Winodow ⇒ DockPanel ⇒ StackPanel ⇒ 各UIコントロール(テキストボックスとか)

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
### MainWinodow.XamlとMainWinodow.xaml.cs
* MainWinodow.XamlとMainWinodow.xaml.csはコンパイル時に合わせて1つのクラスになる。これはMainWindow.csクラスが「Partial」で宣言されていることを見てもわかる。

### Grid
* マス目のように分割し、そのマス目にUI要素を配置するレイアウトコントロール。利用機会が多いらしい。
* 「RowDefinition」と「ColumnDefinition」で分割数を定義する。自動サイジング「Auto」と絶対値指定されたサイズ（下記の場合は「ColumnDefinition」の4列目の100）が確保される。そのあとに残りの全てが「*（下記でいうと「ColumnDefinition」の5列目）」に割り当てられる。


```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="Auto"/>
        <ColumnDefinition Width="Auto"/>
        <ColumnDefinition Width="Auto"/>
        <ColumnDefinition Width="100"/>
        <ColumnDefinition Width="*"/>
    </Grid.ColumnDefinitions>
</Grid>
```

* マス目にどのように配置するかは「Grid.Row="1"」「Grid.Column="3"」というように書く。省略した場合は、「0」を指定したとみなされる。

```xml
<TextBox Grid.Column="1" Text="入力してください"/>
<Label Grid.Row="1" Content="題名"/>
```



### 参考記事

> 日経ソフトウェア2015年8月号
