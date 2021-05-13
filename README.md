# martian-robots-problem

## Description

This is My solution to Martian robots problem. 

I wrote a C# console application and a test project with 71 unit tests that provide 98% of code coverage in the Domain layer.

How I solved the challenges:
  -  Possibility of additional commands types and movements: I created the interface ```ICommand``` that allows to execute any kind of command or movement and I use Inversion of Control to inject the commands.
  - Scent points: I created a service called ```IScentPointsService``` that stores scent points in memory.
  - Bonus: I created a service called ```IMessagesService``` to provide support for multilanguage in some exception messages.

I used these design patters for this app:
  - Domain Driven Design (DDD): My solution has two layers: One is for the UI and is in MartianRobots.App project, and other with models, interfaces, and bussiness logic in MartianRobots.Domain project.
  - Test Driven Design (TDD): Unit tests are in MartianRobots.Domain.Tests project.
  - Inversion of Control (IoC): I implemented IoC to decouple dependencies and for registering the robot commands.

And these NuGet packages:
  - xUnit: Accelerates the creation of Unit tests.
  - Moq: Accelerates the creation of mocks for unit tests.
  - Fluent assertions: Improves readability of asserts.
  - AutoFixture: Generates test data.

## How to execute

 1. Compile the app with Visual Studio 2019 and .NET core 3.1.
 2. Execute the app and paste input data. Here you have a sample input:
 ```5 3
1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFLFLFL
```
 3. Press enter to see the output. Here you have a sample output:
```
1 1 E
3 3 N LOST
2 3 S
```


## License

MIT License

Copyright (c) 2021 Sergio Monedero

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.