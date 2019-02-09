using System;
using Tweetinvi;
using SimpleThinker.CommonCode;
using System.Collections.Generic;
using System.Linq;

namespace ExploreTwitterAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("Ny0egqEXgrsPW0yNIrjBxex3j", "0TBAKoz7TtaqUNQk98wGaFsiBc0KHIEsNcITlbWL5SWTqmqBzw", "22376279-J3wJjfwD2fHwMPMh9paXePWst5XHFa8FqdB7Bj0lY", "pIvqvlPxePiyMhNLe6QbXeEZhJupyE3nLFCGdlP9ZJBFz");
            //Tweetinvi.Tweet.PublishTweet("SensingApp:Still waiting for the snow (or not waiting :()");
            //var authenticatedUser = User.GetAuthenticatedUser();
            //var tweets = Timeline.GetUserTimeline();
            var usertimeline = from c in Timeline.GetUserTimeline(User.GetUserFromScreenName(args[0]).Id) orderby c.CreatedAt ascending select c;
            foreach (var tweet in usertimeline)
            {
                Tweetinvi.Models.ITweet t = tweet;
                Utility.WriteWithColor("<<" + t.CreatedAt + ">>");
                Utility.WriteWithColor(tweet.ToString()+ ":" );

            }
            //Console.Read();
        }

    
    }
}
