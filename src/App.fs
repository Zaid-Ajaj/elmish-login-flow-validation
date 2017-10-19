module App

open System
open Fable.Import.Browser
open Fable.Core
open Fable.Core.JsInterop

open Elmish 
open Elmish.React

// App
Program.mkProgram Admin.State.init Admin.State.update Admin.View.render
|> Program.withReact "elmish-app"
|> Program.withConsoleTrace
|> Program.run
