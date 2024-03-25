using LingoGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebLingo.Device
{
    public class WebDevice : IDevice
    {
        private readonly StringBuilder builder = new StringBuilder();

        public void DrawDefault(char c)
        {
            builder.AppendFormat("<div class='default'>{0}</div>", c);
        }

        public void DrawPartial(char c)
        {
            builder.AppendFormat("<div class='partial'>{0}</div>", c);
        }

        public void DrawExact(char c)
        {
            builder.AppendFormat("<div class='exact'>{0}</div>", c);
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}