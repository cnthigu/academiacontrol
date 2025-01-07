using System;
using System.Diagnostics;

public static class Utils
{
    public static string ObterSerialHD()
    {
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c wmic diskdrive get serialnumber",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = Process.Start(psi))
            {
                if (proc != null)
                {
                    string output = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();
                    string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (lines.Length > 1)
                    {
                        return lines[1].Trim();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao obter o serial do HD: " + ex.Message);
        }

        return null;
    }
}
