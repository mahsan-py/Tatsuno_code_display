namespace WindowsFormsApp12345
{
    public  class Appsetting
    {
        public  string[] comport()
        {
            string[] com = { "COM33", "COM43", "COM63", "COM73", "COM83" };

            return com;

        }

        public static string ConnectionString()
        {
            string constring = "Server=localhost;" +
                "Database=munir_filling;" +
                "Uid=root;" +
                "pwd=''";
            return constring;
        }

        public static string ConnectionApp()
        {
            string constring = "Server=localhost;" +
                "Database=munir_filling;" +
                "Uid=root;" +
                "pwd=''";
            return constring;
        }
       

    }

    
}
