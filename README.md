# Native F# Library

This example shows, how you can build an native Windows x64 DLL with *F#* that can be called from native *C++* code.

Blog post which explains how it works: [Writing a native library in F# which can be called from C++](https://secanablog.wordpress.com/2020/02/01/writing-a-native-library-in-f-which-can-be-called-from-c/)

The example is based on the *C#* version by *Muhammad Azeez* which can be found here: [Writing native libraries in C#](https://mazeez.dev/posts/writing-native-libraries-in-csharp)

## Build & Run

First, the native library has to be build from the *F#* project *NativeLib* in the *src* folder. 
Switch to the *NativeLib* folder and run:

```powershell
> dotnet publish /p:NativeLib=Shared -r win-x64 -c Release
```

This creates a native library under `$(SolutionDir)src\NativeLib\bin\Release\netstandard2.0\win-x64\native`.

Now, you can build and run the *Console C++* application in *Visual Studio*, which will use the *NativeLib.dll* written in *F#*.

The output will be:

```powershell
3
Hello World!
```