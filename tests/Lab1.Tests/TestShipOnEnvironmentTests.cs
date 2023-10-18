using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.FuelMarket;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
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
        { new Augur(), RouteCompletionResult.Success },
    };

    public static TheoryData<ISpaceShip, RouteCompletionResult> AntiMatterFlashValues => new()
    {
        { new Vaklas(), RouteCompletionResult.CrewLost },
        { new Vaklas(new PhotonDeflectors()), RouteCompletionResult.Success },
    };

    public static TheoryData<ISpaceShip, RouteCompletionResult> WhaleCollisionValues => new()
    {
        { new Vaklas(), RouteCompletionResult.ShipDestroyed },
        { new Augur(), RouteCompletionResult.Success },
        { new Meridian(), RouteCompletionResult.Success },
    };

    [Theory]
    [MemberData(nameof(HighDensityNebulaValues))]
    public void HighDensityNebulaTheory(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var environments = new List<ISpaceSector>
        {
            new HighDensityNebula(100),
        };
        var route = new Route(environments);

        Assert.Equal(routeCompletionResult, route.Travel(spaceShip).Result);
    }

    [Theory]
    [MemberData(nameof(AntiMatterFlashValues))]
    public void AntiMatterFlashTests(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var objects = new List<IObjectInHighDensityNebula>
        {
            new AntiMatterFlash(1),
        };
        var environments = new List<ISpaceSector>
        {
            new HighDensityNebula(100, objects),
        };
        var route = new Route(environments);

        Assert.Equal(routeCompletionResult, route.Travel(spaceShip).Result);
    }

    [Theory]
    [MemberData(nameof(WhaleCollisionValues))]
    public void WhaleCollisionTest(ISpaceShip spaceShip, RouteCompletionResult routeCompletionResult)
    {
        var objects = new List<IObjectInNeutrinoParticlesNebula>
        {
            new SpaceWhale(1),
        };
        var environments = new List<ISpaceSector>
        {
            new NeutrinoParticlesNebula(100, objects),
        };
        var route = new Route(environments);

        Assert.Equal(routeCompletionResult, route.Travel(spaceShip).Result);
    }

    [Fact]
    public void ShuttleIsMoreOptimalBecauseCheaper()
    {
        var ships = new ISpaceShip[2];
        ships[0] = new TripShuttle();
        ships[1] = new Vaklas();

        var environments = new List<ISpaceSector>
        {
            new RegularSpace(100),
        };
        var route = new Route(environments);
        var test = new TestShipOnEnvironment(route, new FuelMarket(), CompareTripInfos.Better, ships);

        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("TripShuttle", ship.GetType().Name);
    }

    [Fact]
    public void StellaIsMoreOptimalBecauseAugurCantFinish()
    {
        var ships = new ISpaceShip[2];
        ships[0] = new Stella();
        ships[1] = new Augur();

        var environments = new List<ISpaceSector>
        {
            new HighDensityNebula(1500),
        };
        var route = new Route(environments);
        var test = new TestShipOnEnvironment(route, new FuelMarket(), CompareTripInfos.Better, ships);

        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("Stella", ship.GetType().Name);
    }

    [Fact]
    public void VaklasIsMoreOptimalBecauseEngine()
    {
        var ships = new ISpaceShip[2];
        ships[0] = new Vaklas();
        ships[1] = new TripShuttle();

        var environments = new List<ISpaceSector>
        {
            new NeutrinoParticlesNebula(100),
        };
        var route = new Route(environments);
        var test = new TestShipOnEnvironment(route, new FuelMarket(), CompareTripInfos.Better, ships);

        ISpaceShip? ship = test.SelectOptimalShip();
        Assert.NotNull(ship);
        Assert.Equal("Vaklas", ship.GetType().Name);
    }

    [Fact]
    public void LongRouteTest()
    {
        var ship = new Augur(new PhotonDeflectors());
        var objects = new List<IObjectInHighDensityNebula>
        {
            new AntiMatterFlash(1),
        };
        var environments = new List<ISpaceSector>
        {
            new NeutrinoParticlesNebula(100),
            new HighDensityNebula(100, objects),
            new RegularSpace(100),
        };
        var route = new Route(environments);
        Assert.Equal(RouteCompletionResult.Success, route.Travel(ship).Result);
    }
}