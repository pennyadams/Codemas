// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//c# is a strongly typed language

int count = 3;
string name = "penny";
bool isNaughty = false;


int newCount = count * 3;
newCount++;

if (isNaughty)
{
    Console.WriteLine("This child is naughty, give them coal");
} else
{
    Console.WriteLine("This child is nice, give them presents");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ho ");
}

List<string> presents = new List<string>
{
    "partridge",
    "pear tree",
    "five gold rings"
};

foreach (string gift in presents)
{
    Console.WriteLine(gift);
}

DateTime christmas = new DateTime(2022, 12, 25);
double daysToGo = (christmas - (global::System.DateTime)DateTime.Now).TotalDays;
Console.WriteLine($"Only {daysToGo} days until Christmas");