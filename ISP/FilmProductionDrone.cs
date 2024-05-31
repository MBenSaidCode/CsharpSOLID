using ISP.Abstractions;

namespace ISP
{
    public class FilmProductionDrone : IFly
    {
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