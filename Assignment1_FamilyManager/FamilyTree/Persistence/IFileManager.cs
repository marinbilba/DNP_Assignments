using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFileManager
    {
        void AddAdult(Adult adult);
        List<Adult> GetListAdults();
        
    }
}