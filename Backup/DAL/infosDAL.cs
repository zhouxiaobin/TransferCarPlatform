using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using Model;
using System.Data;

///所以方法目前返回的都是DataTable类型
///如果要修改成IList<T>类型
///只需要将返回值类型改成IList<T>,返回转换Common<T>.Dt2List()  Or Common<T>.Dt2Model()即可

namespace DAL
{
    public class infosDAL
    {
        /// <summary>
        /// 获得所有记录
        /// </summary>
        /// <returns>返回所有记录DataTable</returns>
        public DataTable FindAll_infos()
        {
            return DbHelperSQL.FindByConditions(new infos(), "");
        }
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <param name="start">起始记录号</param>
        /// <param name="limit">每页记录数</param>
        /// <param name="conditions">查询条件</param>
        /// <returns>返回符合记录的当前页数据</returns>
        public DataTable FindAllByPage_infos(string start, string limit, string conditions)
        {
            return DbHelperSQL.FindByPage(new infos(), start, limit, conditions);
        }

        /// <summary>
        /// 查找符合条件记录的总条数
        /// </summary>
        /// <param name="conditions">查询条件</param>
        /// <returns>返回符合的记录条数</returns>
        public string GetCount_infos(string conditions)
        {
            return DbHelperSQL.GetCountByConditions(new infos(), conditions);
        }

        /// <summary>
        /// 根据id查找相应的一条记录
        /// </summary>
        /// <param name="id">要查找的ID号</param>
        /// <returns>返回值</returns>
        public infos FindById_infos(int id)
        {
            infos model = new infos();
            return Common<infos>.Dt2Model(model, DbHelperSQL.FindByConditions(model, " " + Common<object>.GetModelInfo(model)[1] + "=" + id.ToString()));
        }

        /// <summary>
        /// 添加新纪录
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>返回是否成功</returns>
        public bool Add_infos(infos _infos)
        {
            try
            {
                DbHelperSQL.Insert(_infos);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>返回是否成功</returns>
        public bool Update_infos(infos _infos)
        {
            try
            {
                DbHelperSQL.Update(_infos);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>返回是否成功</returns>
        public bool Del_infos(infos _infos)
        {
            try
            {
                DbHelperSQL.Delete(_infos);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="conditions">条件</param>
        /// <returns>返回符合条件的DataTable</returns>
        public DataTable FindByCondition_infos(string conditions)
        {
            return DbHelperSQL.FindByConditions(new infos(), conditions);
        }
    }
}
