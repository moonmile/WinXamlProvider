WinXamlProiver
===============
Dynamic loading XAML file of Windows.UI.Xaml 
 for Windows Store 8.1 and Windows Phone 8.1

F# でコードビハイドを書いて、Windows Store 8.1 と Windows Phone 8.1 で動作させるライブラリです。
少し、コツが要りますが、後々は修正する予定。

# Usage

- フロント XAML を C# のユニバーサルアプリで作成する
- コードビハイドを F# PCL で書く
- フロントで書いた XAML を Xaml/*.xml にコピーする（これは後で直す予定）
- フロント C# の MainPage に以下のように記述する

```
public MainPage()
{
    this.InitializeComponent();

	// パーサを作成
    var pa = new Moonmile.WinXamlProvider.WinRT.ParseXaml();
    pa.InitBind(
        this,		// MainPage 自身
        new WinXamlProvider.Lib.MainPage(),			// コードビハイドする F# ライブラリ
        new Uri("ms-appx:///Xaml/MainPage.xml"));	// バインドする XAML コード
}
```

XAML コードを *.xml に拡張子変換するのは、勝手にコンパイルされないようにするため。

F# のコードビハイドは、次のように書きます。

```
namespace WinXamlProvider.Lib
open System
open Moonmile.WinXamlProvider
open Moonmile.WinXamlProvider.UI

type MainPage() = 
    member val textMessage:TextBlock = null with get, set
    member this.Button_Click(sender:obj, e:RoutedEventArgs) =
        this.textMessage.Text <- "New F# message."
```

- TextBlock 等のコントロールは PCL で使えるように再定義されている。
- textMessage のような、コントロールの名前は C# と同じように x:Name に定義されているものを使う
- Button_Click のような、イベント名は C# のように Click="..." に定義されているものを使う

このあたりを、InitBind で再バインドします。

# NuGet

ちょっと待ち

# Sample

プロジェクト内の WinXamlSample 


# License

The MIT License (MIT)

# Future

- Windows.UI.Xaml 内を総再定義

# History

- ver.0.1.0 2014/07/28 アルファ版で公開

# 日本語の解説

ちょっと待ってて