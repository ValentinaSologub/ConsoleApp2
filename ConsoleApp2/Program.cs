// See https://aka.ms/new-console-template for more information
namespace ConsoleApp2;
    {
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        address.index = "12345";
        address.country = "Ukraine";
        address.city = "Kyiv";
        address.street = "Kreshchatyk";
        address.house = "14";
        address.apartment = "25";

        Console.WriteLine(address);

        User user = new User("john_doe", "John", "Done", "50");
        user.DisplayUserInfo();
        Console.Write(user);

        Converter converter = new Converter(37.0, 40.7, 8.5);
        Console.WriteLine("Конвертація з UAH в інші валюти:");
        double uahAmount = 1000.0;
        Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToUsd(uahAmount)} USD");
        Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToEur(uahAmount)} EUR");
        Console.WriteLine($"{uahAmount} UAH = {converter.ConvertToPln(uahAmount)} PLN");

        Console.WriteLine("nКонвертація з інших валют в UAH:");
        double usdAmount = 50.0;
        double eurAmount = 40.0;
        double plnAmount = 200.0;
        Console.WriteLine($"{usdAmount} USD = {converter.ConvertFromUsd(usdAmount)} UAH");
        Console.WriteLine($"{eurAmount} EUR = {converter.ConvertFromEur(eurAmount)} UAH");
        Console.WriteLine($"{plnAmount} PLN = {converter.ConvertFromPln(plnAmount)} UAH");

        Console.Write(converter);

        Employee employee = new Employee("Semenov", "Max");
        employee.CalculateSalaryAndTax("Developer", 4);
        Console.Write(employee);
    }
}
