namespace Eigen_Huis
{
    internal class Gang : Kamer
    {
        public Gang(string name, double space) : base(name, space)
        {
        }

        public override double Price
        {
            get
            {
                return (10 * Space);
            }
        }
    }
}