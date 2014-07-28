﻿namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type InputScope() = 
    inherit BaseElement()
    //member this.Names
    //    with get() = base.getProp<IList`1>("Names")
    //    and set(value:IList`1) = base.setProp("Names", value )
    member this.Dispatcher
        with get() = base.getProp<CoreDispatcher>("Dispatcher")
        and set(value:CoreDispatcher) = base.setProp("Dispatcher", value )

[<AllowNullLiteral>]
type TextBox() =
    inherit Control()
    member this.SelectionStart
        with get() = base.getProp<Int32>("SelectionStart")
        and set(value:Int32) = base.setProp("SelectionStart", value )
    member this.SelectionLength
        with get() = base.getProp<Int32>("SelectionLength")
        and set(value:Int32) = base.setProp("SelectionLength", value )
    member this.SelectedText
        with get() = base.getProp<String>("SelectedText")
        and set(value:String) = base.setProp("SelectedText", value )
    member this.MaxLength
        with get() = base.getProp<Int32>("MaxLength")
        and set(value:Int32) = base.setProp("MaxLength", value )
    member this.IsTextPredictionEnabled
        with get() = base.getProp<Boolean>("IsTextPredictionEnabled")
        and set(value:Boolean) = base.setProp("IsTextPredictionEnabled", value )
    member this.IsSpellCheckEnabled
        with get() = base.getProp<Boolean>("IsSpellCheckEnabled")
        and set(value:Boolean) = base.setProp("IsSpellCheckEnabled", value )
    member this.IsReadOnly
        with get() = base.getProp<Boolean>("IsReadOnly")
        and set(value:Boolean) = base.setProp("IsReadOnly", value )
    member this.InputScope
        with get() = base.getProp<InputScope>("InputScope")
        and set(value:InputScope) = base.setProp("InputScope", value )
    member this.AcceptsReturn
        with get() = base.getProp<Boolean>("AcceptsReturn")
        and set(value:Boolean) = base.setProp("AcceptsReturn", value )
    member this.TextWrapping
        with get() = base.getProp<TextWrapping>("TextWrapping")
        and set(value:TextWrapping) = base.setProp("TextWrapping", value )
    member this.TextAlignment
        with get() = base.getProp<TextAlignment>("TextAlignment")
        and set(value:TextAlignment) = base.setProp("TextAlignment", value )
    member this.Text
        with get() = base.getProp<String>("Text")
        and set(value:String) = base.setProp("Text", value )
    member this.SelectionHighlightColor
        with get() = base.getProp<SolidColorBrush>("SelectionHighlightColor")
        and set(value:SolidColorBrush) = base.setProp("SelectionHighlightColor", value )
    member this.PreventKeyboardDisplayOnProgrammaticFocus
        with get() = base.getProp<Boolean>("PreventKeyboardDisplayOnProgrammaticFocus")
        and set(value:Boolean) = base.setProp("PreventKeyboardDisplayOnProgrammaticFocus", value )
    member this.PlaceholderText
        with get() = base.getProp<String>("PlaceholderText")
        and set(value:String) = base.setProp("PlaceholderText", value )
    member this.IsColorFontEnabled
        with get() = base.getProp<Boolean>("IsColorFontEnabled")
        and set(value:Boolean) = base.setProp("IsColorFontEnabled", value )
    member this.HeaderTemplate
        with get() = base.getProp<DataTemplate>("HeaderTemplate")
        and set(value:DataTemplate) = base.setProp("HeaderTemplate", value )
    member this.Header
        with get() = base.getProp<Object>("Header")
        and set(value:Object) = base.setProp("Header", value )
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

