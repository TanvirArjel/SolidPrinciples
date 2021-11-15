# Dependency Inversion Principle
 
 This principle states that:
 
 >***High level module should not depend on low level module. Rather they both should depend on abstraction.***

## Bad Design

According to the **Dependency Inversion Principle**, the following code is a bad design.

```C#
// Low level module
public class EmailSender
{
    public void Send(string email, string content)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}

// High level module
public class OrderService
{
    private readonly EmailSender _emailSender;

    public OrderService(EmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Creating order");

        //Sending order details
        _emailSender.Send("tanvirarjel2@gmail.com", "This is order detail.");
    }
}
```
**The problem is:** The high level module **(OrderService)** is tightly dependent on low level module **(EmailSender).**

## Good Design

If we invert the dependency and redesign the above code as follows, it will be compliant to **Dependency Inversion Principle**

```C#
// Low level module
public class EmailSender : IEmailSender
{
    public void Send(string email, string content)
    {
        Console.WriteLine($"Sending email to {email}");
    }
}

// High level module

// Abstraction
public interface IEmailSender
{
    void Send(string email, string content);
}

public class OrderService
{
    private readonly IEmailSender _emailSender;

    public OrderService(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Creating order");

        //Sending order details
        _emailSender.Send("tanvirarjel2@gmail.com", "This is order detail.");
    }
}
```
Now it looks fine, isn't it?
