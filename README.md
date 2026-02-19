# [CacheLine.CPU.SCU](https://github.com/sapozhnikovv/CacheLine.CPU.SCU)
![Logo](https://github.com/sapozhnikovv/CacheLine.CPU.SCU/blob/main/img/name.jpg)
 
Cross-platform lib to get CPU cache line size

Cross-platform library:   
✅ Windows   
✅ Linux  
✅ Mac 


[Example ConsoleApp with docker file](https://github.com/sapozhnikovv/CacheLine.CPU.SCU/tree/main/Example.ConsoleApp)

# Nuget
multi-target package:   
✅ .net7.0   
✅ .net8.0   
✅ .net9.0  

https://www.nuget.org/packages/CacheLine.CPU.SCU

```shell
dotnet add package CacheLine.CPU.SCU
```
or
```shell
NuGet\Install-Package CacheLine.CPU.SCU
```

## Example of using

```c#
namespace CacheLine.CPU.SCU;

var lineSize = CacheLine.GetSize(false);//or CacheLine.Size - it is failsafe method
Console.WriteLine($"Line size = {lineSize} bytes");
```

## License
Free MIT license (https://github.com/sapozhnikovv/CacheLine.CPU.SCU/blob/main/LICENSE)

