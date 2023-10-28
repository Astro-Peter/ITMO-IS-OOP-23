namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public interface IBaseDirector<TB>
{
    public TB Direct(TB baseBuilder);
}