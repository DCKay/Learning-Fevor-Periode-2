namespace Eigen_Huis
{
    internal class Badkamer : Kamer
    {
        public Badkamer(string name, double space) : base(name, space)
        {
        }

        public override double Price
        {
            get
            {
                return 500;
            }
        }
    }
}