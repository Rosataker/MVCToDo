using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCToDo.Models
{
    public class Todo
    {
        public int Id{ get; set; }

        [DisplayName("標題")]
        public string Title { get; set; }

        [DisplayName("內容")]
        public string Contact { get; set; }
        [DisplayName("發佈日期")]
        public DateTime Releasedate { get; set; }

        [DisplayName("狀態")]  //已完成、未完成
        public int Status { get; set; }

        [DisplayName("顯示方式")]  //每日、每周、每月、每年
        public int Flag { get; set; }
    }
}