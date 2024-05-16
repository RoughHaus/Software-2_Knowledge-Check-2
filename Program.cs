// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter how many jets are present on the radar scope: ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Jet>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var jet = new Jet();

    Console.WriteLine("Enter the number of engines for the jet: ");
    jet.Engines = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the altitude for the jet: ");
    jet.Altitude = int.Parse(Console.ReadLine());

    recordList.Add(jet);
}

// Print out the list of records using Console.WriteLine()
foreach (var jet in recordList)
{
    Console.WriteLine(jet.ToString());
}

public class Airplane
{
    public int Engines;
    public int Altitude;

    public override string ToString()
    {
        return $"Engines : {Engines}, Altitude: {Altitude}";
    }
}

public class Jet : Airplane 
{
    private int propellers = 0;
}