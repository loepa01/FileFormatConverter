module TryFSharp =
    let (|->) a b = b a

    [1..100]
    |-> List.filter (fun num -> num % 2 = 0)
    |-> List.map (fun num -> printfn "%d" num)

    for i in [1..100] do 
        if i % 2 = 0 then
            printf "%d" i
        
    List.map (fun num -> printfn "%d" num) 
        (List.filter (fun num -> num % 2 = 0) [1..100])
