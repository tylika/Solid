using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/
interface IPriceable
{
    void SetPrice(double price);
}

// Інтерфейс для елементів, що можуть мати знижки
interface IDiscountable
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
}

// Інтерфейс для елементів, що мають розмір
interface ISizable
{
    void SetSize(byte size);
}

// Інтерфейс для елементів, що мають колір
interface IColorable
{
    void SetColor(byte color);
}

// Клас для книг (ціна та знижки)
class Book : IPriceable, IDiscountable
{
    private double price;
    private string discount;
    private string promocode;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Book price set to: {price:C}");
    }

    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
        Console.WriteLine($"Book discount applied: {discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        this.promocode = promocode;
        Console.WriteLine($"Book promocode applied: {promocode}");
    }
}

// Клас для верхнього одягу (колір, розмір, ціна, знижка)
class Clothing : IPriceable, IDiscountable, IColorable, ISizable
{
    private double price;
    private string discount;
    private string promocode;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Clothing price set to: {price:C}");
    }

    public void ApplyDiscount(string discount)
    {
        this.discount = discount;
        Console.WriteLine($"Clothing discount applied: {discount}");
    }

    public void ApplyPromocode(string promocode)
    {
        this.promocode = promocode;
        Console.WriteLine($"Clothing promocode applied: {promocode}");
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine($"Clothing color set to: {color}");
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine($"Clothing size set to: {size}");
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        // Робота з книгами
        Book book = new Book();
        book.SetPrice(19.99);
        book.ApplyDiscount("10%");
        book.ApplyPromocode("SUMMER2024");

        // Робота з одягом
        Clothing clothing = new Clothing();
        clothing.SetPrice(49.99);
        clothing.SetColor(5); // Наприклад, код кольору
        clothing.SetSize(3);  // Наприклад, розмір M
        clothing.ApplyDiscount("20%");
        clothing.ApplyPromocode("WINTER2024");

        Console.ReadKey();
    }
}
