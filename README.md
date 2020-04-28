# ##NETCore3-Authentication##
## Course -> RawCoding

## Tools:
### Email 
Environment: **development**<br> 
Used: **Papercut-SMTP**<br> 
Realease: **Papercut SMTP v5.7.0** [2020-04-05]<br>
Link: **(https://github.com/ChangemakerStudios/Papercut-SMTP/releases)**<br>

##  Documentation
 - **OAUTH 2.0** : https://tools.ietf.org/html/draft-ietf-oauth-v2-15
 - **OpenID** : https://openid.net/specs/openid-connect-core-1_0.html

## OpenID Flow Types:
 - Authorization Code
 - Implicit
 - Resource Owner Password Credentials
 - Client Credentials
 - Hybrid Flow

## Tokens:
 - **id_token** includes information about the user. The app then parses the token's contents and uses the information (including details like name and profile picture) to customize the user experience.
 - **access_token** are used to inform an API that the bearer of the token has been authorized to access the API and perform a predetermined set of actions 
 - **refresh_token** is a special kind of token used to obtain a renewed Access Token. 


# 1 - Basic / Identity

### Branch: Basics - Authentication
 - Claims
 - ClaimsIdentity
 - ClaimsPrincipal
 - Authorization
 
# 2 - Basic / Authentication

### Branch: BasicsAuthentication&Authorization
Building Blocks:<br>
 - Authorization Requirements
 - Authorization Policies
 - Authorization Handlers
 
### Branch: AuthorizationConcepts 
 - Global Authorization Filter
 - Operation Authorization Requirement
 	- Resource-based authorization(https://jakeydocs.readthedocs.io/en/latest/security/authorization/resourcebased.html)
 - Claims Transformation
 - Authorization Police Proviver
 
### Branch: RazorAuthorization
 - Razor Pages
 	- Authorize Page
	- Authorize Folder
	- Anonymous Page
	
# 3 - OAuth
	
### Branch: OAuthJWTBearer
 - Create a basic OAuthServer
 - Create JwtSecurityToken with claims
 - Validate JwtToken using TokenValidationParameters
 - Apply access_token sended by querystring to header using JwtBearerEvents
 - Create decode parts to access_token like (https://jwt.io)
	- Header part
	- Payload part
	
### Branch: OAuthClient
 - Create a basic OAuthClient
 - access_token
 - Endpoints
 	- Authorize
	- Token

### Branch: SecuringTheAPI
 - Request a HTTP Client

### Branch: RefreshToken
 - Implemented grant_type "refresh_token"
 - Update access_token and refresh_token stored HTTPContext
 
# 4 - Identity Server 4
 
### Branch: ClientCredentials
 - Add Identity Server 4
 - Identity Model
 - Discovery Document
 - Request Client Credentials Token

### Branch: AuthorizationCodeFlow
 - Add IdentityResource: OpenId, Profile
 - Scope: OpenId
 - Pages Login & Register
  
### Branch: IdentityServer4_Cookies_Token_Claims
 - UserManager Add Claim
 - Config Scopes
 - Delete Claims
 - Map Claim
 
### Branch: IdentityServer4_RefreshToken
 - Implemented Refresh Token
 
### Branch: IdentityServer4_ImplicitFlow
 - Implicit Flow is good for clients that use agent(Web Browser or Mobile APP)
 - Not allowed refresh token
 - Create Client Implicit
 - Create Javascript authentication
 
### IdentityServer4_oidcclientjs
 - **Project**: https://github.com/IdentityModel/oidc-client-js
 - **Wiki**: https://github.com/IdentityModel/oidc-client-js/wiki
 - Configure oidc-client-js
 - IdentityServer4 Config Client AllowedCorsOrigins
 - API allow CORS
	
### IdentityServer4_ImplicityFlow_PersistanceClaimsRefreshing
 - Persist in Browser LocalStorage
 - Axios interceptor Refresh Token
 
### IdentityServer4_EFCoreSetup
 - **Docs**: http://docs.identityserver.io/en/release/quickstarts/8_entity_framework.html
 - EntityFramework Core Setup
 - Migration 
 
### IdentityServer4_SignOut_Certificates
 - Implemented SignOut for MVC and JS
 - Generate Certificate via PowerShell
 - **Docs**: https://docs.microsoft.com/pt-br/archive/blogs/kaevans/using-powershell-with-certificates
	
### IdentityServer4_ExternalProviders
 - Implemented Provider Facebook
- **Link**: https://developers.facebook.com/
	
	
