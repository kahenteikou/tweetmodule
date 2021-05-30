using CoreTweet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweetmodule
{
    class Program
    {
        static int Main(string[] args)
        {
            Tokens token;
            if(args.Length < 5)
            {
                return 1;
            }
            try
            {
                token = Tokens.Create(args[0], args[1], args[2], args[3]);
                token.Statuses.Update(args[4]);
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
            return 0;
        }
    }
}
