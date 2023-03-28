using Structures.Model;

var raffle31 = StatOperations.NeverAppeared(Lottery.Emit(20, 10));
var raffle32 = StatOperations.MostAppeared(Lottery.raffleAll, 5);

Console.WriteLine("");
Console.WriteLine("Amount raffle - 10");
Console.WriteLine("");
foreach (var i in raffle32)
{
    Console.WriteLine("mostAppeared - "+i);
}
foreach (var i in raffle31)
{
    Console.WriteLine("neverAppeared - "+i);
}


var raffle21 = StatOperations.NeverAppeared(Lottery.Emit(20, 50));
var raffle22 = StatOperations.MostAppeared(Lottery.raffleAll, 5);

Console.WriteLine("");
Console.WriteLine("Amount raffle - 50");
Console.WriteLine("");
foreach (var i in raffle22)
{
    Console.WriteLine("mostAppeared - "+i);
}
foreach (var i in raffle21)
{
    Console.WriteLine("neverAppeared - "+i);
}

var raffle11 = StatOperations.NeverAppeared(Lottery.Emit(20, 100));
var raffle12 = StatOperations.MostAppeared(Lottery.raffleAll, 5);

Console.WriteLine("");
Console.WriteLine("Amount raffle - 100");
Console.WriteLine("");
foreach(var i in raffle12)
{
    Console.WriteLine("mostAppeared - "+i);
}
foreach(var i in raffle11)
{
    Console.WriteLine("neverAppeared - "+i);
}

