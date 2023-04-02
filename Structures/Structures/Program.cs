using Structures.Model;


List<List<int>> ints = new List<List<int>>() {
    Lottery.Emit(300, 10),
    Lottery.Emit(300, 50),
    Lottery.Emit(300, 100)
};


Console.WriteLine("MostAppeared - " + string.Join(",", ints.MostAppeared(5)));
Console.WriteLine();
Console.WriteLine("NeverAppeared - " + string.Join(",", ints.NeverAppeared()));


