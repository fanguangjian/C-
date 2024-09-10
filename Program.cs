// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Helo C#");
// Console.WriteLine(args[0]);

using System.Data;
using System.Text.Json;
using AutoMapper;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Thread.Sleep: 同步方法，阻塞线程，适用于简单的线程休眠。
// Task.Delay: 异步方法，不阻塞线程，适用于异步编程场景。
// Thread.Sleep: synchronous method, blocking the thread, suitable for simple thread sleeping.
// Task.Delay: asynchronous method, does not block the thread, suitable for asynchronous programming scenarios.


namespace HelloWorld
{  
   
    internal static class Program {
        static async Task Main(string[] args)
        {
           Task firstTask = new Task( () => {
                Thread.Sleep(100);
                Console.WriteLine("Task 1 100");
           });
           firstTask.Start();
           Task secondTask = ConsoleAfterDelayAsync("Task 2 150", 150);
           Task thirdTask = ConsoleAfterDelayAsync("Task 3 1500", 1500);

           ConsoleAfterDelay("Delay 1000", 1000);           
           await firstTask;
           Console.WriteLine("After the task was created");
           ConsoleAfterDelay("Delay 2000", 2000);
           await secondTask;
           await thirdTask;
           Console.WriteLine("After the task was created 123");

        }

        static void ConsoleAfterDelay( string text,  int delayTime){
            Thread.Sleep(delayTime);
            Console.WriteLine(text);
        }

        static async Task ConsoleAfterDelayAsync( string text,  int delayTime){
            // Thread.Sleep(delayTime);
            await Task.Delay(delayTime);
            Console.WriteLine(text);
        }

       
    }
    
}
