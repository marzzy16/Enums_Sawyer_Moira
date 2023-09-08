// See https://aka.ms/new-console-template for more information


// a method that prints my birthday 
int myBirthMonth = (int)Months.May;
int myBirthDay = 16;
int myBirthYear = 2006;

// a string thats set to equal to my birthday
string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

// reads and prints to console
File.WriteAllText("myFile.txt", "This is my text file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

if (!File.Exists("newFile.txt"))
{
    File.Copy("myFile.txt", "newFile.txt");
}
else
{
    File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
}

// prints my birthday to console
File.AppendAllText("newFile.txt", myBirthDate);
Console.WriteLine(File.ReadAllText("newFile.txt"));

// a global enum that has all the months 
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}
