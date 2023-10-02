using System;

class Program
{
    static void Main(string[] args)
    {
        var wekker = new Wekker();

        while (true)
        {
            Console.WriteLine("Wekker Menu:");
            Console.WriteLine("1. Wekker instellen");
            Console.WriteLine("2. Snooze instellen");
            Console.WriteLine("3. Alarm aan/uit");
            Console.WriteLine("4. Snooze aan/uit");
            Console.WriteLine("5. Afsluiten");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Geef de tijd voor de wekker (in seconden): ");
                    var alarmTime = TimeSpan.FromSeconds(int.Parse(Console.ReadLine()));
                    wekker.SetAlarmTime(alarmTime);
                    break;
                case "2":
                    Console.Write("Geef de tijd voor snooze (in seconden): ");
                    var snoozeTime = TimeSpan.FromSeconds(int.Parse(Console.ReadLine()));
                    wekker.SetSnoozeTime(snoozeTime);
                    break;
                case "3":
                    wekker.TurnOnAlarm();
                    break;
                case "4":
                    wekker.TurnOnSnooze();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                    break;
            }
        }
    }
}
