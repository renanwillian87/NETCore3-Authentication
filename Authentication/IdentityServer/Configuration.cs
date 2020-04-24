using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Configuration
    {
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                //new IdentityResources.Profile() ,
                new IdentityResource
                {
                    Name = "rc.scope",
                    UserClaims =
                    {
                        "rc.grandma"
                    }
                }
            };

        public static IEnumerable<ApiResource> GetApis() =>
            new List<ApiResource> {
                new ApiResource("ApiOne"),
                new ApiResource("ApiTwo", new string[] { "rc.api.grandma" })
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client> {
                new Client
                {
                    ClientId = "client_id",
                    ClientSecrets = { new Secret("client_secret".ToSha256()) },

                    AllowedGrantTypes =  GrantTypes.ClientCredentials,

                    AllowedScopes = { "ApiOne" }
                },
                new Client
                {
                    ClientId = "client_id_mvc",
                    ClientSecrets = { new Secret("client_secret_mvc".ToSha256()) },

                    AllowedGrantTypes =  GrantTypes.Code,

                    RedirectUris = { "https://localhost:44395/signin-oidc" },

                    AllowedScopes = { 
                        "ApiOne", 
                        "ApiTwo", 
                        IdentityServer4.IdentityServerConstants.StandardScopes.OpenId,
                        //IdentityServer4.IdentityServerConstants.StandardScopes.Profile,
                        "rc.scope",
                    },

                    // puts alll the claims in the id token
                    //AlwaysIncludeUserClaimsInIdToken = true,
                    AllowOfflineAccess = true, // refresh_token
                    RequireConsent = false,
                },
                new Client
                {
                    ClientId = "client_id_js",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    
                    RedirectUris = { "https://localhost:44324/Home/SignIn" },
                    AllowedCorsOrigins = { "https://localhost:44324" },

                    AllowedScopes =
                    {
                        IdentityServer4.IdentityServerConstants.StandardScopes.OpenId,
                        "ApiOne"
                    },

                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false
                }
            };
    }
}
