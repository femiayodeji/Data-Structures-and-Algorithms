using System;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYLIST");
            ArrayListTest();
        }
        public static void ArrayListTest(){
            ArrayList<int> customArrayList = new ArrayList<int>();
            customArrayList.Add(4);
            customArrayList.Add(5);
            customArrayList.Add(6);
            customArrayList.PrintElements();

            try{
                customArrayList[3] = 20;
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }

            customArrayList.Add(20);
            customArrayList.PrintElements();
            customArrayList.Insert(2,200);
            customArrayList.PrintElements();
        }
    }
}
