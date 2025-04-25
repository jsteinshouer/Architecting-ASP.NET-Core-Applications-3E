
# Section 1: Principles and Methodologies

## Introduction

### What is a design pattern?
### Anti-patterns and code smells
### Understanding the web: request/response
### Getting started with .NET
### Summary
### Questions
### Further reading
### Answers

## Automated Testing

### An overview of automated testing
### Testing approaches

- Uses the [testing diamond](Diagrams/Testing.svg) as opposed to the testing pyramid where majority of tests are integration tests.

### Testing techniques

- TDD (Red, Green, Refactor)
- ATDD

### Test case creation

- Focus on inputs and outputs
- Equivalence partitioning
    * divide outputs into classes or groups
- Boundry value analysis 
- Decision table testing

### Introducing the xUnit framework

- You can install the `C# Dev Kit` extension for VS Code to use the GUI for testing
    * You must build the test project for the tests to appear in the Test Explorer
- Creating a xUnit project `MyProject.Tests`


    ```bash
    dotnet new xunit
    ```

    Add a reference to the project you are testing.

    ```bash
    dotnet add reference ../../src/MyProject.csproj.
    ```

- `[fact]` attribute is used to define a test case
- `[Theroy]` attribute is used to define a data driven test case
- Running tests with the CLI

    ```
    dotnet test
    ```

### Arrange, Act, Assert
### Organizing your tests
### Writing ASP.NET Core integration tests
### Important testing principles
### Summary
### Questions
### Further reading
### Answers

## Architectural Principles

### Separation of concerns (SoC)
### Don’t repeat yourself (DRY)
### Keep it simple, stupid (KISS)
### You Aren’t Gonna Need It (YAGNI)
### The SOLID principles
### Summary
### Questions
### Further reading
### Answers

## REST APIs

### REST and HTTP
### The Data Transfer Object (DTO) pattern
### API contracts
### Summary
### Questions
### Further reading
### Answers

# Section 2: Designing with ASP.NET Core

## Minimal APIs

### Top-level statements
### Minimal hosting
### Minimal APIs
### Using Minimal APIs with Data Transfer Objects
### Summary
### Questions
### Further reading
### Answers

## Model-View-Controller

### The MVC design pattern
### Using MVC with DTOs
### Summary
### Questions
### Further reading
### Answers

## Strategy, Abstract Factory, and Singleton Design Patterns

### The Strategy design pattern
### The Abstract Factory design pattern
### The Singleton design pattern
### Summary
### Questions
### Answers

## Dependency Injection

### What is dependency injection?
### Revisiting the Strategy pattern
### Revisiting the Singleton pattern
### Understanding guard clauses
### Understanding the Service Locator pattern
### Revisiting the Factory pattern
### Summary
### Questions
### Further reading
### Answers

## Application Configuration and the Options Pattern

### Loading the configuration
### Learning the options interfaces
### Exploring common usage scenarios
### Learning options configuration
### Validating our options objects
### Validating options using FluentValidation
### Injecting options objects directly
### Centralizing the configuration for easier management
### Using the configuration-binding source generator
### Using the options validation source generator
### Using the ValidateOptionsResultBuilder class
### Wrapping up
### Summary
### Questions
### Further reading
### Answers

## Logging Patterns

### What is logging?
### Writing logs
### Log levels
### Logging providers
### Configuring logging
### Structured logging
### Summary
### Questions
### Further reading
### Answers

# Section 3: Component Patterns

## Structural Patterns

### The Decorator design pattern
### The Composite design pattern
### The Adapter design pattern
### The Façade design pattern
### Summary
### Questions
### Further reading
### Answers

## Behavioral Patterns

### The Template Method pattern
### The Chain of Responsibility pattern
### Mixing the Template Method and Chain of Responsibility patterns
### Summary
### Questions
### Answers

## Operation Result Pattern

### The Operation Result pattern
### Summary
### Questions
### Further reading
### Answers

# Section 4: Application Patterns

### Anti-pattern – Big Ball of Mud

## Layering and Clean Architecture

### Introducing layering
### Responsibilities of the common layers
### Abstract layers
### Sharing the model
### Clean Architecture
### Implementing layering in real life
### Summary
### Questions
### Further reading
### Answers

## Object Mappers

### The Object Mapper pattern
### Code smell – too many dependencies
### Implementing a mapping façade
### Implementing a mapping service
### Exploring AutoMapper
### Exploring Mapperly
### Summary
### Questions
### Further reading
### Answers

## Mediator and CQS Patterns

### A high-level overview of Vertical Slice Architecture

### The Mediator pattern
### The CQS pattern
### Code smell – Marker Interfaces
### Using MediatR as a mediator
### Summary
### Questions
### Further reading
### Answers

## Getting Started with Vertical Slice Architecture

### Vertical Slice Architecture
### Summary
### Questions
### Further reading
### Answers

## Request-EndPoint-Response (REPR)

### The Request-EndPoint-Response (REPR) pattern
### An e-commerce application—a slice of the real-world
### Summary
### Questions
### Further reading
### Answers

## Introduction to Microservices Architecture

### What are microservices?
### An introduction to Event-Driven Architecture
### Project – BFF
### Revisiting the CQRS pattern
### Overview of the Microservice Adapter pattern
### Summary
### Questions
### Further reading
### Answers

## Modular Monolith

### What is a Modular Monolith?
### Implementing a Modular Monolith
### Project – Modular Monolith
### Transitioning to microservices
### Challenges and pitfalls
### Summary
### Questions
### Further reading
### Answers
### An end is simply a new beginning
