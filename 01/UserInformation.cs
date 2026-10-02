using System;
using System.Text.RegularExpressions;

Console.WriteLine("=== User Information ===");

Console.Write("Enter first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter last name: ");
string lastName = Console.ReadLine();

Console.Write("Enter birth date (yyyy/MM/dd)");
string birthDateText = Console.ReadLine();

Console.Write("Enter national code: ");
string nationalCode = Console.ReadLine() ;

Console.Write("Enter mobile number: ");
string mobile = Console.ReadLine();

Console.Write("Enter bank card number: ");
string cardNumber = Console.ReadLine();


// -------------------------
// Mobile Number
// -------------------------

mobile = mobile.Replace(" ", "")
               .Replace("-", "");

if (mobile.StartsWith("+98"))
{
    mobile = "0" + mobile.Substring(3);
}
else if (mobile.StartsWith("0098"))
{
    mobile = "0" + mobile.Substring(4);
}

bool isMobileValid = Regex.IsMatch(mobile, @"^09\d{9}$");


// -------------------------
// National Code
// -------------------------

bool isNationalCodeValid =
    Regex.IsMatch(nationalCode, @"^\d{10}$");

if (isNationalCodeValid)
{
    int sum = 0;

    for (int i = 0; i < 9; i++)
    {
        sum += int.Parse(nationalCode[i].ToString()) * (10 - i);
    }

    int remainder = sum % 11;
    int controlDigit = int.Parse(nationalCode[9].ToString());

    if (remainder < 2)
    {
        isNationalCodeValid = controlDigit == remainder;
    }
    else
    {
        isNationalCodeValid = controlDigit == 11 - remainder;
    }
}


// -------------------------
// Age
// -------------------------

DateTime birthDate = DateTime.Parse(birthDateText);

int age = DateTime.Now.Year - birthDate.Year;

if (birthDate.Date > DateTime.Now.AddYears(-age).Date)
{
    age--;
}


// -------------------------
// Bank Card
// -------------------------

string bankName = "Unknown";

if (cardNumber.Length == 16)
{
    string prefix = cardNumber.Substring(0, 6);

    switch (prefix)
    {
        case "603799":
            bankName = "Bank Melli";
            break;

        case "589210":
            bankName = "Bank Sepah";
            break;

        case "627648":
            bankName = "Bank Tosee Saderat";
            break;

        case "603770":
            bankName = "Bank Keshavarzi";
            break;

        case "628023":
            bankName = "Bank Maskan";
            break;

        case "627760":
            bankName = "Post Bank";
            break;

        case "622106":
            bankName = "Bank Parsian";
            break;

        case "502229":
            bankName = "Bank Pasargad";
            break;

        case "621986":
            bankName = "Bank Saman";
            break;

        case "603769":
            bankName = "Bank Saderat";
            break;

        case "610433":
            bankName = "Bank Mellat";
            break;

        case "627353":
            bankName = "Bank Tejarat";
            break;
    }
}


// -------------------------
// Result
// -------------------------

Console.WriteLine();
Console.WriteLine("=== User Information ===");

Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);
Console.WriteLine("Birth Date: " + birthDateText);
Console.WriteLine("Age: " + age);

Console.WriteLine(
    "National Code: " +
    (isNationalCodeValid ? "Valid" : "Invalid"));

Console.WriteLine(
    "Mobile Number: " +
    (isMobileValid ? mobile : "Invalid"));

Console.WriteLine("Bank Card: " + cardNumber);
Console.WriteLine("Bank: " + bankName);

