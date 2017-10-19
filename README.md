## Login Flow & Validation

![login](https://user-images.githubusercontent.com/13316248/31772666-b637eff8-b4e0-11e7-9a80-e568e44a3be9.gif)


## Building and running the app

1. Install npm dependencies: `yarn install` or `npm install`
2. Install dotnet dependencies: `.paket/paket.exe install`
3. Restore references for project `cd src && dotnet restore`
4. In one shell, Start Fable daemon: `dotnet fable start`
5. In another shell, Start Webpack dev server: `npm start`
6. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.
