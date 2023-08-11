module Algorithms
    
// 1. Greatest Common Divisor
let rec gcd a b =
    match b with
    | 0 -> a
    | _ -> gcd b (a % b)

    
// 2. Least Common Multiple
let lcm a b = a * b / (gcd a b)

    
// 3. Triangular Numbers Generator
let triGen a = a * (a + 1) / 2


// 4. Fibonacci Numbers

// 4.1 Naive Fibonacci Generator
let rec nFibo a =
    match a with
    | i when i <= 0 -> 0
    | 1 -> 1
    | _ -> nFibo (a-1) + nFibo (a-2)
        
// 4.2 Tail-recursive Fibonacci Generator
let rec tFibo a =
    let rec fibo x y z =
        match x with
        | i when i <= 0 -> y
        | _ -> fibo (x-1) (y+z) y
    fibo a 0 1

// 4.3 Analytic Fibonacci Generator
let aFibo a =
    let phi = 1.6180339887498948482045868343656
    let sq5 = 2.2360679774997896964091736687313
    int (phi**(float a) / sq5 + 0.5)
        
// 4.4 Nearest Fibonacci Rank
let fiboRank a =
    let phi = 1.6180339887498948482045868343656
    let sq5 = 2.2360679774997896964091736687313
    int ((log (sq5 * (float a) + 0.5)) / (log phi))
        
// 4.5 Fibonacci List Generator
let fiboList a =
    (Seq.unfold(fun (x,y) -> Some (x+y, (y, x+y))) (0,1))
    |> Seq.takeWhile(fun z -> z <= a)
    |> Seq.toList
    
    
// 5. Sieve of Eratosthenes
let primeSieve a =
    //let rec pSieve (xs:int list) (ys:int list) =
    //    match ys with
    //    | [] -> xs
    //    | _ -> pSieve (ys.Head :: xs) (ys.Tail |> List.filter (fun i -> i % ys.Head <> 0))
    //pSieve [] [2..a]

    (*let rec pSieve (xs:int list) (ys:int list) =
        match ys.Head with
        | z when z <= int (sqrt (double ys.[ys.Length-1])) -> pSieve (ys.Head :: xs) (ys.Tail |> List.filter (fun i -> i % ys.Head <> 0))
        | _ -> ys |> List.append (xs |> List.rev)    
    pSieve [] [2..a]*)

    let ns = [|0 .. a|]
    for x in [2 .. (int (sqrt (double a)))] do
        for y in [x*x .. x .. a] do ns.[y] <- 0
    ns |> Array.filter (fun i -> i > 1) |> Array.toList 


// 6.0 Largest Prime Factor
