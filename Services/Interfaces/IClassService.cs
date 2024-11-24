using System.Linq.Expressions;
using ThunderGym.Models;
namespace ThunderGym.Services.Interfaces
{
    public interface IClassService
    {
        List<Class> GetClasses();
        List<Class> GetClassesByCondition(Expression<Func<Class, bool>> expression);
        void AddClass(Class sclass);
        void UpdateClass(Class sclass);
        void DeleteClass(Class sclass);
        void Save();
    }
}
