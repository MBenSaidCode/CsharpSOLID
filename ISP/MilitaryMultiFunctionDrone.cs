using ISP.Abstractions;

namespace ISP
{
    public class MilitaryMultiFunctionDrone : IMilitaryMultiFunctionDrone
    {
        public void CollectAudioData()
        {
            Console.WriteLine(nameof(CollectAudioData));
        }

        public void CollectSensorData()
        {
           Console.WriteLine(nameof(CollectSensorData));
        }

        public void CollectVisualData()
        {
            Console.WriteLine(nameof(CollectVisualData));
        }

        public void FireLaser()
        {
            Console.WriteLine(nameof(FireLaser));
        }

        public void FireMachineGun()
        {
            Console.WriteLine(nameof(FireMachineGun));
        }

        public void FireMissile()
        {
            Console.WriteLine(nameof(FireMissile));
        }

        public void Fly()
        {
            Console.WriteLine(nameof(Fly));
        }

        public void Land()
        {
            Console.WriteLine(nameof(Land));
        }

        public void TakeOff()
        {
            Console.WriteLine(nameof(TakeOff));
        }
    }
}