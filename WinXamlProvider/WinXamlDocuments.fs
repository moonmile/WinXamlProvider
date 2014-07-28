namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type InlineCollection() = 
    inherit BaseElement()
    member this.Size
        with get() = base.getProp<UInt32>("Size")
        and set(value:UInt32) = base.setProp("Size", value )

