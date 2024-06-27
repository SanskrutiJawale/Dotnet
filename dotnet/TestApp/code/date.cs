using System;
 
class date{
 
static public void Main()
{
    string currentDate = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
 
    // Displaying current date      
    Console.WriteLine("current Date and Time is: " + currentDate);
}
}