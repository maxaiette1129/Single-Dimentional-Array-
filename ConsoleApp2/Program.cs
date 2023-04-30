namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] singleArray = new int[] { 1, 2, 3 , 4, 5};
            for(int i = 0; i < singleArray.Length; i++) 
            {
                if (singleArray.Length == 5)
                {
                    Console.WriteLine(singleArray[i]);
                    break;
                }   
                else
                {
                    Console.WriteLine("error");
                }
            }
            Console.Clear();
            int[] isTemporray = new int[singleArray.Length];
            Array.Copy(singleArray,isTemporray,singleArray.Length);
            Console.WriteLine(isTemporray[2]);

            singleArray = new int[100];
            Array.Copy(isTemporray, singleArray, isTemporray.Length);
        }
    }
}