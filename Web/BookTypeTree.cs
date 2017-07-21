using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shop.Web
{
    public  class BookTypeTree
    {
        public int id { get; set; }
        public int pId { get; set; }
        public string name { get; set; }
        public bool open { get; set; }
        public bool isParent { get; set; }
        public string click { get; set; }
    }
}