using System;
using System.Collections.Generic;

namespace BS.Domain
{
    public partial class SiteMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
