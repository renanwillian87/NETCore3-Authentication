# ##NETCore3-Authentication##

### Email 
Environment: **development**<br> 
Used: **Papercut-SMTP**<br> 
Realease: **Papercut SMTP v5.7.0** [2020-04-05]<br>
Link: **(https://github.com/ChangemakerStudios/Papercut-SMTP/releases)**<br>

### OAUTH 2.0 Documentation
Link: **(https://tools.ietf.org/html/draft-ietf-oauth-v2-15)**

# 1 - Basic / Identity

## Branchs

### Basics - Authentication
 - Claims
 - ClaimsIdentity
 - ClaimsPrincipal
 - Authorization
 
# 2 - Basic / Authentication

## Branchs 
 
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
	
# 3 - OAuth

## Branchs
	
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

### RefreshToken
 - Implemented grant_type "refresh_token"
 - Update access_token and refresh_token stored HTTPContext
 
# 4 - Identity Server 4

## Branchs
 
### ClientCredentials
 - Add Identity Server 4
 - Identity Model
 - Discovery Document
 - Request Client Credentials Token


