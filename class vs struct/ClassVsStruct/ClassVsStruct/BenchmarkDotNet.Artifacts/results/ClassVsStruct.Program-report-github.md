``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742189 Hz, Resolution=364.6722 ns, Timer=TSC
.NET Core SDK=2.1.508
  [Host]     : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT


```
|          Method |     Mean |    Error |    StdDev |   Median |
|---------------- |---------:|---------:|----------:|---------:|
| StructBenchmark | 157.3 us | 4.959 us | 14.467 us | 163.8 us |
|  ClassBenchmark | 138.8 us | 2.738 us |  2.561 us | 138.8 us |
