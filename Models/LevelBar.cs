using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTiHuDong.Models
{
    public class LevelBar : BindableBase
    {
        private string _img;
        private string _title;
        //private string _nameSpace;
        public string Img { get { return _img; } set { _img = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        //public string NameSpace { get { return _nameSpace;} set { _nameSpace = value; } }
    }
}
