namespace Moonmile.WinXamlProvider.UI
open System
open System.Reflection

type Thickness() =     
    member val Left:Double = 0. with get, set
    member val Top:Double = 0. with get, set
    member val Right:Double = 0. with get, set
    member val Bottom:Double = 0. with get, set

type FontWeight() = 
    member val Weight:int = 0 with get, set

type Color() = 
    member val A:int = 0 with get, set
    member val R:int = 0 with get, set
    member val G:int = 0 with get, set
    member val B:int = 0 with get, set

type Rect() = 
    member val X:Double = 0. with get, set
    member val Y:Double = 0. with get, set
    member val Width:Double = 0. with get, set
    member val Height:Double = 0. with get, set
    member val Left:Double = 0. with get, set
    member val Top:Double = 0. with get, set
    member val Right:Double = 0. with get, set
    member val Bottom:Double = 0. with get, set
    member val IsEmpty:Boolean = false with get, set

type Point() = 
    member val X:Double = 0. with get, set
    member val Y:Double = 0. with get, set

type Size() = 
    member val Width:Double = 0. with get, set
    member val Height:Double = 0. with get, set
    member val IsEmpty:Boolean = false with get, set