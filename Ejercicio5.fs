// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System   


[<EntryPoint>]
let main argv = 
    Console.Write("A:")
    let a = System.Int32.Parse(Console.ReadLine())
    Console.Write("B:")
    let b = System.Int32.Parse(Console.ReadLine())
    
    let lista = [for i in 1..b -> a]
    let suc = List.sum lista
    printf "%d" suc


    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
