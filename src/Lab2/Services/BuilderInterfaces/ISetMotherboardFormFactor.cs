using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.BuilderInterfaces;

public interface ISetMotherboardFormFactor<out T>
{
    public T SetMotherboardFormFactor(MotherBoardFormFactor formFactor);
}