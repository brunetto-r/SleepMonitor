DateTime prevTime = DateTime.MinValue;
var awakeTime = DateTime.Now;
while (true)
{
    var time = DateTime.Now;
    if (time.Subtract(prevTime) > TimeSpan.FromSeconds(1))
    {
        if (prevTime == DateTime.MinValue)
            Console.WriteLine(time + "\tSleep monitoring app started");
        else
        {
            var difference = time - prevTime;
            var awake = prevTime - awakeTime;
            awakeTime = DateTime.Now;
            Console.WriteLine($"After being awake {awake}. PC sleeped {difference} from {prevTime} to {time}");
        }
    }
    prevTime = time;
    Task.Delay(500).Wait();
}