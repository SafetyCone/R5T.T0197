using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0197
{
    /// <inheritdoc cref="IUnadjustedLiraryName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedLiraryName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedLiraryName
    {
        public UnadjustedLiraryName(string value)
            : base(value)
        {
        }
    }
}