namespace System.Runtime.InteropServices
    open System
    open System.Runtime.InteropServices

    [<AttributeUsage(AttributeTargets.Method)>]
    type NativeCallableAttribute() 
        = inherit System.Attribute()
            [<DefaultValue>] val mutable public EntryPoint : string
            [<DefaultValue>] val mutable public CallingConvention : CallingConvention

