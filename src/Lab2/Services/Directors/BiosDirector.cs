using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Services.BiosBuilder;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services.Directors;

public class BiosDirector : IBaseDirector<Bios, IBiosBuilder>
{
    public BiosDirector(IBiosBuilder builder)
    {
        Builder = builder;
    }

    public IBiosBuilder Builder { get; private set; }

    public void BuildWith(IBiosBuilder baseBuilder)
    {
        Builder = baseBuilder;
    }

    public void BuildFrom(Bios baseComponent)
    {
        Builder.SetBiosType(baseComponent.Type)
            .SetBiosVersion(baseComponent.Version)
            .SetCompatibleCpus(baseComponent.CompatibleCpus);
    }

    public Bios GetComponent()
    {
        return Builder.Build();
    }
}