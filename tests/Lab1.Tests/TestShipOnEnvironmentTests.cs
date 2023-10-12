using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceSectors;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TestShipOnEnvironmentTests
{
    public static TheoryData<ISpaceShip, RouteCompletionResult> HighDensityNebulaValues => new()
    {
        { new TripShuttle(), RouteCompletionResult.ShipLost },
        { new Augur(false), RouteCompletionResult.Success },
    };

    public static TheoryData<ISpaceShip, RouteCompletionResult> AntiMatterFlashValues => new()
    {
        { new Vaklas(false), RouteCompletionResult.CrewLost },
        { new Vaklas(true), RouteCompletionResult.Success },
    };

    public static TheoryData<ISpaceShip, RouteCompletionResult> WhaleCollisionValues => new()
    {
        { new Vaklas(false), RouteCompletionResult.ShipDestroyed },
        { new Augur(false), RouteCompletionResult.Success },
        { new Meridian(false), RouteCompletionResult.Success },
    };

    [Theory]
    [MemberData(nameof(HighDensityNebulaValues))]
    public void HighDensityNebulaTheory(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var route = new ISpaceSector[1];
        route[0] = new HighDensityNebula(100, 0);
        var testShips = new TestShipOnEnvironment(route);
        Assert.Equal(routeCompletionResult, testShips.TestShipOnRoute(spaceShip).Result);
    }

    [Theory]
    [MemberData(nameof(AntiMatterFlashValues))]
    public void AntiMatterFlashTests(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var route = new ISpaceSector[1];
        route[0] = new HighDensityNebula(100, 1);
        var testShips = new TestShipOnEnvironment(route);
        Assert.Equal(routeCompletionResult, testShips.TestShipOnRoute(spaceShip).Result);
    }

    [Theory]
    [MemberData(nameof(WhaleCollisionValues))]
    public void WhaleCollisionTest(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var route = new ISpaceSector[1];
        route[0] = new NeutrinoParticlesNebula(100, 1);
        var testShips = new TestShipOnEnvironment(route);
        Assert.Equal(routeCompletionResult, testShips.TestShipOnRoute(spaceShip).Result);
    }

    [Fact]
    public void ShuttleIsMoreOptimalBecauseCheaper()
    {
        var ships = new ISpaceShip[2];
        var environments = new ISpaceSector[1];
        ships[0] = new TripShuttle();
        ships[1] = new Vaklas(false);
        environments[0] = new RegularSpace(10);
        var test = new TestShipOnEnvironment(environments, ships);
        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("TripShuttle", ship.GetName());
    }

    [Fact]
    public void StellaIsMoreOptimalBecauseAugurCantFinish()
    {
        var ships = new ISpaceShip[2];
        var environments = new ISpaceSector[1];
        ships[0] = new Stella(false);
        ships[1] = new Augur(false);
        environments[0] = new HighDensityNebula(1500, 0);
        var test = new TestShipOnEnvironment(environments, ships);
        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("Stella", ship.GetName());
    }

    [Fact]
    public void VaklasIsMoreOptimalBecauseEngine()
    {
        var ships = new ISpaceShip[2];
        var environments = new ISpaceSector[1];
        ships[0] = new TripShuttle();
        ships[1] = new Vaklas(false);
        environments[0] = new NeutrinoParticlesNebula(10, 0);
        var test = new TestShipOnEnvironment(environments, ships);
        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("Vaklas", ship.GetName());
    }

    [Fact]
    public void LongRouteTest()
    {
        var ship = new Augur(true);
        var environments = new ISpaceSector[3];
        environments[0] = new RegularSpace(100, 1);
        environments[1] = new HighDensityNebula(1000, 1);
        environments[2] = new NeutrinoParticlesNebula(1000, 1);
        var test = new TestShipOnEnvironment(environments);
        Assert.Equal(RouteCompletionResult.Success, test.TestShipOnRoute(ship).Result);
    }
}