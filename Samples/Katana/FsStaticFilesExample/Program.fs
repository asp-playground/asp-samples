// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

//namespace FsStaticFilesSample 

open Microsoft.Owin.Hosting
open System
open FsStaticFilesSample

[<EntryPoint>]
let main argv = 

    let url = "http://localhost:1234"
    WebApp.Start<Startup> (url) |> ignore

    Console.WriteLine url
    Console.ReadLine() |> ignore
    0
