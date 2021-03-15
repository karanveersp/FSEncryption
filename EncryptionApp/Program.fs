// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open SimpleAES

[<EntryPoint>]
let main argv =
    let message = AES256.Encrypt("Hello F#", "hello")
    printfn "%s" message
    let decrypted = AES256.Decrypt(message, "hello")
    printfn "Decoded: %s" decrypted
    0
