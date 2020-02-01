// This example is based on: https://mazeez.dev/posts/writing-native-libraries-in-csharp
module NativeLibrary
open System.Runtime.InteropServices
open System
    
[<NativeCallable(EntryPoint = "add", CallingConvention = CallingConvention.StdCall)>]
let Add (a: int) (b: int) : int =
    a + b

[<NativeCallable(EntryPoint = "write_line", CallingConvention = CallingConvention.StdCall)>]
let WriteLine (pString: IntPtr) : int =
    try
        let str = Marshal.PtrToStringAnsi(pString)
        Console.WriteLine(str)
        0
    with
    | _ -> -1