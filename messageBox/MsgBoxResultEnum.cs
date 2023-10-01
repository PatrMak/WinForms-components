using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MsbBoxType
{
    [ComVisible(true)]
    public enum MsgBoxResultEnum
    {
        OK,
        Cancel,
        Update,
        Register,
        Exit
    }
}
