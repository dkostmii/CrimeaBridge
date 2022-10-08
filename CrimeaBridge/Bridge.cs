using System.Text.RegularExpressions;

namespace CrimeaBridge;

internal class Bridge
{
    private string _name;

    private readonly string _explosion;

    public Bridge(string name)
    {
        _name = name;
        _explosion = "🔥💥🔥";
    }

    /// <summary>
    /// Explode the bridge.
    /// </summary>
    public void Explode()
    {
        _name = _name.ToUpper();
        _name = _name.Replace(_explosion, "");

        var pattern = new Regex(@"\W{2,}");
        _name = _explosion + pattern.Replace(_name, " ").Replace(" ", _explosion) + _explosion;
    }

    public override string ToString()
    {
        return _name;
    }
}
