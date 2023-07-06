
    // public string Color {get;set;}; Keep in mind.


public abstract class Vehicle 
{
    string Name;
    public string _Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    public int NumOfPass;
    public string Color;
    public bool HasEngine;
    public int Miles;

    public Vehicle(string name, int pass, string color, bool eng)
    {
        Name = name;
        NumOfPass = pass;
        Color = color;
        HasEngine = eng;
        Miles = 0;
    }
    public Vehicle(string name, string color)
    {
        Name = name;
        NumOfPass = 5;
        Color = color;
        HasEngine = true;
        Miles = 0;
    }

    public void ShowInfo() 
    {
        Console.WriteLine($"Name: {Name}, Number of passengers: {NumOfPass}, Color: {Color}, Has an Engine? {HasEngine}, Miles traveled: {Miles} ");
    }

    public void Travel(int dist)
    {
        Miles += dist;
        Console.WriteLine($"{Name} went {dist} miles. Total miles are now {Miles}.");
    }

        public override string ToString()
    {
        return _Name;
    }

}