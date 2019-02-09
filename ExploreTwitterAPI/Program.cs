using System;
using Tweetinvi;
using SimpleThinker.CommonCode;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ExploreTwitterAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .AddJsonFile("appsecrets.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("appsecrets.json")
                .Build();
            //Console.Read();
            //The Key has been revoked 
            //TODO  Sleeping looks like :) , the secrets will be moved to an ennrypted files 
            Auth.SetUserCredentials(config["TwitterAuthConfig:consumerKey"],
                config["TwitterAuthConfig:consumerSecret"],
            config["TwitterAuthConfig:userAccessToken"], config["TwitterAuthConfig:userAccessSecret"]);
            //Tweetinvi.Tweet.PublishTweet("SensingApp:Snowed in)");
            //var authenticatedUser = User.GetAuthenticatedUser();
            //var tweets = Timeline.GetUserTimeline();
            var usertimeline = from c in Timeline.GetUserTimeline(User.GetUserFromScreenName(args[0]).Id) orderby c.CreatedAt ascending select c;
            foreach (var tweet in usertimeline)
            {
                Tweetinvi.Models.ITweet t = tweet;
                Utility.WriteWithColor("<<" + t.CreatedAt + ">>");
                Utility.WriteWithColor(tweet.ToString()+ ":" );

            }
            Console.Read();
        }

    
    }
}

