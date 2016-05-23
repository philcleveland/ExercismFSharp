module BankAccount
type AccountStatus = Open | Closed

type BankAccount() =
    let mutable balance = Option<float>.None
    let mutable accStatus = Option<AccountStatus>.None
    
    member this.Balance =
        match accStatus with
        | Some x ->
            match x with
            | Open -> Some(this.getBalance())
            | Closed ->  Option<float>.None
        | None -> Option<float>.None
    member this.openAccount() =
        balance <- Some(0.0)
        accStatus <- Some(AccountStatus.Open)
    member this.updateBalance(update:float)=
        match accStatus with
        | Some b -> balance <- Some(balance.Value + update)
        | None -> balance <- balance
    member this.getBalance() = 
        match balance with
        | Some x -> x
        | None -> balance.Value
    member this.closeAccount() =
        accStatus <- Some(AccountStatus.Closed)
        balance <- Option<float>.None
        
        