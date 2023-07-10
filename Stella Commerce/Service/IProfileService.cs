using Stella_Commerce.Model;
using System.Collections.Generic;

namespace Stella_Commerce.Service
{
    public interface IProfileService
    {
        public void CreateProfile(Profile profile);
        public List<Profile> GetAllProfiles();
    }
}
