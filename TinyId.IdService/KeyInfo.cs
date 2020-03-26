using System;
namespace TinyId.IdService
{
    public class KeyInfo:KeyResult
    {
        public int id { get; set; }
        public long startid { get; set; }
        
        public DateTime creattime { get; set; }
        public DateTime updatetime { get; set; }
        public long version { get; set; }
    }
}