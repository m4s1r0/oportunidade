using minutoseguro.cli.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minutoseguro.cli.Models
{
    public class PostViewModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Creator { get; set; }
        public string CommentsUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string GUID { get; set; }
        public List<PostCategoryViewModel> Categories { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string CommentRSS { get; set; }
        public int CommentsQtd { get; set; }

        public SummaryViewModel Summary{ get; set; }
    }
}
