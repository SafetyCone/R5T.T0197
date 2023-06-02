using System;

using R5T.T0132;


namespace R5T.T0197.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ILibraryDescription"/>
        public ILibraryDescription ToLibraryDescription(string value)
        {
            var output = new LibraryDescription(value);
            return output;
        }

        /// <inheritdoc cref="ILibraryName"/>
        public ILibraryName ToLibraryName(string value)
        {
            var output = new LibraryName(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedLiraryName"/>
        public IUnadjustedLiraryName ToUnadjustedLibraryName(string value)
        {
            var output = new UnadjustedLiraryName(value);
            return output;
        }
    }
}
