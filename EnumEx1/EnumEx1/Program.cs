using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEx1
{
    [Flags]
    public enum FilePermissions
    {
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public class Program
    {
        public static void Main()
        {
            FilePermissions permissions = 0; // Start with no permissions

            Console.Write("Enter permissions (r for Read, w for Write, e for Execute): ");
            string input = Console.ReadLine(); // User input

            // Update permissions based on user input
            if (input.Contains('r')) permissions |= FilePermissions.Read;
            if (input.Contains('w')) permissions |= FilePermissions.Write;
            if (input.Contains('e')) permissions |= FilePermissions.Execute;

            Console.WriteLine("Granted permissions:");

            // Check and display granted permissions
            if (permissions.HasFlag(FilePermissions.Read)) Console.WriteLine("- Read");
            if (permissions.HasFlag(FilePermissions.Write)) Console.WriteLine("- Write");
            if (permissions.HasFlag(FilePermissions.Execute)) Console.WriteLine("- Execute");

            if (permissions == 0) Console.WriteLine("No permissions granted."); // No permissions case


            Console.ReadLine();
        }
    }

}
