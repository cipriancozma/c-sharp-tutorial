## What is the compilation process?

A compiler is a program that translates human readable code to computer readable.

## What is the most important skill of a programmer?

The most important skill for a programmer is the ability to find solutions for issues.

## Why C# is a statically typed programming language?

Because it is checked at compile time if we use the correct types.

## Procedural Programming

Programming based on procedures named methods. It can lead to an antipattern named spaghetti code. 

Issues caused by procedural programming:

- Spaghetti code
- No way to control who can access methods
- No separation by levels of abstraction
- Changes in requirements are hard to implement
- Logic is not easily configurable

## Abstraction

Abstraction means that classes expose only essential data and methods and hide the underlying details.

This is a process of hiding complex implementation details and showing only the necessary features of an object. It helps in reducing programming complexity and effort.

Example:
Consider a car. As a driver, you don't need to know how the engine works internally. You just need to know how to use the steering wheel, pedals and gears. This is abstraction.

```
using System;

public class Car {
	private int fuel;

	public void AddFuel(int amount) {
		fuel += amount;
	}

	public void Drive() {
		if(fuel > 0) {
			Console.WriteLine("The car is driving.")
		} else {
			Console.WriteLine("The car is out of fuel.")
		}
	}
}

class Program {
	static void Main(string[] args) {
		Car myCar = new Car();
		myCar.AddFuel(10);
		myCar.Drive();
	}
}
```

Here, the internal workings of add_fuel and drive are abstracted away. Users of the Car class do not need to know how these methods work internally._

## Encapsulation

Bundling data with methods that operate on this data (in a single class).

