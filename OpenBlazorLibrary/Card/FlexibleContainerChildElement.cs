using Microsoft.AspNetCore.Components;

namespace Open.Blazor.Card
{
    public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
    {
        [Parameter]
        protected virtual ElementType ElementType { get; set; } = ElementType.Div;

        protected override ElementType ContainerElementType => ElementType;
    }
}