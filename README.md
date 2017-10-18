## Login Flow & Validation

![login](https://user-images.githubusercontent.com/13316248/31746560-4dde9b3c-b468-11e7-8b85-5ecef9832990.gif)

## Building and running the app

1. Install npm dependencies: `yarn install` or `npm install`
2. Install dotnet dependencies: `.paket/paket.exe install`
3. Restore references for project `cd src && dotnet restore`
4. In one shell, Start Fable daemon: `dotnet fable start`
5. In another shell, Start Webpack dev server: `npm start`
6. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.
