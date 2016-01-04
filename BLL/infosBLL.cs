using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class infosBLL
    {
        infosDAL _infosDao = new infosDAL();

        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns>返回所有记录</returns>
        public DataTable FindAll_infos()
        {
            return _infosDao.FindAll_infos();
        }

        /// <summary>
        /// 根据条件获得该页的记录
        /// </summary>
        /// <param name="start">开始号</param>
        /// <param name="limit">分页大小</param>
        /// <param name="Fields">查询关键字</param>
        /// <param name="query">查询内容</param>
        /// <returns>返回当前页数据</returns>
        public DataTable FindAllByPage_infos(string start, string limit, string where)
        {
            return _infosDao.FindAllByPage_infos(start, limit,where);
        }

        /// <summary>
        /// 获得该条件的记录总条数
        /// </summary>
        /// <param name="Fields">查询关键字</param>
        /// <param name="query">查询内容</param>
        /// <returns>返回记录条数</returns>
        public string GetRecordCount_infos(string where)
        {
            return _infosDao.GetCount_infos(where);
        }

        /// <summary>
        /// 根据id查找指定记录
        /// </summary>
        /// <param name="id">查找的ID号</param>
        /// <returns>返回查找到的对象</returns>
        public infos FindById_infos(int id)
        {
            return _infosDao.FindById_infos(id);
        }

        /// <summary>
        /// 添加新纪录
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>是否添加成功</returns>
        public bool Add_infos(infos _infos)
        {
            return _infosDao.Add_infos(_infos);
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>是否删除成功</returns>
        public bool Del_infos(infos _infos)
        {
            return _infosDao.Del_infos(_infos);
        }

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="infos">实体</param>
        /// <returns>是否更新成功</returns>
        public bool Update_infos(infos _infos)
        {
            return _infosDao.Update_infos(_infos);
        }

        /// <summary>
        /// 查找符合条件的记录
        /// </summary>
        /// <param name="conditions">条件</param>
        /// <returns>返回符合条件的记录</returns>
        public DataTable FindByConditions_infos(string conditions)
        {
            return _infosDao.FindByCondition_infos(conditions);
        }
    }
}
