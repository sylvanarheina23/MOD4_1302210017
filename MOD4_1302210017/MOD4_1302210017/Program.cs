using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace MOD4_1302210017
{
    public class Kodebuah
    {
        public enum namabuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung }
        public static string getKodebuah(namabuah namabuah)
        {
            string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kodebuah[(int)namabuah];
        }
    }

    public class PosisiKarakterGame
    {
        private static string command;

        enum state { Jongkok, Berdiri, Tengkurap, Terbang };

        public static void Main()
        {
            Kodebuah kodebuah = new Kodebuah();
            string getKodebuah = Kodebuah.getKodebuah(Kodebuah.namabuah.Apel);
            Console.WriteLine(getKodebuah);
            Console.WriteLine();

            state state = state.Berdiri;
            string[] screenName = { "landing", "takeoff" };
            while (state != null)
            {
                Console.WriteLine(screenName[(int)state]);
                Console.WriteLine();
                Console.Write("Enter Command : ");

                string command = Console.ReadLine();
                switch (state)
                {
                    case state.Berdiri:
                        if (command == "take off")
                            state = state.Berdiri;
                        else if (command == "landing")
                            state = state.Terbang;
                        else
                        {
                            state = state.Berdiri;
                            Console.WriteLine("Command Salah");

                        }
                        Console.WriteLine();
                        break;

                    case state.Terbang:
                        if (command != "landing")
                            state = state.Terbang;
                        else if (command == "take off")
                            state = state.Berdiri;
                        else
                        {
                            state = state.Terbang;
                            Console.WriteLine("Command Salah");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}