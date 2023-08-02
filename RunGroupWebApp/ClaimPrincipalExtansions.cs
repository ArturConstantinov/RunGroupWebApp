using System.Security.Claims;

namespace RunGroupWebApp
{
    public static class ClaimPrincipalExtansions
    {
        public static string GetUserId (this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
