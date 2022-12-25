System.Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

 int count = 1;
 while (count <= num)
 {
     Console.Write(Math.Pow(count, 3)+" ");
     count++;
 }