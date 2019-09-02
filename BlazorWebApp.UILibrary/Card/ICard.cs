namespace BlazorWebApp.UILibrary.Card
{
    public interface ICard
    {
        void SetHeader(CardHeader header);
        void SetFooter(CardFooter footer);
        void AddBody(CardBody body);
        void ChildStateChanged();
    }
}