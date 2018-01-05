using System;
namespace CrashableTestApp.Core
{
    public interface IModelStoreService
    {
        T LoadModel<T>(string key) where T : class;
        void SaveModel<T>(string key, T model) where T : class;
        void DeleteModel(string key);
        void DeleteAllByMask(params string[] masks);
    }
}
