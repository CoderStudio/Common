using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public sealed class RegexPattern
    {
        public const string Mobile = @"^(134|135|136|137|138|139|147|150|151|152|157|158|159|178|182|183|184|187|188|130|131|132|145|155|156|175|176|185|186|133|153|177|180|181|189|170)\d{8}$";
        public const string Email = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public const string Phone = @"^(\d{3,4}\-)?\d{7,8}$";
        public const string Chinese = @"[\u4e00-\u9fa5]+";
        public const string PureDigit = @"\d+";
        public const string Passport = @"^(G|E)\d{8}$";
        public const string Base64 = @"^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$";
        public const string Url = @"^((?#protocol)https?|ftp)://((?#domain)[-A-Z0-9.]+)((?#file)/[-A-Z0-9+&@#/%=~_|!:,.;]*)?((?#parameters)\?[-A-Z0-9+&@#/%=~_|!:,.;]*)?";
    }
}
