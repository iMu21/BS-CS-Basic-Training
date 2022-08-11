int stringToInt(string st)
{
    int result = 0;
    foreach (char c in st)
    {
        int curr = c - 48;
        result = result * 10 + curr;
    }
    return result;
}

long stringToLong(string st)
{
    long result = 0;
    foreach (char c in st)
    {
        long curr = c - 48L;
        result = result * 10L + curr;
    }
    return result;
}

double stringToDouble(string st)
{
    double result = 0;
    int currentPosition = 0, positionOfDot = st.Length;
    foreach (char c in st)
    {
        if (c == '.') { positionOfDot = currentPosition; continue; }
        long curr = c - 48;
        result = result * 10L + curr;
        currentPosition++;
    }

    int positionOfDotBackward = currentPosition - positionOfDot;
    double toDivide = Math.Pow(10, positionOfDotBackward);
    result = result / toDivide;
    return result;
}

float stringToFloat(string st)
{
    float result = float.Parse(st);
    return result;
}

bool stringToBool(string st)
{
    if (st[0] == 'F') return false;
    return true;
}

long intToLong(int a)
{
    return (long)a;
}


int charToASCIIint(char c)
{
    int result = c;
    return result;
}
bool flag = true;

while (flag)
{
    int task;
    string st;
    Console.WriteLine("Choose an operation:\n1.string to int\n2.string to long\n3.string to double\n4.string to float\n5.string to bool\n6.int to long\n7.char to ASCII int\n");
    task = Convert.ToInt32(Console.ReadLine());
    switch (task)
    {
        case 1:
            st = Console.ReadLine();
            Console.WriteLine(stringToInt(st) + "\n");
            continue;
        case 2:
            st = Console.ReadLine();
            Console.WriteLine(stringToLong(st) + "\n");
            continue;
        case 3:
            st = Console.ReadLine();
            Console.WriteLine(stringToDouble(st) + "\n");
            continue;
        case 4:
            st = Console.ReadLine();
            Console.WriteLine(stringToFloat(st) + "\n");
            continue;
        case 5:
            st = Console.ReadLine();
            Console.WriteLine(stringToBool(st) + "\n");
            continue;
        case 6:
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intToLong(x) + "\n");
            continue;
        case 7:
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(charToASCIIint(c) + "\n");
            continue;
        default:
            flag = false;
            break;
    }
}