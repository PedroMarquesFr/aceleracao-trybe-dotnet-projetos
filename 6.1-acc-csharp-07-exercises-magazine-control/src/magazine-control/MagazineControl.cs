namespace magazine_control;
public class MagazineControl
{
    public List<string> Magazines;

    public MagazineControl(List<string> magazines)
    {
        Magazines = magazines;
    }

    /// <summary>
    /// This function add a magazine to list and return the index.
    /// </summary>
    /// <param name="name">Magazine name</param>
    /// <returns>Added item index.</returns>
    public int SaveMagazine(string name)
    {
        Magazines.Add(name);
        return Magazines.IndexOf(name);
    }

    /// <summary>
    /// This function search for a magazine and return the index.
    /// </summary>
    /// <param name="name">Magazine name</param>
    /// <returns>Item index.</returns>
    public int FindMagazinePosition(string name)
    {
        return Magazines.IndexOf(name);
    }
}
