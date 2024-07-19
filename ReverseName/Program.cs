
using System.Text;


string name;

do
{
    Console.WriteLine("Write the name you want reversed: ");
    name = Console.ReadLine();

} while (name == "");

string reversedName = ReverseName(name);
PrintReverseName(reversedName);

string ReverseName(string name)
{
    var stringBuilder = new StringBuilder();

    for(int i = name.Length - 1; i >= 0; i--)
    {
        stringBuilder.Append(name[i]);
    }

    return stringBuilder.ToString();
}

void PrintReverseName(string name)
{
    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine(name[i]);
    }
}