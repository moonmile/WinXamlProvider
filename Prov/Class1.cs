using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;


namespace Prov
{
    public class ParseXaml
    {
        public void Bind(object page, object bind)
        {
            BindProperty( page, bind, "textMessage" );
            var btn = FindName(page, "btnClickMe");
            bindMethod(page, bind, btn, "Click", "Button_Click");

        }
        public void bindMethod(object page, object bind, object target, string eventName, string methodName)
        {
            var ei = target.GetType().GetRuntimeEvent(eventName);
            var dt = ei.AddMethod.GetParameters()[0].ParameterType;
            var mi = bind.GetType().GetRuntimeMethod(methodName, new Type[] { typeof(object), typeof(EventArgs) });
            // var de = mi.CreateDelegate(dt, this);
            // ei.AddEventHandler(this.btnClickMe, de);


            Action<object, object> handler = (object sender, object eventArgs) =>
                mi.Invoke(bind, new object[] { sender, eventArgs as EventArgs });
            MethodInfo handlerInvoke = typeof(Action<object, object>).GetRuntimeMethod("Invoke", new Type[] { typeof(object), typeof(Type[]) });
            Delegate dele = handlerInvoke.CreateDelegate(dt, handler);

            Func<Delegate, EventRegistrationToken> add = (t) => (EventRegistrationToken)ei.AddMethod.Invoke(target, new object[] { t });
            Action<EventRegistrationToken> remove = t => 
                ei.RemoveMethod.Invoke(target, new object[] { t });
            // WindowsRuntimeMarshal.RemoveAllEventHandlers(remove);
            WindowsRuntimeMarshal.AddEventHandler<Delegate>(add, remove, dele);

        }

        public object FindName(object page, string propName)
        {
            var mi = page.GetType().GetRuntimeMethod("FindName", new Type[] { typeof(string) });
            var res = mi.Invoke(page, new object[] { propName });
            return res;
        }
        public void BindProperty(object page, object bind, string propName)
        {
            var prop = FindName(page, propName);
            var bi = bind.GetType().GetRuntimeProperty(propName);
            var el = new UIElement() { target = prop };
            bi.SetValue(bind, el);

        }
    }
    public class UIElement {
        public object target { get; set; }
        public string Text {
            get {
                var pi = this.target.GetType().GetRuntimeProperty("Text");
                return pi.GetValue(this.target) as String ;
        }
            set {
                var pi = this.target.GetType().GetRuntimeProperty("Text");
                pi.SetValue( this.target, value);
            }
        }
    }
}
