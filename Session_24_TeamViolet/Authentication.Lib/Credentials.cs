namespace Authentication.Lib;

public class Credentials
{
    public string Username { get; set; }

    public string Password { get; set; }


    public bool Auth()
    {
        if (Username == "admin" && Password == "admin")
        {
            return true;
        }
        return false;
    }
}