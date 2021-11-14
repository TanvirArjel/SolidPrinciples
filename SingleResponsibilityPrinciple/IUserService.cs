namespace SingleResponsibilityPrinciple;

// Not following single responsibility
internal interface IUserBadService
{
    bool Login(string userName, string password);
    bool Register(string email, string userName, string password, string confirmPasword);
    void LogError(Exception exception, string errorMessage);
    void SendEmail(string emailAddress, string content);
}

// Following single reponsibility principle.
internal interface IUserService
{
    bool Login(string userName, string password);
    bool Register(string email, string userName, string password, string confirmPasword);
}

internal interface IErrorLogger
{
    void Log(Exception exception, string errorMessage);
}

internal interface IEmailSender
{
    void Send(string emailAddress, string content);
}


