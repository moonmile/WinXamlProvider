namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type ButtonBase() = 
    inherit ContentControl()
    member this.CommandParameter
        with get() = base.getProp<Object>("CommandParameter")
        and set(value:Object) = base.setProp("CommandParameter", value )
    member this.Command
        with get() = base.getProp<Windows.Input.ICommand>("Command")
        and set(value:Windows.Input.ICommand) = base.setProp("Command", value )
    member this.ClickMode
        with get() = base.getProp<ClickMode>("ClickMode")
        and set(value:ClickMode) = base.setProp("ClickMode", value )
    member this.IsPointerOver
        with get() = base.getProp<Boolean>("IsPointerOver")
        and set(value:Boolean) = base.setProp("IsPointerOver", value )
    member this.IsPressed
        with get() = base.getProp<Boolean>("IsPressed")
        and set(value:Boolean) = base.setProp("IsPressed", value )
    member this.ContentTransitions
        with get() = base.getProp<TransitionCollection>("ContentTransitions")
        and set(value:TransitionCollection) = base.setProp("ContentTransitions", value )
    member this.ContentTemplateSelector
        with get() = base.getProp<DataTemplateSelector>("ContentTemplateSelector")
        and set(value:DataTemplateSelector) = base.setProp("ContentTemplateSelector", value )
    member this.ContentTemplate
        with get() = base.getProp<DataTemplate>("ContentTemplate")
        and set(value:DataTemplate) = base.setProp("ContentTemplate", value )
    member this.Content
        with get() = base.getProp<Object>("Content")
        and set(value:Object) = base.setProp("Content", value )
    member this.ContentTemplateRoot
        with get() = base.getProp<UIElement>("ContentTemplateRoot")
        and set(value:UIElement) = base.setProp("ContentTemplateRoot", value )
    member this.FontWeight
        with get() = base.getProp<FontWeight>("FontWeight")
        and set(value:FontWeight) = base.setProp("FontWeight", value )
    member this.FontStyle
        with get() = base.getProp<FontStyle>("FontStyle")
        and set(value:FontStyle) = base.setProp("FontStyle", value )
    member this.FontStretch
        with get() = base.getProp<FontStretch>("FontStretch")
        and set(value:FontStretch) = base.setProp("FontStretch", value )
    member this.FontSize
        with get() = base.getProp<Double>("FontSize")
        and set(value:Double) = base.setProp("FontSize", value )
    member this.FontFamily
        with get() = base.getProp<FontFamily>("FontFamily")
        and set(value:FontFamily) = base.setProp("FontFamily", value )
    member this.CharacterSpacing
        with get() = base.getProp<Int32>("CharacterSpacing")
        and set(value:Int32) = base.setProp("CharacterSpacing", value )
    member this.BorderThickness
        with get() = base.getProp<Thickness>("BorderThickness")
        and set(value:Thickness) = base.setProp("BorderThickness", value )
    member this.BorderBrush
        with get() = base.getProp<Brush>("BorderBrush")
        and set(value:Brush) = base.setProp("BorderBrush", value )
    member this.Background
        with get() = base.getProp<Brush>("Background")
        and set(value:Brush) = base.setProp("Background", value )
    member this.VerticalContentAlignment
        with get() = base.getProp<VerticalAlignment>("VerticalContentAlignment")
        and set(value:VerticalAlignment) = base.setProp("VerticalContentAlignment", value )
    member this.Template
        with get() = base.getProp<ControlTemplate>("Template")
        and set(value:ControlTemplate) = base.setProp("Template", value )
    member this.TabNavigation
        with get() = base.getProp<KeyboardNavigationMode>("TabNavigation")
        and set(value:KeyboardNavigationMode) = base.setProp("TabNavigation", value )
    member this.TabIndex
        with get() = base.getProp<Int32>("TabIndex")
        and set(value:Int32) = base.setProp("TabIndex", value )
    member this.Padding
        with get() = base.getProp<Thickness>("Padding")
        and set(value:Thickness) = base.setProp("Padding", value )
    member this.IsTabStop
        with get() = base.getProp<Boolean>("IsTabStop")
        and set(value:Boolean) = base.setProp("IsTabStop", value )
    member this.IsEnabled
        with get() = base.getProp<Boolean>("IsEnabled")
        and set(value:Boolean) = base.setProp("IsEnabled", value )
    member this.HorizontalContentAlignment
        with get() = base.getProp<HorizontalAlignment>("HorizontalContentAlignment")
        and set(value:HorizontalAlignment) = base.setProp("HorizontalContentAlignment", value )
    member this.Foreground
        with get() = base.getProp<Brush>("Foreground")
        and set(value:Brush) = base.setProp("Foreground", value )
    member this.FocusState
        with get() = base.getProp<FocusState>("FocusState")
        and set(value:FocusState) = base.setProp("FocusState", value )
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


