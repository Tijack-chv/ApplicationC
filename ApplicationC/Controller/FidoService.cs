using Fido2NetLib.Objects;
using Fido2NetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Controller
{
    public class FidoService
    {
        private readonly Fido2 _fido2;

        public FidoService()
        {
            _fido2 = new Fido2(new Fido2Configuration
            {
                Origin = "https://localhost:5001", // Remplace par l'URL de ton application
                ServerDomain = "localhost",
                ServerName = "MyApp"
            });
        }
        /*
        public async Task<CredentialCreateOptions> StartRegistration(string userId, string username, string displayName)
        {
            var user = new Fido2User
            {
                DisplayName = displayName,
                Name = username,
                Id = System.Text.Encoding.UTF8.GetBytes(userId)
            };

            // Génération des options d'enregistrement
            return await _fido2.RequestNewCredential(user, new List<PublicKeyCredentialDescriptor>(), AuthenticatorSelection.Default, AttestationConveyancePreference.None);
        }
        */
    }
}
