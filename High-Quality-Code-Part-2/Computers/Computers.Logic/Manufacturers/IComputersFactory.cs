namespace Computers.Logic.Manufacturers
{
    using ComputerTypes;

    public interface IComputersFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}
