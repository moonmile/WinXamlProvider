using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Windows.UI.Xaml;
using System.Reflection;
using System.Diagnostics;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Core;
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;
using Windows.UI;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Controls.Primitives;

namespace MakeElement
{
    [TestClass]
    public class MakeElement
    {
        [TestMethod]
        public void TestUIElement()
        {
            var fmt =
"    member this.{0}\n" +
"        with get() = base.getProp<{1}>(\"{0}\")\n" +
"        and set(value:{1}) = base.setProp(\"{0}\", value )";

            // プロパティ一覧を作成
            var mm = "";
            Type t = typeof(RoutedEventArgs);
            var pis = t.GetRuntimeProperties();
            foreach (var pi in pis)
            {
                // Debug.WriteLine("* name:{0}", pi.Name, 0);
                if (pi.GetMethod.IsStatic == false && pi.GetMethod.IsPublic ) 
                {
                    var m = string.Format(fmt, pi.Name, pi.PropertyType.Name);
                    // Debug.WriteLine(m);
                    mm += m + "\n";
                }
            }
            mm = string.Format("type {0}() = \n    inherit BaseElement()\n", t.Name) + mm;
            Debug.WriteLine(mm);
        }

        [TestMethod]
        public void TestStruct()
        {
            var fmt =
"    member val {0}:{1} = {2} with get, set";

            // プロパティ一覧を作成
            var mm = "";
            Type t = typeof(ClickMode);
            var pis = t.GetRuntimeProperties();
            foreach (var pi in pis)
            {
                // Debug.WriteLine("* name:{0}", pi.Name, 0);
                if (pi.GetMethod.IsStatic == false)
                {
                    object init = "0";
                    switch (pi.PropertyType.Name)
                    {
                        case "String": init = "\"\""; break;
                        case "Double": init = "0."; break;
                        case "Boolean": init = "false"; break;
                        default: init = "0"; break;
                    }
                    var m = string.Format(fmt, pi.Name, pi.PropertyType.Name, init);
                    // Debug.WriteLine(m);
                    mm += m + "\n";
                }
            }
            foreach (var fi in t.GetRuntimeFields())
            {
                if (fi.IsStatic == false && fi.IsPublic)
                {
                    object init = "0";
                    switch (fi.Name)
                    {
                        case "String": init = "\"\""; break;
                        case "Double": init = "0."; break;
                        case "Boolean": init = "false"; break;
                        default: init = "0"; break;
                    }
                    var m = string.Format(fmt, fi.Name, fi.FieldType.Name, init);
                    // Debug.WriteLine(m);
                    mm += m + "\n";
                }
            }
            mm = string.Format("type {0}() = \n", t.Name) + mm;
            Debug.WriteLine(mm);
        }

        [TestMethod]
        public void TestEnum()
        {
            var mm = "";
            var t = typeof(FlyoutPlacementMode);
            foreach ( var v in Enum.GetValues(t))
            {
                var name = Enum.GetName(t, v);
                var m = string.Format("    | {0} = {1}\n", name, (int)v);
                mm += m;
            }
            mm = string.Format("type {0} = \n", t.Name) + mm;
            Debug.WriteLine(mm);
        }
    }
}
