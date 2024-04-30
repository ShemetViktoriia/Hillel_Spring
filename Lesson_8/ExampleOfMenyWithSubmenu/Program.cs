namespace ExampleOfMenyWithSubmenu
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                // First choice of user action
                byte firstChoice;
                Console.WriteLine((byte)FirstMenuItem.Play + ". Play");
                Console.WriteLine((byte)FirstMenuItem.Record + ". Record");
                Console.WriteLine((byte)FirstMenuItem.Exit + ". Exit");
                Console.WriteLine("Make your choice:");
                firstChoice = ReadChoice();
                Console.Clear();
                switch ((FirstMenuItem)firstChoice)
                {
                    case FirstMenuItem.Play: // User chooses Play
                        Play();
                        break;
                    case FirstMenuItem.Record: // User chooses Record
                        Record();
                        break;
                    case FirstMenuItem.Exit: // User chooses Exit
                        Environment.Exit(0);
                        break;
                    default: // User makes wrong choice 
                        break;
                }

                Console.WriteLine((byte)SecondMenuItem.Pause + ". Pause");
                Console.WriteLine((byte)SecondMenuItem.Stop + ". Stop");
                Console.WriteLine((byte)SecondMenuItem.Exit + ". Exit");
                Console.WriteLine("Make your choice:");

                // Second user choice in case AddMarks
                byte secondChoice = ReadChoice();

                switch ((SecondMenuItem)secondChoice)
                {
                    case SecondMenuItem.Pause: // User chooses Pause
                        {
                            if ((FirstMenuItem)firstChoice == FirstMenuItem.Play) // Playing
                            {
                                PausePlaying();
                            }
                            else // Recording
                            {
                                PauseRecording();
                            }
                            break;
                        }
                    case SecondMenuItem.Stop: // User chooses Stop
                        {
                            if ((FirstMenuItem)firstChoice == FirstMenuItem.Play) // Playing
                            {
                                StopPlaying();
                            }
                            else // Recording
                            {
                                StopRecording();
                            }
                            break;
                        }
                    case SecondMenuItem.Exit: // User chooses Exit
                        Environment.Exit(0);
                        break;
                    default: // User makes wrong choice 
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        /// <summary>
        /// Method which clear last line on the Console
        /// </summary>
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        /// <summary>
        /// Read user input and return number of choice in right case
        /// </summary>
        /// <returns>number between 0 and 2/returns>
        static byte ReadChoice()
        {
            string enter;
            bool isInputRight;
            byte choice;
            Console.WriteLine("");
            do
            {
                ClearLastLine();
                enter = Console.ReadLine();
                isInputRight = byte.TryParse(enter, out choice);
            } while (!isInputRight || choice < (byte)FirstMenuItem.Exit || choice > (byte)FirstMenuItem.Record);
            return choice;
        }

        public static void Play()
        {
            Console.WriteLine("Playing.");
        }

        public static void Record()
        {
            Console.WriteLine("Recording.");
        }

        public static void PausePlaying()
        {
            Console.WriteLine("Pause playing.");
        }

        public static void StopPlaying()
        {
            Console.WriteLine("Stop playing.");
        }

        public static void PauseRecording()
        {
            Console.WriteLine("Pause recording.");
        }

        public static void StopRecording()
        {
            Console.WriteLine("Stop recording.");
        }
    }
}