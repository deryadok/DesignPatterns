using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    class Participant
    {
        private string name;
        private Chatroom chatroom;

        public Participant(string name)
        {
            this.name = name;
        }

        public Chatroom Chatroom
        {
            get { return chatroom; }
            set { chatroom = value; }
        }

        public string Name
        {
            get { return name; }
        }

        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public virtual void Recieve(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
