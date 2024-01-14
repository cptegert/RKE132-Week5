//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int math, biology, chemistry;

//Console.WriteLine("Enter your Math result:");
//math = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter your Biology result:");
//biology = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter your Chemistry result:");
//chemistry = Int32.Parse(Console.ReadLine());


//if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
//{ Console.WriteLine("Congratulations! You got accepted"); }
//else
//{ Console.WriteLine("Your application cannot be approved."); }

Console.WriteLine("Enter your temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{ Console.WriteLine("Boiling hot."); }
else if (temp < 30 && temp >= 20)
{ Console.WriteLine("Hot."); }
else if (temp < 20 && temp >= 15)
{ Console.WriteLine("Warm."); }
else if (temp < 15 && temp >= 10)
{ Console.WriteLine("Chilly."); }
else if (temp < 10 && temp > 0)
{ Console.WriteLine("Cold."); }
else
{ Console.WriteLine("Freezing cold."); }