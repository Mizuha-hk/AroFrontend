namespace allo_frontend;

public interface IServices
{
    Task<IEnumerable<User>> GetUserInfo();

    Task<IEnumerable<User>> GetAllUsers();
}