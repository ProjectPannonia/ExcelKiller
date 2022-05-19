namespace ExcelKiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KillAllExcelFromTaskManager();
        }
        static void KillAllExcelFromTaskManager()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
    }
}
