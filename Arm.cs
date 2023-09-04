public class Arm : Bodyparts
{
    public Arm()
    {
        int handCount = Age / 10;
        Hand[] hands = new Hand[handCount];
        for (int i = 0; i < handCount; i++)
        {
            hands[i] = new Hand();
        }
        Console.WriteLine("I have " + handCount + " hands on my arms.");
    }
}