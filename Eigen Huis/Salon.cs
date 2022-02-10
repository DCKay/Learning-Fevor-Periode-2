namespace Eigen_Huis
{
    internal class Salon : Kamer
    {
        public Salon(string name, double space, bool chimney) : base(name, space)
        {
            Chimney = chimney;
        }

        public override double Price
        {
            get
            {
                if (Chimney == true)
                {
                    return 500;
                }
                else
                {
                    return 300;
                }
            }
        }

        public bool Chimney { get; }
    }
}