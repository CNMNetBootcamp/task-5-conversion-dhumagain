//setup
double initialValue = 0.0;
int conversion = 0;
string result = String.Empty;
string reply = "Y";
bool isString = true;
string inputValue = String.Empty;

//input
PUT("Enter 1 if you like to convert to quart/gallon and " +
" 2 if you like to convert to cups ");

GET inputValue;
if (conversion<1 || conversion>2)
{
"Please enter a valid number.");


PUT "Please enter the amount of substance you would like to convert");

GET inputValue; 

if (!isString)
{
("Please enter a valid number.");

//processing
if (conversion == 1)
{
result = initialValue + " cups of substance is " + initialValue / 4.0 +
	" quarts and " + initialValue / 16.0 + " gallons.";

}
else if (conversion == 2)
{
result = initialValue + " quarts of substance is " + 4 * initialValue + " " +
	" cups.";
}
//output 
GET result;

PUT("Would you like to perform another conversion?");
GET reply