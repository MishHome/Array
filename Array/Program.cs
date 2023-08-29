int[] mass = new int[] { 66, 7, 3, 64, 44, 5, 505, -1,9999, 2868, 9, 10, 11, 1, 0, 912, 13, 14, 15, 2, 30 };
int a = 0;
int c = (mass.Length + 5) - mass.Length;
for (int i = 0; i < mass.Length; i++)
{
    for (int b = i; b < mass.Length; b++)
    {
        if (mass[i] > mass[b])
        {
            a = mass[i];
            mass[i] = mass[b];
            mass[b] = a;
        }
    }
}
for (int index = mass.Length - 5; index < mass.Length; index++)
    Console.WriteLine(mass[index]);

Console.WriteLine("------------");

for (int index = 0; index < c; index++)
    Console.WriteLine(mass[index]);
