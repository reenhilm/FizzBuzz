int[] arrXYZ = new int[3];
string[] sXYZ = Console.ReadLine().Split(' ',3);
arrXYZ[0] = int.Parse(sXYZ[0]);
arrXYZ[1] = int.Parse(sXYZ[1]);
arrXYZ[2] = int.Parse(sXYZ[2]) + 1;

static bool isDevicable(int a, int b)
{
    return a % b == 0;
}
const string FIZZ = "Fizz";
const string BUZZ = "Buzz";
int iLowestDenominator = arrXYZ[0] * arrXYZ[1];

for (int i = 1; i < arrXYZ[2]; i++)
{
    //Smallest Denominator of X and Y
    if (isDevicable(i, iLowestDenominator))
        Console.WriteLine(string.Concat(FIZZ, BUZZ));
    //X
    else if (isDevicable(i, arrXYZ[0]))
        Console.WriteLine(FIZZ);
    //Y
    else if (isDevicable(i, arrXYZ[1]))
        Console.WriteLine(BUZZ);
    else
        Console.WriteLine(i);
}