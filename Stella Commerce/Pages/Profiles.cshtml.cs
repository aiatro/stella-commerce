using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stella_Commerce.Service;
using Stella_Commerce.web.resource;
using System.Collections.Generic;
using System.Text.Json;

namespace Stella_Commerce.Pages
{
    public class ProfilesModel : PageModel
    {
        [BindProperty]
        public PaymentHandle PaymentHandle {get;set;}
        public List<Model.Profile> Profiles { get; set;}
        private readonly IProfileService ProfileService;

        public ProfilesModel(IProfileService profileService) {
            ProfileService = profileService;
        }


        public void OnGet()
        {
            Profiles = ProfileService.GetAllProfiles();
        }

        public void OnPost()
        {
            ProfileService.CreateProfileFromPaymentHandle(PaymentHandle);
        }
    }
}
