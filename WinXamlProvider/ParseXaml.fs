namespace Moonmile.WinXamlProvider
open System
open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices.WindowsRuntime
open Moonmile.WinXamlProvider.UI

type ParseXaml() = 

    let findName( page, propName ) =
        let mi = page.GetType().GetRuntimeMethod("FindName", [|typeof<string>|])
        let res = mi.Invoke( page, [|propName|])
        res

    let bindProperty( page:obj, bind:obj, propName:string ) =
        let pprop = findName( page, propName )
        let bi = bind.GetType().GetRuntimeProperty(propName)
        let elname = propName.Substring(propName.LastIndexOf(".")+1)
        match elname with
        | "TextBlock" -> bi.SetValue( bind, new TextBlock(target = pprop))
        | "Button"    -> bi.SetValue( bind, new Button(target=pprop))
        | _ -> bi.SetValue( bind, new UIElement( target=pprop )) 

    let bindMethod( page:obj, bind:obj, target:obj, eventName:string, methodName:string) =
        let ei = target.GetType().GetRuntimeEvent(eventName)
        let dt = ei.AddMethod.GetParameters().[0].ParameterType
        let mi = bind.GetType().GetRuntimeMethod(methodName,[|typeof<obj>; typeof<EventArgs>|])

        let handler = 
            new Action<obj,obj>( 
                fun sender eventArgs ->
                    let e = new EventArgs()
                    mi.Invoke( bind, [|sender; e|]) |> ignore ) 
        

        let handlerInvoke = handler.GetType().GetRuntimeMethod("Invoke",[|typeof<obj>; typeof<Type[]> |]);
        let dele = handlerInvoke.CreateDelegate(dt, handler)
        
        let add = new Func<Delegate, EventRegistrationToken> ( fun (t) -> 
                        let ret = ei.AddMethod.Invoke(target, [|t|] ) 
                        ret :?> EventRegistrationToken  
                    )
        let remove = new Action<EventRegistrationToken>( fun(t) -> 
                ei.RemoveMethod.Invoke( target, [|t|]) |> ignore 
                ) 
        WindowsRuntimeMarshal.AddEventHandler<Delegate>( add, remove, dele)

(*
        public void bindMethod(object page, object bind, object target, string eventName, string methodName)
        {
            var ei = target.GetType().GetRuntimeEvent(eventName);
            var dt = ei.AddMethod.GetParameters()[0].ParameterType;
            var mi = bind.GetType().GetRuntimeMethod(methodName, new Type[] { typeof(object), typeof(EventArgs) });

            Action<object, object> handler = (object sender, object eventArgs) =>
                mi.Invoke(bind, new object[] { sender, eventArgs as EventArgs });
            MethodInfo handlerInvoke = typeof(Action<object, object>).GetRuntimeMethod("Invoke", new Type[] { typeof(object), typeof(Type[]) });
            Delegate dele = handlerInvoke.CreateDelegate(dt, handler);

            Func<Delegate, EventRegistrationToken> add = (t) => (EventRegistrationToken)ei.AddMethod.Invoke(target, new object[] { t });
            Action<EventRegistrationToken> remove = t => 
                ei.RemoveMethod.Invoke(target, new object[] { t });
            WindowsRuntimeMarshal.AddEventHandler<Delegate>(add, remove, dele);
        }
*)

    member this.Bind(page:obj, bind:obj) =
        bindProperty( page, bind, "textMessage" )
        let btn = findName( page, "btnClickMe")
        bindMethod( page, bind, btn, "Click", "Button_Click" )


        