using System;

public class Whistle
{
    private string sound;

    public Whistle(string whistleSound)
    {
        sound = whistleSound;
    }

    public void Sound()
    {
        Console.WriteLine(sound);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Whistle duckWhistle = new Whistle("Kvaak");
        Whistle roosterWhistle = new Whistle("Peef");

        duckWhistle.Sound();  
        roosterWhistle.Sound(); 
        duckWhistle.Sound();    
    }
}
