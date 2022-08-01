using Application.BRONNERL.Domain.Interfaces.Entities;

namespace Application.BRONNERL.Helpers
{
    public static class AgeHelper
    {
        public static int GetAge(IAgeable ageable)
        {
            return DateTime.Now.Year - ageable.DateDeNaissance.Year;
        }
    }
}