using DOTNETRPG.Models;
using System.Threading.Tasks;
namespace DOTNETRPG.Data
{
    public interface IAuthRepository
    {
        public Task<ServiceResponse<int>> Register(User user, string password);
        public Task<ServiceResponse<string>> Login(string username, string password);
        public Task<bool> UserExists (string name);
    }
}