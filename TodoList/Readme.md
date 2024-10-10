## What is the compilation process?

A compiler is a program that translates human readable code to computer readable.

## What is the most important skill of a programmer?

The most important skill for a programmer is the ability to find solutions for issues.

## Why C# is a statically typed programming language?

Because it is checked at compile time if we use the correct types.

## C# vs .NET

C# is the programming language and .NET is a set of libraries.

## .NET vs .NET Framework vs .NET Standard vs .NET Core

.NET is the newest version of the library

.NET Framework are the versions at the beginning of the library.

.NET Standard is the link between .NET Framework and .NET/.NET Core (e.g. the link between old and new)

.NET Core are the versions before .NET

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

Here, the internal workings of add_fuel and drive are abstracted away. Users of the Car class do not need to know how these methods work internally.

## Inheritance

Inheritance is a mechanism where a new class is derived from an existing class. The new class inherits properties and behaviours from the existing class.

```
using System;

public class Vehicle {
	protected string Brand { get; set }

	public Vehicle(string brand) {
		Brand = brand;
	}

	public void StartEngine() {
		Console.WriteLine($"The {Brand} vehicle's engine is starting.")
	}
}

public class Car: Vehicle {
	public Car(string brand) : base(brand) { }

	public void Drive() {
		Console.WriteLine($"The {Brand} car is being driven.")
	}
}

class Program {
	static void Main(string[] args) {
		Car myCar = new Car("Toyota");
		myCar.StartEngine(); // inherited method
		myCar.Drive(); // car-specific method
	}
}

```

Here, Car inherits from Vehicle, gaining its properties and methods.

## Polymorphism

Polymorphism allows objects of different classes to be treated as objects of a common base class. If often involves method overriding.

```
using System;
using System.Collections.Generic;

public abstract class Animal {
	public abstract string Speak();
}

public class Dog: Animal {
	public override string Speak() {
		return "Woof";
	}
}

public class Cat: Animal {
	public override string Speak() {
		return "Meow";
	}
}

public class Cow: Animal {
	public override string Speak() {
		return "Mooo";
	}
}

class Program {
	static void Main(string[] args) {
		List<Animal> animals = new List<Animal> 
		{
			new Dog(),
			new Cat(),
			new Cow()
		};

		foreach(Animal animal in animals) {
			Console.WriteLine(animal.speak());
		}
	}
}
```

Here, each animal class implements its own version of the speak method. We can treat all of them as Animal objects and call speak, getting different results based on the actual type of animal.


## Encapsulation

Bundling data with methods that operate on this data (in a single class).

Encapsulation is the bundling of data and the methods that operate on that data within a single unit (like a class). It restricts direct access to some of an object's components which is a means of preventing accidental interference and misuse of the methods and data.

```
using System;

public class BankAccount {
	private decimal balance;

	public bool Deposit(decimal amount) {
		if(amount > 0) {
			balance += amount;
			return true;
		}

		return false;
	}
}

public bool Withdraw(decimal amount) {
	if(amount > 0 && amount <= balance) {
		balance -= amount;
		return true;
	}
	return false;
}

public decimal GetBalance() {
	return balance;
}

class Program {
	static void Main(string[] args) {
		BankAccount account = new BankAccount();
		account.Deposit(300);
		account.Withdraw(50);
		Console.WriteLine(account.GetBalance()); // Outputs: 50
		// Console.WriteLine(account.balance); // this will cause a compilation error
	}
}

```

## Methods overloading

It refers to adding a duplicate method on the same class but changing the parameters of the method.

