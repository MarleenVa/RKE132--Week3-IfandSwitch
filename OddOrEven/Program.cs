

Console.WriteLine("Enter a number");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutja arv on paaris voi paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0) //!= - ei ole 
{
    Console.WriteLine("user number is odd");
}else
{

    Console.WriteLine("user number is even");
}