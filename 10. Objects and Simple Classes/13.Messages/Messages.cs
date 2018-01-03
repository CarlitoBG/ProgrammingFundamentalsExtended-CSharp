using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Messages
{
    class User
    {
        public string Username { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }

    class Message
    {
        public string Content { get; set; }

        public User Sender { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ');

            var users = new List<User>();

            while (inputLine[0] != "exit")
            {
                if (inputLine[0] == "register")
                {
                    var newUser = new User()
                    {
                        Username = inputLine[1],
                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.Contains(newUser))
                    {
                        users.Add(newUser);
                    }
                }
                else
                {
                    var sender = inputLine[0];
                    var recipient = inputLine[2];
                    var content = inputLine[3];

                    var newMessage = new Message();

                    newMessage.Content = content;
                    newMessage.Sender = new User
                    {
                        Username = sender,
                        ReceivedMessages = new List<Message>()
                    };

                    var containsSender = users.Where(x => x.Username == sender).ToList();
                    var containsRecipient = users.Where(x => x.Username == recipient).ToList();

                    if (containsSender.Count > 0 && containsRecipient.Count > 0)
                    {
                        var recipientUser = users.First(x => x.Username == recipient);

                        recipientUser.ReceivedMessages.Add(newMessage);
                    }
                }

                inputLine = Console.ReadLine().Split(' ');
            }

            var usernames = Console.ReadLine().Split(' ');
            var firstUsername = usernames[0];
            var secondUsername = usernames[1];

            var firstUser = new User();
            var secondUser = new User();

            foreach (var user in users)
            {
                if (user.Username == firstUsername)
                {
                    firstUser = user;
                }

                if (user.Username == secondUsername)
                {
                    secondUser = user;
                }
            }

            firstUser.ReceivedMessages = firstUser
                .ReceivedMessages.Where(x => x.Sender.Username == secondUsername).ToList();

            secondUser.ReceivedMessages = secondUser
                .ReceivedMessages.Where(x => x.Sender.Username == firstUsername).ToList();

            if (firstUser.ReceivedMessages.Count == 0 && secondUser.ReceivedMessages.Count == 0)
            {
                Console.WriteLine("No messages");
            }

            for (int i = 0; i < Math.Max(firstUser.ReceivedMessages.Count, secondUser.ReceivedMessages.Count); i++)
            {
                if (i < secondUser.ReceivedMessages.Count)
                {
                    Console.WriteLine($"{firstUser.Username}: {secondUser.ReceivedMessages[i].Content}");
                }

                if (i < firstUser.ReceivedMessages.Count)
                {
                    Console.WriteLine($"{firstUser.ReceivedMessages[i].Content} :{secondUser.Username}");
                }
            }
        }
    }
}
