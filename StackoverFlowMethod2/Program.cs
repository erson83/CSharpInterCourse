using System;

namespace Stackoverflow2

{
    class Program

    {

        static void Main()
        {

            var post = new Post(0);
            while (true)
            {
                Console.Write("Enter 'u' to Upvote and 'd' to Downvote. Enter 'ok' or null space to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok" || String.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    if (input.ToLower() == "u")
                    {
                        var upvotevalue = post.Currentvotevalue(true);
                        Console.WriteLine("Current vote value: " + upvotevalue);
                    }
                    else if (input.ToLower() == "d")
                    {
                        var downvote = post.Currentvotevalue(false);
                        Console.WriteLine("Current vote value: " + downvote);
                    }
                }
            }
        }


    }




}
