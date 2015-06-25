
namespace FsStaticFilesSample

open Owin
open Microsoft.Owin
open Microsoft.Owin.FileSystems
open Microsoft.Owin.StaticFiles

type Startup() =

    member this.Configuration(app:IAppBuilder) = 

        let options = FileServerOptions(RequestPath = PathString.Empty, FileSystem = PhysicalFileSystem "static")

        app.UseErrorPage() |> ignore
        app.UseFileServer options |> ignore
        app.UseWelcomePage() |> ignore

