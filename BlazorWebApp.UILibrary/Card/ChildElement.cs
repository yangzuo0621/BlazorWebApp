using Microsoft.AspNetCore.Components;

namespace BlazorWebApp.UILibrary.Card
{
    public abstract class ChildElement<TParent> : ComponentBase
    {
        [CascadingParameter]
        TParent Parent { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (Parent != null)
            {
                Register(Parent);
            }
        }

        protected abstract void Register(TParent parent);
        public abstract RenderFragment RenderContent { get; }

        protected new void StateHasChanged()
        {
            base.StateHasChanged();
            var cscHandler = Parent as IHandleChildStateChanges;
            if (cscHandler != null)
            {
                cscHandler.ChildStateChanged();
            }
        }
    }
}