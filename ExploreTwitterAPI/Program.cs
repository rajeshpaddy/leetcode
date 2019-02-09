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
        	//The Key has been revoked 
        	//TODO  Sleeping looks like :) , the secrets will be moved to an ennrypted files wJjfwD2fHwMPMh9paXePWst5XHFa8FqdB7Bj0lY", "pIvqvlPxePiyMhNLe6QbXeEZhJupyE3nLFCGdlP9ZJBFz");
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
+ ">>");
                Utility.WriteWithColor(tweet.ToString()+ ":" );

            }
            //Console.Read();
        }

    
    }
}
+ ">>");
                Utility.WriteWithColor(tweet.ToString()+ ":" );

            }
            //Console.Read();
        }

    
    }
}
              Utility.WriteWithColor(tweet.ToString()+ ":" );

            }
            //Console.Read();
        }

    
    }
}
