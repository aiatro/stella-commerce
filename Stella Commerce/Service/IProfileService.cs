using Stella_Commerce.Model;
using Stella_Commerce.web.resource;
using System.Collections.Generic;

namespace Stella_Commerce.Service
{
    public interface IProfileService
    {
        public void CreateProfileFromPaymentHandle(PaymentHandle paymentHandle);
        public List<Model.Profile> GetAllProfiles();
    }
}
