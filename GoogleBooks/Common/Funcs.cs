namespace GoogleBooks.Common
{
    class Funcs
    {
        public static string toString(object v, string d = "") => v?.ToString() ?? d; 
    }
}
