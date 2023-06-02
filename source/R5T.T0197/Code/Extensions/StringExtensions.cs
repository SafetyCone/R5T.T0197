using System;


namespace R5T.T0197.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToLibraryDescription(string)"/>
        public static ILibraryDescription ToLibraryDescription(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryDescription(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLibraryName(string)"/>
        public static ILibraryName ToLibraryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedLibraryName(string)"/>
        public static IUnadjustedLiraryName ToUnadjustedLibraryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedLibraryName(value);
        }
    }
}
