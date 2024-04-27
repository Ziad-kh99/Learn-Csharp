
string permission = "Admin|Manager";
int level = 21;
string message = $"Welcome, {(permission.Contains("Admin") && level > 55 ? "Super Admin" : "Admin")} user";
message = $"Welcome, {(permission.Contains("Manager") && level > 20 ? "Conact an Admin for access." : "You do not have sufficient privileges.")}";

Console.WriteLine(message);


