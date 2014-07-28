using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Reflection;
using System.Diagnostics;
using System.Xml.Linq;
using Windows.Storage;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.ApplicationModel.Core;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace WinXamlProvider
{
    /// <summary>
    /// Frame 内へナビゲートするために利用する空欄ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
public MainPage()
{
    this.InitializeComponent();

    var pa = new Moonmile.WinXamlProvider.WinRT.ParseXaml();
    pa.InitBind(
        this,
        new WinXamlProvider.Lib.MainPage(),
        new Uri("ms-appx:///Xaml/MainPage.xml"));
}

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            /// dummy 
        }
    }
}
