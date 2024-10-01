public class Tamagochi
{
    private int hunger = 100;
    private int boredom = 100;
    private int happiness = 100;
    private List<string> words = new List<string>();
    private bool isAlive = true;
    public string name;

    
    public void Feed()
    {
        hunger += 10;
        if (hunger > 100) hunger = 100; 
        Console.WriteLine($"{name} was fed!");
    }

    
    public void Hi()
    {
        happiness += 5;
        if (happiness > 100) happiness = 100; 
        Console.WriteLine($"{name} is happy to see you!");
    }

    
    public void Teach(string word)
    {
        words.Add(word);
        boredom += 10;
        if (boredom > 100) boredom = 100; 
        Console.WriteLine($"{name} learned a new word: {word}!");
    }

    
    public void Tick()
    {
        ReduceBoredom();
        ReduceHappiness();
        ReduceHunger();

        if (hunger <= 0 || boredom <= 0 || happiness <= 0)
        {
            isAlive = false; 
            Console.WriteLine($"{name} has died...");
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}, Boredom: {boredom}, Happiness: {happiness}");
    }

    public bool IsAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        boredom -= 5;
        if (boredom < 0) boredom = 0; 
    }

    private void ReduceHappiness()
    {
        happiness -= 3;
        if (happiness < 0) happiness = 0; 
    }

    private void ReduceHunger()
    {
        hunger -= 7;
        if (hunger < 0) hunger = 0; 
    }
}
