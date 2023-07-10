using Stella_Commerce.Model;
using Stella_Commerce.web.client;
using Stella_Commerce.web.resource;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stella_Commerce.Service
{
    public class ProfileService : IProfileService
    {
        private readonly ProfileContext _context;
        private readonly PaymentClient _paymentClient;

        public ProfileService(ProfileContext profileContext)
        {
            _context = profileContext;
            _paymentClient = new PaymentClient();
        }

        public List<Model.Profile> GetAllProfiles()
        {
            return _context.Profiles.ToList();
        }

        public void CreateProfileFromPaymentHandle(PaymentHandle paymentHandle)
        {
            paymentHandle.MerchantRefNum = Guid.NewGuid().ToString();
            paymentHandle.TransactionType = "PAYMENT";
            paymentHandle.Profile.Locale = "en_CA";
            paymentHandle.PaymentType = "CARD";
            paymentHandle.CurrencyCode = GetCurrencyCodeFromCountry(paymentHandle.BillingDetails.Country);

            _paymentClient.CreatePaymentHandle(paymentHandle);

            Model.Profile profile = new()
            {
                FirstName = paymentHandle.Profile.FirstName,
                LastName = paymentHandle.Profile.LastName,
                Email = paymentHandle.Profile.Email,
                PaymentToken = paymentHandle.PaymentHandleToken,
                MerchantRefNum = paymentHandle.MerchantRefNum,

            };
            _context.Profiles.Add(profile);
        }

        private static string GetCurrencyCodeFromCountry(string country)
        {
            return country switch
            {
                "CA" => "CAD",
                "US" => "USD",
                "GB" => "GBP",
                _ => "EUR",
            };
        }
    }

}
