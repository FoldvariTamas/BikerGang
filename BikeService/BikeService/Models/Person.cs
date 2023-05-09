namespace BikeService.Models;

public abstract class Person
{
    public int ID { get; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Phone { get; private set; }
    public string? Introduction { get; set; }

    public Person(int id, string name, string email, string password, string phone, string? introduction = null)
    {
        ID = id;
        Name = name;
        Email = email;
        Password = password;
        Phone = phone;
        Introduction = introduction;
    }

    public void SetName(string newName)
    {
        Name = newName;
    }

    public void SetEmail(string newEmail)
    {
        Email = newEmail;
    }

    public void SetPassword(string newPassword)
    {
        Password = newPassword;
    }

    public void SetPhone(string newPhone)
    {
        Phone = newPhone;
    }
}