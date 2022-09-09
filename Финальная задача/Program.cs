Console.Write("Введите слова через пробел: ");
string[] input = Console.ReadLine().Split(" ");
int lenOutput = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        lenOutput++;
    }
}

string[] output = new string[lenOutput];
int j = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[j] = input[i];
        j++;
    }
}

for (int i = 0; i < output.Length; i++)
{
    Console.Write(output[i] + " ");
}