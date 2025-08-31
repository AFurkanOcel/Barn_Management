using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class UserControl
    {
        public static class Session
        {
            public static int CurrentUserId { get; set; }
            public static bool CurrentUserType { get; set; }
        }
    }
}
