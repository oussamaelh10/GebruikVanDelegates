using System;
using System.Threading;

public class Wekker
{
    private Timer alarmTimer;
    private Timer snoozeTimer;
    private bool isAlarmOn = false;
    private bool isSnoozeOn = false;

    public void SetAlarmTime(TimeSpan time)
    {
        alarmTimer = new Timer(TriggerAlarm, null, (int)time.TotalMilliseconds, Timeout.Infinite);
    }

    public void SetSnoozeTime(TimeSpan time)
    {
        snoozeTimer = new Timer(TriggerSnooze, null, (int)time.TotalMilliseconds, Timeout.Infinite);
    }

    public void TurnOnAlarm()
    {
        isAlarmOn = true;
    }

    public void TurnOffAlarm()
    {
        isAlarmOn = false;
    }

    public void TurnOnSnooze()
    {
        isSnoozeOn = true;
    }

    public void TurnOffSnooze()
    {
        isSnoozeOn = false;
    }

    private void TriggerAlarm(object state)
    {
        if (isAlarmOn)
        {
            Console.WriteLine("Alarm gaat af: Geluid, Boodschap, Knipperlicht");
            // Voer acties uit voor alarm (geluid, boodschap, knipperlicht)
        }
    }

    private void TriggerSnooze(object state)
    {
        if (isSnoozeOn)
        {
            Console.WriteLine("Snooze gaat af: Geluid, Boodschap, Knipperlicht");
            // Voer acties uit voor snooze (geluid, boodschap, knipperlicht)
        }
    }
}
