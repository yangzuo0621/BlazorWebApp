using Microsoft.AspNetCore.Components;

namespace BlazorWebApp.UILibrary.Card
{
    public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
    {
        [Parameter]
        protected virtual ElementType ElementType { get; set; } = ElementType.Div;

        protected override ElementType ContainerElementType => ElementType;
    }
}