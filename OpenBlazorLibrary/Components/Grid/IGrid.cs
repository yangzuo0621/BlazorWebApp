namespace Open.Blazor.Components.Grid
{
    public interface IGrid
    {
        void SetColumns(Columns columns);
        void ChildStateChanged();
    }
}