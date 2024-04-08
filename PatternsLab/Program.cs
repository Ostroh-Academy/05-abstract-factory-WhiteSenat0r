// Abstract Product: Menu
interface IMenu
{
    void DisplayMenu();
}

// Concrete Products: Fast Food Menu
class FastFoodMenu : IMenu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Fast Food Menu:");
        Console.WriteLine("- Burger");
        Console.WriteLine("- Fries");
        Console.WriteLine("- Soft Drink");
    }
}

// Concrete Products: Gourmet Menu
class GourmetMenu : IMenu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Gourmet Menu:");
        Console.WriteLine("- Filet Mignon");
        Console.WriteLine("- Truffle Risotto");
        Console.WriteLine("- Creme Brulee");
    }
}

// Abstract Product: Interior
interface IInterior
{
    void DesignInterior();
}

// Concrete Products: Fast Food Interior
class FastFoodInterior : IInterior
{
    public void DesignInterior()
    {
        Console.WriteLine("Fast Food Interior: Bright colors, plastic chairs, and tables.");
    }
}

// Concrete Products: Gourmet Interior
class GourmetInterior : IInterior
{
    public void DesignInterior()
    {
        Console.WriteLine("Gourmet Interior: Elegant decor, soft lighting, and comfortable seating.");
    }
}

// Abstract Factory: Restaurant Factory
interface IRestaurantFactory
{
    IMenu CreateMenu();
    IInterior DesignInterior();
}

// Concrete Factory: Fast Food Restaurant Factory
class FastFoodRestaurantFactory : IRestaurantFactory
{
    public IMenu CreateMenu()
    {
        return new FastFoodMenu();
    }

    public IInterior DesignInterior()
    {
        return new FastFoodInterior();
    }
}

// Concrete Factory: Gourmet Restaurant Factory
class GourmetRestaurantFactory : IRestaurantFactory
{
    public IMenu CreateMenu()
    {
        return new GourmetMenu();
    }

    public IInterior DesignInterior()
    {
        return new GourmetInterior();
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        // Creating a fast food restaurant
        IRestaurantFactory fastFoodFactory = new FastFoodRestaurantFactory();
        IMenu fastFoodMenu = fastFoodFactory.CreateMenu();
        IInterior fastFoodInterior = fastFoodFactory.DesignInterior();

        Console.WriteLine("Creating a Fast Food Restaurant:");
        fastFoodMenu.DisplayMenu();
        fastFoodInterior.DesignInterior();
        
        Console.WriteLine();

        // Creating a gourmet restaurant
        IRestaurantFactory gourmetFactory = new GourmetRestaurantFactory();
        IMenu gourmetMenu = gourmetFactory.CreateMenu();
        IInterior gourmetInterior = gourmetFactory.DesignInterior();

        Console.WriteLine("Creating a Gourmet Restaurant:");
        gourmetMenu.DisplayMenu();
        gourmetInterior.DesignInterior();
    }
}
