using System;

namespace Stackoverflow2

{
    public class Post
    {
        // declare variable
        public int Totalvote;
        public bool Upvoteboolean;

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
        public int Currentvotevalue(bool Upvoteboolean)
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
