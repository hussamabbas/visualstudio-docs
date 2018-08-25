//<Snippet1>
using System;

namespace DesignLibrary
{
   [Flags]
   public enum Days : uint
   {
      None        = 0,
      Monday      = 1,
      Tuesday     = 2,
      Wednesday   = 4,
      Thursday    = 8,
      Friday      = 16,
      All         = Monday| Tuesday | Wednesday | Thursday | Friday
   }

   public enum Color :sbyte
   {
      None        = 0,
      Red         = 1,
      Orange      = 3,
      Yellow      = 4
   }
}
//</Snippet1>
