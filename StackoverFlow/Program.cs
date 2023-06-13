using System;

namespace Stackoverflow

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
                        post.Upvote();
                        Console.WriteLine("Current vote value: " + post.Currentvotevalue());
                    }
                    else if (input.ToLower() == "d")
                    {
                        post.Downvote();
                        Console.WriteLine("Current vote value: " + post.Currentvotevalue());
                    }
                    else
                    {
                        Console.WriteLine("Current vote value: " + post.Currentvotevalue());                          
                    }


                }
            }
        }


    }




}
