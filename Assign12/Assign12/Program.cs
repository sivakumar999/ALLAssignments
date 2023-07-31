using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assign12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a piece of text:");
            string inputText = Console.ReadLine();

            int wordCount = CountWords(inputText);
            Console.WriteLine($"Word Count: {wordCount}");

            var emailAddresses = GetEmailAddresses(inputText);
            if (emailAddresses.Count > 0)
            {
                Console.WriteLine("Email Addresses found:");
                foreach (var email in emailAddresses)
                {
                    Console.WriteLine(email);
                }
            }
            else
            {
                Console.WriteLine("No email addresses found.");
            }

            var mobileNumbers = ExtractMobileNumbers(inputText);
            if (mobileNumbers.Count > 0)
            {
                Console.WriteLine("Mobile Numbers found:");
                foreach (var number in mobileNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("No mobile numbers found.");
            }

            Console.WriteLine("Enter a custom regular expression to search:");
            string customRegexPattern = Console.ReadLine();

            var customRegexMatches = PerformCustomRegexSearch(inputText, customRegexPattern);
            if (customRegexMatches.Count > 0)
            {
                Console.WriteLine("Custom Regex Matches found:");
                foreach (var match in customRegexMatches)
                {
                    Console.WriteLine(match);
                }
            }
            else
            {
                Console.WriteLine("No matches found for the custom regular expression.");
            }
            Console.ReadKey();
        }


        static int CountWords(string inputText)
        {
            return inputText.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        static List<string> GetEmailAddresses(string inputText)
        {
            var emailRegex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");
            var emailMatches = emailRegex.Matches(inputText);

            var emailAddresses = new List<string>();
            foreach (Match match in emailMatches)
            {
                emailAddresses.Add(match.Value);
            }

            return emailAddresses;
        }

        static List<string> ExtractMobileNumbers(string inputText)
        {
            var mobileNumberRegex = new Regex(@"\b\d{10}\b");
            var mobileNumberMatches = mobileNumberRegex.Matches(inputText);

            var mobileNumbers = new List<string>();
            foreach (Match match in mobileNumberMatches)
            {
                mobileNumbers.Add(match.Value);
            }

            return mobileNumbers;
        }

        static List<string> PerformCustomRegexSearch(string inputText, string customRegexPattern)
        {
            var customRegex = new Regex(customRegexPattern);
            var customRegexMatches = customRegex.Matches(inputText);

            var matches = new List<string>();
            foreach (Match match in customRegexMatches)
            {
                matches.Add(match.Value);
            }

            return matches;
            
        }
       

       
    }

}
