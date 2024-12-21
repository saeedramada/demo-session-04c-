using System.Text;

internal class program
{
    static void Main(string[] args)
    {
        #region loop statments
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"{i} t");

        //}
        #endregion
        #region for - foreach
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] += 10;
        //    Console.WriteLine(numbers[i]);
        //}
        // class interefae iEnumerable
        //foreach (int number in numbers) { 

        //    Console.WriteLine(number);
        //}
        #endregion
        #region while - do while
        //int num;
        //bool flag;
        //do
        //{
        //    Console.WriteLine("enter even num");
        //    num = int.Parse(Console.ReadLine());
        //   flag= int.TryParse(Console.ReadLine(), out num);
        //}while (num %2==1 || !flag);
        //Console.WriteLine($"{num} is Even");


        //int num =3;
        //bool flag =false;
        //while (num % 2 == 1 || !flag) {
        //    Console.WriteLine("enter even num");
        //    flag = int.TryParse(Console.ReadLine(), out num);

        //}
        //Console.WriteLine($"{num} is Even");

        #endregion
        #region string
        // class =>referance type
        // immutable datatype can not be changed
        //array of chars

        //string Name;
        //Name = new string("saeed");
        //string name01 = "saeed";
        //string name02 = "saeed";
        //Console.WriteLine(name01);
        //Console.WriteLine($"name01 HC : {name01.GetHashCode()}");
        //Console.WriteLine(name02);
        //Console.WriteLine($"name01 HC : {name02.GetHashCode()}");

        //string name01 = "saeed";
        //string name02 = "saleh";
        //Console.WriteLine(name01);
        //Console.WriteLine($"name01 HC : {name01.GetHashCode()}");
        //Console.WriteLine(name02);
        //Console.WriteLine($"name01 HC : {name02.GetHashCode()}");
        //name02 = name01;
        //Console.WriteLine("*********name02 = name01**********");
        //Console.WriteLine(name01);
        //Console.WriteLine($"name01 HC : {name01.GetHashCode()}");
        //Console.WriteLine(name02);
        //Console.WriteLine($"name01 HC : {name02.GetHashCode()}");
        //name01 = "saber";
        //Console.WriteLine("*************name01 = saber**************");

        //Console.WriteLine(name01);
        //Console.WriteLine($"name01 HC : {name01.GetHashCode()}");
        //Console.WriteLine(name02);
        //Console.WriteLine($"name01 HC : {name02.GetHashCode()}");


        //string Message = "Hello";

        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode());
        //Message += "Route";

        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode()); 
        #endregion
        #region stringbuilder

        //StringBuilder message;
        //message = new StringBuilder("hello");
        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());
        //message.Append("route");
        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());   
        #endregion
        #region stringbuilder_method
        //StringBuilder message = new StringBuilder("wlcome");
        //message.Append(" to route");
        //message.AppendLine("saeed");
        //message.Append("saleh");
        //Console.WriteLine(message);


        //message.Remove(0, 7);
        //Console.WriteLine(message);
        //message.Insert(0, "hello");
        //Console.WriteLine(message);

        #endregion
        #region 1Darray

        //int[] numbers = new int[2] {1,2};
        //int[] numbers = new int[] {1,2};    
        //int[] numbers = {1,2};  


        //int[] numbers = new int[2];
        //for (int i = 0; i < numbers.Length; i++) { 
        //    numbers[i] = i+1;
        //}
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}
        //Console.WriteLine(numbers.Length);
        //Console.WriteLine(numbers.Rank);

        #endregion
        #region 2D array
        //int[,] marks = new int[3, 5] //{ {1,2,3,4,5 },{10,20,30,40,50 },{ 100,200,300,400,500} };
        ////Console.WriteLine(marks.Length);
        ////Console.WriteLine(marks.Rank);
        ////Console.WriteLine(marks.GetLength(0));
        ////Console.WriteLine(marks.GetLength(1));
        //for (int i = 0; i < marks.GetLength(0); i++) {
        //    Console.WriteLine($"enter grade studen({i+1})");
        //    for (int j = 0; j < marks.GetLength(1); j++) { 
        //        Console.Write($"enter grade subject({j+1})");
        //        marks[i,j] = int.Parse(Console.ReadLine());
        //    }
        
        //}
        //for (int i = 0; i < marks.GetLength(0); i++)
        //{
        //    Console.WriteLine($" grade studen({i + 1})");
        //    for (int j = 0; j < marks.GetLength(1); j++)
        //    {
        //        Console.Write($" grade subject({j + 1})");
        //        Console.Write(marks[i, j]);
        //    } 
        //}
            #endregion

        }
}