namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection


[<AllowNullLiteral>]
type UIElement() =
    member val target:obj  = null with get, set
    member this.getProp<'T>( propName:string ) =
        let pi = this.target.GetType().GetRuntimeProperty( propName )
        pi.GetValue(this.target) :?> 'T
    member this.setProp( propName:string, value:obj ) =
        let pi = this.target.GetType().GetRuntimeProperty( propName )
        pi.SetValue( this.target, value)


[<AllowNullLiteral>]
type FrameworkElement() = 
    inherit UIElement()

[<AllowNullLiteral>]
type Control() = 
    inherit FrameworkElement()

[<AllowNullLiteral>]
type ContentControl() =
    inherit Control()

[<AllowNullLiteral>]
type ButtonBase() =
    inherit ContentControl()

[<AllowNullLiteral>]
type Button() =
    inherit ButtonBase()

[<AllowNullLiteral>]
type TextBox() =
    inherit Control()

[<AllowNullLiteral>]
type TextBlock() =
    inherit FrameworkElement()
    member this.Text
        with get() = base.getProp<string>("Text")
        and set(value:string) = base.setProp("Text", value )





      