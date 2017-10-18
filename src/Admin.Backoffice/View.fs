module Admin.Backoffice.View

open Admin.Backoffice.Types
open Fable.Helpers.React.Props
open Fable.Helpers.React

let render (state: State) dispatch = 
    div [ Style [ Padding 20; TextAlign "center" ] ]
        [ h1 [ ]  
             [ str "Hello Admin "
               button [ ClassName "btn btn-info btn-lg"
                        OnClick (fun e -> dispatch Logout) ]
                      [ str "Logout" ] ] ]
    