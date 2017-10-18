module Admin.Login.State

open System
open Elmish
open Admin.Login.Types
open Fable.PowerPack

let init() = 
    { InputUsername = ""
      InputPassword = ""
      UsernameValidationErrors =  [ ]
      PasswordValidationErrors =  [ ]
      LoginError = None
      LoggingIn = false }, Cmd.none

let update msg (state: State) = 
    if state.LoggingIn then state, Cmd.none
    else
    match msg with 
    | ChangeUsername name ->
         // Reset validation errors when user is filling form
        let nextState = 
            { state with InputUsername = name
                         UsernameValidationErrors = [ ] }
        nextState, Cmd.none
    | ChangePassword pass ->
        // Reset validation errors when user is filling form
        let nextState = 
            { state with InputPassword = pass
                         PasswordValidationErrors = [ ] }
        nextState, Cmd.none
    | Login ->
        (*
            Apply here your validation rules
            Only invoke the Http.login command when input is valid
            i.e. last case
        *)
        let usernameRules = 
            [ String.IsNullOrWhiteSpace(state.InputUsername), "Field 'Username' cannot be empty"
              state.InputUsername.Trim().Length < 5, "Field 'Username' must at least have 5 characters" ]
        let passwordRules = 
            [ String.IsNullOrWhiteSpace(state.InputPassword), "Field 'Password' cannot be empty"
              state.InputPassword.Trim().Length < 5, "Field 'Password' must at least have 5 characters" ]
        
        let usernameValidationErrors = 
            usernameRules
            |> List.filter fst
            |> List.map snd

        let passwordValidationErrors = 
            passwordRules
            |> List.filter fst
            |> List.map snd

        let startLogin = 
            List.isEmpty usernameValidationErrors
         && List.isEmpty passwordValidationErrors

        if not startLogin then 
          let nextState = 
            { state with UsernameValidationErrors = usernameValidationErrors
                         PasswordValidationErrors = passwordValidationErrors }
          nextState, Cmd.none 
        else 
          let nextState = { state with LoggingIn = true } 
          let credentials  = 
            { Username = state.InputUsername
              Password = state.InputPassword  }
          nextState, Http.login credentials
    | LoginSuccess token -> 
        let nextState = { state with LoggingIn = false }
        nextState, Cmd.none
    | LoginFailed error ->
        let nextState = 
            { state with LoginError = Some error 
                         LoggingIn = false }

        nextState, Cmd.none

