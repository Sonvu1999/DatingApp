using System.Threading.Tasks;
using DatingApp.API.Properties.models;
using System.Collections.Generic;

namespace DatingApp.API.Properties.Data
{
    public interface IDatingRepository
    {
         void Add<T> (T entity) where T: class;
         void Delete<T> (T entity) where T:class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> GetMainPhotoForUser(int userId);
    }
} 