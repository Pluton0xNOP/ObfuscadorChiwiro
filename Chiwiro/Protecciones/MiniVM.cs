using System;
using System.Collections.Generic;

namespace Core.Protecciones
{
    internal class MiniVM
    {

        public enum OpCode : byte
        {
            PUSH,
            ADD,
            JMP,
            PRINT,
            HALT
        }

       
    }
}

