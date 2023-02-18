namespace AttributesApp.Models
{
    public static class UpdateProcess
    {
        [Obsolete("Downloading function not be supported in next version", false)]
        public static void Download(this Update[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading {update}");
                System.Threading.Thread.Sleep(500);
            }
        }
        [Obsolete("Insstaling function can't be use.", true)]
        public static void Install(this Update[] updates)
        {
            foreach (var update in updates)
            {
                Console.WriteLine($"Installing {update}");
                System.Threading.Thread.Sleep(900);
            }
        }
        public static void UpdateAndInstall(this Update[] updates)
        {
            //Download(updates);
            //Install(updates);

            foreach (var update in updates)
            {
                Console.WriteLine($"Downloading {update}");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"Installing {update}");
                System.Threading.Thread.Sleep(900);
            }
        }
    }
}