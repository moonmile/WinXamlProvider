namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type CoreDispatcherPriority = 
    | Normal = 0
    | High = 1
    | Idle = -2
    | Low = -1

type TextWrapping =
  | NoWrap = 1
  | Wrap = 2
  | WrapWholeWords = 3

type TextTrimming = 
    | None = 0
    | CharacterEllipsis = 1
    | WordEllipsis = 2
    | Clip = 3

type TextAlignment = 
    | Center = 0
    | Left = 1
    | Right = 2
    | Justify = 3

type LineStackingStrategy = 
    | MaxHeight = 0
    | BlockLineHeight = 1
    | BaselineToBaseline = 2

type FontStyle = 
    | Normal = 0
    | Oblique = 1
    | Italic = 2

type FontStretch = 
    | Undefined = 0
    | UltraCondensed = 1
    | ExtraCondensed = 2
    | Condensed = 3
    | SemiCondensed = 4
    | Normal = 5
    | SemiExpanded = 6
    | Expanded = 7
    | ExtraExpanded = 8
    | UltraExpanded = 9

type LogicalDirection = 
    | Backward = 0
    | Forward = 1

type TextReadingOrder = 
    | Default = 0
    | DetectFromContent = 1

type TextLineBounds = 
    | Full = 0
    | TrimToCapHeight = 1
    | TrimToBaseline = 2
    | Tight = 3

type OpticalMarginAlignment = 
    | None = 0
    | TrimSideBearings = 1

type HorizontalAlignment = 
    | Left = 0
    | Center = 1
    | Right = 2
    | Stretch = 3

type FlowDirection = 
    | LeftToRight = 0
    | RightToLeft = 1

type VerticalAlignment = 
    | Top = 0
    | Center = 1
    | Bottom = 2
    | Stretch = 3

type ElementTheme = 
    | Default = 0
    | Light = 1
    | Dark = 2

type ManipulationModes =
    | None = 0
    | TranslateX = 1
    | TranslateY = 2
    | TranslateRailsX = 4
    | TranslateRailsY = 8
    | Rotate = 16
    | Scale = 32
    | TranslateInertia = 64
    | RotateInertia = 128
    | ScaleInertia = 256
    | All = 65535
    | System = 65536

type Visibility = 
    | Visible = 0
    | Collapsed = 1

type ElementCompositeMode = 
    | Inherit = 0
    | SourceOver = 1
    | MinBlend = 2

type ClickMode = 
    | Release = 0
    | Press = 1
    | Hover = 2

type KeyboardNavigationMode = 
    | Local = 0
    | Cycle = 1
    | Once = 2

type FocusState = 
    | Unfocused = 0
    | Pointer = 1
    | Keyboard = 2
    | Programmatic = 3

type FlyoutPlacementMode = 
    | Top = 0
    | Bottom = 1
    | Left = 2
    | Right = 3
    | Full = 4
