using PlebQuest;

Client client = new();

while (true)
{
    Console.WriteLine(client.GenerateItem());
    Console.ReadLine();
}

