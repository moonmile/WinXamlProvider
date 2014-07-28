namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type CoreDispatcher() = 
    inherit BaseElement()
    member this.CurrentPriority
        with get() = base.getProp<CoreDispatcherPriority>("CurrentPriority")
        and set(value:CoreDispatcherPriority) = base.setProp("CurrentPriority", value )
    member this.HasThreadAccess
        with get() = base.getProp<Boolean>("HasThreadAccess")
        and set(value:Boolean) = base.setProp("HasThreadAccess", value )

type DependencyObject() = 
    inherit BaseElement()
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type RoutedEventArgs(eventArgs:obj) = 
    inherit BaseElement()
    do 
        base.target <- eventArgs

    member this.OriginalSource
        with get() = base.getProp<Object>("OriginalSource")
        and set(value:Object) = base.setProp("OriginalSource", value )

    
