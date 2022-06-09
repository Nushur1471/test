using Task4;

FormatChecker formatChecker = new FormatChecker();
bool result = formatChecker.IsValid("01762990866");
if (result)
{
    Console.WriteLine("Valid");
}
else
{
    Console.WriteLine("Not Valid");
}
