// Learn more about F# at http://fsharp.org

open System
open System.Linq
open SampleFSharpEF.Model


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let ent = new redmineEntities()
    for it in ent.projects.ToList() do
        Console.WriteLine(String.Format("{0} : {1}", it.id, it.name ))

    0 // return an integer exit code
