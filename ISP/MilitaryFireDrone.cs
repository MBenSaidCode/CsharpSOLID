
using ISP.Abstractions;

namespace ISP
{
    public class MilitaryFireDrone : IFly, IFire
    {
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
            Console.WriteLine(nameof(Land));
        }
    }
}