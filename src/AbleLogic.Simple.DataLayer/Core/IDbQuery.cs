namespace AbleLogic.Simple.DataLayer.Core
{
    public interface IDbQuery
    {
        string CommandText { get; }
        string CommandType { get; set; }
    }
}
