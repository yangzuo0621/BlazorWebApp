namespace Open.Blazor.Card
{
    public interface ICardBody
    {
        void SetTitle(CardTitle title);
        void AddText(CardText text);
        void AddLink(CardLink link);
    }
}