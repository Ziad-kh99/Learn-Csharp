const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
string openingTag = "<span>";
// string closingTag = "</span";

int openingPosition = input.IndexOf("<span>");
int closingPosition = input.IndexOf("</span>");


openingPosition += openingTag.Length;
int length = closingPosition - openingPosition;


quantity = input.Substring(openingPosition, length);

openingTag = "<div>";

openingPosition = input.IndexOf("<div>");
closingPosition = input.IndexOf("</div>");

openingPosition += openingTag.Length;

length = closingPosition - openingPosition;

output = input.Substring(openingPosition, length);

output = output.Replace("&trade;", "$reg;");



Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
