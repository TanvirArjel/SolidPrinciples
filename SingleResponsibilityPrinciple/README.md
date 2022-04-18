# Single Responsibility Principle

This principle states that:
 
>***A class or entity should do only one task at a time or should have only one responsibility at a time.***
 
 ## Bad Design
 The following code is not following the single resonsibility principle.
 
 ```C#
public interface IUserService
{
    bool Login(string userName, string password);
    bool Register(string email, string userName, string password, string confirmPasword);
    void LogError(Exception exception, string errorMessage);
    void SendEmail(string emailAddress, string content);
}
 ```
The Problem is:
 
   1. The above `IUserService` is doing three distinct jobs or reponsibilities where logging error and sending email should not belong to the `IUserSerivce`.

## Good Design

We can move the logging error and sending email jobs/reponsibilites into separate interfaces as follows:

```C#
public interface IUserService
{
    bool Login(string userName, string password);
    bool Register(string email, string userName, string password, string confirmPasword);
}

public interface IErrorLogger
{
    void Log(Exception exception, string errorMessage);
}

public interface IEmailSender
{
    void Send(string emailAddress, string content);
}
```
**Now it looks fine, isn't it?**
