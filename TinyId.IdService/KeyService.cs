using TinyId.IdService.Dal;

namespace TinyId.IdService
{
    public class KeyService : IKeyService
    {
        private IKeyDal keyDal;
        public KeyService(IKeyDal keyDal)
        {
            this.keyDal=keyDal;
        }
        public KeyService()
        {
            keyDal=new KeyDal();
        }
        public KeyResult GetKeyResult(int biztype)
        {
            //重试1000次
            for (int i = 0; i < 1000; i++)
            {
                var info=keyDal.GetKeyInfo(biztype);
                if(info==null)
                {
                    throw new System.Exception("未找到数据");                    
                }
                var maxid=info.setp+info.maxid;
                if(keyDal.UpdateKeyInfo(maxid,info.version,info.id))
                {
                    return new KeyResult(){maxid=info.maxid,delta=info.delta,setp=info.setp};
                }
            }
            throw new System.Exception("error");
        }
    }
}