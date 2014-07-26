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
            /*
            // this.btnClickMe.Click += Button_Click2;  
            var ei = btnClickMe.GetType().GetRuntimeEvent("Click");
            var dt = ei.AddMethod.GetParameters()[0].ParameterType;
            var mi = this.GetType().GetRuntimeMethod("Button_Click2", new Type[] { typeof(object), typeof(RoutedEventArgs) });
            // var de = mi.CreateDelegate(dt, this);
            // ei.AddEventHandler(this.btnClickMe, de);

            Action<object, object> handler = (object sender, object eventArgs) =>
                mi.Invoke(this, new object[] { sender, eventArgs });
            MethodInfo handlerInvoke = typeof(Action<object, object>).GetRuntimeMethod("Invoke", new Type[] { typeof(object), typeof(Type[]) });
            Delegate dele = handlerInvoke.CreateDelegate(dt, handler);

            var instance = btnClickMe;
            Func<EventRegistrationToken> add = () => (EventRegistrationToken)ei.AddMethod.Invoke(instance, new object[] { dele });
            Action<EventRegistrationToken> remove = t => ei.RemoveMethod.Invoke(instance, new object[] { t });

            add();
            */

            // var parse = new Moonmile.WinXamlProvider.ParseXaml();
            // var bindpage = new WinXamlProvider.Lib.MainPage();
            // parse.Bind(this, this, bindpage);

            // var parse = new Prov.ParseXaml();
            // var bind = new Prov.lib.BindData();
            // parse.Bind(this, bind );

            var pa = new Moonmile.WinXamlProvider.ParseXaml();
            var bi = new WinXamlProvider.Lib.MainPage();
            pa.Bind(this, bi);

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            this.textMessage.Text = "old message.";

            /// dummy 
        }
        public void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.textMessage.Text = "old message2.";

            /// dummy 
        }
    }

    /*
    public class ParseXaml
    {
        public void BindTest(object page, object bind, object btn)
        {
            bindMethod(page, bind, btn, "Click", "Button_Click");

        }
        public void bindMethod(object page, object bind, object target, string eventName, string methodName)
        {
            var ei = target.GetType().GetRuntimeEvent(eventName);
            var dt = ei.AddMethod.GetParameters()[0].ParameterType;
            var mi = bind.GetType().GetRuntimeMethod(methodName, new Type[] { typeof(object), typeof(RoutedEventArgs) });
            // var de = mi.CreateDelegate(dt, this);
            // ei.AddEventHandler(this.btnClickMe, de);

            Action<object, object> handler = (object sender, object eventArgs) =>
                mi.Invoke(bind, new object[] { sender, eventArgs });
            MethodInfo handlerInvoke = typeof(Action<object, object>).GetRuntimeMethod("Invoke", new Type[] { typeof(object), typeof(Type[]) });
            Delegate dele = handlerInvoke.CreateDelegate(dt, handler);

            Func<EventRegistrationToken> add = () => (EventRegistrationToken)ei.AddMethod.Invoke(target, new object[] { dele });
            Action<EventRegistrationToken> remove = t => ei.RemoveMethod.Invoke(target, new object[] { t });
            add();
        }
    }
    public class BindData
    {
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("click");
            /// dummy 
        }
    }
    */
}
