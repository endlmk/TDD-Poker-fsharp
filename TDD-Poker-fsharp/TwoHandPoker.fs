module TDD_Poker_fsharp.TwoHandPoker

let isPair a b =
    Card.hasSameRank a b
    
let isFlush a b =
    Card.hasSameSuit a b
    
let isHighCard a b =
    not (isPair a b) && not (isFlush a b)


let isStraight (a: Card.Card)  (b: Card.Card) =
    let rankOrder = [| "2"; "3"; "4"; "5"; "6"; "7"; "8"; "9"; "10"; "J"; "Q"; "K"; "A"|]
    let index_a = Array.findIndex (fun x -> x = a.rank) rankOrder
    let index_b = Array.findIndex (fun x -> x = b.rank) rankOrder
    abs (index_a - index_b) = 1 || (index_a = 12 && index_b = 0) || (index_a = 0 && index_b = 12)
    
let isStraightFlush a b =
    (isStraight a b) && (isFlush a b)