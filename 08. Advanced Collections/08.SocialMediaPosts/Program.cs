using System;
using System.Collections.Generic;

namespace _08.SocialMediaPosts
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();

            var postNameLikesDislikes = new Dictionary<string, Dictionary<string, int>>();
            var comments = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "drop the media")
            {
                var inputElements = inputLine.Split(' ');
                var command = inputElements[0];
                var postName = inputElements[1];

                switch (command)
                {
                    case "post":
                        if (!postNameLikesDislikes.ContainsKey(postName))
                        {
                            postNameLikesDislikes[postName] = new Dictionary<string, int>();
                            postNameLikesDislikes[postName].Add("Likes", 0);
                            postNameLikesDislikes[postName].Add("Dislikes", 0);
                        }
                        break;
                    case "like":
                        postNameLikesDislikes[postName]["Likes"]++;
                        break;
                    case "dislike":
                        postNameLikesDislikes[postName]["Dislikes"]++;
                        break;
                    case "comment":
                        var commentatorName = inputElements[2];

                        if (!comments.ContainsKey(postName))
                        {
                            comments[postName] = new Dictionary<string, List<string>>();
                        }
                        comments[postName].Add(commentatorName, new List<string>());

                        for (int i = 3; i < inputElements.Length; i++)
                        {
                            var comment = inputElements[i];
                            comments[postName][commentatorName].Add(comment);
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var post in postNameLikesDislikes.Keys)
            {
                Console.Write($"Post: {post}");

                var likesAndDislikes = postNameLikesDislikes[post];

                foreach (var likeAndDislike in likesAndDislikes)
                {
                    Console.Write($" | {likeAndDislike.Key}: {likeAndDislike.Value}");
                }
                Console.WriteLine();

                Console.WriteLine("Comments:");
                if (comments.ContainsKey(post))
                {
                    var commentatorsAndComments = comments[post];
                    foreach (var commentatorAndComment in commentatorsAndComments)
                    {
                        Console.WriteLine($"*  {commentatorAndComment.Key}: {string.Join(" ", commentatorAndComment.Value)}");
                    }
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
