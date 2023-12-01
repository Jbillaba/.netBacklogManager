public class BacklogManager
{   public static bool running = true;
    static void Main(string[] args)
    {
        do 
        {
        Program.Menu();
        } while(running);
    }
}