namespace TinyId.IdService
{
    public class KeyResult
    {
        /// <summary>
        /// 当前ID
        /// </summary>
        /// <value></value>
        public long maxid { get; set; }
        /// <summary>
        /// 业务类型
        /// </summary>
        /// <value></value>
        public int biztype { get; set; }
        /// <summary>
        /// 步长
        /// </summary>
        /// <value></value>
        public int setp { get; set; }
        /// <summary>
        /// 每次增量
        /// </summary>
        /// <value></value>
        public int delta { get; set; }
    }
}