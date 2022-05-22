# Building Web Applications with .NET Core 2.1 and JavaScript
 (Second Edition, 2020)  

__Philip Japikse__  
__Kelvin Grossnicklaus__  
__Ben Dewey__  

[Source Code](https://github.com/Apress/building-web-apps)  

## PART I
### .NET Core 2.1  

### Chapter 1: Introducing .NET Core  
Todo: Read details at leisure.  


### Chapter 5: Introducing ASP.NET Core


### JWT Authentication
1. __Install the Jwt Nuget Package__    
Install `System.IdentityModel.Tokens.Jwt` package for signing and verifying token.  

2. __Write The Middleware__   
Your middleware should implement an Invoke method.
```
public async Task Invoke(HttpContext context, IUserService userService)
{
...
}
```  
Inside the  Invoke method you can validate the token sent by the client.  

3. __Write a custom Authorize Attribute class__  
Your custom attribute class must extend the `System.Attribute` class and implement `Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter`interface.
```  
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
		public void OnAuthorization(AuthorizationFilterContext context)
	 {
      ...
     }
}
```  
You can then use the `Authorize` attribute as decorator to protected an action method or an entire controller class.

4. __Add the your middleware to the request pipeline__   
In the `startup` class  
```
app.UseMiddleware<JwtMiddleware>();
```

__Learn More__   
[ASP.NET Core 3.1 - JWT Authentication](https://jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api#authorize-attribute-cs)   
[ASP.NET Web API 2 - Creating And Validating JWT](https://www.c-sharpcorner.com/article/asp-net-web-api-2-creating-and-validating-jwt-json-web-token/)

### Logging
#### Serilog
__Install Nuget Packages__  
* `Serilog.AspNetCore`
* `Serilog.Settings.Configuration`  
__Optionally install enrichers__  
* `Serilog.Enrichers.Environment`
* `Serilog.Enrichers.Thread`
* `Serilog.Enrichers.Process`  
__Optional install Seq sink__  
* `Serilog.Sinks.Seq`   

### Error Handling

__Learn More__  
[ASP.NET Core 3.1 - Global Error Handler](https://jasonwatmore.com/post/2020/10/02/aspnet-core-31-global-error-handler-tutorial)
