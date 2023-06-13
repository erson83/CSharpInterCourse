using System;

namespace Stackoverflow3

{
    public class Post
    {
        // declare variable
        public int Totalvote { get; set; }
        public bool Upvoteboolean { get; set; }

        // intialize variable

        public Post(int totalvote)
        {
            this.Totalvote = totalvote;
        }

        public Post(int totalvote, bool upvoteboolean)
            :this(totalvote)
        {
            this.Upvoteboolean = upvoteboolean;
        }

        // return method
        public int Currentvotevalue
        {
            get
            {
                if (Upvoteboolean)
                {
                    Totalvote++;
                }
                else
                {
                    Totalvote--;
                }
                return Totalvote;
            }
        }
    }

}
