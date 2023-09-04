public class Mutant
{
    public string name ="Unknown";

    public Mutant(string name1)
    {
        name = name1;
        Random rnd = new Random();
        int okArmNumber = rnd.Next(1, 5);
        int okLegNumber = rnd.Next(1, 6);
        int armNumber = okArmNumber;
        int legNumber = okLegNumber;

        Arm[] arms = new Arm[okArmNumber];
        for (int i = 0; i < okArmNumber; i++)
        {
            arms[i] = new Arm();
        }
        Leg[] legs = new Leg[okLegNumber];
        for (int i = 0; i < okLegNumber; i++)
        {
            legs[i] = new Leg();
        }
        Console.WriteLine(name + " has " + armNumber + " arms and " + legNumber + " legs.");
    }


    public void Greet(Mutant other)
    {
        Console.WriteLine("");
        Console.WriteLine("Hello, my name is " + name);
        Console.WriteLine("Hello, " + name + " my name is " + other.name);
        
    }

}