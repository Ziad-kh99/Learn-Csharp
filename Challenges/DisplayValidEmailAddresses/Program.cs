string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};


for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayAddresses(corporate[i, 0], corporate[i, 1], "contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayAddresses(external[i, 0], external[i, 1]);
}



void DisplayAddresses(string firstName, string lastName, string domain = "hayworth.com")
{
    string userName = (firstName.Substring(0, 2) + lastName).ToLower();
    string emailAddress = $"{userName}@{domain}";
    Console.WriteLine(emailAddress);
}


