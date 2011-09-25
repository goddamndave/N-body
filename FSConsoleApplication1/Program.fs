// Learn more about F# at http://fsharp.net

let sqr x = x * x
let distance (x1, y1) (x2, y2) = sqrt (sqr(x2-x1) + sqr(y2-y1))
let printFloatList floatList = 
    floatList
    |> List.map (fun (x: float) -> System.Console.WriteLine(x))

let printPoint2DList point2DList = 
    point2DList
    |> List.map (fun (x: list<float>) -> x)
    |> List.map (fun [x; y] -> System.Console.WriteLine(x))

let rec printHead (list: List<float>) = 
    match list with
    | head::tail -> 
        System.Console.WriteLine(list.Head)
        printHead(list.Tail)
    | [] -> ()

let printPointNDList pointNDList = 
    pointNDList
    |> List.map (fun (x: list<float>) -> x)
    |> List.map (fun list -> //needs a match set to handle both the empty and nonempty cases
        printHead(list)
       )
    
    
let floatList = [1.0; 10.0]
System.Console.WriteLine(floatList)
ignore (printFloatList floatList) 

let pointNDList = [[1.0; 2.0; 3.0]; [10.0; 20.0; 30.0]]
System.Console.WriteLine(pointNDList)
ignore (printPointNDList pointNDList)
//System.Console.WriteLine(distance particles.[0] particles.[1])



// don't close the terminal window until I press a key
System.Console.ReadLine() |> ignore