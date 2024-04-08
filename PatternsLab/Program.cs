namespace PatternsLab;

// Abstract Product Interfaces
interface IButton
{
    void Paint();
}

interface ITextBox
{
    void Paint();
}

// Concrete Products
class WinButton : IButton
{
    public void Paint() => Console.WriteLine("Windows style button");
}

class WinTextBox : ITextBox
{
    public void Paint() => Console.WriteLine("Windows style text box");
}

class MacButton : IButton
{
    public void Paint() => Console.WriteLine("Mac style button");
}

class MacTextBox : ITextBox
{
    public void Paint() => Console.WriteLine("Mac style text box");
}

// Abstract Factory Interface
interface IGUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}

// Concrete Factories
class WinFactory : IGUIFactory
{
    public IButton CreateButton() => new WinButton();

    public ITextBox CreateTextBox() => new WinTextBox();
}

class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();

    public ITextBox CreateTextBox() => new MacTextBox();
}

// Usage
class Program
{
    static void Main(string[] args)
    {
        IGUIFactory factory = new WinFactory();
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();
        button.Paint(); // Output: Windows style button
        textBox.Paint(); // Output: Windows style text box

        factory = new MacFactory();
        button = factory.CreateButton();
        textBox = factory.CreateTextBox();
        button.Paint(); // Output: Mac style button
        textBox.Paint(); // Output: Mac style text box
    }
}