using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhongKham
{
    class NhanVien 
    {
        private string _maNV;
        public string maNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private string _hoNV;

        public string HoNV
        {
            get { return _hoNV; }
            set { _hoNV = value; }
        }
                
        private string _tenNV;
        public string tenNV
        {
            get { return _tenNV; }
            set { _tenNV = value; }
        }
        private string _dcNV;
        public string dcNV
        {
            get { return _dcNV; }
            set { _dcNV = value; }
        }
        private string _dtNV;
        public string dtNV
        {
            get { return _dtNV; }
            set { _dtNV = value; }
        }
        private DateTime _nsNV;

        public DateTime nsNV
        {
            get { return _nsNV; }
            set { _nsNV = value; }
        }
        
        private string _gtNV;
        public string gtNV
        {
            get { return _gtNV; }
            set { _gtNV = value; }
        }
        private string _cvNV;

        public string cvNV
        {
            get { return _cvNV; }
            set { _cvNV = value; }
        }
        private string  _knNV;

        public string  knNV
        {
            get { return _knNV; }
            set { _knNV = value; }
        }
        private DateTime _nbdlNV;

        public DateTime nbdlNV
        {
            get { return _nbdlNV; }
            set { _nbdlNV = value; }
        }
        private decimal _mlNV;

        public decimal mlNV
        {
            get { return _mlNV; }
            set { _mlNV = value; }
        }
        
        public NhanVien()
        {
           _maNV = "";
           _hoNV = "";
           _tenNV = "";
           _nsNV = Convert.ToDateTime("1990/1/1"); ;
           _gtNV = "";
           _dcNV = "";           
           _dtNV = "";
           _cvNV = "";
           _knNV = "";
           _nbdlNV = Convert.ToDateTime("1990/1/1");
           _mlNV = 0;
        }
        public NhanVien(string maNV, string hoNV, string tenNV, DateTime nsNV, string gtNV, string dcNV, string dtNV, string cvNV, string knNV, DateTime nbdlNV, decimal mlNV)
        {
           _maNV = maNV;
           _tenNV = tenNV;
           _dcNV = dcNV;
           _dtNV = dtNV;
           _nsNV = nsNV;
           _gtNV = gtNV;
           _hoNV = hoNV;
           _cvNV = cvNV;
           _knNV = knNV;
           _nbdlNV = nbdlNV;
           _mlNV = mlNV;
        }
    }
}
