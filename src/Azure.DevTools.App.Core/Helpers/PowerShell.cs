using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Azure.DevTools.App.Core.Helpers;

public static class PowerShell
{
    private const string PWS = "powershell.exe";

    public static async Task<PowerShellResult> RunAsync(string commands)
    {
        return await Task.Run(() =>
        {
            var process = new Process
            {
                StartInfo = BuildProcessStartInfo(commands, true)
            };
            process.Start();

            return new PowerShellResult
            {
                ResultOutput = process.StandardOutput.ReadToEnd(),
                ErrorOutput = process.StandardError.ReadToEnd()
            };
        });
    }

    public static async Task RunOpenWindowAsync(string commands)
    {
        await Task.Run(() =>
        {
            var process = new Process
            {
                StartInfo = BuildProcessStartInfo(commands, false)
            };
            process.Start();
        });
    }

    private static ProcessStartInfo BuildProcessStartInfo(string arguments, bool runInBackground)
    {
        if (runInBackground)
        {
            return new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8,
                FileName = PWS,
                Arguments = arguments
            };
        }

        return new ProcessStartInfo
        {
            FileName = PWS,
            Arguments = arguments,
        };
    }
}

public class PowerShellResult
{
    public string ResultOutput
    {
        get; set;
    }

    public string ErrorOutput
    {
        get; set;
    }
}
