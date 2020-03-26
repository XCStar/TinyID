using System;
namespace TinyId.IdService.Dal
{
    public interface IKeyDal
    {
        KeyInfo GetKeyInfo(int biztype);
        bool UpdateKeyInfo(long maxid,long version,int id);
    }
}