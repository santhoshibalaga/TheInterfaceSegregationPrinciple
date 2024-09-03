# Interface Segregation Principle (ISP)

## Overview

The **Interface Segregation Principle (ISP)** is one of the five SOLID principles of object-oriented design, which are widely regarded as best practices for designing robust, maintainable, and flexible software systems. ISP states that no client should be forced to depend on interfaces they do not use. In other words, an interface should provide only the functionality that is relevant to the client, and large, monolithic interfaces should be split into more specific ones.

## Why Interface Segregation Principle?

In object-oriented programming, interfaces define a contract that implementing classes must fulfill. If an interface becomes too large or includes too many methods, it can lead to a situation where implementing classes are forced to provide unnecessary or irrelevant functionality, leading to code that is harder to understand, maintain, and extend.

The Interface Segregation Principle aims to solve this problem by advocating for smaller, more specific interfaces. This approach has several benefits:

- **Increased Flexibility**: Smaller interfaces are easier to implement and modify, leading to more adaptable code.
- **Improved Maintainability**: Code that depends on smaller interfaces is easier to understand and maintain.
- **Enhanced Reusability**: Specific interfaces are more likely to be reused across different parts of a system or even in different projects.
- **Reduced Coupling**: By adhering to ISP, you minimize the dependencies between classes, leading to a more loosely coupled system.

# CLASS DIAGRAM
![ClassDiagram](https://github.com/user-attachments/assets/84d364d0-b6da-4eaf-b9cb-f0032b895c60)


## Example Scenario

Imagine a smart home system where various devices like lights, thermostats, cameras, and assistants implement a variety of functionalities such as turning on/off, adjusting brightness, detecting motion, recording video, and setting schedules.


### Bad Design: A Fat Interface  && Good Design: Segregated Interfaces

In a poor design, you might create a single large interface that includes all possible operations and In a good design, you might create different interfaces that include only the relevant operations for each client:

```csharp
//Bad Design
public interface ISmartDevice
{
    void TurnOn();
    void TurnOff();
    void AdjustBrightness(int level);
    void SetTemperature(int temp);
    void DetectMotion();
    void RecordVideo();
    void SetSchedule(string schedule);
}

// Good Design
public interface ISwitchable
{
    void TurnOn();
    void TurnOff();
}

public interface IBrightnessAdjustable
{
    void AdjustBrightness();
}
public interface IMotionDetectable
{
    void DetectMotion();
}
public interface IVideoRecordable
{
    void RecordVideo();
}
public interface ITemperatureAdjustable
{
    void SetTemperature();
}
public interface ISchedulable
{
    void SetSchedule(string schedule);
}

