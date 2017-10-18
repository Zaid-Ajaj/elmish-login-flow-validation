module Admin.Backoffice.Types

type Msg = 
    | Logout
    | Other

type State = { Username: string }