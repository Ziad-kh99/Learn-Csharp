

string IPv4 = "111.255.1.5";

string[] octets = IPv4.Split('.', StringSplitOptions.RemoveEmptyEntries);


if(ValidateLingth() && ValidateZeros() && ValidateRange())
{
    Console.WriteLine($"IP: {IPv4} is a valid IPv4 Address.");
}
else
{
    Console.WriteLine($"IP: {IPv4} is an invalid IPv4 Address.");
}

bool ValidateLingth()
{
    if (octets.Length == 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool ValidateZeros()
{
    foreach (string oct in octets)
    {
        if (oct.Length < 1 || oct.Length > 4 || oct.StartsWith('0'))
        {
            return false;
        }
    }

    return true;
}

bool ValidateRange()
{
    int validOct;

    foreach (string oct in octets)
    {
        if (int.TryParse(oct, out validOct) == false)
        {
            return false;
        }

        if (validOct < 0 || validOct > 255)
        {
            return false;
        }
    }

    return true;
}
