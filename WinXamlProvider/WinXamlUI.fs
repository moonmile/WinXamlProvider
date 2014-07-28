namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

[<AllowNullLiteral>]
type SetterBaseCollection() = 
    inherit BaseElement()
    member this.IsSealed
        with get() = base.getProp<Boolean>("IsSealed")
        and set(value:Boolean) = base.setProp("IsSealed", value )

type TriggerCollection() = 
    inherit BaseElement()

type ResourceDictionary() = 
    inherit DependencyObject()
    member this.Source
        with get() = base.getProp<Uri>("Source")
        and set(value:Uri) = base.setProp("Source", value )
    //member this.MergedDictionaries
    //    with get() = base.getProp<IList`1>("MergedDictionaries")
    //    and set(value:IList`1) = base.setProp("MergedDictionaries", value )
    //member this.ThemeDictionaries
    //    with get() = base.getProp<IDictionary`2>("ThemeDictionaries")
    //    and set(value:IDictionary`2) = base.setProp("ThemeDictionaries", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

[<AllowNullLiteral>]
type Style() = 
    inherit BaseElement()
    member this.TargetType
        with get() = base.getProp<Type>("TargetType")
        and set(value:Type) = base.setProp("TargetType", value )
    member this.BasedOn
        with get() = base.getProp<Style>("BasedOn")
        and set(value:Style) = base.setProp("BasedOn", value )
    member this.IsSealed
        with get() = base.getProp<Boolean>("IsSealed")
        and set(value:Boolean) = base.setProp("IsSealed", value )
    member this.Setters
        with get() = base.getProp<SetterBaseCollection>("Setters")
        and set(value:SetterBaseCollection) = base.setProp("Setters", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

[<AllowNullLiteral>]
type UIElement() =
    inherit BaseElement()


[<AllowNullLiteral>]
type FrameworkElement() = 
    inherit BaseElement()
    member this.Language
        with get() = base.getProp<String>("Language")
        and set(value:String) = base.setProp("Language", value )
    member this.HorizontalAlignment
        with get() = base.getProp<HorizontalAlignment>("HorizontalAlignment")
        and set(value:HorizontalAlignment) = base.setProp("HorizontalAlignment", value )
    member this.Height
        with get() = base.getProp<Double>("Height")
        and set(value:Double) = base.setProp("Height", value )
    member this.MaxWidth
        with get() = base.getProp<Double>("MaxWidth")
        and set(value:Double) = base.setProp("MaxWidth", value )
    member this.FlowDirection
        with get() = base.getProp<FlowDirection>("FlowDirection")
        and set(value:FlowDirection) = base.setProp("FlowDirection", value )
    member this.DataContext
        with get() = base.getProp<Object>("DataContext")
        and set(value:Object) = base.setProp("DataContext", value )
    member this.MaxHeight
        with get() = base.getProp<Double>("MaxHeight")
        and set(value:Double) = base.setProp("MaxHeight", value )
    member this.Name
        with get() = base.getProp<String>("Name")
        and set(value:String) = base.setProp("Name", value )
    member this.Width
        with get() = base.getProp<Double>("Width")
        and set(value:Double) = base.setProp("Width", value )
    member this.VerticalAlignment
        with get() = base.getProp<VerticalAlignment>("VerticalAlignment")
        and set(value:VerticalAlignment) = base.setProp("VerticalAlignment", value )
    member this.Tag
        with get() = base.getProp<Object>("Tag")
        and set(value:Object) = base.setProp("Tag", value )
    member this.Style
        with get() = base.getProp<Style>("Style")
        and set(value:Style) = base.setProp("Style", value )
    member this.Resources
        with get() = base.getProp<ResourceDictionary>("Resources")
        and set(value:ResourceDictionary) = base.setProp("Resources", value )
    member this.Margin
        with get() = base.getProp<Thickness>("Margin")
        and set(value:Thickness) = base.setProp("Margin", value )
    member this.MinWidth
        with get() = base.getProp<Double>("MinWidth")
        and set(value:Double) = base.setProp("MinWidth", value )
    member this.MinHeight
        with get() = base.getProp<Double>("MinHeight")
        and set(value:Double) = base.setProp("MinHeight", value )
    member this.ActualHeight
        with get() = base.getProp<Double>("ActualHeight")
        and set(value:Double) = base.setProp("ActualHeight", value )
    member this.ActualWidth
        with get() = base.getProp<Double>("ActualWidth")
        and set(value:Double) = base.setProp("ActualWidth", value )
    member this.BaseUri
        with get() = base.getProp<Uri>("BaseUri")
        and set(value:Uri) = base.setProp("BaseUri", value )
    member this.Parent
        with get() = base.getProp<DependencyObject>("Parent")
        and set(value:DependencyObject) = base.setProp("Parent", value )
    member this.Triggers
        with get() = base.getProp<TriggerCollection>("Triggers")
        and set(value:TriggerCollection) = base.setProp("Triggers", value )
    member this.RequestedTheme
        with get() = base.getProp<ElementTheme>("RequestedTheme")
        and set(value:ElementTheme) = base.setProp("RequestedTheme", value )
    member this.IsTapEnabled
        with get() = base.getProp<Boolean>("IsTapEnabled")
        and set(value:Boolean) = base.setProp("IsTapEnabled", value )
    member this.IsRightTapEnabled
        with get() = base.getProp<Boolean>("IsRightTapEnabled")
        and set(value:Boolean) = base.setProp("IsRightTapEnabled", value )
    member this.IsHoldingEnabled
        with get() = base.getProp<Boolean>("IsHoldingEnabled")
        and set(value:Boolean) = base.setProp("IsHoldingEnabled", value )
    member this.IsHitTestVisible
        with get() = base.getProp<Boolean>("IsHitTestVisible")
        and set(value:Boolean) = base.setProp("IsHitTestVisible", value )
    member this.IsDoubleTapEnabled
        with get() = base.getProp<Boolean>("IsDoubleTapEnabled")
        and set(value:Boolean) = base.setProp("IsDoubleTapEnabled", value )
    member this.ManipulationMode
        with get() = base.getProp<ManipulationModes>("ManipulationMode")
        and set(value:ManipulationModes) = base.setProp("ManipulationMode", value )
    member this.Clip
        with get() = base.getProp<RectangleGeometry>("Clip")
        and set(value:RectangleGeometry) = base.setProp("Clip", value )
    member this.CacheMode
        with get() = base.getProp<CacheMode>("CacheMode")
        and set(value:CacheMode) = base.setProp("CacheMode", value )
    member this.AllowDrop
        with get() = base.getProp<Boolean>("AllowDrop")
        and set(value:Boolean) = base.setProp("AllowDrop", value )
    member this.Visibility
        with get() = base.getProp<Visibility>("Visibility")
        and set(value:Visibility) = base.setProp("Visibility", value )
    member this.UseLayoutRounding
        with get() = base.getProp<Boolean>("UseLayoutRounding")
        and set(value:Boolean) = base.setProp("UseLayoutRounding", value )
    member this.Transitions
        with get() = base.getProp<TransitionCollection>("Transitions")
        and set(value:TransitionCollection) = base.setProp("Transitions", value )
    member this.RenderTransformOrigin
        with get() = base.getProp<Point>("RenderTransformOrigin")
        and set(value:Point) = base.setProp("RenderTransformOrigin", value )
    member this.RenderTransform
        with get() = base.getProp<Transform>("RenderTransform")
        and set(value:Transform) = base.setProp("RenderTransform", value )
    member this.Projection
        with get() = base.getProp<Projection>("Projection")
        and set(value:Projection) = base.setProp("Projection", value )
    member this.Opacity
        with get() = base.getProp<Double>("Opacity")
        and set(value:Double) = base.setProp("Opacity", value )
    member this.DesiredSize
        with get() = base.getProp<Size>("DesiredSize")
        and set(value:Size) = base.setProp("DesiredSize", value )
    //member this.PointerCaptures
    //    with get() = base.getProp<IReadOnlyList`1>("PointerCaptures")
    //    and set(value:IReadOnlyList`1) = base.setProp("PointerCaptures", value )
    member this.RenderSize
        with get() = base.getProp<Size>("RenderSize")
        and set(value:Size) = base.setProp("RenderSize", value )
    member this.CompositeMode
        with get() = base.getProp<ElementCompositeMode>("CompositeMode")
        and set(value:ElementCompositeMode) = base.setProp("CompositeMode", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )



[<AllowNullLiteral>]
type TextPointer() = 
    inherit BaseElement()
    member this.LogicalDirection
        with get() = base.getProp<LogicalDirection>("LogicalDirection")
        and set(value:LogicalDirection) = base.setProp("LogicalDirection", value )
    member this.Offset
        with get() = base.getProp<Int32>("Offset")
        and set(value:Int32) = base.setProp("Offset", value )
    member this.Parent
        with get() = base.getProp<DependencyObject>("Parent")
        and set(value:DependencyObject) = base.setProp("Parent", value )
    member this.VisualParent
        with get() = base.getProp<FrameworkElement>("VisualParent")
        and set(value:FrameworkElement) = base.setProp("VisualParent", value )




