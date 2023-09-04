public class Hand : Bodyparts
{
    public Hand()
    {
        Random rnd = new Random();
        int fingerNumber = rnd.Next(1, 8);
        int age = rnd.Next(1, 100);
       Finger[] fingers = new Finger[fingerNumber];
        for (int i = 0; i < fingerNumber; i++)
        {
            fingers[i] = new Finger();
        } 
    }
}