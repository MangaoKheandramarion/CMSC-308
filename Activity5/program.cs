using System.Collections;
using System.IO;
public class Program
{
 static ArrayList bmCounter = new ArrayList();
 static ArrayList names = new ArrayList();
 static ArrayList colors = new ArrayList();
 static ArrayList contents = new ArrayList();
 static void Main(string[] args)
 {
 Menu();
 }
static void Menu()
 {
 
 char choice;
 Console.WriteLine("===MENU===");
 Console.WriteLine("1.Display Info");
 Console.WriteLine("2.Change Color");
 Console.WriteLine("3.Refill");
 Console.WriteLine("4.Write");
 Console.WriteLine();
 Console.Write("Enter your choice: ");
 choice = Convert.ToChar(Console.ReadLine());
 Console.WriteLine();
 
 switch (choice)
 {
 case 'A':
 Add();
 break;
 case 'S':
 Search();
 break;
 case 'V':
 View();
 break;
 case 'E':
 Console.Write("Exiting the program...");
 Console.ReadLine();
break;
 default:
 Console.WriteLine("Your input is invalid");
 Console.ReadKey();
 Console.Clear();
 Menu();
 break;
 }
 }
static void Add()
 {
 string filepath = @"D:\FPAct8_(Mangao)\BoardMarker.txt";
 
 Console.Write("Input boardMarker Name: ");
 names.Add(Console.ReadLine());
 Console.Write("Input inkColor: ");
 colors.Add(Console.ReadLine());
 Console.Write("Input inkContent: ");
 contents.Add(Console.ReadLine());
 bmCounter.Add(null);
 
 using (StreamWriter sw = new StreamWriter(filepath))
 {
 sw.WriteLine("Number \tName \tColor \tContemt ");
 for (int i = 0; i < bmCounter.Count; i++)
 {
 sw.WriteLine("{0} \t{1} \t{2} \t{3}", i + 1, names[i], colors[i], contents[i]);
 }
 }
 Console.WriteLine("Information SAVED successfully!!!");
 Console.WriteLine();
 Console.Write("Returning to Menu...");
 Console.ReadLine();
 Console.Clear();
 Menu();
 }
 
static void Search()
{
 int i;
Console.Write("Enter the bm number: ");
 i = Convert.ToInt32(Console.ReadLine());
 i--;
