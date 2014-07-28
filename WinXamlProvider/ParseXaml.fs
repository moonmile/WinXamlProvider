namespace Moonmile.WinXamlProvider
open System
open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices.WindowsRuntime
open System.Linq
open Moonmile.WinXamlProvider.UI


type ParseXaml() = 

    let findName( page, propName ) =
        let mi = page.GetType().GetRuntimeMethod("FindName", [|typeof<string>|])
        let res = mi.Invoke( page, [|propName|])
        res

    let bindMethod( page:obj, bind:obj, target:obj, eventName:string, methodName:string) =
        let ei = target.GetType().GetRuntimeEvent(eventName)
        let dt = ei.AddMethod.GetParameters().[0].ParameterType
        let mi = bind.GetType().GetRuntimeMethod(methodName,[|typeof<obj>; typeof<RoutedEventArgs>|])

        let handler = 
            new Action<obj,obj>( 
                fun sender eventArgs ->
                    let e = new RoutedEventArgs(eventArgs)
                    mi.Invoke( bind, [|sender; e|]) |> ignore ) 
        

        let handlerInvoke = handler.GetType().GetRuntimeMethod("Invoke",[|typeof<obj>; typeof<Type[]> |]);
        let dele = handlerInvoke.CreateDelegate(dt, handler)
        
        let add = new Func<Delegate, EventRegistrationToken> ( fun (t) -> 
                        let ret = ei.AddMethod.Invoke(target, [|t|] ) 
                        ret :?> EventRegistrationToken  
                    )
        let remove = new Action<EventRegistrationToken>( fun(t) -> 
                ei.RemoveMethod.Invoke( target, [|t|]) |> ignore ) 
        WindowsRuntimeMarshal.AddEventHandler<Delegate>( add, remove, dele)

    let bindProperty( page:obj, bind:obj, propName:string, t:Type ) =
        let pprop = findName( page, propName )
        if pprop <> null then 
            let bi = bind.GetType().GetRuntimeProperty(propName)

            match t.Name with
            | "TextBlock" -> bi.SetValue( bind, new TextBlock(target = pprop))
            | "TextBox" -> bi.SetValue( bind, new TextBox(target = pprop))
            | "Button"    -> bi.SetValue( bind, new Button(target=pprop))
            | _ -> bi.SetValue( bind, new UIElement( target=pprop )) 

    /// <summary>
    /// XAMLを別のコードビハイドクラスにバインドする
    /// </summary>
    /// <param name="page">バインド元のC#のMainPage</param>
    /// <param name="bind">バインド先のF#のMainPage</param>
    member this.Bind(page:obj, bind:obj) =
        // bind 先に公開してあるプロパティを検索して自動バインドする
        // bindProperty( page, bind, "textMessage", typeof<TextBlock>)
        let pis = bind.GetType().GetRuntimeProperties().ToList()
        pis |> Seq.iter( fun(pi) -> 
            bindProperty( page, bind, pi.Name, pi.GetMethod.ReturnType ))

        // bind 先に公開してあるイベントメソッドを検索して自動バインドする
        // 1.bind.Button_Click を検索
        // 2.page.Button_Click を特定
        // 3.Button.Click event を特定
        // 4.page.btnClickMe を特定

        // ややこしいので、ひとまず、フロント側の C# で実現する
        
        //let mis = bind.GetType().GetRuntimeMethods().ToList()
        //for mib in mis do
        //    let bindName = mib.Name
        //    for mip in page.GetType().GetRuntimeMethods().ToList() do
        //        if mib.Name = mip.Name then


        // let btn = findName( page, "btnClickMe")
        // bindMethod( page, bind, btn, "Click", "Button_Click" )


    member this.BindMethod( page:obj, bind:obj, target:obj, eventName:string, methodName:string) =
        bindMethod( page, bind, target, eventName, methodName )

        