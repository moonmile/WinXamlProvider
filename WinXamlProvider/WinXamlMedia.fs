namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type GeneralTransform() = 
    inherit BaseElement()
    member this.InverseCore
        with get() = base.getProp<GeneralTransform>("InverseCore")
        and set(value:GeneralTransform) = base.setProp("InverseCore", value )
    member this.Inverse
        with get() = base.getProp<GeneralTransform>("Inverse")
        and set(value:GeneralTransform) = base.setProp("Inverse", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type Transform() = 
    inherit GeneralTransform()
    member this.InverseCore
        with get() = base.getProp<GeneralTransform>("InverseCore")
        and set(value:GeneralTransform) = base.setProp("InverseCore", value )
    member this.Inverse
        with get() = base.getProp<GeneralTransform>("Inverse")
        and set(value:GeneralTransform) = base.setProp("Inverse", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type Brush() = 
    inherit Transform()    
    member this.Transform
        with get() = base.getProp<Transform>("Transform")
        and set(value:Transform) = base.setProp("Transform", value )
    member this.RelativeTransform
        with get() = base.getProp<Transform>("RelativeTransform")
        and set(value:Transform) = base.setProp("RelativeTransform", value )
    member this.Opacity
        with get() = base.getProp<Double>("Opacity")
        and set(value:Double) = base.setProp("Opacity", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type FontFamily() = 
    inherit BaseElement()
    member this.Source
        with get() = base.getProp<String>("Source")
        and set(value:String) = base.setProp("Source", value )

type SolidColorBrush() = 
    inherit Brush()
    member this.Color
        with get() = base.getProp<Color>("Color")
        and set(value:Color) = base.setProp("Color", value )
    member this.Transform
        with get() = base.getProp<Transform>("Transform")
        and set(value:Transform) = base.setProp("Transform", value )
    member this.RelativeTransform
        with get() = base.getProp<Transform>("RelativeTransform")
        and set(value:Transform) = base.setProp("RelativeTransform", value )
    member this.Opacity
        with get() = base.getProp<Double>("Opacity")
        and set(value:Double) = base.setProp("Opacity", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type Geometry() = 
    inherit BaseElement()
    member this.Transform
        with get() = base.getProp<Transform>("Transform")
        and set(value:Transform) = base.setProp("Transform", value )
    member this.Bounds
        with get() = base.getProp<Rect>("Bounds")
        and set(value:Rect) = base.setProp("Bounds", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type RectangleGeometry() = 
    inherit BaseElement()
    member this.Rect
        with get() = base.getProp<Rect>("Rect")
        and set(value:Rect) = base.setProp("Rect", value )
    member this.Transform
        with get() = base.getProp<Transform>("Transform")
        and set(value:Transform) = base.setProp("Transform", value )
    member this.Bounds
        with get() = base.getProp<Rect>("Bounds")
        and set(value:Rect) = base.setProp("Bounds", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type CacheMode() = 
    inherit BaseElement()
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

type TransitionCollection() = 
    inherit BaseElement()

type Projection() = 
    inherit BaseElement()
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )