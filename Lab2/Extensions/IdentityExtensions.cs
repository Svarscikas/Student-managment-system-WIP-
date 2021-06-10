using System.Security.Claims;
using System.Security.Principal;

namespace Lab2.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetStudentID(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("StudentID");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}