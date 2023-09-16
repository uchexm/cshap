/*string[] fraudulentIds = new string[3];

fraudulentIds[0] = "A123";

fraudulentIds[1] = "B456";

fraudulentIds[2] = "C789";*/

string[] fraudulentIds = {"A123", "B456", "C789"};


Console.WriteLine($"First: {fraudulentIds[0]}");
Console.WriteLine($"Second: {fraudulentIds[1]}");
Console.WriteLine($"Third: {fraudulentIds[2]}");

fraudulentIds[0] = "F00456";

Console.WriteLine($"Reassigned First: {fraudulentIds[0]}");

Console.WriteLine($"There are {fraudulentIds.Length} fraudulent orders");