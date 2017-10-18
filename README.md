## Login Flow & Validation [Demo](https://fable-elmish.github.io/sample-react-timer-svg/)
![clock.gif](https://cloud.githubusercontent.com/assets/13316248/24984147/011f8420-1fec-11e7-98c7-4005046f174c.gif)

## Building and running the app

1. Install npm dependencies: `yarn install` or `npm install`
2. Install dotnet dependencies: `.paket/paket.exe install`
3. Restore references for project `cd src && dotnet restore`
4. In one shell, Start Fable daemon: `dotnet fable start`
5. In another shell, Start Webpack dev server: `npm start`
6. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.
