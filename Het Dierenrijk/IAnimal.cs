namespace Het_Dierenrijk
{
    public interface IAnimal
    {
        int Age { get; set; }
        string Name { get; set; }

        void Intro();
    }
}