# NETCore3-Authentication

### Email 
Environment: **development**<br> 
Used: **Papercut-SMTP**<br> 
Realease: **Papercut SMTP v5.7.0** [2020-04-05]<br>
Link: **(https://github.com/ChangemakerStudios/Papercut-SMTP/releases)**<br>

### OAUTH 2.0 Documentation
Link: **(https://tools.ietf.org/html/draft-ietf-oauth-v2-15)**

## Branchs

### Basics - Authentication
 - Claims
 - ClaimsIdentity
 - ClaimsPrincipal
 - Authorization
 
### BasicsAuthentication&Authorization
Building Blocks:<br>
 - Authorization Requirements
 - Authorization Policies
 - Authorization Handlers
 
### AuthorizationConcepts 
 - Global Authorization Filter
 - Operation Authorization Requirement
 	- Resource-based authorization(https://jakeydocs.readthedocs.io/en/latest/security/authorization/resourcebased.html)
 - Claims Transformation
 - Authorization Police Proviver
 
### RazorAuthorization
 - Razor Pages
 	- Authorize Page
	- Authorize Folder
	- Anonymous Page
	
### OAuthJWTBearer
 - Create a basic OAuthServer
 - Create JwtSecurityToken with claims
 - Validate JwtToken using TokenValidationParameters
 - Apply access_token sended by querystring to header using JwtBearerEvents
 - Create decode parts to access_token like (https://jwt.io)
	- Header part
	- Payload part
	
### OAuthClient
 - Create a basic OAuthClient
 - access_token
 - Endpoints
 	- Authorize
	- Token

### SecuringTheAPI
 - Request a HTTP Client