type Button() = 
    inherit ButtonBase()
    member this.Flyout
        with get() = base.getProp<FlyoutBase>("Flyout")
        and set(value:FlyoutBase) = base.setProp("Flyout", value )
    member this.CommandParameter
        with get() = base.getProp<Object>("CommandParameter")
        and set(value:Object) = base.setProp("CommandParameter", value )
    member this.Command
        with get() = base.getProp<Windows.Input.ICommand>("Command")
        and set(value:Windows.Input.ICommand) = base.setProp("Command", value )
    member this.ClickMode
        with get() = base.getProp<ClickMode>("ClickMode")
        and set(value:ClickMode) = base.setProp("ClickMode", value )
    member this.IsPointerOver
        with get() = base.getProp<Boolean>("IsPointerOver")
        and set(value:Boolean) = base.setProp("IsPointerOver", value )
    member this.IsPressed
        with get() = base.getProp<Boolean>("IsPressed")
        and set(value:Boolean) = base.setProp("IsPressed", value )
    member this.ContentTransitions
        with get() = base.getProp<TransitionCollection>("ContentTransitions")
        and set(value:TransitionCollection) = base.setProp("ContentTransitions", value )
    member this.ContentTemplateSelector
        with get() = base.getProp<DataTemplateSelector>("ContentTemplateSelector")
        and set(value:DataTemplateSelector) = base.setProp("ContentTemplateSelector", value )
    member this.ContentTemplate
        with get() = base.getProp<DataTemplate>("ContentTemplate")
        and set(value:DataTemplate) = base.setProp("ContentTemplate", value )
    member this.Content
        with get() = base.getProp<Object>("Content")
        and set(value:Object) = base.setProp("Content", value )
    member this.ContentTemplateRoot
        with get() = base.getProp<UIElement>("ContentTemplateRoot")
        and set(value:UIElement) = base.setProp("ContentTemplateRoot", value )
    member this.FontWeight
        with get() = base.getProp<FontWeight>("FontWeight")
        and set(value:FontWeight) = base.setProp("FontWeight", value )
    member this.FontStyle
        with get() = base.getProp<FontStyle>("FontStyle")
        and set(value:FontStyle) = base.setProp("FontStyle", value )
    member this.FontStretch
        with get() = base.getProp<FontStretch>("FontStretch")
        and set(value:FontStretch) = base.setProp("FontStretch", value )
    member this.FontSize
        with get() = base.getProp<Double>("FontSize")
        and set(value:Double) = base.setProp("FontSize", value )
    member this.FontFamily
        with get() = base.getProp<FontFamily>("FontFamily")
        and set(value:FontFamily) = base.setProp("FontFamily", value )
    member this.CharacterSpacing
        with get() = base.getProp<Int32>("CharacterSpacing")
        and set(value:Int32) = base.setProp("CharacterSpacing", value )
    member this.BorderThickness
        with get() = base.getProp<Thickness>("BorderThickness")
        and set(value:Thickness) = base.setProp("BorderThickness", value )
    member this.BorderBrush
        with get() = base.getProp<Brush>("BorderBrush")
        and set(value:Brush) = base.setProp("BorderBrush", value )
    member this.Background
        with get() = base.getProp<Brush>("Background")
        and set(value:Brush) = base.setProp("Background", value )
    member this.VerticalContentAlignment
        with get() = base.getProp<VerticalAlignment>("VerticalContentAlignment")
        and set(value:VerticalAlignment) = base.setProp("VerticalContentAlignment", value )
    member this.Template
        with get() = base.getProp<ControlTemplate>("Template")
        and set(value:ControlTemplate) = base.setProp("Template", value )
    member this.TabNavigation
        with get() = base.getProp<KeyboardNavigationMode>("TabNavigation")
        and set(value:KeyboardNavigationMode) = base.setProp("TabNavigation", value )
    member this.TabIndex
        with get() = base.getProp<Int32>("TabIndex")
        and set(value:Int32) = base.setProp("TabIndex", value )
    member this.Padding
        with get() = base.getProp<Thickness>("Padding")
        and set(value:Thickness) = base.setProp("Padding", value )
    member this.IsTabStop
        with get() = base.getProp<Boolean>("IsTabStop")
        and set(value:Boolean) = base.setProp("IsTabStop", value )
    member this.IsEnabled
        with get() = base.getProp<Boolean>("IsEnabled")
        and set(value:Boolean) = base.setProp("IsEnabled", value )
    member this.HorizontalContentAlignment
        with get() = base.getProp<HorizontalAlignment>("HorizontalContentAlignment")
        and set(value:HorizontalAlignment) = base.setProp("HorizontalContentAlignment", value )
    member this.Foreground
        with get() = base.getProp<Brush>("Foreground")
        and set(value:Brush) = base.setProp("Foreground", value )
    member this.FocusState
        with get() = base.getProp<FocusState>("FocusState")
        and set(value:FocusState) = base.setProp("FocusState", value )
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
    // member this.PointerCaptures
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

