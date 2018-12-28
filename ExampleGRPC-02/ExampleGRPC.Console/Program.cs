using System;
using System.Text;
using ExampleGRPC.Proto;
using Google.Protobuf;

namespace ExampleGRPC.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User()
            {
                FirstName = "Jim",
                LastName = "Chen"
            };

            System.Console.WriteLine($"Original: {user}\n");

            var bytes = user.ToByteArray();

            System.Console.WriteLine(bytes.Dump() + "\n");

            var parsedUser = User.Parser.ParseFrom(bytes);
            System.Console.WriteLine($"Parsed: {parsedUser}\n");

            System.Console.ReadKey();
        }
    }

    public static class Helper
    {
        public static string Dump(this byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length);
            foreach (var b in bytes)
            {
                sb.Append(b);
            }

            return sb.ToString();
        }
    }
}
