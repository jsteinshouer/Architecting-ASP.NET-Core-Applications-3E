using System;
using System.Linq;
using System.Reflection;
using Xunit;

public class SimpleTestRunner
{
    public static void RunTests(Type testClassType)
    {
        Console.WriteLine($"Running tests in {testClassType.Name}...");

        // Create an instance of the test class
        var testClassInstance = Activator.CreateInstance(testClassType);

        // Get all methods with the [Fact] or [Theory] attribute
        var testMethods = testClassType.GetMethods()
            .Where(m => m.GetCustomAttributes(typeof(FactAttribute), false).Any() ||
                        m.GetCustomAttributes(typeof(TheoryAttribute), false).Any());

        foreach (var method in testMethods)
        {
            var theoryData = method.GetCustomAttributes(typeof(InlineDataAttribute), false)
                                   .Cast<InlineDataAttribute>();
            
            if (theoryData.Any())
            {
                // Handle [Theory] with [InlineData]
                foreach (var data in theoryData)
                {
                    try
                    {
                        var parameters = data.GetData(method).ToArray<object[]>()[0];
                        Console.WriteLine($"Running {method.Name} with arguments: {String.Join(",", parameters)}...");
                        method.Invoke(testClassInstance, parameters);
                        Console.WriteLine($"✔ {method.Name} passed.");
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine($"✘ {method.Name} failed: {ex.InnerException?.Message}");
                        if ( ex.InnerException?.GetType().Namespace != "Xunit.Sdk" )
                        {
                            Console.Write($"{ex.InnerException?.StackTrace}");
                        }
                    }
                }
            }
            else
            {
                // Handle [Fact]
                try
                {
                    Console.WriteLine($"Running {method.Name}...");
                    method.Invoke(testClassInstance, null);
                    Console.WriteLine($"✔ {method.Name} passed.");
                }
                catch (TargetInvocationException ex)
                {
                    Console.WriteLine($"✘ {method.Name} failed: {ex.InnerException?.Message}");
                    if ( ex.InnerException?.GetType().Namespace != "Xunit.Sdk" )
                    {
                        Console.Write($"{ex.InnerException?.StackTrace}");
                    }
                }
            }
        }
    }
}