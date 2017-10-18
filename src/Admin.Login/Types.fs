module Admin.Login.Types


type LoginResult = 
    | Success of token:string
    | UsernameDoesNotExist
    | PasswordIncorrect
    | LoginError of errorMsg:string

type LoginInfo = 
    { Username : string 
      Password : string }

type Msg = 
    | Login
    | ChangeUsername of string
    | ChangePassword of string
    | LoginSuccess of adminSecureToken: string
    | LoginFailed of error:string

type State = {
    LoggingIn: bool
    InputUsername: string
    UsernameValidationErrors: string list
    PasswordValidationErrors: string list
    InputPassword: string
    LoginError: string option
}