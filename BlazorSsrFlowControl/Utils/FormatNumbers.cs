namespace BlazorSsrFlowControl.Utils
{
    public class FormatNumbers
    {
        public static string? Time(int? n)
        {
            return n?.ToString().Length == 1 ? "0" + n : n.ToString();
        }
    }
}
