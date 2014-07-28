using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.ApplicationModel.Core;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using System.IO;


namespace Moonmile.WinXamlProvider.WinRT
{
    public sealed class ParseXaml
    {
        Page _page;
        public void InitBind(Page page, object bind, Uri path)
        {
            _page = page;

            var pa = new Moonmile.WinXamlProvider.ParseXaml();
            var bi = bind; //  new WinXamlProvider.Lib.MainPage();
            pa.Bind(page, bi);

            MakeXamlDic(path).ContinueWith(
                (dic) =>
                {
                    // Debug.WriteLine("complete MakeXamlDic");
                    CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                        CoreDispatcherPriority.Normal,
                        () =>
                        {
                            foreach (var item in this.LstUIXaml)
                            {
                                pa.BindMethod(pa, bi, item.UI, item.EventName, item.MethodName);
                            }
                        }).AsTask().ContinueWith((t) => { });

                });
        }
        Dictionary<DependencyObject, XElement> UItoXel = new Dictionary<DependencyObject, XElement>();

        List<UIXaml> LstUIXaml = new List<UIXaml>();
        private class UIXaml
        {
            public DependencyObject UI { get; set; }
            public XElement Xel { get; set; }
            public string EventName { get; set; }
            public string MethodName { get; set; }
        }

        private async Task<Dictionary<DependencyObject, XElement>> MakeXamlDic(Uri path)
        {
            var doc = await loadXaml(path);
            var vit = VisualTreeToList(_page).GetEnumerator();
            var eit = XElementToList(doc.Root).GetEnumerator();

            while (vit.MoveNext())
            {
                var vname = vit.Current.GetType().Name;
                while (eit.MoveNext())
                {
                    if (eit.Current.Name.LocalName == vname ||
                        eit.Current.Name.LocalName == "Page")
                    {
                        Debug.WriteLine("{0} {1}", vname, eit.Current.Name.LocalName);
                        this.UItoXel.Add(vit.Current, eit.Current);

                        foreach (var attr in eit.Current.Attributes())
                        {
                            switch (attr.Name.LocalName)
                            {
                                case "Click":
                                    this.LstUIXaml.Add(new UIXaml()
                                    {
                                        UI = vit.Current,
                                        Xel = eit.Current,
                                        EventName = attr.Name.LocalName,
                                        MethodName = attr.Value
                                    });
                                    break;
                            }
                        }
                        break;
                    }
                }
            }
            return this.UItoXel;
        }
        List<DependencyObject> VisualTreeToList(DependencyObject obj, List<DependencyObject> lst = null)
        {
            if (lst == null)
            {
                lst = new List<DependencyObject>();
            }
            lst.Add(obj);
            int cnt = VisualTreeHelper.GetChildrenCount(obj);
            for (int i = 0; i < cnt; i++)
            {
                var ch = VisualTreeHelper.GetChild(obj, i);
                lst = VisualTreeToList(ch, lst);
            }
            return lst;
        }
        List<XElement> XElementToList(XElement obj, List<XElement> lst = null)
        {
            if (lst == null)
            {
                lst = new List<XElement>();
            }
            lst.Add(obj);
            var nd = obj.FirstNode;
            while (nd != null)
            {
                if (nd is XElement)
                {
                    lst = XElementToList(nd as XElement, lst);
                }
                nd = nd.NextNode;
            }
            return lst;
        }
        async Task<XDocument> loadXaml(Uri path)
        {
            try
            {
                var st = await StorageFile.GetFileFromApplicationUriAsync(path);
                var sr = await st.OpenStreamForReadAsync();
                var doc = XDocument.Load(sr);
                return doc;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
