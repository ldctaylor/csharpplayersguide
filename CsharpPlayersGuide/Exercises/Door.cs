namespace CsharpPlayersGuide.Exercises
{
    internal enum State
    {
        Open,
        Closed,
        Locked
    }

    internal class Door
    {
        public State State { get; set; }
        public string Passcode { get; set; }

        internal Door(string passcode)
        {
            State = State.Closed;
            Passcode = passcode;
        }

        public void Close()
        {
            if (State == State.Open)
            {
                State = State.Closed;
                Console.WriteLine("The door is now closed.");
            }
            else
            {
                Console.WriteLine("The door is already closed or locked.");
            }
        }

        public void Open()
        {
            if (State == State.Closed)
            {
                State = State.Open;
                Console.WriteLine("The door is now open.");
            }
            else
            {
                Console.WriteLine("Unable to open door, it is either locked or already open.");
            }
        }

        public void Lock()
        {
            if (State == State.Closed)
            {
                State = State.Locked;
                Console.WriteLine("The door is now locked.");
            }
            else
            {
                Console.WriteLine("Unable to lock door, it is either already locked or open.");
            }
        }

        public void Unlock()
        {

            if (State == State.Locked)
            {
                Console.WriteLine("Enter the passcode: ");
                string passcode = Console.ReadLine();
                if (passcode == Passcode)
                {
                    State = State.Closed;
                    Console.WriteLine("The door is now unlocked.");
                }
                else
                {
                    Console.WriteLine("Unable to unlock door, the passcode is incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Unable to unlock door, it is either already unlocked or the passcode is incorrect.");
            }
        }

        public void ChangePasscode(string oldPasscode, string newPasscode)
        {
            if (oldPasscode == Passcode)
            {
                Passcode = newPasscode;
                Console.WriteLine("Passcode has been changed.");
            }
            else
            {
                Console.WriteLine("Unable to change passcode, the old passcode is incorrect.");
            }
        }

        public static void Run()
        {
            Console.WriteLine("Enter a passcode: ");
            string passcode = Console.ReadLine();

            Door door = new(passcode);
            Console.WriteLine("Door created. Enter a command (open, close, lock, unlock), or q to quit: ");

            while (true)
            {

                string command = Console.ReadLine();

                switch (command)
                {
                    case "open":
                        door.Open();
                        break;
                    case "close":
                        door.Close();
                        break;
                    case "lock":
                        door.Lock();
                        break;
                    case "unlock":
                        door.Unlock();
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }


    }
}