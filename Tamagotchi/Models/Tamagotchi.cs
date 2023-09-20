using System;
using System.Timers;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Forms;
public class TamagotchiModel
{
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Boredom { get; set; }
    public int Sleepiness { get; set; }
    public int Age { get; set; }

    private Timer degradeTimer;

    public TamagotchiModel(string name)
    {
        Name = name;
        Hunger = 100;
        Boredom = 100;
        Sleepiness = 100;
        Age = 0;

        degradeTimer = new Timer();
        degradeTimer.Interval = 1000; // 1 second
        degradeTimer.Tick += DegradeTimer_Tick;
        degradeTimer.Start();
    }

    private void DegradeTimer_Tick(object sender, EventArgs e)
    {
        Hunger -= 10;
        Boredom -= 5;
        Sleepiness -= 8;
        Age += 1;

        if (Hunger < 0) Hunger = 0;
        if (Boredom < 0) Boredom = 0;
        if (Sleepiness < 0) Sleepiness = 0;

        if (Hunger == 0)
        {

        }


    }
}
