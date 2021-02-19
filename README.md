# Cross-Platform .NET Dependency Injection in Kentico Xperience 13
Kentico Xperience 13 is among the first CMS platforms to adopt .NET Core, but Xperience is also a product in transition.  In version 13, websites are built using Core, but the CMS application is still on ASP.NET Web Forms.  We often create custom code that needs to be available in both the web site and in this CMS application.  Using DI in the CMS application isn't straightforward.  Although the CMS app uses Microsoft extensions under the covers, it wraps the DI within its own service locator, so that custom code doesn’t have direct access to the service collection.

Here's a boilerplate example for how to register the dependencies in shared libraries using patterns that are familiar in .NET Core while also using the shared components in the CMS application.

## Original Article
[Cross-Platfrom .NET Dependency Injection in Kentico Xperience 13](https://bluemodus.com/articles/cross-platform-net-dependency-injection-in-kentico-xperience-13)
