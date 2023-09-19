using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTiHuDong.Models
{
    public class AnswerBar : BindableBase
    {
        private string _title;
        public string Title { get { return _title; } set { _title = value; } }
    }
}
