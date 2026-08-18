# SmartDevices

A C# console application that simulates a smart home containing different types of smart devices.

The project demonstrates important Object-Oriented Programming (OOP) concepts such as abstraction, inheritance, encapsulation, polymorphism, method overriding, and unit testing.

## Features

- Smart device hierarchy using inheritance
- Switchable devices with ON/OFF behaviour
- Energy consumption tracking
- Thermostat temperature management
- Door opening tracking
- 24-hour smart home simulation
- House energy consumption calculation
- Unit testing using xUnit

## Device Structure

The project uses a base `Device` class and specialised device classes.

```text
Device
│
├── SwitchableDevice
│   ├── Light
│   ├── Kettle
│   └── SecurityCamera
│
├── Thermostat
│
└── DoorSensor



## Devices

## Light

- Rated power: 9 W
- Can be switched ON and OFF
- Tracks energy consumption


## Kettle

- Rated power: 2200 W
- Can be switched ON and OFF
- Tracks energy consumption


## Security Camera

- Rated power: 12 W
- Can be switched ON and OFF
- Tracks energy consumption


## Thermostat

- Has a target temperature
- Has a current temperature
- Allows the target temperature to be changed
- Provides a device report

## Door Sensor

- Tracks whether the door is open
- Records door openings
- Reports the number of openings

## Object-Oriented Programming Concepts


## Abstraction


The `Device` class is an abstract base class that defines common behaviour for all devices.


## Encapsulation


Device state is protected using access modifiers such as `private set` and `protected set`. This prevents outside code from directly changing certain values.

## Inheritance


Common behaviour is shared through inheritance.

`Light`, `Kettle`, and `SecurityCamera` inherit from `SwitchableDevice`, while `Thermostat` and `DoorSensor` inherit directly from `Device`.


## Polymorphism

Different device types are stored in a single `List<Device>`.

Each device provides its own implementation of `Report()`.

## Method Overriding

Each concrete device overrides the abstract `Report()` method from `Device`.

## Unit Testing

The project uses xUnit to test the behaviour of the devices.

The tests cover:

- Device initial states
- Turning devices ON and OFF
- Toggle behaviour
- Energy consumption
- Energy accumulation
- Device wattage
- Thermostat temperature changes
- Thermostat reports
- Door opening behaviour
- Door opening counts

All current unit tests are passing.

## Technologies Used

- C#
- .NET
- Visual Studio
- xUnit
- Git
- GitHub

## What I Learned

This project helped me understand how to design a small object-oriented system using separate classes with different responsibilities.

The main concepts I practised were abstraction, encapsulation, inheritance, polymorphism, method overriding, unit testing, debugging, and Git version control.

I also learned that writing code that compiles is not enough. Unit tests help verify that the code behaves correctly and can identify logic errors that the compiler cannot detect.
