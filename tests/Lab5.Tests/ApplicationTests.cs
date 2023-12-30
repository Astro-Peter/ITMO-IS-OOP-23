using System.Collections.Generic;
using Lab5.Application.Abstractions.Models;
using Lab5.Application.Abstractions.Repositories;
using Lab5.Application.Contracts.User;
using Lab5.Application.Models.Operation;
using Lab5.Application.Models.User;
using Lab5.Application.UserServices;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class ApplicationTests
{
    [Fact]
    public void ChangeMoney_MoneyIncreased_WeAddMoney()
    {
        var userService = new UserService(new MockUserRepo(), new MockOperationsRepo())
        {
            User = new User(123, "1234", 123),
        };
        UserOperationResult result = userService.ChangeMoney(10);
        Assert.IsType<UserOperationResult.Success>(result);
        Assert.Equal(133, userService.User.Money);
    }

    [Fact]
    public void ChangeMoney_MoneyDecreased_WeSubtractLessMoneyThanInAccount()
    {
        var userService = new UserService(new MockUserRepo(), new MockOperationsRepo())
        {
            User = new User(123, "1234", 123),
        };
        UserOperationResult result = userService.ChangeMoney(-10);
        Assert.IsType<UserOperationResult.Success>(result);
        Assert.Equal(113, userService.User.Money);
    }

    [Fact]
    public void ChangeMoney_OperationFailure_WeSubtractTooMuchMoney()
    {
        var userService = new UserService(new MockUserRepo(), new MockOperationsRepo())
        {
            User = new User(123, "1234", 123),
        };
        UserOperationResult result = userService.ChangeMoney(-1000);
        Assert.IsType<UserOperationResult.Failure>(result);
    }

    public class MockOperationsRepo : IOperationRepository
    {
        public IEnumerable<Operation> GetAllOperations(int accountId)
        {
            return new List<Operation>();
        }
    }

    public class MockUserRepo : IUserRepository
    {
        public void AddUser(string pinCode)
        {
        }

        public User? GetUser(int accountId, string pinCode)
        {
            return null;
        }

        public DbUserOperationResult ChangeUserMoney(User user, float amount)
        {
            if (amount + user.Money < 0)
            {
                return new DbUserOperationResult.Failure("not enough");
            }

            return new DbUserOperationResult.Success(new User(user.UserId, user.PinCode, user.Money + amount));
        }
    }
}