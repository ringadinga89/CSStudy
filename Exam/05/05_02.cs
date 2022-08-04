using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam._05
{

    class NotFoundException : Exception
    {
        public NotFoundException() : base("해당하는 숫자를 찾을 수 없습니다.") { }
    }

    internal class _05_02
    {
    }
}
