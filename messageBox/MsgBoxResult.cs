using MsbBoxType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MsgBox
{
    public class MsgBoxResult
    {
        static MsgBoxResultEnum _msgBoxResult;
        public static MsgBoxResultEnum msgBoxResult
        {
            get
            {
                return _msgBoxResult;
            }
            set
            {
                _msgBoxResult = value;
            }
        }
    }
}
