namespace WinXamlProvider.Lib
open System
open Moonmile.WinXamlProvider
open Moonmile.WinXamlProvider.UI

type MainPage() = 
    member val textMessage:TextBlock = null with get, set
    member this.Button_Click(sender:obj, e:RoutedEventArgs) =
        this.textMessage.Text <- "New F# message."
         