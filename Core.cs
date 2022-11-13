namespace practice_two;

public class Core
{
    private readonly List<User> _users = new();

    public void Init()
    { 
        Register("juan@gmail.com", "123456");
    }

    public bool Register( string email, string password )
    {

        if ( email.Trim().Length == 0 || password.Trim().Length == 0 )
        {
            return false;
        }

        var user = _users.Find(u => u.Email == email);

        if ( user != null )
        {
            Console.WriteLine($"User { user.Email } already exists");
            return false;
        }

        var newUser = new User()
        {
            Email = email,
            Password = BCrypt.Net.BCrypt.HashPassword( password )
        };
        
        _users.Add( newUser );
        
        return true;
    }

    public int Login( string email, string password )
    {

        var user = _users.Find((u) => u.Email == email);

        if ( user == null )
        {
            return -1;
        }

        var userPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
        
        if ( !userPassword )
        {
            return -2;
        }

        return 1;

    }
    
}