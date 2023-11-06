// See https://aka.ms/new-console-template for more information

using Test.Api.Controllers;
using Test.Domain;

var serviceResponse = new StudentsController();

Console.WriteLine(serviceResponse.Call());
Console.WriteLine(serviceResponse.Call().AddAsterix());

Console.ReadKey();
