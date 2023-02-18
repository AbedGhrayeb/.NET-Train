using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttributesApp.Models
{
    public class Update
    {
        private int _version;
        private string _messege;
        public Update(int version,string msg)
        {
            _version=version;
            _messege=msg;
        }
        public string Messege{get {return _messege;}}
        public int Version{get {return _version;}}

        public override string ToString()
        {
            return $"{_version} {_messege}";

        }
    }
}