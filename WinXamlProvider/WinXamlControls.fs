namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type DataTemplateSelector() = 
    inherit BaseElement()

type ControlTemplate() = 
    inherit BaseElement()
    member this.TargetType
        with get() = base.getProp<Type>("TargetType")
        and set(value:Type) = base.setProp("TargetType", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type FlyoutBase() = 
    inherit BaseElement()
    member this.Placement
        with get() = base.getProp<FlyoutPlacementMode>("Placement")
        and set(value:FlyoutPlacementMode) = base.setProp("Placement", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )
