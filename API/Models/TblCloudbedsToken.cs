using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class TblCloudbedsToken
    {
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string TokenType { get; set; }
        public int Expires { get; set; }
        public DateTime Created { get; set; }
    }
}
