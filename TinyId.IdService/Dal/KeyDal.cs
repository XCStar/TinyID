using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;

namespace TinyId.IdService.Dal
{
    public class KeyDal : IKeyDal
    {
        private static readonly string connectionstring="server=192.168.7.160;uid=sa;database=Test;pwd=test.123456";
        public KeyInfo GetKeyInfo(int biztype)
        {
            using(SqlConnection sql=new SqlConnection(connectionstring))
            {
                var strsql="select * from idinfo WHERE biztype=@type";
                var infos= sql.Query<KeyInfo>(strsql,new {type=biztype});
                return infos.FirstOrDefault();
            }
        }

        public bool UpdateKeyInfo(long maxid, long version, int id)
        {
            using(SqlConnection sql=new SqlConnection(connectionstring))
            {
                var strsql="update idinfo set maxid=@maxid,updatetime=getdate(),[version]=[version]+1 where id=@id and version=@version";
                var count= sql.Execute(strsql,new {maxid=maxid,id=id,version=version});
                return count==1;
            }
        }
    }
}