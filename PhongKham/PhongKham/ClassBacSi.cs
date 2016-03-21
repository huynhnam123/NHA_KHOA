using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhongKham
{
    class ClassBacSi
    {
        private string _maBS;
        public string maBS
        {
            get { return _maBS; }
            set { _maBS = value; }
        }
        private string _tenBS;
        public string tenBS
        {
            get { return _tenBS; }
            set { _tenBS = value; }
        }
        private string _dcBS;
        public string dcBS
        {
            get { return _dcBS; }
            set { _dcBS = value; }
        }
        private string _dtBS;
        public string dtBS
        {
            get { return _dtBS; }
            set { _dtBS = value; }
        }
        private string _nsBS;
        public string nsBS
        {
            get { return _nsBS; }
            set { _nsBS = value; }
        }
        private string _gtBS;
        public string gtBS
        {
            get { return _gtBS; }
            set { _gtBS = value; }
        }
        public ClassBacSi()
        {
            this._maBS = "";
            this._tenBS = "";
            this._dcBS = "";
            this._dtBS = "";
            this._nsBS = "";
            this._gtBS = "";
        }
        public ClassBacSi(string maBS, string tenBS, string dcBS, string dtBS, string nsBS, string gtBS)
        {
            this._maBS = maBS;
            this._tenBS = tenBS;
            this._dcBS = dcBS;
            this._dtBS = dtBS;
            this._nsBS = nsBS;
            this._gtBS = gtBS;
        }
    }
}
