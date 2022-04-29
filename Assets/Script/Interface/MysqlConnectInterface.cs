namespace GameJDBC.Interface
{
    public interface MysqlConnectInterface
    {
        string Name { get; }
        string sqlName { get; set; }
        string sqlIPConnect { get; set; }

        /// <summary>
        /// 链接需要自己实现接口
        /// </summary>
        /// <param name="m_sql_Name_ConnectName">数据库名</param>
        /// <param name="m_sql_Ip_Confie">链接ip <see cref="m_IsLocal"/><value>为true 不需要添，直接“”</value></param>
        /// <param name="m_IsLocal">是否本地 </param>
        /// <param name="m_IsLongRange">是否远程</param>
        void Connect(string m_sql_Name_ConnectName, string m_sql_Ip_Confie, bool m_IsLocal, bool m_IsLongRange);

        /// <summary>
        /// 关闭链接
        /// </summary>
        void CloseConnect();
    }
}