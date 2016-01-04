using System;
using System.Collections;


/**
 * 作者：陈杰
 * QQ  : 710782046
 * Email:ovenjackchain@gmail.com
 * Blog :http://hi.baidu.com/jackvoilet
 */
namespace Model
{
    public class infos
    {
        #region 构造函数
        public infos()
        { }

        public infos(int iid, string title, string details, string imgs, string classify, string publiship, string publishman, string publishtime, string isshow, string istop, int hits, string notes)
        {

            this._iid = iid;
            this._title = title;
            this._details = details;
            this._imgs = imgs;
            this._classify = classify;
            this._publiship = publiship;
            this._publishman = publishman;
            this._publishtime = publishtime;
            this._isshow = isshow;
            this._istop = istop;
            this._hits = hits;
            this._notes = notes;

        }
        #endregion

        #region 成员

        private int _iid;
        private string _title;
        private string _details;
        private string _imgs;
        private string _classify;
        private string _publiship;
        private string _publishman;
        private string _publishtime;
        private string _isshow;
        private string _istop;
        private int _hits;
        private string _notes;

        #endregion


        #region 属性

        public int iid
        {
            get { return _iid; }
            set { _iid = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string details
        {
            get { return _details; }
            set { _details = value; }
        }

        public string imgs
        {
            get { return _imgs; }
            set { _imgs = value; }
        }

        public string classify
        {
            get { return _classify; }
            set { _classify = value; }
        }

        public string publiship
        {
            get { return _publiship; }
            set { _publiship = value; }
        }

        public string publishman
        {
            get { return _publishman; }
            set { _publishman = value; }
        }

        public string publishtime
        {
            get { return _publishtime; }
            set { _publishtime = value; }
        }

        public string isshow
        {
            get { return _isshow; }
            set { _isshow = value; }
        }

        public string istop
        {
            get { return _istop; }
            set { _istop = value; }
        }

        public int hits
        {
            get { return _hits; }
            set { _hits = value; }
        }

        public string notes
        {
            get { return _notes; }
            set { _notes = value; }
        }


        #endregion
        #region 获得自增键
        private string ReturnAutoID()
        {
            return "iid";
        }
        #endregion
    }
}
