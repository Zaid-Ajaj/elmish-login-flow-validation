module Admin.Login.Http

open Admin.Login.Types
open Elmish
open Fable.PowerPack


let private loginPromise (info: LoginInfo) = 
    promise {
        // simulate server word
        do! Promise.sleep 1500
        return LoginResult.Success "my-secure-access-token"
    }

let login (info: LoginInfo) =
    
    let successHandler = function
        | Success token -> LoginSuccess token
        | UsernameDoesNotExist -> LoginFailed "Username does not exist"
        | PasswordIncorrect -> LoginFailed "The password you entered is incorrect"
        | LoginError error -> LoginFailed error
    
    Cmd.ofPromise loginPromise info
                  successHandler
                  (fun ex -> LoginFailed "Unknown error occured while logging you in")
