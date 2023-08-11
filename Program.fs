open System
open Algorithms
open Problems

[<EntryPoint>]
let main argv =
    let stopWatch = System.Diagnostics.Stopwatch.StartNew()

    // printfn "Problem No. 1 Answer = %d\n" (prob1 1000 3 5)
    // printfn "Problem No. 2 Answer = %d\n" (prob2 4000000)
    printfn "Problem No. 3 Answer = %d\n"(600851475143L)

    //printfn "%A" (primeSieve 1000000)
     
    stopWatch.Stop()
    printfn "Elapsed Time: %.3f seconds\n" stopWatch.Elapsed.TotalSeconds
    0 // return 0