using System;

namespace Stackoverflow

{
    public class Post
    {
        // declare variable
        public int Totalvote;

        // intialize variable
        public Post(int totalvote) 
        {
        this.Totalvote  = totalvote;
        }

        // void method
        public void Upvote()
        {

            // using void will not return value to main, only storing value within this class
            Totalvote++;
            // this will increase the Totalvote by 1 which will be passed to the public int Currentvotevalue()
        }

        public void Downvote()
        {
            Totalvote--;
        }

        // return method
        public int Currentvotevalue()
        {
            return Totalvote;
        }
    }

}
