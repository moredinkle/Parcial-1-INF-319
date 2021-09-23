// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    let random = new System.Random()
    let a () = random.Next(1, 1000)
    let lista = [ for i in 1 .. 10 -> a ()]

    printfn "\n lista"
    for i in lista do
      printf "%i " i
    
    
    let pares = [for i in lista do if i%2=0 then yield i]
    let impares = [for i in lista do if i%2<>0 then yield i]
    
    printfn "\n pares"
    for i in pares do
        printf "%i " i

    printfn "\n impares"
    for i in impares do
        printf "%i " i
    
    Console.ReadKey() |>ignore
    0 // devolver un código de salida entero
