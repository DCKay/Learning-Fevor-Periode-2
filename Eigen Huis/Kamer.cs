namespace Eigen_Huis
{
    internal abstract class Kamer
    {
        public virtual string Name { get; set; }
        public virtual double Space { get; set; }
        public virtual double Price { get; }

        protected Kamer(string name, double space)
        {
            Name = name;
            Space = space;
        }
    }
}