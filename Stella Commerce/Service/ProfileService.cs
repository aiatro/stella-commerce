using Stella_Commerce.Model;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Commerce.Service
{
    public class ProfileService : IProfileService
    {
        private readonly ProfileContext _context;

        public ProfileService(ProfileContext profileContext)
        {
            _context = profileContext;
        }

        public List<Profile> GetAllProfiles()
        {
            return _context.Profiles.ToList();
        }

        public void CreateProfile(Profile profile)
        {
            _context.Profiles.Add(profile);
        }
    }
}
