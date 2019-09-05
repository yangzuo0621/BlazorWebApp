using Microsoft.AspNetCore.Components;

namespace Open.Blazor.Common
{
    public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
    {
        [Parameter]
        protected virtual ElementType ElementType { get; set; } = ElementType.Div;

        protected override ElementType ContainerElementType => ElementType;
    }
}
