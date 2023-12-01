using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.RequestIterator;

public class RequestIterator : IRequestIterator
{
    private readonly IList<string> _splitRequest;
    private int _currentString;

    public RequestIterator(string request)
    {
        _splitRequest = request.Split();
    }

    public string GetCurrentObject()
    {
        return _splitRequest[_currentString];
    }

    public bool Advance()
    {
        if (_currentString == _splitRequest.Count - 1)
        {
            return false;
        }

        _currentString++;
        return true;
    }
}