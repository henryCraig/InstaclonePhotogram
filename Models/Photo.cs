using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace InstaclonePhotogram.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public byte[] Img { get; set; }
    }
}
