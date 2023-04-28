string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20 && !permission.Contains("Admin"))
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission.Contains("Manager") && level < 20 && !permission.Contains("Admin"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if (!permission.Contains("Manager") && !permission.Contains("Admin"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}