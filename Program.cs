Console.Write("Введите число отличное от 1, если хотите ввести массив самостоятельнно. ");
int choise = Convert.ToInt32(Console.ReadLine());
if (choise==1)
{

   string basic = "Hello, 2, world, :-)" ;
   string[] basicArray = basic.Split(", ");
   // string []endArray= new string[basicArray.Length];
   int el=0;
   
   for (int d=0;d<basicArray.Length;d++)
   {
      if(basicArray[d].ToString().Length<=3)
      {
         el+=1;
      }
   }
   string[]endArray= new string[el];
   int index= 0;
      for (int d=0;d<basicArray.Length;d++)
   {
      if(basicArray[d].ToString().Length<=3)
      {
         endArray[index]=basicArray[d];
         index+=1;
      }
    
   }
   
 Console.WriteLine($"Массив: [{String.Join(", ", endArray)}]");
   
}
else
{Console.WriteLine("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(size);
string[]array=GetArray(size);
PrintArray(array);
}
string[]GetArray(int size)
{ 
   int el=0;
   string []array=new string[size];
   for(int i =0;i<size;i++)
   { Console.Write("Введите данные : ");
    string num = Convert.ToString(Console.ReadLine());
    array[i]=num;
   }
   for (int d=0;d<size;d++)
   {
      if(array[d].ToString().Length<=3)
      {
         el+=1;
      }
   }
   string[]endArray= new string[el];
   int index= 0;
      for (int d=0;d<size;d++)
   {
      if(array[d].ToString().Length<=3)
      {
         endArray[index]=array[d];
         index+=1;
      }
    
   }
   



return endArray; 
}
void PrintArray(string[] array)
{
  Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
} 

