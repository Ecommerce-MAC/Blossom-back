using Entities.Entities;

namespace APIServ.IServices
{
    public interface IUserService
    {
        List<UserItem> GetAllUser();
        int InsertUser(UserItem userItem);
        void DeleteUser(int id);
        void UpdateUser(UserItem userItem);
    }
}
