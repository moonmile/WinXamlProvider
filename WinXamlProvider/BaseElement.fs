namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

[<AllowNullLiteral>]
type BaseElement() =
    member val target:obj  = null with get, set
    member this.getProp<'T>( propName:string ) =
        let pi = this.target.GetType().GetRuntimeProperty( propName )
        pi.GetValue(this.target) :?> 'T
    member this.setProp( propName:string, value:obj ) =
        let pi = this.target.GetType().GetRuntimeProperty( propName )
        pi.SetValue( this.target, value)

