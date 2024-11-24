namespace Utilities
{
    public static class ConsoleOutPut
    {
        public static void WriteDot(string dotChar = ".", bool isError = false)
        {
            Console.ForegroundColor = isError ? ConsoleColor.Red : ConsoleColor.Yellow;
            Console.Write(dotChar);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void WriteVerbose(string message, bool isError = false)
        {
            Console.ForegroundColor = isError ? ConsoleColor.Red : ConsoleColor.Yellow;
            if (message.Contains("->Munged<-"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("M");
            }
            else
            {
                Console.Write(message);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
